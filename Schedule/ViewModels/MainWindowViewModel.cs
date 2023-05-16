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
                Month = 8;
            }

            IssuingHoursTableViewModal = new IssuingHoursTableViewModal(Group, Month);

        }
    }
}