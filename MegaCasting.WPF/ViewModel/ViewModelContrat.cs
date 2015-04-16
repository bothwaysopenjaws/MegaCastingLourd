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

        public ObservableCollection<contrat> Contrats { get; set; }
        public ObservableCollection<typecontrat> TypeContrats { get; set; }


        public ViewModelContrat()
        {
            Contrats = new ObservableCollection<contrat>(this.Entities.contrats);
            TypeContrats = new ObservableCollection<typecontrat>(this.Entities.typecontrats);
        }

    }
}
