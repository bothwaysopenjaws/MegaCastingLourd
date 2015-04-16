using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelCompetence : ViewModelBase
    {
        ObservableCollection<competence> Competences { get; set; }
        ObservableCollection<typecompetence> TypeCompetences { get; set; }

        public ViewModelCompetence()
        {
            Competences = new ObservableCollection<competence>(this.Entities.competences);
            TypeCompetences = new ObservableCollection<typecompetence>(this.Entities.typecompetences);
        }

    }
}
