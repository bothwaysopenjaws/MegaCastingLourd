using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPF.Functions
{
    public class Functions
    {


        public int CalculAge(DateTime anniversaire)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - anniversaire.Year;
            if (anniversaire > now.AddYears(-age))
                age--;
            return age;
        }

    }
}
