﻿#pragma checksum "..\..\..\GestionWindows\GestionTypeAbonnement.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AC2B5180969C8BC1D1607BDA820B1B96"
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
    /// GestionTypeAbonnement
    /// </summary>
    public partial class GestionTypeAbonnement : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\GestionWindows\GestionTypeAbonnement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtoTypeAbonnementAjouter;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GestionWindows\GestionTypeAbonnement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonTypeAbonnementSupprimer;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\GestionWindows\GestionTypeAbonnement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonTypeAbonnementModifier;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\GestionWindows\GestionTypeAbonnement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxAbonnements;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\GestionWindows\GestionTypeAbonnement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxNomTypeAbonnement;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\GestionWindows\GestionTypeAbonnement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxNombreOffreTypeAbonnement;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCasting.WPF;component/gestionwindows/gestiontypeabonnement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GestionWindows\GestionTypeAbonnement.xaml"
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
            this.ButtoTypeAbonnementAjouter = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\GestionWindows\GestionTypeAbonnement.xaml"
            this.ButtoTypeAbonnementAjouter.Click += new System.Windows.RoutedEventHandler(this.ButtoTypeAbonnementAjouter_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonTypeAbonnementSupprimer = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\GestionWindows\GestionTypeAbonnement.xaml"
            this.ButtonTypeAbonnementSupprimer.Click += new System.Windows.RoutedEventHandler(this.ButtonTypeAbonnementSupprimer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonTypeAbonnementModifier = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\GestionWindows\GestionTypeAbonnement.xaml"
            this.ButtonTypeAbonnementModifier.Click += new System.Windows.RoutedEventHandler(this.ButtonTypeAbonnementModifier_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListBoxAbonnements = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.TextBoxNomTypeAbonnement = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TextBoxNombreOffreTypeAbonnement = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

