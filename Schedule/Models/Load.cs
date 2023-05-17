using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Load
    {
        public virtual int Id { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Discipline Discipline { get; set; }
        public virtual Group Group { get; set; }
        public virtual SubGroup SubGroup { get; set; }
        public virtual LessonType LessonType { get; set; }
        public virtual int HoursBalance { get; set; }
        public virtual int DistributeHours { get; set; }
    }
}
