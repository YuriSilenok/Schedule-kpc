using Schedule.Common;
using Schedule.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Dynamic;
using System.Linq;

namespace Schedule.ViewModels
{
    internal class MainWindowViewModel : Notify
    {
        private ObservableCollection<Row> table;
        private Group selectedGroup;
        private int selectedMonth = DateTime.Now.Month - 1;

        public ObservableCollection<Row> Table { get => table; set => Set(ref table, value); }
        public ObservableCollection<Group> Groups { get; } = new ObservableCollection<Group>(DBContext.DB.Groups);
        
        public Group SelectedGroup
        {
            get => selectedGroup;
            set 
            { 
                Set(ref selectedGroup, value);
                UpdateTable();
            }
        }

        public List<string> Months { get; } = new List<string>()
        {
            "Январь", "Февраль", "Март", "Апрель",
            "Май", "Июнь", "Июль", "Август",
            "Сентябрь", "Октябрь", "Декабрь"
        };
        
        public int SelectedMonth
        {
            get => selectedMonth;
            set
            {
                Set(ref selectedMonth, value);
                UpdateTable();
            }
        }

        private void UpdateTable()
        {
            if (selectedGroup == null) return;

            ObservableCollection<Row> table = new ObservableCollection<Row>();

            DBContext db = DBContext.DB;
            List<IssuingHours> IssuingHours = db.IssuingHours
                .Where(i => i.Date.Month == selectedMonth + 1 && i.Load.GroupId == selectedGroup.Id)
                .ToList();
            Row row = null;
            foreach (IssuingHours issuingHours in IssuingHours)
            {
                if (row == null) row = new Row();
                else if (row.Discipline.Id != issuingHours.Load.DisciplineId ||
                    row.LessonType.Id != issuingHours.Load.LessonTypeId)
                {
                    table.Add(row);
                    row = new Row();
                }

                row.Discipline = issuingHours.Load.Discipline;
                row.LessonType = issuingHours.Load.LessonType;
                row.DistributeHours = issuingHours.Load.HoursBalance;
                row.Teacher = issuingHours.Load.Teacher;
                row.HoursBalance = 0;
                row.HoursInDays[issuingHours.Date.Day] = issuingHours;

            }
            if (row != null) table.Add(row);

            Table = table;
        }

        public class Row : Notify
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public Load Load { get; set; }
            public Discipline Discipline { get; set; }
            public Teacher Teacher { get; set; }
            public LessonType LessonType { get; set; }
            public int DistributeHours { get; set; }
            public int Total { get; set; }
            public int HoursBalance { get; set; }

            public IssuingHours[] HoursInDays { get; set; } = new IssuingHours[31];

            public IssuingHours HoursInDay01 { get => HoursInDays[0]; set => Set(ref HoursInDays[0], value); }
            public IssuingHours HoursInDay02 { get => HoursInDays[1]; set => Set(ref HoursInDays[1], value); }
            public IssuingHours HoursInDay03 { get => HoursInDays[2]; set => Set(ref HoursInDays[2], value); }
            public IssuingHours HoursInDay04 { get => HoursInDays[3]; set => Set(ref HoursInDays[3], value); }
            public IssuingHours HoursInDay05 { get => HoursInDays[4]; set => Set(ref HoursInDays[4], value); }
            public IssuingHours HoursInDay06 { get => HoursInDays[5]; set => Set(ref HoursInDays[5], value); }
            public IssuingHours HoursInDay07 { get => HoursInDays[6]; set => Set(ref HoursInDays[6], value); }
            public IssuingHours HoursInDay08 { get => HoursInDays[7]; set => Set(ref HoursInDays[7], value); }
            public IssuingHours HoursInDay09 { get => HoursInDays[8]; set => Set(ref HoursInDays[8], value); }
            public IssuingHours HoursInDay10 { get => HoursInDays[9]; set => Set(ref HoursInDays[9], value); }
            public IssuingHours HoursInDay11 { get => HoursInDays[10]; set => Set(ref HoursInDays[10], value); }
            public IssuingHours HoursInDay12 { get => HoursInDays[11]; set => Set(ref HoursInDays[11], value); }
            public IssuingHours HoursInDay13 { get => HoursInDays[12]; set => Set(ref HoursInDays[12], value); }
            public IssuingHours HoursInDay14 { get => HoursInDays[13]; set => Set(ref HoursInDays[13], value); }
            public IssuingHours HoursInDay15 { get => HoursInDays[14]; set => Set(ref HoursInDays[14], value); }
            public IssuingHours HoursInDay16 { get => HoursInDays[15]; set => Set(ref HoursInDays[15], value); }
            public IssuingHours HoursInDay17 { get => HoursInDays[16]; set => Set(ref HoursInDays[16], value); }
            public IssuingHours HoursInDay18 { get => HoursInDays[17]; set => Set(ref HoursInDays[17], value); }
            public IssuingHours HoursInDay19 { get => HoursInDays[18]; set => Set(ref HoursInDays[18], value); }
            public IssuingHours HoursInDay20 { get => HoursInDays[19]; set => Set(ref HoursInDays[19], value); }
            public IssuingHours HoursInDay21 { get => HoursInDays[20]; set => Set(ref HoursInDays[20], value); }
            public IssuingHours HoursInDay22 { get => HoursInDays[21]; set => Set(ref HoursInDays[21], value); }
            public IssuingHours HoursInDay23 { get => HoursInDays[22]; set => Set(ref HoursInDays[22], value); }
            public IssuingHours HoursInDay24 { get => HoursInDays[23]; set => Set(ref HoursInDays[23], value); }
            public IssuingHours HoursInDay25 { get => HoursInDays[24]; set => Set(ref HoursInDays[24], value); }
            public IssuingHours HoursInDay26 { get => HoursInDays[25]; set => Set(ref HoursInDays[25], value); }
            public IssuingHours HoursInDay27 { get => HoursInDays[26]; set => Set(ref HoursInDays[26], value); }
            public IssuingHours HoursInDay28 { get => HoursInDays[27]; set => Set(ref HoursInDays[27], value); }
            public IssuingHours HoursInDay29 { get => HoursInDays[28]; set => Set(ref HoursInDays[28], value); }
            public IssuingHours HoursInDay30 { get => HoursInDays[29]; set => Set(ref HoursInDays[29], value); }
            public IssuingHours HoursInDay31 { get => HoursInDays[30]; set => Set(ref HoursInDays[30], value); }
        }
    }
}