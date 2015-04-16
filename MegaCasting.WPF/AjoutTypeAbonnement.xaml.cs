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

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour AjoutTypeAbonnement.xaml
    /// </summary>
    public partial class AjoutTypeAbonnement : Window
    {

        private ViewModelAbonnement _ViewModel;

        public AjoutTypeAbonnement()
        {
            InitializeComponent();

            // Récupération de la ViewModel
            _ViewModel = new ViewModelAbonnement();

            // intégrer la View au dataContext
            this.DataContext = _ViewModel;
        }
        
        private void ButtonAjoutTypeAbonnement_Click(object sender, RoutedEventArgs e)
        {

            string saisieOffre = this.TextBoxOffre.Text;

            // Vérifier que les saisies du nom n'est pa null et que l'offre ne soit pas des chiffres 
            if (this.TextBoxNom.Text != null && IsInteger(saisieOffre) == true)
            {
                     // instancié un nouveau type d'abonnement
                    typeabonnement typeAbonnement = new typeabonnement();
                    typeAbonnement.libelle = this.TextBoxNom.Text;
                    typeAbonnement.nbOffre = int.Parse(saisieOffre);

                    // ajouter à la viewModel du nouveau type d'abonnement
                    _ViewModel.TypeAbonnements.Add(typeAbonnement);

                    // Une fois que la viewModel est mise a jour on sauvegarde les modifications 
                    this._ViewModel.Save();

                    // fermeture de la fenêtre
                    this.Close();
            }
                // si la saisie n'est pas valide apparition d'un message d'erreur
            else
            {
                MessageBox.Show("Saisie invalide !, veuillez saisir des données correcte.");
            }
        
        }

        // Permet de vérifier si la saisie est un int
       public bool IsInteger(string text)
        {
            //Le mot clé uint désigne un type int
            uint value;
            return uint.TryParse(text, out value);
        }
    }
}
