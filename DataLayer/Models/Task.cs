using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Task
    {
        public int TaskID { get; set; }
        public int ListID { get; set; }
        public string Title { get; set; }
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
