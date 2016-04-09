using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyERP.Model
{
    public class SYS_USER
    {
        public string USER_CODE { get; set; }
        public string PASSWORD { get; set; }
        public string USER_NAME { get; set; }
        public string STOCK_CODE { get; set; }
        public string STOCK_NAME { get; set; }
        public string DEPARTMENT_CODE { get; set; }
        public string DEPARTMENT_NAME { get; set; }
        public bool? PPRICE_SHOW { get; set; }
    }
}
