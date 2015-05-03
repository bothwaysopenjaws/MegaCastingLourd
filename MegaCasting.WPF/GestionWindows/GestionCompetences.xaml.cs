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
using System.Collections.ObjectModel;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour Competences.xaml
    /// </summary>
    public partial class GestionCompetences : Window
    {

        #region Attributs
        protected ViewModelCompetence _ViewModelCompetence;
        public ObservableCollection<Competence> competencesArtistes;
       
        #endregion

        #region Constructeurs

        public GestionCompetences(Utilisateur utilisateur)
        {
            InitializeComponent();

            _ViewModelCompetence = new ViewModelCompetence();
            // intégrer la View au dataContext
            this.DataContext = _ViewModelCompetence;



            competencesArtistes = new ObservableCollection<Competence>(utilisateur.competences);

            this.ComboboxNiveauCompetence.ItemsSource = _ViewModelCompetence.niveaux;

            this.ComboboxTypeCompetence.ItemsSource = _ViewModelCompetence.typeCompetences;

            this.ListBoxCompetencesArtistes.ItemsSource = competencesArtistes;

        }


        #endregion

        
    }
}
