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
        ObservableCollection<typemedia> TypeMedia { get; set; }



        public ViewModelMedia()
        {
            TypeMedia = new ObservableCollection<typemedia>(this.Entities.typemedias);
        }
    }
}
