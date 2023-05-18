using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class IssuingHours
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? Hours { get; set; }

        public int LoadId { get; set; }
        public virtual Load Load { get; set; }
    }
}
