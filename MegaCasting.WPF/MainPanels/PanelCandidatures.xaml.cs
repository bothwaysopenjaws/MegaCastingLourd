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
using System.Windows.Forms;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour PanelCandidatures.xaml
    /// </summary>
    public partial class PanelCandidatures : System.Windows.Controls.UserControl
    {



        #region Attributs
            protected ViewModelCandidature _ViewModelCandidatures;


        #endregion

        #region Constructeurs
            
        public PanelCandidatures()
        {
            InitializeComponent();
            // Instantiation du viewmodel
            this._ViewModelCandidatures = new ViewModelCandidature();

            // Attribution du contexte au panel
            this.DataContext = _ViewModelCandidatures;

        }


        #endregion

        #region Évènements

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

                System.Windows.MessageBox.Show("Suppression réussite !!!");
            }
            else
            {
                System.Windows.MessageBox.Show(" Veuillez sélectionner une candidature à supprimer.");
            }
        }


        


        /// <summary>
        /// Ajouter ou modifier l'URL d'un cv d'une candidature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCandidatureUrlCV_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "d:\\MegaGestion\\Cv et motivation";
            openFileDialog.Filter = "Pdf Files|*.pdf";
            openFileDialog.ShowDialog();
            if ((openFileDialog.FileName != null) && (this.ListBoxCandidatures.SelectedItem != null))
            {
                this.TextBoxCandidatureUrlCV.Content = openFileDialog.FileName;
                _ViewModelCandidatures.candidatures.Where(candidatureTemp => candidatureTemp.Identifiant == ((Candidature)this.ListBoxCandidatures.SelectedItem).Identifiant).First().UrlCv = openFileDialog.FileName;
                _ViewModelCandidatures.Save();

            }
            
        }



        /// <summary>
        /// Ajouter ou modifier l'url d'une candidature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxCandidatureUrlLettreMotivation_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "d:\\MegaGestion\\Cv et motivation";
            openFileDialog.Filter = "Pdf Files|*.pdf";
            openFileDialog.ShowDialog();
            if ((openFileDialog.FileName != null) && (this.ListBoxCandidatures.SelectedItem != null))
            {
                this.TextBoxCandidatureUrlLettreMotivation.Content = openFileDialog.FileName;
                _ViewModelCandidatures.candidatures.Where(candidatureTemp => candidatureTemp.Identifiant == ((Candidature)this.ListBoxCandidatures.SelectedItem).Identifiant).First().UrlLettreMotivation = openFileDialog.FileName;
                _ViewModelCandidatures.Entities.SaveChanges();
                _ViewModelCandidatures.Save();
            }
        }

        #endregion
    }
}
