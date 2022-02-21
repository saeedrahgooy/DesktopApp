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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.Hide();
            INotification notification = new EmailNotification();
            IProvider provider = new EFProvider();
            RegisterPage registerPage = new RegisterPage(notification,provider);
            registerPage.ShowDialog();
        }
    }
}
