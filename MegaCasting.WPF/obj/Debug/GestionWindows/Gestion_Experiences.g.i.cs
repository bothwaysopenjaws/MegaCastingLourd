﻿#pragma checksum "..\..\..\GestionWindows\Gestion_Experiences.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "42F3DB4451D1CCE2FCD6BCA6A8490078"
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
    /// Gestion_Experiences
    /// </summary>
    public partial class Gestion_Experiences : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonExperienceAjouter;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonExperienceSupprimer;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonExperienceModifier;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxExperiences;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxDescriptionExp;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerFinExperiences;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerDebutExperiences;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBlockDescriptionExp;
        
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
            System.Uri resourceLocater = new System.Uri("/MegaCasting.WPF;component/gestionwindows/gestion_experiences.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
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
            this.ButtonExperienceAjouter = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
            this.ButtonExperienceAjouter.Click += new System.Windows.RoutedEventHandler(this.ButtonExperienceAjouter_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonExperienceSupprimer = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\GestionWindows\Gestion_Experiences.xaml"
            this.ButtonExperienceSupprimer.Click += new System.Windows.RoutedEventHandler(this.ButtonExperienceSupprimer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonExperienceModifier = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.ListBoxExperiences = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.TextBoxDescriptionExp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.DatePickerFinExperiences = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.DatePickerDebutExperiences = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.TextBlockDescriptionExp = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

