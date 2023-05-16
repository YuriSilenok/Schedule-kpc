using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Models
{
    class SubGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Group Group { get; set; }
    }
}
