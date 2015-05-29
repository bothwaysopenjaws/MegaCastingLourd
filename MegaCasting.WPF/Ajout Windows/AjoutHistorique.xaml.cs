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

namespace MegaCasting.WPF.Ajout_Windows
{
    /// <summary>
    /// Logique d'interaction pour AjoutHistorique.xaml
    /// </summary>
    public partial class AjoutHistorique : Window
    {
        #region Attributs
        protected ViewModelUtilisateur viewModelUtilisateur;
        protected Utilisateur artiste;
        #endregion

        #region Constructeur
        public AjoutHistorique(Utilisateur utilisateurPanel, ViewModelUtilisateur viewModelUser)
        {
            InitializeComponent();
            artiste = utilisateurPanel;
            viewModelUtilisateur = new ViewModelUtilisateur();
            viewModelUtilisateur = viewModelUser;
            this.DataContext = viewModelUtilisateur;
        }
        #endregion

        #region Evenements
        /// <summary>
        /// Ajout D'une expériences pour l'artiste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExperienceAjouter_Click(object sender, RoutedEventArgs e)
        {
            Historique historique = new Historique();
            if (this.TextBoxNomSocieteExp.Text != null && this.TextBoxNomSocieteExp.Text != "")
            {
                if (this.DatePickerDebutExperiences.SelectedDate < this.DatePickerFinExperiences.SelectedDate && this.DatePickerFinExperiences.SelectedDate != null && this.DatePickerDebutExperiences.SelectedDate != null)
                {
                    historique.Societe = this.TextBoxNomSocieteExp.Text;
                    historique.DateDebut = (DateTime)this.DatePickerDebutExperiences.SelectedDate;
                    historique.DateFin = (DateTime)this.DatePickerFinExperiences.SelectedDate;
                    historique.Description = this.TextBlockDescriptionExp.Text;

                    viewModelUtilisateur.Entities.Utilisateurs.Where(utilisateurTemp => utilisateurTemp.Identifiant == artiste.Identifiant).First().historiques.Add(historique);
                    viewModelUtilisateur.artistes.Where(utilisateurTemp => utilisateurTemp.Identifiant == artiste.Identifiant).First().historiques.Add(historique);
                    viewModelUtilisateur.HistoriquesArtiste.Add(historique);
                    this.viewModelUtilisateur.Save();
                    this.Close();
                }
                else { MessageBox.Show("Veuillez saisir une date de début inférieur à la date de fin !"); }
            }
            else { MessageBox.Show("Veuillez saisir un nom de société !"); }
        }
        #endregion
    }
}
