using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class RegisterPage : Form
    {
        public delegate void SendNotification(Message message);
        private readonly INotification _notification;
        private readonly IProvider _provider;
        //private readonly INotification IList<_notification>;
        //private readonly IProvider IList<_provider>;

        public RegisterPage(INotification notification,IProvider provider)
        {
            InitializeComponent();
            _notification = notification;
            _provider = provider;
            
        }

        //public void RegisterProvider(IProvider provider)
        //{
        //    _provider.Add(provider);
        //}



        //public void RegisterChannel(INotification channel)
        //{
        //    _notification.Add(channel);
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            // Connect to Database
            string connection = "database = .,";
            //RegisterProvider(new EFProvider());
            //foreach (var provider in _provider)
            //{
            //    var result=provider.Connect(connection);
                
            //    MessageBox.Show(result.Message,"اطلاعات" ,MessageBoxButtons.OK,MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            //}
            
            //Notofication Section
            Message message = new Message();
            message.To = txtEmail.Text;
            _notification.Send(message);
            ResultDto result =_provider.Connect(connection);
            if (result.IsConnect)
            {
            MessageBox.Show(result.Message);

            }
            else
            {
                MessageBox.Show("EfProvide Not Ready To use");
            }
            // Dependence Injection Implement
            //RegisterChannel(new EmailNotification());
            //foreach (var channel in _notification)
            //{
            //    channel.Send(message);
            //}

            // Delegate Implement
            //EmailNotification emailNotification = new EmailNotification();
            //SmsNotification smsNotification = new SmsNotification();
            //SendNotification sendNotification = emailNotification.Send;
            //SendNotification sendNotification = smsNotification.Send;
            //sendNotification(message);

            this.Close();
            
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnRegister.Focus();

            }
        }

        private void RegisterPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
