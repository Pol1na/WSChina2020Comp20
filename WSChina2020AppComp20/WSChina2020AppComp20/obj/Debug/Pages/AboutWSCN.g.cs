﻿#pragma checksum "..\..\..\Pages\AboutWSCN.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "778860F0410FF4F14358E069CDA3F04601C35B255184A57F853507991744B217"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using WSChina2020AppComp20.Pages;


namespace WSChina2020AppComp20.Pages {
    
    
    /// <summary>
    /// AboutWSCN
    /// </summary>
    public partial class AboutWSCN : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\AboutWSCN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AccessionButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\AboutWSCN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CommitteeButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\AboutWSCN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResultsButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\AboutWSCN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AboutWSCNListBox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\AboutWSCN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveFileBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WSChina2020AppComp20;component/pages/aboutwscn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AboutWSCN.xaml"
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
            this.AccessionButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\AboutWSCN.xaml"
            this.AccessionButton.Click += new System.Windows.RoutedEventHandler(this.AccessionButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CommitteeButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.ResultsButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.AboutWSCNListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.SaveFileBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Pages\AboutWSCN.xaml"
            this.SaveFileBtn.Click += new System.Windows.RoutedEventHandler(this.SaveFileBtn_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

