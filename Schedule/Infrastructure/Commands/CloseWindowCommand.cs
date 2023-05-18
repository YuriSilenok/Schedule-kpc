using Schedule.Infrastructure.Commands.Base;
using Schedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Schedule.Infrastructure.Commands
{
    class CloseWindowCommand : Command
    {
        public override bool CanExecute(object parameter) => parameter is Window;

        public override void Execute(object parameter)
        {
            if (!CanExecute(parameter)) return;

            var window = (Window)parameter;
            DBContext.DB.SaveChanges();
            window.Close();
        }
    }

}
