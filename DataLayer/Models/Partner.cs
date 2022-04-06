using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Partner
    {
        public int PartnerID { get; set; }
        public int UserID { get; set; }
        public int ListID { get; set; }


        public Partner()
        {

        }
        public virtual User User { get; set; }
        public virtual List List { get; set; }
    }
}
