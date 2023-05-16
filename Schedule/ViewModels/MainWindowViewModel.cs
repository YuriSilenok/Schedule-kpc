using Schedule.Models;
using Schedule.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.ViewModels
{
    class MainWindowViewModel : ViewModel
    {

        private List<IssuingHours> loads = new List<IssuingHours>();

        private Group group;
        public Group Group { 
            get => group; 
        }

        private string month;
        public string Month
        {
            get => month;
        }


        private DataTable table;
        public DataTable Table
        {
            get => table;
            set => Set(ref table, value);
        }


        public MainWindowViewModel()
        {
            Discipline d = new Discipline() { Name = "История" };
            loads.Add(new IssuingHours()
            {
                Load = new Load()
                {
                    Discipline = d,
                    Hours = 46,
                    Group = new Group() { Name = "2-2П9" },
                    LessonType = new LessonType() { Name = "Ау" },
                    Teacher = new Teacher() { Name = "Задорина" }
                },
                Date = DateTime.Today,
                Hours = 46
            });
            loads.Add(new IssuingHours()
            {
                Load = new Load()
                {
                    Discipline = d,
                    Hours = 6,
                    Group = new Group() { Name = "2-2П9" },
                    LessonType = new LessonType() { Name = "СР" },
                    Teacher = new Teacher() { Name = "Задорина" }
                },
                Date = DateTime.Today,
                Hours = 6
            });

            group = new Group() { Name = "2-2П9"};
            month = "Сентябрь";
            table = new DataTable();
            table.Columns.Add("Дисциплина", typeof(string));
            table.Columns.Add("Кол часов", typeof(string));
            table.Columns.Add("Фамилия", typeof(string));
            for (int i = 1; i <= 31; i++)
                table.Columns.Add(i.ToString(), typeof(string));

            Discipline discipline = null;
            foreach (IssuingHours item in loads)
            {
                table.Rows.Add(
                    discipline == item.Load.Discipline ? item.Load.LessonType.Name : item.Load.Discipline.Name,
                    item.Load.Hours,
                    item.Load.Teacher.Name
                );
                discipline = item.Load.Discipline;
            }
        }
    }
}