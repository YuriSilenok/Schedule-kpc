using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models
{
    class Group
    {
        public string Name { get; set; }
        public List<SubGroup> SubGroups { get; set; } = new List<SubGroup>();
    }
}
