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
        protected ViewModelAbonnement _ViewModel;

        public GestionTypeAbonnement()
        {
            InitializeComponent();

            // Récupération de la ViewModel
            _ViewModel = new ViewModelAbonnement();

            // intégrer la View au dataContext
            this.DataContext = _ViewModel;
        }

        // Ajouter un type Abonnement
        private void ButtoTypeAbonnementAjouter_Click(object sender, RoutedEventArgs e)
        {
            // créer la fenêtre permettant l'ajout en passant en paramètre La viewModel
            AjoutTypeAbonnement ajout = new AjoutTypeAbonnement(_ViewModel);

            // Ouverture sans possibilité de naviguer sur les autres fenêtres
            ajout.ShowDialog();
        }

        // Supprimer un type d'abonnement
        private void ButtonTypeAbonnementSupprimer_Click(object sender, RoutedEventArgs e)
        {
            // On créer un type temporaire
            TypeAbonnement type = new TypeAbonnement();

            // On récupère l'abonnement sélectionner dans la liste
            type = (TypeAbonnement)(this.ListBoxAbonnements.SelectedItem);

            // Vérifie qu'un type a été séléctionné dans la listeBox
            if (type != null)
            {

                // Suppression 
                _ViewModel.Entities.TypeAbonnements.Remove(type);
                _ViewModel.TypeAbonnements.Remove(type);

                // Sauvegarder la suppression
                this._ViewModel.Save();

                MessageBox.Show("Suppression réussite !!!");
            }
            else
            {
                MessageBox.Show(" Saisie invalide !\r Veuillez sélectionner un abonnement à supprimer.");
            }
        }

        // modifier un type d'abonnement
        private void ButtonTypeAbonnementModifier_Click(object sender, RoutedEventArgs e)
        {
            string saisieOffre = this.TextBoxNombreOffreTypeAbonnement.Text;

            // On créer un type temporaire
            TypeAbonnement type = new TypeAbonnement();

            // On récupère l'abonnement sélectionner dans la liste et on l'intègre au temporaire
            type = (TypeAbonnement)(this.ListBoxAbonnements.SelectedItem);

            // Vérifie que la saisie n'est pas null que l'offre est bien en chiffre et que un Abonnment à été sélectionner dans la liste
            if (this.TextBoxNombreOffreTypeAbonnement.Text != null && IsInteger(saisieOffre) == true && type != null)
            {
                // Modifier le type d'abonnement
                ((TypeAbonnement)(this.ListBoxAbonnements.SelectedItem)).Libelle = this.TextBoxNomTypeAbonnement.Text;
                ((TypeAbonnement)(this.ListBoxAbonnements.SelectedItem)).NombreOffres = int.Parse(saisieOffre);
                
                

                // Une fois que la viewModel est mise à jour on sauvegarde les modifications 
                this._ViewModel.Save();
                MessageBox.Show("Modification réussite !!!");
         
            }

            // si la saisie n'est pas valide apparition d'un message d'erreur
            else
            {
                MessageBox.Show("Saisie invalide !\r Modification impossible.");
                
            }



        }

        // Permet de vérifier si la saisie est un int
        public bool IsInteger(string text)
        {
            //Le mot clé uint désigne un type int
            uint value;
            return uint.TryParse(text, out value);
        }
    }
}
