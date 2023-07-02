using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOffice.Desktop.Models
{
    public partial class Emploeyy
    {
        public string FullName { get => ($"{Surname} {Name} {Patronymic}"); }
    }
}
