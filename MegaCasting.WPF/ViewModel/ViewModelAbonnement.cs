using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelAbonnement : ViewModelBase
    {
       public ObservableCollection<Abonnement> Abonnements { get; set; }
       public ObservableCollection<TypeAbonnement> TypeAbonnements { get; set; }


        public ViewModelAbonnement()
        {
            Abonnements = new ObservableCollection<Abonnement>(this.Entities.Abonnements);
            TypeAbonnements = new ObservableCollection<TypeAbonnement>(this.Entities.TypeAbonnements);
        }
    }
}
