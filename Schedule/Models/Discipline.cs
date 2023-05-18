using Schedule.Common;

namespace Schedule.Models
{
    public class Discipline : Notify
    {
        private string name;

        public int Id { get; set; }
        public string Name { get => name; set => Set(ref name, value); }
    }
}
