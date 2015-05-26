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
using MegaCasting.WPF.GestionWindows;
using MegaCasting.WPF.ViewModel;
using MegaCasting.WPF.Functions;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour PanelPartenaires.xaml
    /// </summary>
    public partial class PanelPartenaires : UserControl
    {

        #region Attributs
        ViewModelUtilisateur _ViewModelUtilisateur;
        Functions.Functions function = new Functions.Functions();


        #endregion

        #region Constructeurs
        public PanelPartenaires()
        {
            InitializeComponent();
            _ViewModelUtilisateur = new ViewModelUtilisateur();
            this.DataContext = _ViewModelUtilisateur;
        }


        #endregion

        #region Évènements


        /// <summary>
        /// Ouverture d'une fenêtre d'ajout de partenaire de diffusion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPartenaireAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutPartenaire nouveauPartenaire = new AjoutPartenaire(_ViewModelUtilisateur);
            nouveauPartenaire.ShowDialog();
        }


        /// <summary>
        /// Suppression d'un partenaire de diffusion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPartenaireSupprimer_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce partenaire ?", "Suppression d'un partenaire", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    // On créer un Partenaire temporaire
                    Utilisateur partenaire = new Utilisateur();

                    // On récupère le partenaire sélectionner dans la liste
                    partenaire = (Utilisateur)(this.ListBoxPartenaires.SelectedItem);

                    // Vérifie qu'un type a été séléctionné dans la listeBox
                    if (partenaire != null)
                    {

                        // reste a gérer la suppression des offres lié au partenaire

                        // Suppression 
                        _ViewModelUtilisateur.diffuseurs.Remove(partenaire);
                        _ViewModelUtilisateur.Entities.Utilisateurs.Remove(partenaire);


                        // Sauvegarder la suppression
                        this._ViewModelUtilisateur.Save();

                        MessageBox.Show("Suppression réussite !!!");
                    }
                    else
                    {
                        MessageBox.Show(" Saisie invalide !\r Veuillez sélectionner un partenaire à supprimer.");
                    }

                    break;
                case MessageBoxResult.No:

                    break;
                case MessageBoxResult.Cancel:

                    break;
            }
        }


        /// <summary>
        /// Sauvegarde des modification sur les partenaires de diffusion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPartenaireModifier_Click(object sender, RoutedEventArgs e)
        {

            // Vérifie que la saisie n'est pas null que le pa est bien en chiffre et que un Abonnment à été sélectionner dans la liste
            if (this.TextBoxPartenaireNom.Text != null && this.TextBoxPartenairePrenom != null)
            {
                DateTime date = (DateTime)this.DatePickerDateNaissance.SelectedDate;
                int age = function.CalculAge(date);
                if (age > 18)
                {
                    //Modifier le partenaire
                    ((Utilisateur)(this.ListBoxPartenaires.SelectedItem)).DateNaissance = date; 
                    ((Utilisateur)(this.ListBoxPartenaires.SelectedItem)).Nom = this.TextBoxPartenaireNom.Text;
                    ((Utilisateur)(this.ListBoxPartenaires.SelectedItem)).Prenom = this.TextBoxPartenairePrenom.Text;
                    ((Utilisateur)(this.ListBoxPartenaires.SelectedItem)).Telephone = this.TextBoxPartenaireNumTel.Text;
                    ((Utilisateur)(this.ListBoxPartenaires.SelectedItem)).Email = this.TextBoxPartenaireEmail.Text;
                    ((Utilisateur)(this.ListBoxPartenaires.SelectedItem)).adresse.Rue = this.TextBoxPartenaireRue.Text;
                    ((Utilisateur)(this.ListBoxPartenaires.SelectedItem)).adresse.CodePostal = this.TextBoxPartenaireCodePostal.Text;
                    ((Utilisateur)(this.ListBoxPartenaires.SelectedItem)).adresse.Ville = this.TextBoxPartenaireCity.Text;
                    ((Utilisateur)(this.ListBoxPartenaires.SelectedItem)).adresse.Pays = this.TextBoxPartenairePays.Text;

                    // Une fois que la viewModel est mise à jour on sauvegarde les modifications 
                    this._ViewModelUtilisateur.Save();
                    MessageBox.Show("Modification réussite !!!");

                }
                else { MessageBox.Show("Le partenaire doit être agé de 18 ans ou plus."); }

                // si la saisie n'est pas valide apparition d'un message d'erreur
            }
            else
            {
                MessageBox.Show("Saisie invalide !\r Modification impossible.");

            }



        }

        #endregion

    }
}
