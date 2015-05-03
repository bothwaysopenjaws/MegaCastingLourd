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
using MegaCasting.DBLib;
using MegaCasting.WPF.GestionWindows;
using MegaCasting.WPF.ViewModel;


namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour PanelPartenaires.xaml
    /// </summary>
    public partial class PanelPartenaires : UserControl
    {

        #region Attributs
            ViewModelUtilisateur _ViewModelUtilisateur;


        #endregion

        #region Constructeurs
            public PanelPartenaires()
            {
                InitializeComponent();
                _ViewModelUtilisateur = new ViewModelUtilisateur();
                this.DataContext = _ViewModelUtilisateur;
            }


            #endregion

        #region Évènements


            /// <summary>
            /// Ouverture d'une fenêtre d'ajout de partenaire de diffusion
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void ButtonPartenaireAjouter_Click(object sender, RoutedEventArgs e)
            {
                AjoutPartenaire nouveauPartenaire = new AjoutPartenaire();
                nouveauPartenaire.ShowDialog();
            }


            /// <summary>
            /// Suppression d'un partenaire de diffusion
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void ButtonPartenaireSupprimer_Click(object sender, RoutedEventArgs e)
            {
                MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce partenaire ?", "Suppression d'un partenaire", MessageBoxButton.YesNoCancel);
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


            /// <summary>
            /// Sauvegarde des modification sur les partenaires de diffusion
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void ButtonPartenaireModifier_Click(object sender, RoutedEventArgs e)
            {
                _ViewModelUtilisateur.Save();
            }

            #endregion

    }
}
