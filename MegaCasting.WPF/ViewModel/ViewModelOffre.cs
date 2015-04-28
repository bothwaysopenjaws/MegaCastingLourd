using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
   public class ViewModelOffre : ViewModelBase
    {
        public ObservableCollection<Offre> offres { get; set; }
        public ObservableCollection<TypeContrat> TypeContrats { get; set; }

        public ViewModelOffre ()
        {
            offres   = new ObservableCollection<Offre>(this.Entities.Offres);
            TypeContrats = new ObservableCollection<TypeContrat>(this.Entities.TypeContrats);

        }

    }
}
