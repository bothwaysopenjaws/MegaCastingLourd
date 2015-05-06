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
using MegaCasting.WPF.ViewModel;
using MegaCasting.DBLib;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour AjoutCredit.xaml
    /// </summary>
    public partial class AjoutCredit : Window
    {


        #region Attributs
        public ViewModelAbonnement viewModelAbonnement;
        private Utilisateur _annonceur;

        public Utilisateur annonceur
        {
            get { return _annonceur; }
            set { _annonceur = value; }
        }
        

        #endregion
        


        #region Constructeurs

        public AjoutCredit(Utilisateur annonceurPanel, ViewModelAbonnement viewModelAbonnementPanel)
        {

            InitializeComponent();
            viewModelAbonnement = new ViewModelAbonnement();
            viewModelAbonnement = viewModelAbonnementPanel;
            this.DataContext = viewModelAbonnement;
            annonceur = annonceurPanel;
          
        }
        #endregion

        private void ButtonAjouterAbonnementAnnonceur_Click(object sender, RoutedEventArgs e)
        {
            if (this.ComboBoxTypeAbonnement.SelectedItem != null)
            {

                Abonnement abonnement = new Abonnement();
                abonnement.typeabonnement = (TypeAbonnement)(this.ComboBoxTypeAbonnement.SelectedItem);
                abonnement.Restant = ((TypeAbonnement)(this.ComboBoxTypeAbonnement.SelectedItem)).NombreOffres;
                abonnement.DateSouscription = DateTime.Now;
                abonnement.utilisateur = annonceur;
                
                viewModelAbonnement.annonceurs.Where(annonceurTemp => annonceurTemp == annonceur).First().abonnements.Add(abonnement);
                viewModelAbonnement.Save();
                MessageBox.Show("Ajout réussi.");
                this.Close();
                
            }
            
        }




       
    }
}
