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


        #region Attributs
        protected ViewModelAbonnement _ViewModelAbonement;
        #endregion

        #region Constructeur

        /// <summary>
        /// Constructeur récupérant de la viewModel de la frame précédente
        /// </summary>
        /// <param name="_ViewModel"></param>
        public  AjoutTypeAbonnement(ViewModelAbonnement _ViewModel)
        {
            InitializeComponent();

            // Intégration de la ViewModel récupérer avec celle de cette fenêtre
            _ViewModelAbonement =  _ViewModel;

            // intégrer la View au dataContext
            this.DataContext = _ViewModelAbonement;
        }
      
     

        #endregion


        #region Évènements
  
        private void ButtonAjoutTypeAbonnement_Click(object sender, RoutedEventArgs e)
        {

            string saisieOffre = this.TextBoxOffre.Text;

            // Vérifier que les saisies du nom n'est pa null et que l'offre ne soit pas des chiffres que l'offre ne soit pas null 
            if (this.TextBoxNom.Text != null && IsInteger(saisieOffre) == true && this.TextBoxNom.Text != "" && this.TextBoxOffre.Text != "")
            {
                     // instancié un nouveau type d'abonnement
                TypeAbonnement typeAbonnement = new TypeAbonnement();
                    typeAbonnement.Libelle = this.TextBoxNom.Text;
                    typeAbonnement.NombreOffres = int.Parse(saisieOffre);

                    // ajouter à la viewModel du nouveau type d'abonnement
                    _ViewModelAbonement.TypeAbonnements.Add(typeAbonnement);
                    _ViewModelAbonement.Entities.TypeAbonnements.Add(typeAbonnement);
                    // Une fois que la viewModel est mise a jour on sauvegarde les modifications 
                    this._ViewModelAbonement.Save();

                    // fermeture de la fenêtre
                    this.Close();
            }
                // si la saisie n'est pas valide apparition d'un message d'erreur
            else
            {
                MessageBox.Show("Saisie invalide !\r veuillez saisir des données correcte.");
                this.TextBoxOffre.Clear();
            }
        
        }
      
        #endregion



        #region Méthodes
       /// <summary>
       ///  Permet de vérifier si la saisie est un int 
       /// </summary>
       /// <param name="text"></param>
       /// <returns></returns>
       public bool IsInteger(string text)
        {
            //Le mot clé du int désigne un type int
            uint value;
            return uint.TryParse(text, out value);
        }
        #endregion
        
    }
}
