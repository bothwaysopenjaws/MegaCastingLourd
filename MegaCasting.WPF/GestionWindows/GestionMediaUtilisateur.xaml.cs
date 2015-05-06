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
using MegaCasting.WPF.Ajout_Windows;
using MegaCasting.DBLib;
using MegaCasting.WPF.ViewModel;
using System.Windows.Forms;

namespace MegaCasting.WPF.GestionWindows
{
    /// <summary>
    /// Logique d'interaction pour GestionMediaUtilisateur.xaml
    /// </summary>
    public partial class GestionMediaUtilisateur : Window
    {
        #region Attributs
        public ViewModelMedia viewModelMedia;
        public Utilisateur utilisateur;
        #endregion



        #region Constructeur
        public GestionMediaUtilisateur(Utilisateur utilisateurPanel)
        {
            utilisateur = utilisateurPanel;
            InitializeComponent();
            viewModelMedia = new ViewModelMedia();
            viewModelMedia.multimediasParArtiste(utilisateurPanel);
            this.DataContext = viewModelMedia;
        }
        #endregion



        #region Evenement
        /// <summary>
        /// Ajouter un média à un artiste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAjouterMedia_Click(object sender, RoutedEventArgs e)
        {
            // Ouverture d'une fenêtre de recherche de fichier
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "d:\\MegaGestion\\multimedia";

            openFileDialog.ShowDialog();

            // Verifications
            if ((openFileDialog.FileName != null) && (utilisateur != null))
            {
                // Instanciation
                Multimedia multimedia = new Multimedia();
                multimedia.Url = openFileDialog.FileName;
                //Découpage de l'url pour récupéré le nom du fichier
                string[] separateur = new string[] {"\\"};
                string[] resultat = openFileDialog.FileName.Split(separateur, StringSplitOptions.None);
                multimedia.Nom = resultat.Last();


                multimedia.typemedia = viewModelMedia.Entities.TypeMedias.First();
                viewModelMedia.Entities.Utilisateurs.Where(utilisateurTemp => utilisateurTemp.Identifiant == utilisateur.Identifiant).First().multimedias.Add(multimedia);
                multimedia.utilisateur = viewModelMedia.Entities.Utilisateurs.Where(utilisateurTemp => utilisateurTemp.Identifiant == utilisateur.Identifiant).First();
                //push sur la base de données
                
                viewModelMedia.multimediasArtiste.Add(multimedia);
                viewModelMedia.Save();
                
            }
            
        }



        /// <summary>
        /// Suppression d'un media d'un artiste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSupprimerMedia_Click(object sender, RoutedEventArgs e)
        {
            if (this.ListBoxMediaArtiste.SelectedItem != null)
            {
                // Suppression 
                viewModelMedia.Entities.Multimedias.Remove((Multimedia)this.ListBoxMediaArtiste.SelectedItem);
                viewModelMedia.multimediasArtiste.Remove((Multimedia)this.ListBoxMediaArtiste.SelectedItem);
                viewModelMedia.Save();
            }
        }
        #endregion

        
    }

}
