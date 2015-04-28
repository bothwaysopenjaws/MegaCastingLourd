using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelCandidature : ViewModelBase
    {

        public ObservableCollection<Candidature> candidatures { get; set; }

        public ViewModelCandidature()
        {
            candidatures = new ObservableCollection<Candidature>(this.Entities.Candidatures);
            
        }

    }
}
