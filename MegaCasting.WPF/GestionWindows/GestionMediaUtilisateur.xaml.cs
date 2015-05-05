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
using MegaCasting.WPF.Ajout_Windows;
using MegaCasting.DBLib;
using MegaCasting.WPF.ViewModel;

namespace MegaCasting.WPF.GestionWindows
{
    /// <summary>
    /// Logique d'interaction pour GestionMediaUtilisateur.xaml
    /// </summary>
    public partial class GestionMediaUtilisateur : Window
    {
        #region Attributs
        #endregion
        #region Constructeur
        public GestionMediaUtilisateur()
        {
            InitializeComponent();
        }
        #endregion
        #region Evenement
        private void ButtonAjouterMedia_Click(object sender, RoutedEventArgs e)
        {
            AjoutMediaArtiste ajoutMediaArtiste = new AjoutMediaArtiste();
            ajoutMediaArtiste.ShowDialog();
        }
        #endregion
    }

}
