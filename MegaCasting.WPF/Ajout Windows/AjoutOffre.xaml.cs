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
using MegaCasting.WPF;
using MegaCasting.WPF.ViewModel;

namespace MegaCasting.WPF.Ajout_Windows
{
    /// <summary>
    /// Logique d'interaction pour AjouteOffre.xaml
    /// </summary>
    public partial class AjouteOffre : Window
    {
        #region Attributs
        protected ViewModelOffre _ViewModelOffre;
        #endregion

        #region Constructeur
        public AjouteOffre(ViewModelOffre _ViewModel)
        {
            InitializeComponent();

            // Récupération du viewModel
            this._ViewModelOffre = _ViewModel;

            // intégration de la View au dataContext
            this.DataContext = _ViewModelOffre;


        }
        #endregion



        #region Evènements


        /// <summary>
        /// Evènements gérant la création d'une nouvelle offre
        /// </summary>
        private void ButtonAjouterOffre_Click(object sender, RoutedEventArgs e)
        {
            Offre offre = new Offre();
            // Vérifie que chaque champ est renseigné
            if (this.TextBoxIntituleAjoutOffre != null && this.ComboboxContrat.SelectedItem != null && this.ComboboxMetier.SelectedItem != null && this.ComboboxUtilisateur != null)
            {
                // vérifié que les dates sont valides et quelles ne sont pas inférieur à la date du jour
                if (this.DatePickerOffresDateDebutAjouter.SelectedDate != null && this.DatePickerOffresDateFinAjouter.SelectedDate != null && this.DatePickerOffresDateFinAjouter.SelectedDate > System.DateTime.Now && this.DatePickerOffresDateDebutAjouter.SelectedDate > System.DateTime.Now)
                {
                    // vérifie que la date de publication n'est pas supérieurs à la date de début du contrat
                    if (this.DatePickerOffresDateDebutAjouter.SelectedDate > this.DatePickerOffresDateFinAjouter.SelectedDate)
                    {
                        offre.Intitule = this.TextBoxIntituleAjoutOffre.Text;
                        offre.DateDebut = (DateTime)this.DatePickerOffresDateDebutAjouter.SelectedDate;
                        offre.DatePublication = (DateTime)this.DatePickerOffresDateFinAjouter.SelectedDate;
                        offre.Description = this.TextBoxDescription.Text;
                        offre.Duree = this.textBoxDureeAjoutOffre.Text;
                        offre.IsActive = false;
                        offre.Metier = ((Metier)this.ComboboxMetier.SelectedItem);
                        offre.TypeContrat = ((TypeContrat)this.ComboboxContrat.SelectedItem);
                        offre.Utilisateur = ((Utilisateur)this.ComboboxUtilisateur.SelectedItem);

                        // ajouter à la viewModel la nouvelle offre
                        _ViewModelOffre.offres.Add(offre);
                        _ViewModelOffre.Entities.Offres.Add(offre);

                        // Une fois que la viewModel est mise a jour on sauvegarde les modifications 
                        this._ViewModelOffre.Save();

                        // fermeture de la fenêtre
                        this.Close();
                    }
                    else { MessageBox.Show("La date de publication ne peut pas être plus récente que la date du contrat !");}
                }
                else
                {
                    MessageBox.Show("Veuillez saisir des dates valides !");
                }



            }
            else
            {

                MessageBox.Show("Veuillez saisir des données valides !");
            }
        }
        #endregion
    }
}
