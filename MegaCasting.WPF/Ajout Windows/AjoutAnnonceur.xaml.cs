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
using System.Collections.ObjectModel;

namespace MegaCasting.WPF.Ajout_Windows
{
    /// <summary>
    /// Logique d'interaction pour AjoutAnnonceur.xaml
    /// </summary>
    public partial class AjoutAnnonceur : Window
    {
        #region Attributs
        protected ViewModelUtilisateur _ViewModelUtilisateur;
        #endregion

        #region Constructeur
        public AjoutAnnonceur(ViewModelUtilisateur _ViewModel)
        {
            InitializeComponent();
            // instancie la  viewModel
            _ViewModelUtilisateur = new ViewModelUtilisateur();
           
            _ViewModelUtilisateur = _ViewModel;

            this.DataContext = _ViewModelUtilisateur;
        
        }
        #endregion

        #region Evènements
        private void ButtonAjouterAnnonceur_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur annonceur = new Utilisateur();
            Adresse adresseAnnonceur = new Adresse();

            ObservableCollection<TypeUtilisateur> type = _ViewModelUtilisateur.typeUtilisateurs;
            TypeUtilisateur typeTemp = new TypeUtilisateur();

            if (this.TextBoxNomAjoutAnnonceur.Text != null && this.TextBoxEmailAjoutAnnonceur.Text != null && this.TextBoxTelAjoutAnnonceur.Text != null && this.TextBoxNomAjoutAnnonceur.Text != "" && this.TextBoxEmailAjoutAnnonceur.Text != "" && this.TextBoxTelAjoutAnnonceur.Text != "")
            {
            annonceur.Nom = this.TextBoxNomAjoutAnnonceur.Text;
            annonceur.Prenom = this.TextBoxPrenomAjoutAnnonceur.Text;
            annonceur.Email = this.TextBoxEmailAjoutAnnonceur.Text;
            annonceur.Telephone = this.TextBoxTelAjoutAnnonceur.Text;
            adresseAnnonceur.Rue = this.TextBoxRueAjoutAnnonceur.Text;
            adresseAnnonceur.CodePostal =this.TextBoxCPAjoutAnnonceur.Text;
            adresseAnnonceur.Ville =  this.TextBoxVilleAjoutAnnonceur.Text;
            adresseAnnonceur.Pays = this.textBoxPaysAjoutAnnonceur.Text;
            annonceur.adresse = (Adresse)adresseAnnonceur;
            annonceur.Login = annonceur.Nom + "login";
            annonceur.Password = annonceur.Nom + "Password";


            // retrouve le type d'utilisateur associé aux annonceurs
            foreach (TypeUtilisateur typeUtilisateur in type)
            {

                if (typeUtilisateur.Libelle.Contains("Annonceur"))
                {
                    annonceur.typeutilisateur = (TypeUtilisateur)typeUtilisateur;
                }

            }

            _ViewModelUtilisateur.annonceurs.Add(annonceur);
            _ViewModelUtilisateur.Entities.Utilisateurs.Add(annonceur);

            _ViewModelUtilisateur.Save();
            this.Close();
            }
            else { MessageBox.Show("veuillez saisir au minimum :\r\n - Un nom\n - Un numéro de téléphone \n - Une adresse mail."); }
        }
        #endregion
    }
}
