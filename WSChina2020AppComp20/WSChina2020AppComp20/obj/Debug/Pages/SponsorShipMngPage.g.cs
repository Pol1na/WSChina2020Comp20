﻿#pragma checksum "..\..\..\Pages\SponsorShipMngPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0ACF16F45F360FE0E6538C35B410270C62D0C38EFE1E2F4076A6CE631E626014"
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
    /// SponsorShipMngPage
    /// </summary>
    public partial class SponsorShipMngPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Pages\SponsorShipMngPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StatisticsBtn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\SponsorShipMngPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ViewBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\SponsorShipMngPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChartBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WSChina2020AppComp20;component/pages/sponsorshipmngpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\SponsorShipMngPage.xaml"
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
            this.StatisticsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Pages\SponsorShipMngPage.xaml"
            this.StatisticsBtn.Click += new System.Windows.RoutedEventHandler(this.StatisticsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ViewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Pages\SponsorShipMngPage.xaml"
            this.ViewBtn.Click += new System.Windows.RoutedEventHandler(this.ViewBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ChartBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Pages\SponsorShipMngPage.xaml"
            this.ChartBtn.Click += new System.Windows.RoutedEventHandler(this.ChartBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

