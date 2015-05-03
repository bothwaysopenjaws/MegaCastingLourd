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

namespace MegaCasting.WPF

{
    /// <summary>
    /// Logique d'interaction pour PanelArtistes.xaml
    /// </summary>
    public partial class PanelArtistes : UserControl
    {

        #region Attributs
        protected ViewModelDomaine_Metier _ViewModelMetierDomaine;
        public ObservableCollection<Metier> metierArtiste = new ObservableCollection<Metier>();
        public ObservableCollection<Domaine> DomaineArtiste = new ObservableCollection<Domaine>();
        #endregion

        #region Constructeurs

        public PanelArtistes()
        {
            InitializeComponent();
            _ViewModelMetierDomaine = new ViewModelDomaine_Metier();
            // Récupération de la ViewModel
            
            // intégrer la View au dataContext
            this.DataContext = _ViewModelMetierDomaine;

           
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
            // Récupère tout les métiers assorti à l'artiste sélectionné
            metierArtiste = new ObservableCollection<Metier>(((Utilisateur)this.ListBoxArtistes.SelectedItem).metiers);
            this.ListBoxMetiers.ItemsSource = metierArtiste;

            DomaineArtiste = new ObservableCollection<Domaine>();
            // recherche tout les domaines associés aux métiers
            foreach (Metier metier in metierArtiste)
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


        #endregion


    }
}
