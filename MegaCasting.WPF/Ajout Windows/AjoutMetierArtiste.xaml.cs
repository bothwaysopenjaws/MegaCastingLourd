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
using MegaCasting.WPF.Ajout_Windows;

namespace MegaCasting.WPF.Ajout_Windows
{
    /// <summary>
    /// Interaction logic for AjoutMetierArtiste.xaml
    /// </summary>
    public partial class AjoutMetierArtiste : Window
    {
        #region Attributs
        protected ViewModelDomaine_Metier viewModelMetierArtiste;
        public Utilisateur artiste;
        #endregion
        #region constructeur
        public AjoutMetierArtiste(ViewModelDomaine_Metier viewModelDomaineMetier, Utilisateur artisteAjout)
        {
            InitializeComponent();

            artiste = artisteAjout;
            viewModelMetierArtiste = new ViewModelDomaine_Metier();
            viewModelMetierArtiste = viewModelDomaineMetier;
            this.DataContext = viewModelMetierArtiste;
        }
        #endregion


        #region Evenements
        private void ButtonAjouterMetierArtiste_Click(object sender, RoutedEventArgs e)
        {
            int isNull = 0;

            if (this.ComboBoxMetier.SelectedItem != null)
            {
                Metier metier = new Metier();
                metier = (Metier)this.ComboBoxMetier.SelectedItem;

                foreach (Metier metierArtiste in artiste.metiers)
                {
                    if (metierArtiste.Identifiant == metier.Identifiant)
                    {
                        isNull = isNull + 1;
                    }

                }
                if (isNull == 0)
                {
                    viewModelMetierArtiste.artistes.Where(artisteTemp => artisteTemp.Identifiant == artiste.Identifiant).First().metiers.Add(metier);
                    viewModelMetierArtiste.metierParArtiste(artiste);
                    viewModelMetierArtiste.Save();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("l'artiste dispose déja du métier.");
                }



            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un métier.");
            }
        }
        #endregion
    }
}
