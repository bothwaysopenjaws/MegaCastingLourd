using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelUtilisateur : ViewModelBase
    {
        public ObservableCollection<Utilisateur> utilisateurs { get; set; }
        public ObservableCollection<TypeUtilisateur> typeUtilisateurs { get; set; }
        public ObservableCollection<Historique> historiques { get; set; }
        public ObservableCollection<Utilisateur> artistes { get; set; }
        

        public ViewModelUtilisateur()
        {
            utilisateurs = new ObservableCollection<Utilisateur>(this.Entities.Utilisateurs);
            typeUtilisateurs = new ObservableCollection<TypeUtilisateur>(this.Entities.TypeUtilisateurs);
            historiques = new ObservableCollection<Historique>(this.Entities.Historiques);
            artistes = new ObservableCollection<Utilisateur>(utilisateurs.Where(UtilisateurTemp => UtilisateurTemp.IdentifiantTypeutilisateur == 3).ToList());

        }


    }
}
