using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelDomaine : ViewModelBase
    {
        ObservableCollection<Domaine> domaines { get; set; }
        ObservableCollection<Metier> metiers { get; set; }
        
        public ViewModelDomaine()
        {
            domaines = new ObservableCollection<Domaine>(this.Entities.Domaines);
            metiers = new ObservableCollection<Metier>(this.Entities.Metiers);
        }



    }
}
