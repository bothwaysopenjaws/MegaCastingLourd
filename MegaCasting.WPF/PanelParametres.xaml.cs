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
    /// Logique d'interaction pour PanelParametres.xaml
    /// </summary>
    public partial class PanelParametres : UserControl
    {
        public PanelParametres()
        {
            InitializeComponent();
        }

        private void ButtonParametreTypeAbonnements_Click(object sender, RoutedEventArgs e)
        {
            GestionTypeAbonnement gestionAbonnement = new GestionTypeAbonnement();
            gestionAbonnement.ShowDialog();
        }

        private void ButtonParametreTypeCompetences_Click(object sender, RoutedEventArgs e)
        {
            GestionTypeCompetence gestiontypeCompetence = new GestionTypeCompetence();
            gestiontypeCompetence.ShowDialog();
        }
    }
}
