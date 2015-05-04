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
using MegaCasting.WPF.GestionWindows;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour GestionTypeMetierDomaine.xaml
    /// </summary>
    public partial class GestionTypeMetierDomaine : Window
    {

        #region Attributs
        protected ViewModelDomaine_Metier _ViewModel;

        #endregion

        #region Constructeurs
        public GestionTypeMetierDomaine()
        {
            InitializeComponent();


            // Récupération de la ViewModel
            _ViewModel = new ViewModelDomaine_Metier();

            // intégrer la View au dataContext
            this.DataContext = _ViewModel;


            


        }
        #endregion


        #region Évènements


        /// <summary>
        /// Supprimer un domaine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDomaineSupprimer_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce domaine ?", "Suppression d'un domaine", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    // On créer un domaine temporaire
                    Domaine domaine = new Domaine();

                    // On récupère le domaine sélectionner dans la liste
                    domaine = (Domaine)(this.ListBoxDomaines.SelectedItem);

                    // Vérifie qu'un domaine a été séléctionné dans la listeBox
                    if (domaine != null)
                    {

                        // Suppression 
                        _ViewModel.Entities.Domaines.Remove(domaine);
                        _ViewModel.domaines.Remove(domaine);

                        // Sauvegarder la suppression
                        this._ViewModel.Save();

                        MessageBox.Show("Suppression réussite !!!");
                    }
                    else
                    {
                        MessageBox.Show(" Saisie invalide !\r Veuillez sélectionner un Domaine à supprimer.");
                    }

                    break;
                case MessageBoxResult.No:

                    break;
                case MessageBoxResult.Cancel:

                    break;
            }


        }

        /// <summary>
        /// Enregistrer les modification d'un domaine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDomaineModifier_Click(object sender, RoutedEventArgs e)
        {

            // On créer un domaine temporaire
            Domaine domaine = new Domaine();

            // On récupère le domaine sélectionner dans la liste et on l'intègre au temporaire
            domaine = (Domaine)(this.ListBoxDomaines.SelectedItem);

            // Vérifie que la textBox n'est pas null et vérifie la sélection dans la liste
            if (this.TextBoxNomDomaine.Text != null && domaine != null)
            {
                // Modifier le type de domaine
                ((Domaine)(this.ListBoxDomaines.SelectedItem)).Libelle = this.TextBoxNomDomaine.Text;


                // Une fois que la viewModel est mise à jour on sauvegarde les modifications 
                this._ViewModel.Save();

                // Affiche un message confirmant la modification
                MessageBox.Show("Modification réussite !!!");

            }
            else
            {
                MessageBox.Show("Saisie invalide !\r Modification impossible.");

            }
        }

        /// <summary>
        /// Ouverture d'une fenêtre d'ajout de domaine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDomaineAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutDomaine ajoutDomaine = new AjoutDomaine(_ViewModel);
            ajoutDomaine.ShowDialog();
        }

        /// <summary>
        /// Sauvegarde des modification d'un metier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMetierModifier_Click(object sender, RoutedEventArgs e)
        {
            // récupère la saisie
            string saisieLibelle = this.TextboxNomMetier.Text;

            string saisieDescription = this.TextboxDescriptionMetier.Text;

            Domaine domaine = ((Domaine)(this.comboBoxDomaine.SelectedItem));



            // On créer un metier temporaire
            Metier metier = new Metier();

            // On récupère le metier sélectionner dans la liste et on l'intègre au temporaire
            metier = (Metier)(this.ListBoxTypeMetier.SelectedItem);

            // Vérifie que la textBox n'est pas null et vérifie la sélection dans la liste
            if (saisieLibelle != null)
            {
                // Modifier le type d'abonnement
                ((Metier)(this.ListBoxTypeMetier.SelectedItem)).Libelle = saisieLibelle;
                ((Metier)(this.ListBoxTypeMetier.SelectedItem)).Description = saisieDescription;
                ((Metier)(this.ListBoxTypeMetier.SelectedItem)).domaine = domaine;




                // Une fois que la viewModel est mise à jour on sauvegarde les modifications 
                this._ViewModel.Save();

                // Affiche un message confirmant la modification
                MessageBox.Show("Modification réussite !!!");

            }
            else
            {
                MessageBox.Show("Saisie invalide !\r Modification impossible.");

            }
        }

        /// <summary>
        /// Suppression d'un metier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMetierSupprimer_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce métier ?", "Suppression d'un métier", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    // On créer un métier temporaire
                    Metier metier = new Metier();

                    // On récupère le métier sélectionner dans la liste
                    metier = (Metier)(this.ListBoxTypeMetier.SelectedItem);

                    // Vérifie qu'un métier a été séléctionné dans la listeBox
                    if (metier != null)
                    {

                        // Suppression 
                        _ViewModel.Entities.Metiers.Remove(metier);
                        _ViewModel.metiers.Remove(metier);

                        // Sauvegarder la suppression
                        this._ViewModel.Save();

                        MessageBox.Show("Suppression réussite !!!");
                    }
                    else
                    {
                        MessageBox.Show(" Saisie invalide !\r Veuillez sélectionner un métier à supprimer.");
                    }

                    break;
                case MessageBoxResult.No:

                    break;
                case MessageBoxResult.Cancel:

                    break;
            }


        }

        /// <summary>
        /// Ouverture d'une fenêtre d'ajout de metier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMetierAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutMetier ajoutMetier = new AjoutMetier(_ViewModel);
            ajoutMetier.ShowDialog();
        }
        #endregion

    }
}
