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
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }

        [Display(Name ="")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime? DoneDate { get; set; }
        public Boolean IsDone { get; set; } = false;
        public int UserID { get; set; }

        public Task()
        {

        }
        public virtual User User { get; set; }
        public virtual List List { get; set; }
    }
}
