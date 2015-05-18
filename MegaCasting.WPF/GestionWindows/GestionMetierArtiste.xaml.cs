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
using MegaCasting.WPF.Ajout_Windows;
using MegaCasting.WPF.ViewModel;

namespace MegaCasting.WPF.GestionWindows
{
    /// <summary>
    /// Logique d'interaction pour GestionMetierArtiste.xaml
    /// </summary>
    public partial class GestionMetierArtiste : Window
    {

        #region Attributs
        protected ViewModelDomaine_Metier _ViewModelMetier;
        protected Utilisateur artiste;
        #endregion
        #region Contructeur
        public GestionMetierArtiste(Utilisateur user, ViewModelDomaine_Metier viewModelMetierDomaine)
        {
            InitializeComponent();

            artiste = user;

            _ViewModelMetier = new ViewModelDomaine_Metier();
            //_ViewModelMetier.competencesParArtiste(artiste); récupération des métiers artiste
            _ViewModelMetier = viewModelMetierDomaine;
            this.DataContext = _ViewModelMetier;
        }
        #endregion
        #region Evenement

        #endregion
    }
}
