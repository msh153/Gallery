﻿#pragma checksum "..\..\frmViewer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3DCDD6EA116D9B0ABF6EAEADE34CB96DFFFA68BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Gallery;
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


namespace Gallery {
    
    
    /// <summary>
    /// frmViewer
    /// </summary>
    public partial class frmViewer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\frmViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ViewedPhotoForSlideShow;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\frmViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonNext;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\frmViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.DoubleAnimation myDoubleAnimationNext;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\frmViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonPrevious;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\frmViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.DoubleAnimation myDoubleAnimationPrev;
        
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
            System.Uri resourceLocater = new System.Uri("/Gallery;component/frmviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\frmViewer.xaml"
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
            
            #line 8 "..\..\frmViewer.xaml"
            ((Gallery.frmViewer)(target)).Loaded += new System.Windows.RoutedEventHandler(this.WindowLoaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\frmViewer.xaml"
            ((Gallery.frmViewer)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ViewedPhotoForSlideShow = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.buttonNext = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\frmViewer.xaml"
            this.buttonNext.Click += new System.Windows.RoutedEventHandler(this.Button_Next_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.myDoubleAnimationNext = ((System.Windows.Media.Animation.DoubleAnimation)(target));
            return;
            case 5:
            this.buttonPrevious = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\frmViewer.xaml"
            this.buttonPrevious.Click += new System.Windows.RoutedEventHandler(this.Button_Prev_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.myDoubleAnimationPrev = ((System.Windows.Media.Animation.DoubleAnimation)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

