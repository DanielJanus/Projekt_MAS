﻿#pragma checksum "..\..\..\Views\PersonalDataAddForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0E6285C27AACB4C020F12E2B5670A2F5E3A927F0B4DA7A2A2D2B77746264587B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using MAS_Implementacja.Views;
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


namespace MAS_Implementacja.Views {
    
    
    /// <summary>
    /// PersonalDataAddForm
    /// </summary>
    public partial class PersonalDataAddForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Views\PersonalDataAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdDaneOsobowe;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\PersonalDataAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtImie;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\PersonalDataAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNazwisko;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\PersonalDataAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDataUrodzenia;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\PersonalDataAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAdresEmail;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\PersonalDataAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefon;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\PersonalDataAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAdres;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\PersonalDataAddForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPesel;
        
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
            System.Uri resourceLocater = new System.Uri("/MAS-Implementacja;component/views/personaldataaddform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PersonalDataAddForm.xaml"
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
            this.txtIdDaneOsobowe = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtImie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtNazwisko = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtDataUrodzenia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtAdresEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtTelefon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtAdres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtPesel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 54 "..\..\..\Views\PersonalDataAddForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddPersonalData);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 55 "..\..\..\Views\PersonalDataAddForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
