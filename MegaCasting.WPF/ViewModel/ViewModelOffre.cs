using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelOffre : ViewModelBase
    {
        public ObservableCollection<Offre> Offres { get; set; }
        public ObservableCollection<TypeContrat> TypeContrats { get; set; }

        public ViewModelOffre ()
        {
            Offres   = new ObservableCollection<Offre>(this.Entities.Offres);
            TypeContrats = new ObservableCollection<TypeContrat>(this.Entities.TypeContrats);

        }

    }
}
