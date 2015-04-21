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
        ObservableCollection<multimedia> Multimedias { get; set; }


        public ViewModelMedia()
        {
            TypeMedias = new ObservableCollection<typemedia>(this.Entities.typemedias);
            Multimedias = new ObservableCollection<multimedia>(this.Entities.multimedias);  
        }
    }
}
