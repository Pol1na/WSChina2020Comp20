﻿#pragma checksum "..\..\..\Pages\CoordinatorMenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D490A672361AC60A93DCC10CBA09F5C7FE76B2ED64A0615D20DBD2D13D49E76"
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
    /// CoordinatorMenuPage
    /// </summary>
    public partial class CoordinatorMenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Pages\CoordinatorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HelloTB;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\CoordinatorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VolunteerBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\CoordinatorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SponsorBtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\CoordinatorMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CompServiceBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WSChina2020AppComp20;component/pages/coordinatormenupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\CoordinatorMenuPage.xaml"
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
            this.HelloTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.VolunteerBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Pages\CoordinatorMenuPage.xaml"
            this.VolunteerBtn.Click += new System.Windows.RoutedEventHandler(this.VolunteerBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SponsorBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Pages\CoordinatorMenuPage.xaml"
            this.SponsorBtn.Click += new System.Windows.RoutedEventHandler(this.SponsorBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CompServiceBtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Pages\CoordinatorMenuPage.xaml"
            this.CompServiceBtn.Click += new System.Windows.RoutedEventHandler(this.CompServiceBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

