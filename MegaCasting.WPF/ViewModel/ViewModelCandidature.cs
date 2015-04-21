using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelCandidature : ViewModelBase
    {

        ObservableCollection<Candidature> Candidatures { get; set; }

        public ViewModelCandidature()
        {
            Candidatures = new ObservableCollection<Candidature>(this.Entities.Candidatures);
            
        }

    }
}
