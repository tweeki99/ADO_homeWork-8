using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityApp
{
    public class Visitor : Entity
    {
        public DateTime DateTimeIn { get; set; }
        public DateTime? DateTimeOut { get; set; }
        public string Name { get; set; }
        public string PassportNumber{ get; set; }
        public string PurposeOfVisit { get; set; }

        public Visitor()
        {
            DateTimeIn = DateTime.Now;
        }
    }
}
