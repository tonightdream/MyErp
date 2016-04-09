using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyERP.Model
{
   public class SYS_MENU
    {
       
       public string MENU_CODE { get; set; }
       public string MENU_NAME { get; set; }
       public string PARENT_MENU_CODE { get; set; }
       public string MENU_UNIT  { get; set; }
    }
}
