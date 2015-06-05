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
using MegaCasting.WPF.ViewModel;
using System.Collections.ObjectModel;
using MegaCasting.WPF;
using MegaCasting.WPF.GestionWindows;
using MegaCasting.WPF.Ajout_Windows;
using MegaCasting.WPF.Functions;

namespace MegaCasting.WPF

{
    /// <summary>
    /// Logique d'interaction pour PanelArtistes.xaml
    /// </summary>
    public partial class PanelArtistes : UserControl
    {

        #region Attributs
        
        protected ViewModelUtilisateur viewModelUser;
        protected ViewModelDomaine_Metier viewModelMetierDomaine;
        
        public ObservableCollection<Metier> metierArtiste = new ObservableCollection<Metier>();
        public ObservableCollection<Domaine> DomaineArtiste = new ObservableCollection<Domaine>();
        Functions.Functions function = new Functions.Functions();
        #endregion

        #region Constructeurs

        public PanelArtistes()
        {
            InitializeComponent();
            viewModelUser = new ViewModelUtilisateur();
            // Récupération de la ViewModel
            
            // intégrer la View au dataContext
            this.DataContext = viewModelUser;

           
        }


        #endregion  

        #region Évènements

        /// <summary>
        /// Permet de gérer la mise en place des données dans les listBox Metier et domaine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxArtistes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModelMetierDomaine = new ViewModelDomaine_Metier();
            
            Utilisateur user = ((Utilisateur)this.ListBoxArtistes.SelectedItem);
            viewModelMetierDomaine.metierParArtiste(user);
            this.ListBoxMetiers.ItemsSource = viewModelMetierDomaine.metiersArtistes;

            DomaineArtiste = new ObservableCollection<Domaine>();
            // recherche tout les domaines associés aux métiers
            foreach (Metier metier in viewModelMetierDomaine.metiersArtistes)
            {
                // si le domaine est déja contenu dans la collection on ne le rajoute pas 
                if ( !DomaineArtiste.Contains(metier.domaine))
                {
                    DomaineArtiste.Add(metier.domaine);
                }
                
            }
            
            this.ListBoxDomaines.ItemsSource = DomaineArtiste;

            
        }

        /// <summary>
        /// ouverture d'une fenêtre de gestion des compétences d'un artiste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGestionCompetenceArtiste_Click(object sender, RoutedEventArgs e)
        {
            if (this.ListBoxArtistes.SelectedItem != null)
            {
                Utilisateur utilisateur = new Utilisateur();
                utilisateur = (Utilisateur)(this.ListBoxArtistes.SelectedItem);

                GestionCompetences gestionCompetence = new GestionCompetences(utilisateur);
                gestionCompetence.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez selectionné un artiste.");
            }
            
        }

        /// <summary>
        /// Ouverture d'une fenêtre de gestion des medias d'un artiste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMediaArtiste_Click(object sender, RoutedEventArgs e)
        {
            if (this.ListBoxArtistes.SelectedItem != null)
            {
                Utilisateur utilisateur = new Utilisateur();
                utilisateur = (Utilisateur)(this.ListBoxArtistes.SelectedItem);
                GestionMediaUtilisateur gestionMediaUtilisateur = new GestionMediaUtilisateur(utilisateur);
                gestionMediaUtilisateur.ShowDialog();
                
            }
            
        }

        /// <summary>
        /// Ouverture d'une fenêtre de gestion des expériences d'un artiste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExperiencesArtiste_Click(object sender, RoutedEventArgs e)
        {
            if (this.ListBoxArtistes.SelectedItem != null)
            {
                Utilisateur utilisateur = new Utilisateur();
                utilisateur = (Utilisateur)(this.ListBoxArtistes.SelectedItem);
                Gestion_Experiences gestionUtilisateur = new Gestion_Experiences(utilisateur);
                gestionUtilisateur.ShowDialog();

            }
        }
        
        /// <summary>
        /// Ajout d'un artiste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonArtisteAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutArtiste ajoutArtiste = new AjoutArtiste(viewModelUser);
            ajoutArtiste.ShowDialog();
        }
        /// <summary>
        /// Gérer les domaines de l'artiste sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModifierMetiersArtistes_Click(object sender, RoutedEventArgs e)
        {
            if (this.ListBoxArtistes.SelectedItem != null)
            {
                Utilisateur utilisateur = new Utilisateur();
                utilisateur = (Utilisateur)(this.ListBoxArtistes.SelectedItem);

                GestionMetierArtiste gestionMetierArtiste = new GestionMetierArtiste(utilisateur,viewModelUser);
                gestionMetierArtiste.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez selectionné un artiste.");
            }
        }
        #endregion

        private void ButtonArtisteModifier_Click(object sender, RoutedEventArgs e)
        {
           
                    if (this.TextBoxNomArtiste != null && this.TextBoxNomArtiste.Text != "" && this.TextBoxEmailArtiste != null && this.TextBoxEmailArtiste.Text != null && this.TextBoxTelephoneArtiste != null && this.TextBoxTelephoneArtiste.Text != null)
                    {
                        DateTime date = (DateTime)this.DatePickerDateNaissance.SelectedDate;
                        int age = function.CalculAge(date);
                        if (age > 18)
                        {
                            Adresse adresseArtiste = new Adresse();
                            ((Utilisateur)(this.ListBoxArtistes.SelectedItem)).Nom = this.TextBoxNomArtiste.Text;
                            ((Utilisateur)(this.ListBoxArtistes.SelectedItem)).Prenom = this.TextBoxPrenomArtiste.Text;
                            ((Utilisateur)(this.ListBoxArtistes.SelectedItem)).Telephone = this.TextBoxTelephoneArtiste.Text;
                            ((Utilisateur)(this.ListBoxArtistes.SelectedItem)).Email = this.TextBoxEmailArtiste.Text;
                            ((Utilisateur)(this.ListBoxArtistes.SelectedItem)).DateNaissance = date;
                            adresseArtiste.Rue = this.TextBoxRueArtiste.Text;
                            adresseArtiste.CodePostal = this.TextBoxCPArtiste.Text;
                            adresseArtiste.Ville = this.TextBoxVilleArtiste.Text;
                            adresseArtiste.Pays = this.TextBoxPaysArtiste.Text;
                            ((Utilisateur)(this.ListBoxArtistes.SelectedItem)).adresse = (Adresse)adresseArtiste;

                            // Une fois que la viewModel est mise à jour on sauvegarde les modifications

                            this.viewModelUser.Save();
                            MessageBox.Show("Modification réussite !!!");
                        }
                        else { MessageBox.Show("L'artiste doit être agé de 18 ans ou plus."); }
                    }


                    else { MessageBox.Show("L' artiste doit disposer au minimum de : \n - Un nom \n - Un numéro de téléphone \n - Un Email "); }
                   
        }
        private void ButtonArtisteSupprimer_Click(object sender, RoutedEventArgs e)
        { 
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet artiste ?", "Suppression d'un artiste", MessageBoxButton.YesNoCancel);
            switch (result)
            {
            case MessageBoxResult.Yes:
            Utilisateur artiste = new Utilisateur();

            // On récupère l'annonceur sélectionner dans la liste
            artiste = (Utilisateur)(this.ListBoxArtistes.SelectedItem);


            if (this.ListBoxArtistes.SelectedItem != null && artiste.competences.Count == 0 && artiste.historiques.Count == 0 && artiste.metiers.Count == 0 && artiste.offres.Count == 0 && artiste.multimedias.Count == 0 && artiste.abonnements.Count == 0)
            {
                
                viewModelUser.Entities.Utilisateurs.Remove((Utilisateur)this.ListBoxArtistes.SelectedItem);
                viewModelUser.artistes.Remove((Utilisateur)this.ListBoxArtistes.SelectedItem);
                viewModelUser.Save();
            }
            else { MessageBox.Show("Vous ne pouvez supprimer des artistes qui ont des champs associés."); }
            break;
            case MessageBoxResult.No:

            break;
            case MessageBoxResult.Cancel:

            break;
            }
        }
        

      

      

        

        
        

       

       

        


    }
}
