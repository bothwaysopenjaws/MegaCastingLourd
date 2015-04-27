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

namespace MegaCasting.WPF.GestionWindows
{
    /// <summary>
    /// Logique d'interaction pour AjoutMetier.xaml
    /// </summary>
    public partial class AjoutMetier : Window
    {
        protected ViewModelDomaine_Metier _ViewModelMetier;

        public AjoutMetier(ViewModelDomaine_Metier _ViewModel)
        {
            InitializeComponent();
            // Intégration de la ViewModel récupérer avec celle de cette fenêtre
            _ViewModelMetier = _ViewModel;

            // intégrer la View au dataContext
            this.DataContext = _ViewModelMetier;

            this.comboBoxMetier.ItemsSource = _ViewModel.domaines;
        }

        private void ButtonAjoutMetier_Click(object sender, RoutedEventArgs e)
        {

            string nom = this.TextBoxNomMetier.Text;
            string description = this.TextboxDescriptionMetier.Text;
            Domaine domaine = new Domaine();
            domaine = (Domaine)(this.comboBoxMetier.SelectedItem);

            if (this.TextBoxNomMetier.Text != null && this.TextboxDescriptionMetier.Text != "")
            {
                Metier metier = new Metier();
                metier.Libelle = nom;
                metier.Description = description;
                metier.domaine = domaine;


                // ajouter à la viewModel 
                _ViewModelMetier.metiers.Add(metier);
                _ViewModelMetier.Entities.Metiers.Add(metier);

                // Une fois que la viewModel est mise a jour on sauvegarde les modifications 
                this._ViewModelMetier.Save();

                this.Close();
            }
            else
            {
                MessageBox.Show("Saisie invalide !\r veuillez saisir des données correcte.");
                this.TextBoxNomMetier.Clear();
                this.TextboxDescriptionMetier.Clear();
                
            }

        }
    }
}
