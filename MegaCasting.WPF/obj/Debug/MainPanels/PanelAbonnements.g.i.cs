﻿#pragma checksum "..\..\..\MainPanels\PanelAbonnements.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A7348EA8E6E62E25F83EBE78FDCA085"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34209
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MegaCasting.WPF {
    
    
    /// <summary>
    /// PanelAbonnements
    /// </summary>
    public partial class PanelAbonnements : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\MainPanels\PanelAbonnements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxUtilisateurs;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\MainPanels\PanelAbonnements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelAbonnementTypeAbonnement;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MainPanels\PanelAbonnements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelAbonnementRestant;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MainPanels\PanelAbonnements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelAbonnementDate;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\MainPanels\PanelAbonnements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAbonnementsAjouter;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\MainPanels\PanelAbonnements.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxHistoriqueHistorique;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MegaCasting.WPF;component/mainpanels/panelabonnements.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainPanels\PanelAbonnements.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ListBoxUtilisateurs = ((System.Windows.Controls.ListBox)(target));
            
            #line 23 "..\..\..\MainPanels\PanelAbonnements.xaml"
            this.ListBoxUtilisateurs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxUtilisateurs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LabelAbonnementTypeAbonnement = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LabelAbonnementRestant = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.LabelAbonnementDate = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.ButtonAbonnementsAjouter = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\MainPanels\PanelAbonnements.xaml"
            this.ButtonAbonnementsAjouter.Click += new System.Windows.RoutedEventHandler(this.ButtonAbonnementsAjouter_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ListBoxHistoriqueHistorique = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

