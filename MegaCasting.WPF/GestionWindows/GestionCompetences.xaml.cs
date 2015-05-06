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
using System.Collections.ObjectModel;
using MegaCasting.WPF.Ajout_Windows;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour Competences.xaml
    /// </summary>
    public partial class GestionCompetences : Window
    {

        #region Attributs
        protected ViewModelCompetence viewModelCompetence;
        protected Utilisateur artiste;
       
        #endregion

        #region Constructeurs

        public GestionCompetences(Utilisateur artisteTemp)
        {
            artiste = artisteTemp;
            
            InitializeComponent();
            viewModelCompetence = new ViewModelCompetence();
            viewModelCompetence.competencesParArtiste(artiste);
            // intégrer la View au dataContext
            this.DataContext = viewModelCompetence;


        }


        #endregion

        #region Evenement

        /// <summary>
        /// Event ouvrant une fenêtre permettant l'ajout de nouvelles compétences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCompetenceAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutCompetenceArtiste competenceArtiste = new AjoutCompetenceArtiste(viewModelCompetence,  artiste);
            competenceArtiste.ShowDialog();
            this.DataContext = competenceArtiste.viewModelCompetence;
        }

        /// <summary>
        /// Event de sauvegarder des modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCompetenceSauvegarder_Click(object sender, RoutedEventArgs e)
        {
            viewModelCompetence.Save();
        }

        /// <summary>
        /// Eventde suppression d'une compétence d'un artiste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCompetenceSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (this.ListBoxCompetencesArtistes.SelectedItem != null)
            {
                viewModelCompetence.Entities.Competences.Remove((Competence)this.ListBoxCompetencesArtistes.SelectedItem);
                viewModelCompetence.competencesArtiste.Remove((Competence)this.ListBoxCompetencesArtistes.SelectedItem);
                viewModelCompetence.competencesParArtiste(artiste);
                viewModelCompetence.Save();
            }
        }
        #endregion


    }
}
