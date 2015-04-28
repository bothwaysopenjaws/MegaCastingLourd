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
        
       /// <summary>
       /// Efface le panel actuel et envoie vers le panel panelAnnonceurs
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void MenuItemAnnonceurs_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelAnnonceurs panelAnnonceurs = new PanelAnnonceurs();
            dockPanelMain.Children.Add(panelAnnonceurs);
        }

        /// <summary>
        /// Efface le panel actuel et envoie vers le panel panelOffres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemOffres_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelOffres panelOffres = new PanelOffres();
            dockPanelMain.Children.Add(panelOffres);
        }

        /// <summary>
        /// Efface le panel actuel et envoie vers le panel panelPartenaires
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemPartenaires_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelPartenaires panelPartenaires = new PanelPartenaires();
            dockPanelMain.Children.Add(panelPartenaires);
        }

        /// <summary>
        /// Efface le panel actuel et envoie vers le panel panelArtistes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemArtistes_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelArtistes panelArtistes = new PanelArtistes();
            dockPanelMain.Children.Add(panelArtistes);
        }
        /// <summary>
        /// Efface le panel actuel et envoie vers le panel panelCandidatures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemCandidatures_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelCandidatures panelCandidatures = new PanelCandidatures();
            dockPanelMain.Children.Add(panelCandidatures);
        }
        /// <summary>
        /// Efface le panel actuel et envoie vers le panel panelParametres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemParametres_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelParametres panelParametres = new PanelParametres();
            dockPanelMain.Children.Add(panelParametres);
        }


        /// <summary>
        /// Efface le panel actuel et envoie vers le panel panelAbonnements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemAbonnements_Click(object sender, RoutedEventArgs e)
        {
            this.CleanDockPanel();
            PanelAbonnements panelAbonnements = new PanelAbonnements();
            dockPanelMain.Children.Add(panelAbonnements);
        }

        /// <summary>
        /// Ferme la fenetre MainWindows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #region Méthodes

        /// <summary>
        /// Supprime le panel acutellement présent dans le dockPanel
        /// </summary>
        private void CleanDockPanel()
        {
              dockPanelMain.Children.Clear();  //Nettoyage du dockPanel

            
        }
        #endregion

        /// <summary>
        /// Permet le déplacement de la fenêtre lorsque l'on clique en continu sur le thumb de la mainWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragWindow_Click(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {

            this.Left += e.HorizontalChange;
            this.Top += e.VerticalChange;

        }

    }
}
