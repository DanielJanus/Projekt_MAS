﻿#pragma checksum "..\..\..\Views\EmployeeUpdateForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "799823ECEB712328E6A8C9B097ED142FB4423B1F5EB5E724393BBB9143A68F93"
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
    /// EmployeeUpdateForm
    /// </summary>
    public partial class EmployeeUpdateForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Views\EmployeeUpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdPracownikaUpdate;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\EmployeeUpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdDaneUpdate;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\EmployeeUpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdUmowaUpdate;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\EmployeeUpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumerKontaUpdate;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\EmployeeUpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIndywidualnaStawkaUpdate;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\EmployeeUpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLiczbaGodzinUpdate;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Views\EmployeeUpdateForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPensjaUpdate;
        
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
            System.Uri resourceLocater = new System.Uri("/MAS-Implementacja;component/views/employeeupdateform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\EmployeeUpdateForm.xaml"
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
            this.txtIdPracownikaUpdate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtIdDaneUpdate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtIdUmowaUpdate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtNumerKontaUpdate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtIndywidualnaStawkaUpdate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtLiczbaGodzinUpdate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtPensjaUpdate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 50 "..\..\..\Views\EmployeeUpdateForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateEmployeeData);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 51 "..\..\..\Views\EmployeeUpdateForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

