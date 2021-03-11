using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OrderSysManagement.Methods
{
    public class CommonMethods
    {
        public DateTime SetParameters(string para)
        {
            return Convert.ToDateTime(WebUtility.UrlDecode(para));
        }
    }
}
