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


namespace MegaCasting.WPF.GestionWindows
{
    /// <summary>
    /// Logique d'interaction pour AjoutPartenaire.xaml
    /// </summary>
    public partial class AjoutPartenaire : Window
    {
        #region Attributs
        ViewModelUtilisateur _ViewModelUtilisateur;
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

            if (this.TextBoxNomAjoutPartenaire.Text != null && this.TextBoxEmailAjoutPartenaire.Text != null && this.TextBoxTelAjoutPartenaire.Text != null && this.TextBoxNomAjoutPartenaire.Text != "" && this.TextBoxEmailAjoutPartenaire.Text != "" && this.TextBoxTelAjoutPartenaire.Text != "")
            {
                
                partenaire.Nom = this.TextBoxNomAjoutPartenaire.Text;
                partenaire.Prenom = this.TextBoxPrenomAjoutPartenaire.Text;
                partenaire.Telephone = this.TextBoxTelAjoutPartenaire.Text;
                partenaire.Email = this.TextBoxEmailAjoutPartenaire.Text;
                partenaire.Login = partenaire.Nom + "login";
                partenaire.Password = partenaire.Nom + "Password";
                adressePartenaire.Rue = this.TextBoxRueAjoutPartenaire.Text;
                adressePartenaire.Pays = this.textBoxPaysAjoutPartenaire.Text;
                adressePartenaire.Ville = this.TextBoxVilleAjoutPartenaire.Text;
                adressePartenaire.CodePostal = this.TextBoxCPAjoutPartenaire.Text;

                // retrouve le type d'utilisateur associé aux partenaires
                foreach (TypeUtilisateur typeUtilisateur in type)
                {

                    if (typeUtilisateur.Libelle.Contains("Diffuseur"))
                    {
                        partenaire.typeutilisateur = (TypeUtilisateur)typeUtilisateur;
                    }

                }

                partenaire.adresse = (Adresse)adressePartenaire;
                _ViewModelUtilisateur.diffuseurs.Add(partenaire);
                _ViewModelUtilisateur.Entities.Utilisateurs.Add(partenaire);

                this._ViewModelUtilisateur.Save();
                this.Close();
            }
            else { MessageBox.Show("veuillez saisir au minimum :\r\n - Un nom\n - Un numéro de téléphone \n - Une adresse mail."); }
        }
        #endregion
    }


}
