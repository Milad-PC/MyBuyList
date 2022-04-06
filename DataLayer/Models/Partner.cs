using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Partner
    {
        [Key]
        public int PartnerID { get; set; }

        [Display(Name ="کاربر")]
        public int UserID { get; set; }

        [Display(Name ="لیست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int ListID { get; set; }


        public Partner()
        {

        }
        public virtual User User { get; set; }
        public virtual List List { get; set; }
    }
}
