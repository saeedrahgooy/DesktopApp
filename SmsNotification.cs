using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public class SmsNotification : INotification
    {
        public void Send(Message message)
        {
            MessageBox.Show($"یک اس ام اس به {message.To} ارسال شد");
        }
    }
}
