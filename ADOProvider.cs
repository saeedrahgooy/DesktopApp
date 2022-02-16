using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    public class ADOProvider : IProvider
    {
        
        public ResultDto Connect(string connectionStr)
        {
            // Bussines Section For Connect to Database
            return new ResultDto
            {
                IsConnect = true,
                Message = "You Connect To Database With ADO",
            };

        }
    }
}
