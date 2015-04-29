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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MegaCasting.DBLib;
using MegaCasting.WPF.ViewModel;
using System.Collections.ObjectModel;

namespace MegaCasting.WPF

{
    /// <summary>
    /// Logique d'interaction pour PanelArtistes.xaml
    /// </summary>
    public partial class PanelArtistes : UserControl
    {
        protected ViewModelUtilisateur _ViewModel;

        public PanelArtistes()
        {
            InitializeComponent();

            // Récupération de la ViewModel
            _ViewModel = new ViewModelUtilisateur();

            // intégrer la View au dataContext
            this.DataContext = _ViewModel;

            
        }
    }
}
