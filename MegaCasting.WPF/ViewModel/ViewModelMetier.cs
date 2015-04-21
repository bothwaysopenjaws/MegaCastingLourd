using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelMetier : ViewModelBase
    {
        public ObservableCollection<Metier> Metiers { get; set; }
        public ObservableCollection<Domaine> Domaines { get; set; }


        public ViewModelMetier()
        {
            Metiers = new ObservableCollection<Metier>(this.Entities.Metiers);
            Domaines = new ObservableCollection<Domaine>(this.Entities.Domaines);
        }

    }
}
