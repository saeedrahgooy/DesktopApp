using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public class EFProvider : IProvider
    {
        public ResultDto Connect(string connectionStr)
        {
            // Implement Section For Connect to Database
            return new ResultDto
            {
                IsConnect = true,
                Message = string.Format("You Connect To Database With EF")
            };
            
        }
    }
}
