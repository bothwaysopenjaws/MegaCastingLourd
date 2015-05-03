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


        #region Constructeurs


        public PanelParametres()
        {
            InitializeComponent();
        }

        #endregion


        #region Évènements

        /// <summary>
        /// Ouverture d'une fenêtre de gestion des type d'abonnements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonParametreTypeAbonnements_Click(object sender, RoutedEventArgs e)
        {
            GestionTypeAbonnement gestionAbonnement = new GestionTypeAbonnement();
            gestionAbonnement.ShowDialog();
        }

        /// <summary>
        /// Ouverture d'une fenêtre de gestion des type de compétences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonParametreTypeCompetences_Click(object sender, RoutedEventArgs e)
        {
            GestionTypeCompetence gestiontypeCompetence = new GestionTypeCompetence();
            gestiontypeCompetence.ShowDialog();
        }

        /// <summary>
        /// Ouverture d'une fenêtre de gestion des domaines
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonParametreMetierDomaines_Click(object sender, RoutedEventArgs e)
        {
            GestionTypeMetierDomaine gestionTypeMetierDomaine = new GestionTypeMetierDomaine();
            gestionTypeMetierDomaine.ShowDialog();
        }

        /// <summary>
        /// Ouverture d'une fenêtre de gestion des type de contrats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonParametreTypeContrat_Click(object sender, RoutedEventArgs e)
        {
            GestionTypeContrat gestionTypeContrat = new GestionTypeContrat();
            gestionTypeContrat.ShowDialog();
        }


        #endregion

    }
}
