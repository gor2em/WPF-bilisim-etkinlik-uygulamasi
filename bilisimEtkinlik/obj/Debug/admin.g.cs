﻿#pragma checksum "..\..\admin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3E3F7B876D496BA096293738280B0DDCFE72B8F1"
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


namespace bilisimEtkinlik {
    
    
    /// <summary>
    /// admin
    /// </summary>
    public partial class admin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ky;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_kapat;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid rectangle_md;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_kulad;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_parola;
        
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
            System.Uri resourceLocater = new System.Uri("/bilisimEtkinlik;component/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\admin.xaml"
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
            this.btn_ky = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.btn_kapat = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\admin.xaml"
            this.btn_kapat.Click += new System.Windows.RoutedEventHandler(this.btn_kapat_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rectangle_md = ((System.Windows.Controls.Grid)(target));
            
            #line 20 "..\..\admin.xaml"
            this.rectangle_md.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.rectangle_md_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_kulad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_parola = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            
            #line 38 "..\..\admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.adminGiris);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
