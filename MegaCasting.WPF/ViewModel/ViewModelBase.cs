using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using MegaCasting.DBLib;


namespace MegaCasting.WPF.ViewModel
{
  public  class ViewModelBase
    {
        megacastingEntities _Entities = new megacastingEntities();

        public megacastingEntities Entities { get { return _Entities; } }


        public void Save()
        {

            this.Entities.SaveChanges();
        }
    }
}
