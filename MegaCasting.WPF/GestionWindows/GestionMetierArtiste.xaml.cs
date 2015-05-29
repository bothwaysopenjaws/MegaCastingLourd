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
using MegaCasting.WPF.Ajout_Windows;
using MegaCasting.WPF.ViewModel;

namespace MegaCasting.WPF.GestionWindows
{
    /// <summary>
    /// Logique d'interaction pour GestionMetierArtiste.xaml
    /// </summary>
    public partial class GestionMetierArtiste : Window
    {

        #region Attributs
        protected ViewModelDomaine_Metier _ViewModelMetier;
        protected ViewModelUtilisateur _ViewModelUser;
        protected Utilisateur artiste;
        #endregion
        #region Contructeur

        public GestionMetierArtiste(Utilisateur user,ViewModelUtilisateur viewModelUser)
        {
            InitializeComponent();

            artiste = user;
            _ViewModelUser = new ViewModelUtilisateur();
            _ViewModelUser = viewModelUser;
            _ViewModelMetier = new ViewModelDomaine_Metier();
            _ViewModelMetier.metierParArtiste(artiste);

            this.DataContext = _ViewModelMetier;
        }
        #endregion




        #region Evenement
        private void ButtonAjouterMetier_Click(object sender, RoutedEventArgs e)
        {
            AjoutMetierArtiste ajoutMetierArtiste = new AjoutMetierArtiste(_ViewModelMetier, artiste);
            ajoutMetierArtiste.ShowDialog();

        }
        //a finir
        private void ButtonSupprimerMetier_Click(object sender, RoutedEventArgs e)
        {
            Metier metierArtiste = (Metier)this.ListBoxMetiersArtiste.SelectedItem;
            
            if (metierArtiste != null)
            {

                _ViewModelMetier.Entities.Utilisateurs.Where(utilisateurTemp => utilisateurTemp.Identifiant == artiste.Identifiant).First().metiers.Remove(metierArtiste);
                _ViewModelMetier.artistes.Where(utilisateurTemp => utilisateurTemp.Identifiant == artiste.Identifiant).First().metiers.Remove(metierArtiste);

                _ViewModelUser.Entities.Utilisateurs.Where(utilisateurTemp => utilisateurTemp.Identifiant == artiste.Identifiant).First().metiers.Remove(metierArtiste);
                _ViewModelUser.artistes.Where(utilisateurTemp => utilisateurTemp.Identifiant == artiste.Identifiant).First().metiers.Remove(metierArtiste);
                _ViewModelMetier.metiersArtistes.Remove(metierArtiste);
                
                _ViewModelUser.Save();
                _ViewModelMetier.Save();
                                       
            }
           
        }

        #endregion




    }
}
