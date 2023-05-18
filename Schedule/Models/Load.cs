using Schedule.Common;

namespace Schedule.Models
{
    public class Load : Notify
    {
        private int hoursBalance;
        private int distributeHours;

        public int Id { get; set; }
        public int HoursBalance { get => hoursBalance; set => Set(ref hoursBalance, value); }
        public int DistributeHours { get => distributeHours; set => Set(ref distributeHours, value); }

        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public int DisciplineId { get; set; }
        public virtual Discipline Discipline { get; set; }

        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public int? SubGroupId { get; set; }
        public virtual SubGroup SubGroup { get; set; }

        public int LessonTypeId { get; set; }
        public virtual LessonType LessonType { get; set; }
    }
}
