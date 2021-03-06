﻿using System;
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
    /// Logique d'interaction pour PanelAbonnements.xaml
    /// </summary>
    public partial class PanelAbonnements : UserControl
    {

        #region Attributs
        protected ViewModelAbonnement viewModelAbonnement;
       
        #endregion



        #region Constructeurs
        public PanelAbonnements()
                {
                    InitializeComponent();

                    // Récupération du viewModel

                    this.viewModelAbonnement = new ViewModelAbonnement();           
                    // intégration de la View au dataContext
                    this.DataContext = viewModelAbonnement;
                    this.ButtonAbonnementsAjouter.Visibility = Visibility.Hidden;
                }
        #endregion
        



       #region Evènements

        /// <summary>
        /// Evenement d'actualisation des données sur le panel Abonnement lors d'un changement de selection sur la listeBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void ListBoxUtilisateurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
       {
           // Verification de la validité de la selection
           if(this.ListBoxUtilisateurs.SelectedItem != null)
           {
               //Vérification de la presence d'abonnement pour cet annonceur
               if (((Utilisateur)(this.ListBoxUtilisateurs.SelectedItem)).abonnements.Any())
               {
                   // Recherche du dernier abonnement en cours           
                   Abonnement abonnement = new Abonnement();
                   abonnement = ((Utilisateur)(this.ListBoxUtilisateurs.SelectedItem)).abonnements.Last();

                   // affichage des données
                   this.LabelAbonnementTypeAbonnement.Content = abonnement.typeabonnement.Libelle;
                   this.LabelAbonnementRestant.Content = abonnement.Restant.ToString();
                   this.LabelAbonnementDate.Content = abonnement.DateSouscription.ToString();


                   // Gestion de l'affichage du bouton d'ajout de crédit
                   if (abonnement.Restant > 0)
                   {

                       this.ButtonAbonnementsAjouter.Visibility = Visibility.Hidden;
                   }
                   else
                   {
                       this.ButtonAbonnementsAjouter.Visibility = Visibility.Visible;
                   }
               }
               else
               {
                   this.LabelAbonnementRestant.Content = "Aucun abonnement souscrit";
                   this.ButtonAbonnementsAjouter.Visibility = Visibility.Visible;
               }


           }

       }

        /// <summary>
        /// ouverture d'une fenetre pour l'achat d'un pack de diffusion par un annonceur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      private void ButtonAbonnementsAjouter_Click(object sender, RoutedEventArgs e)
       {
           Utilisateur annonceur = new Utilisateur();
           annonceur = (Utilisateur)(this.ListBoxUtilisateurs.SelectedItem);
           
           AjoutCredit ajoutCredit = new AjoutCredit(annonceur, viewModelAbonnement);
           ajoutCredit.ShowDialog();
           viewModelAbonnement = ajoutCredit.viewModelAbonnement;


         

           Abonnement abonnement = new Abonnement();
           abonnement = ((Utilisateur)(this.ListBoxUtilisateurs.SelectedItem)).abonnements.Last();

           // affichage des données
           this.LabelAbonnementTypeAbonnement.Content = abonnement.typeabonnement.Libelle;
           this.LabelAbonnementRestant.Content = abonnement.Restant.ToString();
           this.LabelAbonnementDate.Content = abonnement.DateSouscription.ToString();
 


       }
       #endregion

 
       


    }
}
