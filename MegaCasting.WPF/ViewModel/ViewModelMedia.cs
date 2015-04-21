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
        ObservableCollection<TypeMedia> TypeMedias { get; set; }
        ObservableCollection<Multimedia> Multimedias { get; set; }


        public ViewModelMedia()
        {
            TypeMedias = new ObservableCollection<TypeMedia>(this.Entities.TypeMedias);
            Multimedias = new ObservableCollection<Multimedia>(this.Entities.Multimedias);  
        }
    }
}
