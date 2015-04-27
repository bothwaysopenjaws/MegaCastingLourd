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
using MegaCasting.WPF.GestionWindows;
using MegaCasting.DBLib;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour GestionTypeContrat.xaml
    /// </summary>
    public partial class GestionTypeContrat : Window
    {
        protected ViewModelOffre _ViewModel;

        public GestionTypeContrat()
        {
            InitializeComponent();

            // Récupération de la ViewModel
            _ViewModel = new ViewModelOffre();

            // intégrer la View au dataContext
            this.DataContext = _ViewModel;
        }

        private void ButtonContratAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutTypeContrat typeContrat = new AjoutTypeContrat(_ViewModel);
            typeContrat.ShowDialog();
        }

        private void ButtonContratSupprimer_Click(object sender, RoutedEventArgs e)
        {
            // On créer un type temporaire
            TypeContrat type = new TypeContrat();

            // On récupère le type sélectionner dans la liste
            type = (TypeContrat)(this.ListBoxTypeContrats.SelectedItem);

            // Vérifie qu'un type a été séléctionné dans la listeBox
            if (type != null)
            {

                // Suppression 
                _ViewModel.Entities.TypeContrats.Remove(type);
                _ViewModel.TypeContrats.Remove(type);

                // Sauvegarder la suppression
                this._ViewModel.Save();

                MessageBox.Show("Suppression réussite !!!");
            }
            else
            {
                MessageBox.Show(" Saisie invalide !\r Veuillez sélectionner un type de contrat à supprimer.");
            }
        }

        private void ButtonContratModifier_Click(object sender, RoutedEventArgs e)
        {
            string saisieNom = this.TextboxNomAjoutContrat.Text;

            // On créer un type temporaire
            TypeContrat type = new TypeContrat();

            // On récupère le type sélectionner dans la liste et on l'intègre au temporaire
            type = (TypeContrat)(this.ListBoxTypeContrats.SelectedItem);

            // Vérifie que la saisie n'est pas null 
            if (saisieNom != null && saisieNom != "")
            {
                // Modifier le type
                ((TypeContrat)(this.ListBoxTypeContrats.SelectedItem)).Libelle = this.TextboxNomAjoutContrat.Text;
                

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
    }
}
