using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class List
    {
        public int ListID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int MakerID { get; set; }

        public List()
        {

        }
        public virtual List<Task> Tasks { get; set; }
        public virtual List<Partner> Partners { get; set; }
    }
}
