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
using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;
using MegaCasting.WPF.Ajout_Windows;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour PanelAnnonceurs.xaml
    /// </summary>
    public partial class PanelAnnonceurs : UserControl
    {

        #region Attributs

        ViewModelUtilisateur _ViewModelUtilisateur;
        Functions.Functions function = new Functions.Functions();
        #endregion

        #region Constructeurs
        public PanelAnnonceurs()
        {
            InitializeComponent();
            _ViewModelUtilisateur = new ViewModelUtilisateur();

            this.DataContext = _ViewModelUtilisateur;

        }

        #endregion

        #region Évènements



        /// <summary>
        /// Supprimer un annonceur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnnonceurSupprimer_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet annonceur ?", "Suppression d'un annonceur", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    // On créer un anonceur temporaire
                    Utilisateur annonceur = new Utilisateur();

                    // On récupère l'annonceur sélectionner dans la liste
                    annonceur = (Utilisateur)(this.ListBoxAnnonceurs.SelectedItem);

                    // Vérifie qu'un annonceur a été séléctionné dans la listeBox
                    if (annonceur != null)
                    {

                        // reste a gérer la suppression des offres lié a l'annonceur

                        // Suppression 
                        _ViewModelUtilisateur.annonceurs.Remove(annonceur);
                        _ViewModelUtilisateur.Entities.Utilisateurs.Remove(annonceur);


                        // Sauvegarder la suppression
                        this._ViewModelUtilisateur.Save();

                        MessageBox.Show("Suppression réussie ! ");
                    }
                    else
                    {
                        MessageBox.Show(" Saisie invalide !\r Veuillez sélectionner un annonceur à supprimer.");
                    }
                    break;
                case MessageBoxResult.No:

                    break;
                case MessageBoxResult.Cancel:

                    break;
            }
        }

        /// <summary>
        /// Modifier un annonceur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnnoceurModifier_Click(object sender, RoutedEventArgs e)
        {
            if (this.textBoxNomAnnonceur != null && this.textBoxNomAnnonceur.Text != "" && this.textBoxEmailAnnonceur != null && this.textBoxEmailAnnonceur.Text != null && this.textBoxTelephoneAnnonceur != null && this.textBoxTelephoneAnnonceur.Text != null)
            {
                DateTime date = (DateTime)this.DatePickerDateNaissance.SelectedDate;
                int age = function.CalculAge(date);
                if (age > 18)
                {
                    Adresse adresseAnnonceur = new Adresse();
                    ((Utilisateur)(this.ListBoxAnnonceurs.SelectedItem)).Nom = this.textBoxNomAnnonceur.Text;
                    ((Utilisateur)(this.ListBoxAnnonceurs.SelectedItem)).Prenom = this.textBoxPrenomAnnonceur.Text;
                    ((Utilisateur)(this.ListBoxAnnonceurs.SelectedItem)).Telephone = this.textBoxTelephoneAnnonceur.Text;
                    ((Utilisateur)(this.ListBoxAnnonceurs.SelectedItem)).Email = this.textBoxEmailAnnonceur.Text;
                    ((Utilisateur)(this.ListBoxAnnonceurs.SelectedItem)).DateNaissance = date;
                    adresseAnnonceur.Rue = this.textBoxRueAnnonceur.Text;
                    adresseAnnonceur.CodePostal = this.textBoxCodePostalAnnonceur.Text;
                    adresseAnnonceur.Ville = this.textBoxVilleAnnonceur.Text;
                    adresseAnnonceur.Pays = this.textBoxPaysAnnonceur.Text;
                    ((Utilisateur)(this.ListBoxAnnonceurs.SelectedItem)).adresse = (Adresse)adresseAnnonceur;


                    // Une fois que la viewModel est mise à jour on sauvegarde les modifications 
                    this._ViewModelUtilisateur.Save();
                    MessageBox.Show("Modification réussite !!!");
                }
                else { MessageBox.Show("L'annonceur doit être agé de 18 ans ou plus."); }
            }


            else { MessageBox.Show("L' annonceur doit disposer au minimum de : \n - Un nom \n - Un numéro de téléphone \n - Un Email "); }
        }

        /// <summary>
        /// Ajouter un annonceur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnnonceurAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutAnnonceur annnonceur = new AjoutAnnonceur(_ViewModelUtilisateur);
            annnonceur.ShowDialog();
        }
        #endregion






    }
}
