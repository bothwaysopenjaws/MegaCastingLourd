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
    /// Logique d'interaction pour GestionTypeAbonnement.xaml
    /// </summary>
    public partial class GestionTypeAbonnement : Window
    {
        private ViewModelAbonnement _ViewModel;

        public GestionTypeAbonnement()
        {
            InitializeComponent();

            // Récupération de la ViewModel
            _ViewModel = new ViewModelAbonnement();

            // intégrer la View au dataContext
            this.DataContext = _ViewModel;
        }

        private void ButtoTypeAbonnementAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutTypeAbonnement ajout = new AjoutTypeAbonnement();

            ajout.ShowDialog();
        }

        private void ButtonTypeAbonnementSupprimer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonTypeAbonnementModifier_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
