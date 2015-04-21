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

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour TabParametres.xaml
    /// </summary>
    public partial class TabParametres : UserControl
    {
        public TabParametres()
        {
            InitializeComponent();
        }

        private void ButtonParametreTypeAbonnements_Click(object sender, RoutedEventArgs e)
        {
            GestionTypeAbonnement gestionAbonnement = new GestionTypeAbonnement();
            gestionAbonnement.ShowDialog();
        }
    }
}
