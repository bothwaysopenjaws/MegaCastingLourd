﻿#pragma checksum "..\..\TabParametres.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DD517D0D83EB67ABCEE9CB063B42A95D"
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
    /// PanelParametre
    /// </summary>
    public partial class PanelParametre : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\TabParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonParametreTypeContrat;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\TabParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonParametreTypeCompetences;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\TabParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonParametreTypeAbonnements;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\TabParametres.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonParametreMetierDomaines;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCasting.WPF;component/tabparametres.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TabParametres.xaml"
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
            this.ButtonParametreTypeContrat = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.ButtonParametreTypeCompetences = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\TabParametres.xaml"
            this.ButtonParametreTypeCompetences.Click += new System.Windows.RoutedEventHandler(this.ButtonParametreTypeCompetences_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonParametreTypeAbonnements = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\TabParametres.xaml"
            this.ButtonParametreTypeAbonnements.Click += new System.Windows.RoutedEventHandler(this.ButtonParametreTypeAbonnements_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonParametreMetierDomaines = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

