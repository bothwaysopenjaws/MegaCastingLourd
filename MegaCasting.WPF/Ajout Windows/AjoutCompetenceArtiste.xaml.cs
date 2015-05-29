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
using MegaCasting.WPF.GestionWindows;

namespace MegaCasting.WPF.Ajout_Windows
{
    /// <summary>
    /// Logique d'interaction pour AjoutCompetenceArtiste.xaml
    /// </summary>
    public partial class AjoutCompetenceArtiste : Window
    {
#region attributs
        public ViewModelCompetence viewModelCompetence;
        public Utilisateur artiste;
 
	#endregion
        
        public AjoutCompetenceArtiste(ViewModelCompetence viewModelCompetencesArtistes, Utilisateur artisteAjout)
        {
            artiste = artisteAjout;

            InitializeComponent();
            viewModelCompetence = viewModelCompetencesArtistes;
            this.DataContext = viewModelCompetence;



        }

        private void ButtonAjouterCompetenceArtiste_Click(object sender, RoutedEventArgs e)
        {
            if ((this.ComboBoxTypeCompetence.SelectedItem != null) && (this.ComboBoxNiveauCompetence.SelectedItem != null))
            {
                Competence competence = new Competence();
                competence.niveau = (Niveau)this.ComboBoxNiveauCompetence.SelectedItem;
                competence.typecompetence = (TypeCompetence)this.ComboBoxTypeCompetence.SelectedItem;
                competence.utilisateur = viewModelCompetence.Entities.Utilisateurs.Where(utilisateurTemp => utilisateurTemp.Identifiant == artiste.Identifiant).First();

                if (!artiste.competences.Any(competenceTemp => competenceTemp.typecompetence.Identifiant == ((TypeCompetence)this.ComboBoxTypeCompetence.SelectedItem).Identifiant))
                {
                    ////viewModelCompetence.artistes.Where(artisteTemp => artisteTemp.Identifiant == artiste.Identifiant).First().competences.Add(competence);
                    //// ajouter à la viewModel du nouveau type de compétences
                    //viewModelCompetence.competences.Add(competence);
                    //viewModelCompetence.Entities.Competences.Add(competence);

                    //viewModelCompetence.competencesParArtiste(artiste);
                    //this.viewModelCompetence.Save();
                    //this.Close();

                    viewModelCompetence.Entities.Utilisateurs.Where(utilisateurTemp => utilisateurTemp.Identifiant == artiste.Identifiant).First().competences.Add(competence);
                    viewModelCompetence.artistes.Where(utilisateurTemp => utilisateurTemp.Identifiant == artiste.Identifiant).First().competences.Add(competence);
                    viewModelCompetence.competencesArtiste.Add(competence);
                    viewModelCompetence.Save();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("L'artiste possède déjà cette compétence ! ");
                }
 

            }
  
            
        }
    }
}
