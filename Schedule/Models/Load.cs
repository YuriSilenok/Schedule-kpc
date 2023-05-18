using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Load
    {
        public int Id { get; set; }
        public int HoursBalance { get; set; }
        public int DistributeHours { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public int DisciplineId { get; set; }
        public virtual Discipline Discipline { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int SubGroupId { get; set; }
        public virtual SubGroup SubGroup { get; set; }

        public int LessonTypeId { get; set; }
        public virtual LessonType LessonType { get; set; }
    }
}
