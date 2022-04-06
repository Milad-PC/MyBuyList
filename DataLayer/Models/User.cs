using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Display(Name ="نام")]
        [MaxLength(50,ErrorMessage ="مقدار ورودی از حد مجاز بیشتر است.")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Name { get; set; }

        [Display(Name ="نام کاربری")]
        [MaxLength(50,ErrorMessage ="مقدار ورودی از حد مجاز بیشتر است.")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string UserName { get; set; }

        [Display(Name ="کلمه عبور")]
        [MinLength(8, ErrorMessage ="حداقل کاراکتر های کلمه عبور 8 می باشد.")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Password { get; set; }

        [Display(Name ="شماره تماس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(11, ErrorMessage = "ورودی صحیح نیست")]
        [MinLength(11, ErrorMessage = "ورودی صحیح نیست")]
        public string Phone { get; set; }

        [Display(Name ="تاریخ عضویت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime Date { get; set; }= DateTime.Now;

        public User()
        {

        }

        public virtual List<Task> Tasks { get; set; }
        public virtual List<Partner> Partners { get; set; }
    }
}
