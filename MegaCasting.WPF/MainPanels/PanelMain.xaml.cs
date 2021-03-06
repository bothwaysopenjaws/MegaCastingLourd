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


namespace MegaCasting.WPF
{
    /// <summary>
    /// Logique d'interaction pour PanelMain.xaml
    /// </summary>
    public partial class PanelMain : UserControl
    {


        #region Constructeurs

            public PanelMain()
        {
            InitializeComponent();
            this.labelMain.Content = "Bienvenue  dans MegaGestion, Gestionnaire de données pour le site MegaShow !";
            // On découpe cette chaine en 2
            int i = System.Security.Principal.WindowsIdentity.GetCurrent().Name.IndexOf(@"\");
            // On récupère le login et le domaine
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Substring(i + 1, System.Security.Principal.WindowsIdentity.GetCurrent().Name.Length - i - 1);
            this.labelConnexion.Content = " Bienvenue " + userName;
            
        }


        #endregion

        
    }
}
