using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    public class ViewModelMedia : ViewModelBase
    {
        public ObservableCollection<TypeMedia> typeMedias { get; set; }
        public ObservableCollection<Multimedia> multimedias { get; set; }
        public ObservableCollection<Multimedia> multimediasArtiste { get; set; }


        public ViewModelMedia()
        {
            typeMedias = new ObservableCollection<TypeMedia>(this.Entities.TypeMedias);
            multimedias = new ObservableCollection<Multimedia>(this.Entities.Multimedias);  
        }



        /// <summary>
        /// Récupère les medias d'un artiste
        /// </summary>
        /// <param name="artiste"></param>
        public void multimediasParArtiste(Utilisateur artiste)
        {
            multimediasArtiste = new ObservableCollection<Multimedia>(this.Entities.Multimedias.Where(multimediaTemp => multimediaTemp.IdentifiantUtilisateur == artiste.Identifiant).ToList());
        }
    }
}
