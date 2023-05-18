using Schedule.Common;
using System;

namespace Schedule.Models
{
    public class IssuingHours : Notify
    {
        private DateTime date;
        private int hours;

        public int Id { get; set; }
        public DateTime Date { get => date; set => Set(ref date, value); }
        public int Hours { get => hours; set => Set(ref hours, value); }

        public int LoadId { get; set; }
        public virtual Load Load { get; set; }
    }
}
