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
using System.Collections.ObjectModel;
using MegaCasting.WPF.Functions;


namespace MegaCasting.WPF.GestionWindows
{
    /// <summary>
    /// Logique d'interaction pour AjoutPartenaire.xaml
    /// </summary>
    public partial class AjoutPartenaire : Window
    {
        #region Attributs
        ViewModelUtilisateur _ViewModelUtilisateur;
        Functions.Functions function = new Functions.Functions();
        #endregion

        #region Constructeur
        public AjoutPartenaire(ViewModelUtilisateur _ViewModel)
        {
            InitializeComponent();

            // Récupération du viewModel
            this._ViewModelUtilisateur = new ViewModelUtilisateur();

            _ViewModelUtilisateur = _ViewModel;
            // intégration de la View au dataContext
            this.DataContext = _ViewModelUtilisateur;
        }
        #endregion


        /// <summary>
        /// Ajout d'un partenaire dans la base de donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Evènements
        private void ButtonAjouterPartenaire_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur partenaire = new Utilisateur();
            Adresse adressePartenaire = new Adresse();

            ObservableCollection<TypeUtilisateur> type = _ViewModelUtilisateur.typeUtilisateurs;
            TypeUtilisateur typeTemp = new TypeUtilisateur();

            if (this.TextBoxNomAjoutPartenaire.Text != null && this.TextBoxEmailAjoutPartenaire.Text != null && this.TextBoxTelAjoutPartenaire.Text != null && this.TextBoxNomAjoutPartenaire.Text != "" && this.TextBoxEmailAjoutPartenaire.Text != "" && this.TextBoxTelAjoutPartenaire.Text != "" && this.DatePickerNaissancePartenaire.SelectedDate != null)
            {
                 DateTime dateNaissance = (DateTime)this.DatePickerNaissancePartenaire.SelectedDate;

                int age = function.CalculAge(dateNaissance);

                if (age > 18)
                {
                partenaire.Nom = this.TextBoxNomAjoutPartenaire.Text;
                partenaire.Prenom = this.TextBoxPrenomAjoutPartenaire.Text;
                partenaire.Email = this.TextBoxEmailAjoutPartenaire.Text;
                partenaire.email_canonical = partenaire.Email;
                partenaire.DateNaissance = dateNaissance;
                partenaire.Telephone = this.TextBoxTelAjoutPartenaire.Text;
                adressePartenaire.Rue = this.TextBoxRueAjoutPartenaire.Text;
                adressePartenaire.CodePostal = this.TextBoxCPAjoutPartenaire.Text;
                adressePartenaire.Ville = this.TextBoxVilleAjoutPartenaire.Text;
                adressePartenaire.Pays = this.textBoxPaysAjoutPartenaire.Text;
                partenaire.adresse = (Adresse)adressePartenaire;
                partenaire.username = partenaire.Nom + partenaire.Prenom;
                partenaire.username_canonical = partenaire.username;
                var saltByte = function.CreateSaltByte();
                partenaire.salt = function.SaltByteToString(saltByte);
                partenaire.Password = SimpleHash.ComputeHash(partenaire.Nom + partenaire.Prenom, "SHA512", saltByte);
                    
                partenaire.enabled = true;
                partenaire.locked = false;
                partenaire.expired = false;
                partenaire.roles = "a:0:{}";
                partenaire.credentials_expired = false;

                // retrouve le type d'utilisateur associé aux partenaires
                foreach (TypeUtilisateur typeUtilisateur in type)
                {

                    if (typeUtilisateur.Libelle.Contains("Diffuseur"))
                    {
                        partenaire.typeutilisateur = (TypeUtilisateur)typeUtilisateur;
                    }

                }

                _ViewModelUtilisateur.diffuseurs.Add(partenaire);
                _ViewModelUtilisateur.Entities.Utilisateurs.Add(partenaire);

                this._ViewModelUtilisateur.Save();
                    this.Close();
                    }
                else { MessageBox.Show("L'artiste doit être agé de 18 ans ou plus."); }
                
            }
            else { MessageBox.Show("veuillez saisir au minimum :\r\n - Un nom\n - Un numéro de téléphone \n - Une adresse mail. \n - Une date de naissance."); }
        }
        #endregion
    }


}
