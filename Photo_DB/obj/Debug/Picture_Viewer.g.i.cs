﻿#pragma checksum "..\..\Picture_Viewer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9B1002C7FE6BB59F57B117CD667FAFAB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Maps.MapControl.WPF;
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


namespace PhotoApp {
    
    
    /// <summary>
    /// ViewPictures
    /// </summary>
    public partial class ViewPictures : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Tree;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Photos;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBrowse;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border EXIF_DATA;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvExifData;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LOCATION;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Maps.MapControl.WPF.Map LocationMap;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Photo;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagebox;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform RotateImage;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 266 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Longitude;
        
        #line default
        #line hidden
        
        
        #line 284 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Latitude;
        
        #line default
        #line hidden
        
        
        #line 302 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMode;
        
        #line default
        #line hidden
        
        
        #line 313 "..\..\Picture_Viewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRotate;
        
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
            System.Uri resourceLocater = new System.Uri("/PhotoApp;component/picture_viewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Picture_Viewer.xaml"
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
            
            #line 9 "..\..\Picture_Viewer.xaml"
            ((PhotoApp.ViewPictures)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Tree = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.Photos = ((System.Windows.Controls.ListView)(target));
            
            #line 68 "..\..\Picture_Viewer.xaml"
            this.Photos.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Photos_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnBrowse = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\Picture_Viewer.xaml"
            this.btnBrowse.Click += new System.Windows.RoutedEventHandler(this.btnBrowse_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EXIF_DATA = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.lvExifData = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.LOCATION = ((System.Windows.Controls.Border)(target));
            return;
            case 8:
            this.LocationMap = ((Microsoft.Maps.MapControl.WPF.Map)(target));
            return;
            case 9:
            this.Photo = ((System.Windows.Controls.Border)(target));
            return;
            case 10:
            this.imagebox = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.RotateImage = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 12:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 264 "..\..\Picture_Viewer.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Longitude = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.Latitude = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.btnMode = ((System.Windows.Controls.Button)(target));
            
            #line 311 "..\..\Picture_Viewer.xaml"
            this.btnMode.Click += new System.Windows.RoutedEventHandler(this.btnMode_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.btnRotate = ((System.Windows.Controls.Button)(target));
            
            #line 322 "..\..\Picture_Viewer.xaml"
            this.btnRotate.Click += new System.Windows.RoutedEventHandler(this.btnRotate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

