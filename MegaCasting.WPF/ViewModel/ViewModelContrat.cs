using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelContrat : ViewModelBase
    {

        public ObservableCollection<typecontrat> TypeContrats { get; set; }


        public ViewModelContrat()
        {
            
            TypeContrats = new ObservableCollection<typecontrat>(this.Entities.typecontrats);
        }

    }
}
