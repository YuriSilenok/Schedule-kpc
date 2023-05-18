using Schedule.Common;

namespace Schedule.Models
{
    public class SubGroup : Notify
    {
        private string name;

        public int Id { get; set; }
        public string Name { get => name; set => Set(ref name, value); }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
