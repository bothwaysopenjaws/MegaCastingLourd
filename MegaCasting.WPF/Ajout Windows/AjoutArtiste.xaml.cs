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
using MegaCasting.WPF.Functions;
using System.Collections.ObjectModel;


namespace MegaCasting.WPF.Ajout_Windows
{
    /// <summary>
    /// Logique d'interaction pour AjoutArtiste.xaml
    /// </summary>
    public partial class AjoutArtiste : Window
    {
        #region Attributs
        protected ViewModelUtilisateur _viewModelUser;
        Functions.Functions function = new Functions.Functions();
        #endregion

        #region Constructeurs
        public AjoutArtiste( ViewModelUtilisateur viewModelUser)
        {
            InitializeComponent();
            _viewModelUser = new ViewModelUtilisateur();
            _viewModelUser = viewModelUser;

            this.DataContext = _viewModelUser;

        }
        #endregion

        #region Evenements


        private void ButtonAjouterArtiste_Click(object sender, RoutedEventArgs e)
        {
            Utilisateur artiste = new Utilisateur();
            Adresse adresseArtiste = new Adresse();

            ObservableCollection<TypeUtilisateur> type = _viewModelUser.typeUtilisateurs;
            TypeUtilisateur typeTemp = new TypeUtilisateur();

            if (this.TextBoxNomAjoutArtiste.Text != null && this.TextBoxEmailAjoutArtiste.Text != null && this.TextBoxTelAjoutArtiste.Text != null && this.TextBoxNomAjoutArtiste.Text != "" && this.TextBoxEmailAjoutArtiste.Text != "" && this.TextBoxTelAjoutArtiste.Text != "")
            {
                DateTime dateNaissance = (DateTime)this.DatePickerNaissanceArtiste.SelectedDate;

                int age = function.CalculAge(dateNaissance);

                if (age > 18)
                {


                    String passwordSalt = function.CreateSHA(artiste.Nom + artiste.Prenom);
                    String[] tabString = passwordSalt.Split('|');
                    artiste.Nom = this.TextBoxNomAjoutArtiste.Text;
                    artiste.DateNaissance = dateNaissance;
                    artiste.Prenom = this.TextBoxPrenomAjoutArtiste.Text;
                    artiste.Email = this.TextBoxEmailAjoutArtiste.Text;
                    artiste.email_canonical = artiste.Email;
                    artiste.Telephone = this.TextBoxTelAjoutArtiste.Text;
                    adresseArtiste.Rue = this.TextBoxRueAjoutArtiste.Text;
                    adresseArtiste.CodePostal = this.TextBoxCPAjoutArtiste.Text;
                    adresseArtiste.Ville = this.TextBoxVilleAjoutArtiste.Text;
                    adresseArtiste.Pays = this.textBoxPaysAjoutArtiste.Text;
                    artiste.adresse = (Adresse)adresseArtiste;
                    artiste.username = artiste.Nom + artiste.Prenom;
                    artiste.username_canonical = artiste.username;

                    artiste.Password = tabString[0];
                    artiste.salt = tabString[1];
                    artiste.enabled = true;
                    artiste.locked = false;
                    artiste.expired = false;
                    artiste.roles = "a:0:{}";
                    artiste.credentials_expired = false;


                    // retrouve le type d'utilisateur associé aux annonceurs
                    foreach (TypeUtilisateur typeUtilisateur in type)
                    {

                        if (typeUtilisateur.Libelle.Contains("Artiste"))
                        {
                            artiste.typeutilisateur = (TypeUtilisateur)typeUtilisateur;
                        }

                    }

                    _viewModelUser.artistes.Add(artiste);
                    _viewModelUser.Entities.Utilisateurs.Add(artiste);

                    _viewModelUser.Save();
                    this.Close();
                }
                else { MessageBox.Show("L'artiste doit être agé de 18 ans ou plus."); }
            }
            else { MessageBox.Show("veuillez saisir au minimum :\r\n - Un nom\n - Un numéro de téléphone \n - Une adresse mail."); }
        }

        #endregion
    }
}
