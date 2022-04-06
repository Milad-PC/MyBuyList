using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }

        [Display(Name ="لیست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int ListID { get; set; }

        [Display(Name ="عنوان")]
        [MaxLength(200,ErrorMessage ="مقدار ورودی از حد مجاز بیشتر است.")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }

        [Display(Name ="تاریخ ساخت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Display(Name ="زمان انجام")]
        public DateTime? DoneDate { get; set; }

        [Display(Name ="وضعیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public Boolean IsDone { get; set; } = false;

        [Display(Name ="کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UserID { get; set; }

        public Task()
        {

        }
        public virtual User User { get; set; }
        public virtual List List { get; set; }
    }
}
