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
        public PanelPartenaires()
        {
            InitializeComponent();
        }

        private void ButtonPartenaireAjouter_Click(object sender, RoutedEventArgs e)
        {
            AjoutPartenaire nouveauPartenaire = new AjoutPartenaire();
            nouveauPartenaire.ShowDialog();
        }

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
    }
}
