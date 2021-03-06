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
using System.Windows.Shapes;
using MegaCasting.DBLib;
using MegaCasting.WPF.ViewModel;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour GestionTypeCompetence.xaml
    /// </summary>
    public partial class GestionTypeCompetence : Window
    {

        #region Attributs
        protected ViewModelCompetence _ViewModel;
        #endregion

        #region Constructeurs
           public GestionTypeCompetence()
        {
            InitializeComponent();

            // Récupération de la ViewModel
            _ViewModel = new ViewModelCompetence();

            // intégrer la View au dataContext
            this.DataContext = _ViewModel;
        }

        #endregion

        #region Évènements
           
        /// <summary>
        /// Ouverture de la fenêtre ajoutTypeCompetence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtontypeCompetenceAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutTypeCompetence ajoutTypeCompetence = new AjoutTypeCompetence(_ViewModel);

            ajoutTypeCompetence.ShowDialog();
        }

        /// <summary>
        /// modifier une compétence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtontypeCompetenceModifier_Click(object sender, RoutedEventArgs e)
        {
            // récupère la saisie
            string saisieLibelle = this.TextboxNomAjoutTypeCompetence.Text;

            // On créer un type temporaire
            TypeCompetence type = new TypeCompetence();

            // On récupère la Compétence sélectionner dans la liste et on l'intègre au temporaire
            type = (TypeCompetence)(this.ListBoxTypeCompetences.SelectedItem);

            // Vérifie que la textBox n'est pas null et vérifie la sélection dans la liste
            if (this.TextboxNomAjoutTypeCompetence.Text != null && type != null)
            {
                // Modifier le type d'abonnement
                ((TypeCompetence)(this.ListBoxTypeCompetences.SelectedItem)).Libelle = this.TextboxNomAjoutTypeCompetence.Text;




                // Une fois que la viewModel est mise à jour on sauvegarde les modifications 
                this._ViewModel.Save();

                // Affiche un message confirmant la modification
                MessageBox.Show("Modification réussite !!!");


            }

            // si la saisie n'est pas valide apparition d'un message d'erreur
            else
            {
                MessageBox.Show("Saisie invalide !\r Modification impossible.");

            }

        }

        /// <summary>
        ///  Supprimer une compétence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtontypeCompetenceSupprimer_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce type de compétence ?", "Suppression d'un type de compétence", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    // On créer un type temporaire
                    TypeCompetence type = new TypeCompetence();

                    // On récupère la compétence sélectionner dans la liste
                    type = (TypeCompetence)(this.ListBoxTypeCompetences.SelectedItem);

                    // Vérifie qu'un type a été séléctionné dans la listeBox
                    if (type != null)
                    {

                        // Suppression 
                        _ViewModel.Entities.TypeCompetences.Remove(type);
                        _ViewModel.typeCompetences.Remove(type);

                        // Sauvegarder la suppression
                        this._ViewModel.Save();

                        MessageBox.Show("Suppression réussite !!!");
                    }
                    else
                    {
                        MessageBox.Show(" Saisie invalide !\r Veuillez sélectionner une Compétence à supprimer.");
                    }

                    break;
                case MessageBoxResult.No:

                    break;
                case MessageBoxResult.Cancel:

                    break;
            }



        }
           #endregion

    }
}
