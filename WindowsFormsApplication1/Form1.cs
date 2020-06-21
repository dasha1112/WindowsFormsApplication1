using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TIBCO.EMS;
using NLog;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        Connection connectionProd = null;
        Session sessionProd = null;
        MessageProducer msgProducer = null;
        Destination destinationProd = null;
        ConnectionFactory factory = null;
        EMSCompletionListener completionListener = null;

        Connection connectionCons = null;
        Session sessionCons = null;
        MessageConsumer msgConsumer = null;
        Destination destinationCons = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Tibems.SetExceptionOnFTSwitch(true);
                

                factory = new TIBCO.EMS.ConnectionFactory(TIBCOServerName.Text + "," + TIBCOServerName.Text);


               // factory.SetConnAttemptCount(30);
              //  factory.SetConnAttemptDelay(120000);
              //  factory.SetConnAttemptTimeout(2000);

              //  factory.SetReconnAttemptCount(30);
              //  factory.SetReconnAttemptDelay(120000);
              //  factory.SetReconnAttemptTimeout(2000);

                connectionProd = factory.CreateConnection(UserTextBox.Text, PasswordTextBox.Text);
                connectionCons = factory.CreateConnection(UserTextBox.Text, PasswordTextBox.Text);

                // create the session
                sessionProd = connectionProd.CreateSession(false, Session.AUTO_ACKNOWLEDGE);
                sessionCons = connectionCons.CreateSession(false, Session.AUTO_ACKNOWLEDGE);
                destinationProd = sessionProd.CreateQueue(TIBCO_EMS_Queue_Send.Text);
                destinationCons = sessionCons.CreateQueue(TIBCO_EMS_Queue_Receve.Text);

                // create the consumer
                msgConsumer = sessionCons.CreateConsumer(destinationCons);

                // start the connection
                connectionCons.Start();
                Thread threadCons = new Thread(Consumer);
                threadCons.Start();
                // create the producer
                msgProducer = sessionProd.CreateProducer(null);

                completionListener = new EMSCompletionListener(LogTextBox); 
            }
            catch (EMSException ex)
            {
                LogTextBox.Text = LogTextBox.Text + "\nException in csMsgProducer: " + ex.Message;
                logger.Error(ex, "Exception in csMsgProducer");
                LogTextBox.Text = LogTextBox.Text + "\n" + ex.StackTrace;
            }
        }

        private void TIBCO_EMS_Queue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMsgSend_Click(object sender, EventArgs e)
        {
            
            // publish messages
            TextMessage msgProd;
            if(SendMsgTextBox.Text.Trim().Length != 0)
            {
                // create text message
                msgProd = sessionProd.CreateTextMessage();
                
                // set message text
                msgProd.Text = SendMsgTextBox.Text;
                //connectionProd.
                msgProducer.Send(destinationProd, msgProd, completionListener);

                LogTextBox.Text = LogTextBox.Text + "\nPublished message: " + SendMsgTextBox.Text;
                logger.Info("Published message: " + SendMsgTextBox.Text);
            }           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            // close the connection
            connectionProd.Close();
            connectionCons.Close();
        }

        public void Consumer()
{
    int ackMode = Session.AUTO_ACKNOWLEDGE;
    TIBCO.EMS.Message msg = null;

 while (true)
        {
            try
            {
                // receive the message
                msg = msgConsumer.Receive();
            }
            catch (EMSException EMSex)
            {
                LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + EMSex.Message; });
                logger.Error(EMSex.Message);     
            }
            if (msg == null)
                break;
            
            if (ackMode == Session.CLIENT_ACKNOWLEDGE ||
                ackMode == Session.EXPLICIT_CLIENT_ACKNOWLEDGE ||
                ackMode == Session.EXPLICIT_CLIENT_DUPS_OK_ACKNOWLEDGE)
                msg.Acknowledge();

            LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\nReceived message: " + msg; });
            logger.Info("Received message: " + msg);
               
     if(msg is TextMessage)
     {
         TextMessage tm = (TextMessage)msg;
         //ReceveMsgTextBox.Text = tm.Text;
         ReceveMsgTextBox.Invoke((MethodInvoker)delegate() { ReceveMsgTextBox.Text = tm.Text; });
         logger.Info(tm.Text);
     }
            if (msg is BytesMessage)
            {
                BytesMessage bm = (BytesMessage)msg;
                LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + bm.ReadBoolean(); });
                LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + bm.ReadChar(); });
                LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + bm.ReadShort(); });
                LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + bm.ReadInt(); });
                LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + bm.ReadLong(); });
                LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + bm.ReadFloat(); });
                LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + bm.ReadDouble(); });
            }

            if (msg is MapMessage)
            {
                MapMessage mm = (MapMessage)msg;
                var mapNames = mm.GetMapNames();
                LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.ToString(); });
             /*   foreach (String name in mapNames)
                {
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetBoolean(name); });
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetByte(name); });
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetBytes(name); });
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetChar(name); });
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetShort(name); });
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetInt(name); });
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetLong(name); });
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetFloat(name); });
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetDouble(name); });
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetString(name); });
                    LogTextBox.Invoke((MethodInvoker)delegate() { LogTextBox.Text = LogTextBox.Text + "\n" + mm.GetObject(name); });
                }*/
            }

        }
    }    
    }

    public class EMSCompletionListener : ICompletionListener
    {
        RichTextBox rtb = null;
        private static Logger log = LogManager.GetCurrentClassLogger();


        // Note:  Use caution when modifying a message in a completion
        // listener to avoid concurrent message use.
        public EMSCompletionListener(RichTextBox tt) : base()
        {
            rtb = tt;
            
        }

        public void OnCompletion(TIBCO.EMS.Message msg)
        {
            try
            {
                rtb.Invoke((MethodInvoker)delegate() { rtb.Text = rtb.Text + "\nSuccessfully sent message " + ((TextMessage)msg).Text; });
                log.Info("nSuccessfully sent message " + ((TextMessage)msg).Text);
            }
            catch (EMSException e)
            {
                rtb.Invoke((MethodInvoker)delegate()
                {
                    rtb.Text = rtb.Text + "\nError retrieving message text.";
                    rtb.Text = rtb.Text + "\nMessage: " + e.Message;
                    rtb.Text = rtb.Text + "\n" + e.StackTrace;
                    log.Error(e, "Error retrieving message text.");
                });
            }
        }

        public void OnException(TIBCO.EMS.Message msg, Exception ex)
        {
            try
            {
                rtb.Invoke((MethodInvoker)delegate() { rtb.Text = rtb.Text + "\nError sending message " + ((TextMessage)msg).Text; });
                log.Error("Error sending message " + ((TextMessage)msg).Text);
            }
            catch (EMSException e)
            {
                rtb.Invoke((MethodInvoker)delegate()
                {
                    rtb.Text = rtb.Text + "\nError retrieving message text.";
                    rtb.Text = rtb.Text + "\nMessage: " + e.Message;
                    rtb.Text = rtb.Text + "\n" + e.StackTrace;
                    log.Error(e, "Error retrieving message text.");
                });
            }

            rtb.Invoke((MethodInvoker)delegate()
            {
                rtb.Text = rtb.Text + "\nMessage: " + ex.Message;
                rtb.Text = rtb.Text + "\n" + ex.StackTrace;
            });
        }


    }

}
