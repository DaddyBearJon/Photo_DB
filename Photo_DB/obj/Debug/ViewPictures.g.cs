﻿#pragma checksum "..\..\ViewPictures.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "82F963C6DAE92394818B5D64BBEE73E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
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
        
        
        #line 45 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Tree;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Photos;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBrowse;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LOCATION;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Maps.MapControl.WPF.Map LocationMap;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Longitude;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Latitude;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMode;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border EXIF_DATA;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvExifData;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Photo;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagebox;
        
        #line default
        #line hidden
        
        
        #line 240 "..\..\ViewPictures.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform Rotate_Image;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\ViewPictures.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PhotoApp;component/viewpictures.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ViewPictures.xaml"
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
            
            #line 9 "..\..\ViewPictures.xaml"
            ((PhotoApp.ViewPictures)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Tree = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.Photos = ((System.Windows.Controls.ListView)(target));
            
            #line 63 "..\..\ViewPictures.xaml"
            this.Photos.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Photos_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnBrowse = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\ViewPictures.xaml"
            this.btnBrowse.Click += new System.Windows.RoutedEventHandler(this.btnBrowse_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LOCATION = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.LocationMap = ((Microsoft.Maps.MapControl.WPF.Map)(target));
            return;
            case 7:
            this.Longitude = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Latitude = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnMode = ((System.Windows.Controls.Button)(target));
            
            #line 174 "..\..\ViewPictures.xaml"
            this.btnMode.Click += new System.Windows.RoutedEventHandler(this.btnMode_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EXIF_DATA = ((System.Windows.Controls.Border)(target));
            return;
            case 11:
            this.lvExifData = ((System.Windows.Controls.ListView)(target));
            return;
            case 12:
            this.Photo = ((System.Windows.Controls.Border)(target));
            return;
            case 13:
            this.imagebox = ((System.Windows.Controls.Image)(target));
            return;
            case 14:
            this.Rotate_Image = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 15:
            this.btnRotate = ((System.Windows.Controls.Button)(target));
            
            #line 258 "..\..\ViewPictures.xaml"
            this.btnRotate.Click += new System.Windows.RoutedEventHandler(this.btnRotate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
