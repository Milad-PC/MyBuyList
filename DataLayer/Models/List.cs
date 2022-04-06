using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class List
    {
        [Key]
        public int ListID { get; set; }

        [Display(Name ="عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100,ErrorMessage ="مقدار ورودی از حد مجاز بیشتر است.")]
        public string Name { get; set; }

        [Display(Name ="تاریخ ثبت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Display(Name ="سازنده لیست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int MakerID { get; set; }

        public List()
        {

        }
        public virtual List<Task> Tasks { get; set; }
        public virtual List<Partner> Partners { get; set; }
    }
}
