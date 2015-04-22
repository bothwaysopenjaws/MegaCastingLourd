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
using MegaCasting.WPF.ViewModel;
using System.Windows.Shapes;
using MegaCasting.DBLib;

namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour AjoutTypeCompetence.xaml
    /// </summary>
    public partial class AjoutTypeCompetence : Window
    {
        protected ViewModelCompetence _ViewModelCompetence;

        public AjoutTypeCompetence(ViewModelCompetence _ViewModel)
        {
            InitializeComponent();
            // Intégration de la ViewModel récupérer avec celle de cette fenêtre
            _ViewModelCompetence = _ViewModel;

            // intégrer la View au dataContext
            this.DataContext = _ViewModelCompetence;
        }

        private void ButtonAjoutTypeCompetence_Click(object sender, RoutedEventArgs e)
        {
            // récupère le text de la textbox dans une string 
            string saisieLibelle = this.TextBoxNom.Text;

            // Vérifier que les saisies du nom n'est pa null n'y vide  
            if (this.TextBoxNom.Text != null && this.TextBoxNom.Text != "" )
            {
                // instancié un nouveau type de compétence
                TypeCompetence typeCompetence = new TypeCompetence();
                typeCompetence.Libelle = this.TextBoxNom.Text;
                

                // ajouter à la viewModel du nouveau type de compétences
                _ViewModelCompetence.TypeCompetences.Add(typeCompetence);
                _ViewModelCompetence.Entities.TypeCompetences.Add(typeCompetence);

                // Une fois que la viewModel est mise a jour on sauvegarde les modifications 
                this._ViewModelCompetence.Save();

               
                this.Close();
            }
            // si la saisie n'est pas valide apparition d'un message d'erreur
            else
            {
                MessageBox.Show("Saisie invalide !\r veuillez saisir des données correcte.");
                this.TextBoxNom.Clear();
            }



        }
    }
}
