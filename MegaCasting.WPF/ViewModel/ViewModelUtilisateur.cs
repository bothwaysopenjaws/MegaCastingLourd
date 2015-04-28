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
        ObservableCollection<Utilisateur> Utilisateurs { get; set; }
        ObservableCollection<TypeUtilisateur> TypeUtilisateurs { get; set; }
        ObservableCollection<Adresse> Adresses { get; set; }
        ObservableCollection<Historique> Historiques { get; set; }
        
        

        public ViewModelUtilisateur()
        {
            Utilisateurs = new ObservableCollection<Utilisateur>(this.Entities.Utilisateurs);
            TypeUtilisateurs = new ObservableCollection<TypeUtilisateur>(this.Entities.TypeUtilisateurs);
            Adresses = new ObservableCollection<Adresse>(this.Entities.Adresses);
            Historiques = new ObservableCollection<Historique>(this.Entities.Historiques);

        }


    }
}
