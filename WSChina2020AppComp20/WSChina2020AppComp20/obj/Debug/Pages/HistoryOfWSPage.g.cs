﻿#pragma checksum "..\..\..\Pages\HistoryOfWSPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "08CA64387E8B3A4AC1B25EE29DE1C011A537D37E35114844FBDC786737BF0A7E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
    /// HistoryOfWSPage
    /// </summary>
    public partial class HistoryOfWSPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\Pages\HistoryOfWSPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AlbertImage;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\HistoryOfWSPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NoImage;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\HistoryOfWSPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DirectorsImage;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\HistoryOfWSPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer Scroll;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\HistoryOfWSPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HistoryWSTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WSChina2020AppComp20;component/pages/historyofwspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\HistoryOfWSPage.xaml"
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
            this.AlbertImage = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\HistoryOfWSPage.xaml"
            this.AlbertImage.Click += new System.Windows.RoutedEventHandler(this.AlbertImage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NoImage = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\HistoryOfWSPage.xaml"
            this.NoImage.Click += new System.Windows.RoutedEventHandler(this.NoImage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DirectorsImage = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\HistoryOfWSPage.xaml"
            this.DirectorsImage.Click += new System.Windows.RoutedEventHandler(this.DirectorsImage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Scroll = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.HistoryWSTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

