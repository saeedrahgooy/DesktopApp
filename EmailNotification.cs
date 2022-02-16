using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public class EmailNotification : INotification
    {
        public void Send(Message message)
        {
            if (message.To.Contains("@"))
            {
                MessageBox.Show($"یک ایمیل به {message.To} ارسال شد");
            }
            else
            {

                MessageBox.Show(string.Format("ایمیل شما معتبر نیست لطفا یک ایمیل معتبر وارد کنید"));
            }

        }
    }
}
