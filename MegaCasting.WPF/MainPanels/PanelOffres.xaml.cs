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
using System.Collections.ObjectModel;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour PanelOffres.xaml
    /// </summary>
    public partial class PanelOffres : UserControl
    {



        #region Attributs
        protected ViewModelOffre _ViewModelOffre;
      
        #endregion

        #region Constructeurs
        public PanelOffres()
        {
            InitializeComponent();
            this._ViewModelOffre = new ViewModelOffre();
            this.DataContext = _ViewModelOffre;
        }       
        #endregion

        #region Évènements


        #region Chargement de la listebox/Moteur de recherche

        /// <summary>
        /// Recherche : Recharge la listebox avec toutes les offres, sans tri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOffreReset_Click(object sender, RoutedEventArgs e)
        {
            this.ListBoxOffres.ItemsSource = _ViewModelOffre.offres;

        }

        /// <summary>
        /// Recherche : Recharge la listebox avec les offres selon l'annonceur selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxOffresAnnonceur_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ObservableCollection<Offre> offreParAnnonceur = new ObservableCollection<Offre>(_ViewModelOffre.offres.Where(offreTemp => offreTemp.Utilisateur == ((Utilisateur)(this.ComboBoxOffresAnnonceur.SelectedItem))));

            this.ListBoxOffres.ItemsSource = offreParAnnonceur;
        }

        /// <summary>
        /// Recherche : Recharge la listebox selon le domaine selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxOffresDomaine_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ObservableCollection<Offre> offreParDomaine = new ObservableCollection<Offre>(_ViewModelOffre.offres.Where(offreTemp => offreTemp.Metier.domaine == ((Domaine)(this.ComboBoxOffresDomaine.SelectedItem))));

            this.ListBoxOffres.ItemsSource = offreParDomaine;
        }

        /// <summary>
        /// Recherche : Recharge la listebox selon le metier selectionné dans la combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxOffresMetier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ObservableCollection<Offre> offreParMetier = new ObservableCollection<Offre>(_ViewModelOffre.offres.Where(offreTemp => offreTemp.Metier == ((Metier)(this.ComboBoxOffresMetier.SelectedItem))));

            this.ListBoxOffres.ItemsSource = offreParMetier;
        }

        /// <summary>
        /// Recherche : Recharge la listebox selon le type de contrat selectionné dans la combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxOffresTypeContrat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ObservableCollection<Offre> offreParTypeContrat = new ObservableCollection<Offre>(_ViewModelOffre.offres.Where(offreTemp => offreTemp.TypeContrat == ((TypeContrat)(this.ComboBoxOffresTypeContrat.SelectedItem))));

            this.ListBoxOffres.ItemsSource = offreParTypeContrat;
        }


        /// <summary>
        /// Evenement d'activation d'une offre, retirant un crédit à l'abonnement courant de l'annonceur de l'offre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxOffreIsActive_Checked(object sender, RoutedEventArgs e)
        {
            if (this.ListBoxOffres.SelectedItem != null)
            {
                Offre offre = new Offre();
                offre = ((Offre)this.ListBoxOffres.SelectedItem);
                Utilisateur annonceur = new Utilisateur();
                annonceur = (Utilisateur)offre.Utilisateur;
                Abonnement abo = new Abonnement();
                abo = (Abonnement)annonceur.abonnements.Last();
                if (annonceur.abonnements.Last() != null)
                {
                    if (abo.Restant == 0)
                    {
                        MessageBox.Show(" L'annonceur n'a plus de crédit de diffusion");
                        ((Offre)this.ListBoxOffres.SelectedItem).IsActive = false;


                    }
                    else
                    {

                        MessageBox.Show("L'annonceur " + ((Utilisateur)(this.ComboBoxOffresAnnonceurAjouter.SelectedItem)).Nom + " " + ((Utilisateur)(this.ComboBoxOffresAnnonceurAjouter.SelectedItem)).Prenom + " viens de dépenser un crédit.");
                        ((Abonnement)((Utilisateur)(this.ComboBoxOffresAnnonceurAjouter.SelectedItem)).abonnements.Last()).Restant = ((Abonnement)((Utilisateur)(this.ComboBoxOffresAnnonceurAjouter.SelectedItem)).abonnements.Last()).Restant - 1;
                        _ViewModelOffre.Save();
                        ((Offre)this.ListBoxOffres.SelectedItem).IsActive = true;


                    }
                }
                else
                {
                    MessageBox.Show("L'annonceur de l'offre doit d'abord acheter un pack de diffusion pour que son offre soit diffusée.");
                    ((Offre)this.ListBoxOffres.SelectedItem).IsActive = false;
                }
            }

        }

 
        #endregion


        #endregion
 

    }
}
