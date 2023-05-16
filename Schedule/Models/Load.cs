using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models
{
    class Load
    {
        public Teacher Teacher { get; set; }
        public Discipline Discipline { get; set; }
        public Group Group { get; set; }
        public SubGroup SubGroup { get; set; }
        public LessonType LessonType { get; set; }
        public int Hours { get; set; }
    }
}
