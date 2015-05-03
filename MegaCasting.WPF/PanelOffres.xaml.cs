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
    /// Logique d'interaction pour PanelOffres.xaml
    /// </summary>
    public partial class PanelOffres : UserControl
    {



        #region Attributs
        protected ViewModelOffre _ViewModelOffre;
      
        #endregion


        #region Constructeurs
        public PanelOffres()
        {
            InitializeComponent();
            this._ViewModelOffre = new ViewModelOffre();
            this.DataContext = _ViewModelOffre;
        }       
        #endregion





        #region Évènements
        /// <summary>
        /// Recharge la listebox avec toutes les offres, sans tri
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOffreReset_Click(object sender, RoutedEventArgs e)
        {
            this.ListBoxOffres.ItemsSource = _ViewModelOffre.offres;

        }
        #endregion


        #region Méthodes



        #endregion



        #region Méthodes

        #endregion

    }
}
