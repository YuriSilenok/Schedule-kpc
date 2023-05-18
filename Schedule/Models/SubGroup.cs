using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class SubGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
