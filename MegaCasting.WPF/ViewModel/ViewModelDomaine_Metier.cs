using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
   public class ViewModelDomaine_Metier : ViewModelUtilisateur
    {
       public ObservableCollection<Domaine> domaines { get; set; }
       public ObservableCollection<Metier> metiers { get; set; }
       public ObservableCollection<Metier> metiersArtistes { get; set; }
        
        public ViewModelDomaine_Metier()
        {
            domaines = new ObservableCollection<Domaine>(this.Entities.Domaines);
            metiers = new ObservableCollection<Metier>(this.Entities.Metiers);
        }

        public void metierParArtiste(Utilisateur user)
        {
            metiersArtistes = new ObservableCollection<Metier>();
            if(user != null)
            {
                foreach(Metier metier in user.metiers)
                {
                    metiersArtistes.Add(metier);
                }
            }
        }

    }
}
