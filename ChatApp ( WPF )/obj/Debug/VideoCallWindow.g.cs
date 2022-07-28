﻿#pragma checksum "..\..\VideoCallWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "927E2F0C2AF0AD934F5196F87D33B7513BACC89698DD1E73B5481FC43A142684"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ChatApp___WPF__;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using VisioForge.Core.UI.WPF;


namespace ChatApp___WPF__ {
    
    
    /// <summary>
    /// VideoCallWindow
    /// </summary>
    public partial class VideoCallWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\VideoCallWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VisioForge.Core.UI.WPF.VideoView videoView;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\VideoCallWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\VideoCallWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMaximize;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\VideoCallWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\VideoCallWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_camera;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\VideoCallWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_microphone;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\VideoCallWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon icon_microphone;
        
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
            System.Uri resourceLocater = new System.Uri("/ChatApp ( WPF );component/videocallwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VideoCallWindow.xaml"
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
            
            #line 9 "..\..\VideoCallWindow.xaml"
            ((ChatApp___WPF__.VideoCallWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\VideoCallWindow.xaml"
            ((ChatApp___WPF__.VideoCallWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 12 "..\..\VideoCallWindow.xaml"
            ((ChatApp___WPF__.VideoCallWindow)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Window_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.videoView = ((VisioForge.Core.UI.WPF.VideoView)(target));
            return;
            case 3:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\VideoCallWindow.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnMaximize = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\VideoCallWindow.xaml"
            this.btnMaximize.Click += new System.Windows.RoutedEventHandler(this.btnMaximize_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\VideoCallWindow.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_camera = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btn_microphone = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\VideoCallWindow.xaml"
            this.btn_microphone.Click += new System.Windows.RoutedEventHandler(this.btn_microphone_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.icon_microphone = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 9:
            
            #line 151 "..\..\VideoCallWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
