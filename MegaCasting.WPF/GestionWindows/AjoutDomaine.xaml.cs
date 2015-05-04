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
namespace MegaCasting.WPF.GestionWindows
{
    /// <summary>
    /// Logique d'interaction pour AjoutDomaine.xaml
    /// </summary>
    public partial class AjoutDomaine : Window
    {
        #region Attributs
        protected ViewModelDomaine_Metier _ViewModelDomaine;
        #endregion

        #region Constructeur
        public AjoutDomaine(ViewModelDomaine_Metier _ViewModel)
        {
            InitializeComponent();
            // Intégration de la ViewModel récupérer avec celle de cette fenêtre
            _ViewModelDomaine = _ViewModel;

            // intégrer la View au dataContext
            this.DataContext = _ViewModelDomaine;
        }
        #endregion

        #region Evénements
        private void ButtonAjoutDomaine_Click(object sender, RoutedEventArgs e)
        {
            // récupère le text de la textbox dans une string 
            string saisieLibelle = this.TextBoxNomDomaine.Text;

            // Vérifier que les saisies du nom n'est pa null n'y vide  
            if (this.TextBoxNomDomaine.Text != null && this.TextBoxNomDomaine.Text != "")
            {
                // instancié un nouveau domaine
                Domaine domaine = new Domaine();
                domaine.Libelle = this.TextBoxNomDomaine.Text;
                

                // ajouter à la viewModel du nouveau domaine
                _ViewModelDomaine.domaines.Add(domaine);
                _ViewModelDomaine.Entities.Domaines.Add(domaine);

                // Une fois que la viewModel est mise a jour on sauvegarde les modifications 
                this._ViewModelDomaine.Save();

               
                this.Close();
            }
            // si la saisie n'est pas valide apparition d'un message d'erreur
            else
            {
                MessageBox.Show("Saisie invalide !\r veuillez saisir des données correcte.");
                this.TextBoxNomDomaine.Clear();
            }



        }
        #endregion

    }
}
