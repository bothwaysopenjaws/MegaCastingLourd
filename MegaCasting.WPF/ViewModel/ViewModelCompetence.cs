using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
   public class ViewModelCompetence : ViewModelBase
    {
       public ObservableCollection<Competence> Competences { get; set; }
       public ObservableCollection<TypeCompetence> TypeCompetences { get; set; }
       public ObservableCollection<Niveau> niveaux { get; set; }

        public ViewModelCompetence()
        {
            Competences = new ObservableCollection<Competence>(this.Entities.Competences);
            TypeCompetences = new ObservableCollection<TypeCompetence>(this.Entities.TypeCompetences);
            niveaux = new ObservableCollection<Niveau>(this.Entities.Niveaux);
        }

    }
}
