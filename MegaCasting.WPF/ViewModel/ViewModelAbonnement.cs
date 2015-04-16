using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelAbonnement : ViewModelBase
    {
       public ObservableCollection<abonnement> Abonnements { get; set; }
       public ObservableCollection<typeabonnement> TypeAbonnements { get; set; }


        public ViewModelAbonnement()
        {
            Abonnements = new ObservableCollection<abonnement>(this.Entities.abonnements);
            TypeAbonnements = new ObservableCollection<typeabonnement>(this.Entities.typeabonnements);
        }
    }
}
