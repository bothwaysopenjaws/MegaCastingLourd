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

namespace MegaCasting.WPF.GestionWindows
{
    /// <summary>
    /// Logique d'interaction pour AjoutTypeContrat.xaml
    /// </summary>
    public partial class AjoutTypeContrat : Window
    {
        #region Attributs
        protected ViewModelOffre _ViewModelOffre;
        #endregion

        #region Constructeur
        public AjoutTypeContrat(ViewModelOffre _ViewModel)
        {
            InitializeComponent();
            // Intégration de la ViewModel récupérer avec celle de cette fenêtre
            _ViewModelOffre = _ViewModel;

            // intégrer la View au dataContext
            this.DataContext = _ViewModelOffre;

      
        }
        #endregion

        #region Evènements
        private void ButtonAjoutContrat_Click(object sender, RoutedEventArgs e)
        {
            string saisieNomContrat = this.TextBoxNomTypeContrat.Text;


            if (saisieNomContrat != null &&  saisieNomContrat != "")
            {
                TypeContrat typeContrat = new TypeContrat();
                typeContrat.Libelle = saisieNomContrat;

                _ViewModelOffre.Entities.TypeContrats.Add(typeContrat);
                _ViewModelOffre.TypeContrats.Add(typeContrat);

                _ViewModelOffre.Save();

                this.Close();
            }
            else
            {
                MessageBox.Show("Ajout impossible ! \n veuillez saisir des données valides.");
                this.TextBoxNomTypeContrat.Clear();
            }
        }
        #endregion
    }
}
