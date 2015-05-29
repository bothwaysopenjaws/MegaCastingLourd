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
using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using MegaCasting.WPF.Ajout_Windows;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour Gestion_Experiences.xaml
    /// </summary>
    public partial class Gestion_Experiences : Window
    {
        #region Attributs
        protected ViewModelUtilisateur viewModelUtilisateur;
        protected Utilisateur artiste;
        #endregion

        #region Constructeurs
        public Gestion_Experiences(Utilisateur utilisateurPanel)
        {

            InitializeComponent();
            artiste = utilisateurPanel;
            viewModelUtilisateur = new ViewModelUtilisateur();
            viewModelUtilisateur.HistoriquesParArtiste(utilisateurPanel);
            this.DataContext = viewModelUtilisateur;
        }
        #endregion


        /// <summary>
        /// Ouverture de l'ajout D'une expérience
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Evènements
        private void ButtonExperienceAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutHistorique ajouthistorique = new AjoutHistorique(artiste, viewModelUtilisateur);
            ajouthistorique.ShowDialog();
        }
        /// <summary>
        /// Suppression d'une expérience
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExperienceSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (this.ListBoxExperiences.SelectedItem != null)
            {
                // Suppression 
                viewModelUtilisateur.Entities.Historiques.Remove((Historique)this.ListBoxExperiences.SelectedItem);
                viewModelUtilisateur.HistoriquesArtiste.Remove((Historique)this.ListBoxExperiences.SelectedItem);
                viewModelUtilisateur.Save();
            }
        }

        private void ButtonExperienceModifier_Click(object sender, RoutedEventArgs e)
        {
            
            this.viewModelUtilisateur.Save();
        
        }
        #endregion

        

    }
}
