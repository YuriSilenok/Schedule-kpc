using Microsoft.EntityFrameworkCore;
using Schedule.Models;
using Schedule.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.ViewModels
{
    class MainWindowViewModelItem : ViewModel
    {
        private string discipline;
        public string Discipline
        {
            get => discipline;
            set=>Set(ref discipline, value);
        }




    }

    class MainWindowViewModel : ViewModel
    {
        public IssuingHoursTableViewModal IssuingHoursTableViewModal { get; set; }

        private Group group;
        public Group Group { 
            get => group;
            set => Set(ref group, value);
        }

        private int month;
        public int Month
        {
            get => month;
            set => Set(ref month, value);
        }


        private DataTable table;
        public DataTable Table
        {
            get => table;
            set => Set(ref table, value);
        }

        
        public MainWindowViewModel()
        {
            using(DBContext db = new DBContext())
            {
                Group = db.Groups.First();
                Month = 5;
            }

            IssuingHoursTableViewModal = new IssuingHoursTableViewModal(Group, Month);

        }
    }
    internal class IssuingHoursTableViewModal : ViewModel
    {
        public List<IssuingHoursItemViewModal> Data = new List<IssuingHoursItemViewModal>();
        public IssuingHoursTableViewModal(Group group, int month)
        {
            using (DBContext db = new DBContext())
            {
                List<IssuingHours> IssuingHours = db.IssuingHours
                    .Where(i => i.Date.Month == month && i.Load.Group == group)
                    .ToList();
                
                foreach (IssuingHours issuingHours in IssuingHours)
                {
                    IssuingHoursItemViewModal item = new IssuingHoursItemViewModal()
                    {
                        Discipline = issuingHours.Load.Discipline,
                        LessonType = issuingHours.Load.LessonType,
                        DistributeHours = issuingHours.Load.HoursBalance,
                        Teacher = issuingHours.Load.Teacher,
                        HoursBalance = 0
                    };
                    item.HoursInDays[0] = issuingHours.Hours;
                    Data.Add(item);
                }
            }
        }
    }

    internal class IssuingHoursItemViewModal : ViewModel
    {
        public Discipline Discipline { get; set; }
        public Teacher Teacher { get; set; }
        public LessonType LessonType { get; set; }
        public int DistributeHours { get; set; }
        public int Total { get; set; }
        public int HoursBalance { get; set; }

        public int?[] HoursInDays { get; set; } = new int?[31];
        public int? HoursInDay01 { get => HoursInDays[0]; set => HoursInDays[0] = value; }
        public int? HoursInDay02 { get => HoursInDays[1]; set => HoursInDays[1] = value; }
        public int? HoursInDay03 { get => HoursInDays[2]; set => HoursInDays[2] = value; }
        public int? HoursInDay04 { get => HoursInDays[3]; set => HoursInDays[3] = value; }
        public int? HoursInDay05 { get => HoursInDays[4]; set => HoursInDays[4] = value; }
        public int? HoursInDay06 { get => HoursInDays[5]; set => HoursInDays[5] = value; }
        public int? HoursInDay07 { get => HoursInDays[6]; set => HoursInDays[6] = value; }
        public int? HoursInDay08 { get => HoursInDays[7]; set => HoursInDays[7] = value; }
        public int? HoursInDay09 { get => HoursInDays[8]; set => HoursInDays[8] = value; }
        public int? HoursInDay10 { get => HoursInDays[9]; set => HoursInDays[9] = value; }
        public int? HoursInDay11 { get => HoursInDays[10]; set => HoursInDays[10] = value; }
        public int? HoursInDay12 { get => HoursInDays[11]; set => HoursInDays[11] = value; }
        public int? HoursInDay13 { get => HoursInDays[12]; set => HoursInDays[12] = value; }
        public int? HoursInDay14 { get => HoursInDays[13]; set => HoursInDays[13] = value; }
        public int? HoursInDay15 { get => HoursInDays[14]; set => HoursInDays[14] = value; }
        public int? HoursInDay16 { get => HoursInDays[15]; set => HoursInDays[15] = value; }
        public int? HoursInDay17 { get => HoursInDays[16]; set => HoursInDays[16] = value; }
        public int? HoursInDay18 { get => HoursInDays[17]; set => HoursInDays[17] = value; }
        public int? HoursInDay19 { get => HoursInDays[18]; set => HoursInDays[18] = value; }
        public int? HoursInDay20 { get => HoursInDays[19]; set => HoursInDays[19] = value; }
        public int? HoursInDay21 { get => HoursInDays[20]; set => HoursInDays[20] = value; }
        public int? HoursInDay22 { get => HoursInDays[21]; set => HoursInDays[21] = value; }
        public int? HoursInDay23 { get => HoursInDays[22]; set => HoursInDays[22] = value; }
        public int? HoursInDay24 { get => HoursInDays[23]; set => HoursInDays[23] = value; }
        public int? HoursInDay25 { get => HoursInDays[24]; set => HoursInDays[24] = value; }
        public int? HoursInDay26 { get => HoursInDays[25]; set => HoursInDays[25] = value; }
        public int? HoursInDay27 { get => HoursInDays[26]; set => HoursInDays[26] = value; }
        public int? HoursInDay28 { get => HoursInDays[27]; set => HoursInDays[27] = value; }
        public int? HoursInDay29 { get => HoursInDays[28]; set => HoursInDays[28] = value; }
        public int? HoursInDay30 { get => HoursInDays[29]; set => HoursInDays[29] = value; }
        public int? HoursInDay31 { get => HoursInDays[30]; set => HoursInDays[30] = value; }
    }
}