using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models
{
    class IssuingHours
    {
        public DateTime Date { get; set; }
        public Load Load { get; set; }
        public int Hours { get; set; }
    }
}
