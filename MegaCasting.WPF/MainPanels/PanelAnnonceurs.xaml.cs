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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MegaCasting.WPF.ViewModel;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour PanelAnnonceurs.xaml
    /// </summary>
    public partial class PanelAnnonceurs : UserControl
    {

        #region Attributs

        ViewModelUtilisateur _ViewModelUtilisateur;
        #endregion

        #region Constructeurs
              public PanelAnnonceurs()
        {
            InitializeComponent();
            _ViewModelUtilisateur = new ViewModelUtilisateur();

        }

        #endregion

       #region Évènements



        /// <summary>
        /// Supprimer un annonceur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnnonceurSupprimer_Click(object sender, RoutedEventArgs e)
                {
                    MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer cet annonceur ?", "Suppression d'un annonceur", MessageBoxButton.YesNoCancel);
                    switch (result)
                    {
                        case MessageBoxResult.Yes:

                            break;
                        case MessageBoxResult.No:

                            break;
                        case MessageBoxResult.Cancel:

                            break;
                    }
                }



       #endregion
  
        
    }
}
