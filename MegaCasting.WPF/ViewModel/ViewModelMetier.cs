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
        public ObservableCollection<metier> Metiers { get; set; }
        public ObservableCollection<domaine> Domaines { get; set; }


        public ViewModelMetier()
        {
            Metiers = new ObservableCollection<metier>(this.Entities.metiers);
            Domaines = new ObservableCollection<domaine>(this.Entities.domaines);
        }

    }
}
