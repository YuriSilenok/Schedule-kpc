using Schedule.Models;
using Schedule.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.ViewModels
{
    internal class IssuingHoursTableViewModal : ViewModel
    {
        public List<IssuingHoursItemViewModal> Data = new List<IssuingHoursItemViewModal>();
        public IssuingHoursTableViewModal(Group group, int month)
        {
            using(DBContext db = new DBContext())
            {
                List<IssuingHours> IssuingHours = db.IssuingHours
                    .Where(i=>i.Date.Month == month && i.Load.Group == group).ToList();
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
                    item.HoursInDays[issuingHours.Date.Day] = issuingHours.Hours;
                    Data.Add(item);
                }
            }
        }
    }
}
