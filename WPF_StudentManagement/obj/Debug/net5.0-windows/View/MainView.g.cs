﻿#pragma checksum "..\..\..\..\View\MainView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "386B25D3A3135E4F9412D2D217C9B48AB55C31BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WPF_StudentManagement.View;
using WPF_StudentManagement.ViewModels;


namespace WPF_StudentManagement.View {
    
    
    /// <summary>
    /// MainView
    /// </summary>
    public partial class MainView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnDashBoard;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnStudentMangement;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnClass;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlControlBar;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMaximize;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\View\MainView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_StudentManagement;component/view/mainview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MainView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnDashBoard = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.btnStudentMangement = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.btnClass = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.pnlControlBar = ((System.Windows.Controls.StackPanel)(target));
            
            #line 104 "..\..\..\..\View\MainView.xaml"
            this.pnlControlBar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.pnlControlBar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\..\View\MainView.xaml"
            this.pnlControlBar.MouseEnter += new System.Windows.Input.MouseEventHandler(this.pnlControlBar_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\..\..\View\MainView.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnMaximize = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\..\View\MainView.xaml"
            this.btnMaximize.Click += new System.Windows.RoutedEventHandler(this.btnMaximize_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\..\View\MainView.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

