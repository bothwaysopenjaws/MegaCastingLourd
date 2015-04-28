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


        public ViewModelMedia()
        {
            typeMedias = new ObservableCollection<TypeMedia>(this.Entities.TypeMedias);
            multimedias = new ObservableCollection<Multimedia>(this.Entities.Multimedias);  
        }
    }
}
