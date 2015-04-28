﻿using System;
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
using MegaCasting.DBLib;
namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour PanelAbonnements.xaml
    /// </summary>
    public partial class PanelAbonnements : UserControl
    {
       protected ViewModelUtilisateur _ViewModelUtilisateur;
       protected String nbUtilisateur;

       public PanelAbonnements()
        {
            InitializeComponent();

            // Récupération du viewModel
           
            this._ViewModelUtilisateur = new ViewModelUtilisateur();

            nbUtilisateur = (_ViewModelUtilisateur.Entities.Utilisateurs.Count()).ToString();

            // intégration de la View au dataContext
            this.DataContext = _ViewModelUtilisateur;
        }
    }
}
