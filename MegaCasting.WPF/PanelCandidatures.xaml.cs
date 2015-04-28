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

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour PanelCandidatures.xaml
    /// </summary>
    public partial class PanelCandidatures : UserControl
    {

        protected ViewModelCandidature _ViewModelCandidatures;

        public PanelCandidatures()
        {
            InitializeComponent();
            // Instantiation du viewmodel
            this._ViewModelCandidatures = new ViewModelCandidature();

            // Attribution du contexte au panel
            this.DataContext = _ViewModelCandidatures;
        }

        /// <summary>
        /// Event de suppression d'une candidature sur le panel panelCandidatures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCandidatureSupprimer_Click(object sender, RoutedEventArgs e)
        {




            // Vérification de l'état de la candidature
            if (((Candidature)(this.ListBoxCandidatures.SelectedItem)) != null)
            {
                _ViewModelCandidatures.Entities.Candidatures.Remove((Candidature)(this.ListBoxCandidatures.SelectedItem));
                // Suppression de la liste
                _ViewModelCandidatures.candidatures.Remove((Candidature)(this.ListBoxCandidatures.SelectedItem));
                //Suppression dans l'entité
                

                // Sauvegarde des changements
                _ViewModelCandidatures.Save();

                MessageBox.Show("Suppression réussite !!!");
            }
            else
            {
                MessageBox.Show(" Veuillez sélectionner une candidature à supprimer.");
            }
        }
    }
}
