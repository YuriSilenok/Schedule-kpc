using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class IssuingHours
    {
        public virtual int Id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Load Load { get; set; }
        public virtual int? Hours { get; set; }
    }
}
