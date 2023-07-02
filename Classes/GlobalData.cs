using ProjectOffice.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProjectOffice.Desktop.Classes
{
    internal class GlobalData
    {
        public static DbProjectOfficeEntities BaseConnect = new DbProjectOfficeEntities();

        public static Frame ActiveFrame;

        public static Project SelectedProject;
    }
}
