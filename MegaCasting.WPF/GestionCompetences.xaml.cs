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
        ViewModelCompetence _ViewModelCompetence;
        ViewModelDomaine_Metier _ViewModelUtilisateur;
        ObservableCollection<Competence> competencesArtistes = new ObservableCollection<Competence>();

        public GestionCompetences(ViewModelDomaine_Metier _ViewModel,Utilisateur utilisateur)
        {
            InitializeComponent();
            _ViewModelUtilisateur = _ViewModel;
            // Récupération de la ViewModel

            // intégrer la View au dataContext
            this.DataContext = _ViewModelUtilisateur;

            competencesArtistes = new ObservableCollection<Competence>((utilisateur.competences));

            this.ListBoxCompetencesArtistes.ItemsSource = competencesArtistes;

        }
    }
}
