﻿#pragma checksum "..\..\..\GestionWindows\GestionMediaUtilisateur.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "74346FB342C8D84E03BCD876EBCB58D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace MegaCasting.WPF.GestionWindows {
    
    
    /// <summary>
    /// GestionMediaUtilisateur
    /// </summary>
    public partial class GestionMediaUtilisateur : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\GestionWindows\GestionMediaUtilisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxMediaArtiste;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\GestionWindows\GestionMediaUtilisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TextBoxUrlMedia;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\GestionWindows\GestionMediaUtilisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TextBoxNomMedia;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\GestionWindows\GestionMediaUtilisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxTypeMedia;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\GestionWindows\GestionMediaUtilisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAjouterMedia;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\GestionWindows\GestionMediaUtilisateur.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSupprimerMedia;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCasting.WPF;component/gestionwindows/gestionmediautilisateur.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GestionWindows\GestionMediaUtilisateur.xaml"
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
            this.ListBoxMediaArtiste = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.TextBoxUrlMedia = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.TextBoxNomMedia = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ComboBoxTypeMedia = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ButtonAjouterMedia = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\GestionWindows\GestionMediaUtilisateur.xaml"
            this.ButtonAjouterMedia.Click += new System.Windows.RoutedEventHandler(this.ButtonAjouterMedia_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonSupprimerMedia = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\GestionWindows\GestionMediaUtilisateur.xaml"
            this.ButtonSupprimerMedia.Click += new System.Windows.RoutedEventHandler(this.ButtonSupprimerMedia_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

