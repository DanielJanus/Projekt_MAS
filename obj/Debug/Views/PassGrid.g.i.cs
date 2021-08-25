﻿#pragma checksum "..\..\..\Views\PassGrid.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A1BAF3BFFB81B88433AB32CE638B74A3379524B2E97D42EA1D5ADE2FB56C6F28"
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
    /// PassGrid
    /// </summary>
    public partial class PassGrid : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Views\PassGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridPassData;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\PassGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdPassDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/MAS-Implementacja;component/views/passgrid.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PassGrid.xaml"
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
            
            #line 16 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewPersonalData);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 17 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewSchoolings);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 18 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewTrainings);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenMainPage);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 20 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewClubs);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gridPassData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            
            #line 26 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddPassData);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 27 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdatePassData);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 28 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeletePassData);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 29 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadPassData);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtIdPassDelete = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 33 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MoveToClient);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 34 "..\..\..\Views\PassGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddToSpecificClient);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
