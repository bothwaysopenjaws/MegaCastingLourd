using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
   public class ViewModelCompetence : ViewModelUtilisateur
    {
       public ObservableCollection<Competence> competences { get; set; }
       public ObservableCollection<TypeCompetence> typeCompetences { get; set; }
       public ObservableCollection<Niveau> niveaux { get; set; }
       public ObservableCollection<Competence> competencesArtiste { get; set; }



        public ViewModelCompetence()
        {
            
            competences = new ObservableCollection<Competence>(this.Entities.Competences);
            typeCompetences = new ObservableCollection<TypeCompetence>(this.Entities.TypeCompetences);
            niveaux = new ObservableCollection<Niveau>(this.Entities.Niveaux);

            
        }

        public void competencesParArtiste(Utilisateur artiste)
        {
            if (artiste != null)
            {
                competencesArtiste = new ObservableCollection<Competence>(this.Entities.Competences.Where(competenceTemp => competenceTemp.IdentifiantUtilisateur == artiste.Identifiant));
            }
        }




    }
}
