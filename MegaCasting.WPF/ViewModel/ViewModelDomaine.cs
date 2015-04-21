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
        ObservableCollection<domaine> domaines { get; set; }
        ObservableCollection<metier> metiers { get; set; }
        
        public ViewModelDomaine()
        {
            domaines = new ObservableCollection<domaine>(this.Entities.domaines);
            metiers = new ObservableCollection<metier>(this.Entities.metiers);
        }



    }
}
