﻿#pragma checksum "..\..\ScreenshotWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2064F84A8691DEFD60E45AD2A28C7470"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ImgurSniper;
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
using Toast;


namespace ImgurSniper {
    
    
    /// <summary>
    /// ScreenshotWindow
    /// </summary>
    public partial class ScreenshotWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.Storyboard FormFade;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.DoubleAnimation FormFadeAnimation;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SnipperGrid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border selectionRectangle;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label coords;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Magnifyer;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse MagnifyingEllipse;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.VisualBrush MagnifyerBrush;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MagnifyedImage;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ScreenshotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Toast.Toasty toast;
        
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
            System.Uri resourceLocater = new System.Uri("/ImgurSniper;component/screenshotwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ScreenshotWindow.xaml"
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
            
            #line 7 "..\..\ScreenshotWindow.xaml"
            ((ImgurSniper.ScreenshotWindow)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Cancel);
            
            #line default
            #line hidden
            
            #line 10 "..\..\ScreenshotWindow.xaml"
            ((ImgurSniper.ScreenshotWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StartDrawing);
            
            #line default
            #line hidden
            
            #line 10 "..\..\ScreenshotWindow.xaml"
            ((ImgurSniper.ScreenshotWindow)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ReleaseRectangle);
            
            #line default
            #line hidden
            
            #line 10 "..\..\ScreenshotWindow.xaml"
            ((ImgurSniper.ScreenshotWindow)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.DrawRectangle);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FormFade = ((System.Windows.Media.Animation.Storyboard)(target));
            return;
            case 3:
            this.FormFadeAnimation = ((System.Windows.Media.Animation.DoubleAnimation)(target));
            return;
            case 4:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.SnipperGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.img = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.selectionRectangle = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.coords = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Magnifyer = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.MagnifyingEllipse = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 11:
            this.MagnifyerBrush = ((System.Windows.Media.VisualBrush)(target));
            return;
            case 12:
            this.MagnifyedImage = ((System.Windows.Controls.Image)(target));
            return;
            case 13:
            this.toast = ((Toast.Toasty)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

