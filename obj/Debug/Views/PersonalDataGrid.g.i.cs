﻿#pragma checksum "..\..\..\Views\PersonalDataGrid.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2B6D2BD631B7EDC1BF179B1E3DC532A1A02A99FF31757FA007BFA5DCED63FE3F"
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
    /// PersonalDataGrid
    /// </summary>
    public partial class PersonalDataGrid : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Views\PersonalDataGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridPersonalData;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\PersonalDataGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdPersonalDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/MAS-Implementacja;component/views/personaldatagrid.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PersonalDataGrid.xaml"
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
            
            #line 17 "..\..\..\Views\PersonalDataGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewSchoolings);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\..\Views\PersonalDataGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewTrainings);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\..\Views\PersonalDataGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenMainPage);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gridPersonalData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            
            #line 25 "..\..\..\Views\PersonalDataGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeletePersonalData);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 26 "..\..\..\Views\PersonalDataGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadPersonalData);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtIdPersonalDelete = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 30 "..\..\..\Views\PersonalDataGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewClubs);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 31 "..\..\..\Views\PersonalDataGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MoveToEmployee);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 32 "..\..\..\Views\PersonalDataGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MoveToClients);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
