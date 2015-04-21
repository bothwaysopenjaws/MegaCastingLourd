using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF.ViewModel
{
    class ViewModelMedia : ViewModelBase
    {
        ObservableCollection<typemedia> TypeMedias { get; set; }
        ObservableCollection<media> Medias { get; set; }


        public ViewModelMedia()
        {
            TypeMedias = new ObservableCollection<typemedia>(this.Entities.typemedias);
            Medias = new ObservableCollection<media>(this.Entities.medias);  
        }
    }
}
