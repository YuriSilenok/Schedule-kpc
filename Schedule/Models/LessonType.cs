using Schedule.Common;

namespace Schedule.Models
{
    public class LessonType : Notify
    {
        private string name;

        public int Id { get; set; }
        public string Name { get => name; set => Set(ref name, value); }
    }
}
