using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
   public class ViewModelOffre : ViewModelUtilisateur
    {
        public ObservableCollection<Offre> offres { get; set; }
        public ObservableCollection<TypeContrat> TypeContrats { get; set; }
        public ObservableCollection<Domaine> domaines { get; set; }
        public ObservableCollection<Metier> metiers { get; set; }
       

        public ViewModelOffre ()
        {
            offres   = new ObservableCollection<Offre>(this.Entities.Offres);
            TypeContrats = new ObservableCollection<TypeContrat>(this.Entities.TypeContrats);
            domaines = new ObservableCollection<Domaine>(this.Entities.Domaines);
            metiers = new ObservableCollection<Metier>(this.Entities.Metiers);
        }

    }
}
