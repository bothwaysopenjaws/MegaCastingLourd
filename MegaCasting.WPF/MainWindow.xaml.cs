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

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItemAnnonceurs_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelAnnonceurs panelAnnonceurs = new PanelAnnonceurs();
            dockPanelMain.Children.Add(panelAnnonceurs);
        }

        private void MenuItemOffres_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelOffres panelOffres = new PanelOffres();
            dockPanelMain.Children.Add(panelOffres);
        }

        private void MenuItemPartenaires_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelPartenaires panelPartenaires = new PanelPartenaires();
            dockPanelMain.Children.Add(panelPartenaires);
        }

        private void MenuItemArtistes_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelArtistes panelArtistes = new PanelArtistes();
            dockPanelMain.Children.Add(panelArtistes);
        }

        private void MenuItemCandidatures_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelCandidatures panelCandidatures = new PanelCandidatures();
            dockPanelMain.Children.Add(panelCandidatures);
        }

        private void MenuItemParametres_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelParametres panelParametres = new PanelParametres();
            dockPanelMain.Children.Add(panelParametres);
        }

        private void MenuItemAbonnements_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelAbonnements panelAbonnements = new PanelAbonnements();
            dockPanelMain.Children.Add(panelAbonnements);
        }


        private void menuItemQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #region Méthodes
        private void CleanDockPanel()
        {
              dockPanelMain.Children.Clear();  //Nettoyage du dockPanel

            
        }
        #endregion

        private void DragWindow_Click(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {

            this.Left += e.HorizontalChange;
            this.Top += e.VerticalChange;

        }

    }
}
