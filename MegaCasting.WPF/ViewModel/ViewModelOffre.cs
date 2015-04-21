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
        public ObservableCollection<offre> Offres { get; set; }
        public ObservableCollection<typecontrat> TypeContrats { get; set; }

        public ViewModelOffre ()
        {
            Offres   = new ObservableCollection<offre>(this.Entities.offres);
            TypeContrats = new ObservableCollection<typecontrat>(this.Entities.typecontrats);

        }

    }
}
