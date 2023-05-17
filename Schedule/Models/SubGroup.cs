using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class SubGroup
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Group Group { get; set; }
    }
}
