﻿#pragma checksum "..\..\..\GestionWindows\GestionTypeContrat.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7EF4FFE8FB0CCF77B43CF5C09C869C50"
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
    /// GestionTypeContrat
    /// </summary>
    public partial class GestionTypeContrat : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\GestionWindows\GestionTypeContrat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonContratAjouter;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\GestionWindows\GestionTypeContrat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonContratSupprimer;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GestionWindows\GestionTypeContrat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonContratModifier;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\GestionWindows\GestionTypeContrat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxTypeContrats;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\GestionWindows\GestionTypeContrat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextboxNomAjoutContrat;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCasting.WPF;component/gestionwindows/gestiontypecontrat.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GestionWindows\GestionTypeContrat.xaml"
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
            this.ButtonContratAjouter = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\GestionWindows\GestionTypeContrat.xaml"
            this.ButtonContratAjouter.Click += new System.Windows.RoutedEventHandler(this.ButtonContratAjouter_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonContratSupprimer = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\GestionWindows\GestionTypeContrat.xaml"
            this.ButtonContratSupprimer.Click += new System.Windows.RoutedEventHandler(this.ButtonContratSupprimer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonContratModifier = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\GestionWindows\GestionTypeContrat.xaml"
            this.ButtonContratModifier.Click += new System.Windows.RoutedEventHandler(this.ButtonContratModifier_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListBoxTypeContrats = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.TextboxNomAjoutContrat = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

