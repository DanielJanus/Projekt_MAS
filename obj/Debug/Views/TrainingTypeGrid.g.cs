#pragma checksum "..\..\..\Views\TrainingTypeGrid.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B235A65A993AD14E2A72F006EDDE15BFB323CF6D15272D999D6E125B49E665C0"
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
    /// TrainingTypeGrid
    /// </summary>
    public partial class TrainingTypeGrid : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Views\TrainingTypeGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridTrainingType;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\TrainingTypeGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdTrainingDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/MAS-Implementacja;component/views/trainingtypegrid.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\TrainingTypeGrid.xaml"
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
            
            #line 16 "..\..\..\Views\TrainingTypeGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PersonalData);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 17 "..\..\..\Views\TrainingTypeGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewClubs);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 18 "..\..\..\Views\TrainingTypeGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewSchooling);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\..\Views\TrainingTypeGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToMainPage);
            
            #line default
            #line hidden
            return;
            case 5:
            this.gridTrainingType = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            
            #line 25 "..\..\..\Views\TrainingTypeGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddTrainingType);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 26 "..\..\..\Views\TrainingTypeGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateTrainingTypes);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 27 "..\..\..\Views\TrainingTypeGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteTrainingType);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 28 "..\..\..\Views\TrainingTypeGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadTrainingTypes);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtIdTrainingDelete = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 32 "..\..\..\Views\TrainingTypeGrid.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToTraining);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

