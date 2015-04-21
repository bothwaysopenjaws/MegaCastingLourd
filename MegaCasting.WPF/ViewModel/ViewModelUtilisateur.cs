using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelUtilisateur : ViewModelBase
    {
        ObservableCollection<utilisateur> Utilisateurs { get; set; }
        ObservableCollection<typeutilisateur> TypeUtilisateurs { get; set; }
        ObservableCollection<adresse> Adresses { get; set; }
        ObservableCollection<historique> Historiques { get; set; }
        

        public ViewModelUtilisateur()
        {
            Utilisateurs = new ObservableCollection<utilisateur>(this.Entities.utilisateurs);
            TypeUtilisateurs = new ObservableCollection<typeutilisateur>(this.Entities.typeutilisateurs);
            Adresses = new ObservableCollection<adresse>(this.Entities.adresses);
            Historiques = new ObservableCollection<historique>(this.Entities.historiques);

        }


    }
}
