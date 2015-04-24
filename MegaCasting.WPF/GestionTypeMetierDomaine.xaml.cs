using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MegaCasting.DBLib;
using MegaCasting.WPF.ViewModel;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour GestionTypeMetierDomaine.xaml
    /// </summary>
    public partial class GestionTypeMetierDomaine : Window
    {
        protected ViewModelDomaine_Metier _ViewModel;


        public GestionTypeMetierDomaine()
        {
            InitializeComponent();
            

            // Récupération de la ViewModel
            _ViewModel = new ViewModelDomaine_Metier();

            // intégrer la View au dataContext
            this.DataContext = _ViewModel;
        }
    }
}
