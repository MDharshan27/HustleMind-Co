﻿#pragma checksum "..\..\..\..\ForgotWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3E9DEF7CA4D6406E9D716F936F7F562856D93122"
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
using System.Windows.Controls.Ribbon;
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


namespace HustleMind_Co_ {
    
    
    /// <summary>
    /// ForgotWindow
    /// </summary>
    public partial class ForgotWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\ForgotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMobileNumber;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\ForgotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtNewPassword;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\ForgotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVisibleNewPassword;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\ForgotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnToggleNewPassword;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\ForgotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtConfirmPassword;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\ForgotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVisibleConfirmPassword;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\ForgotWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnToggleConfirmPassword;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HustleMind Co.;component/forgotwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ForgotWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtMobileNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtNewPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.txtVisibleNewPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnToggleNewPassword = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\..\ForgotWindow.xaml"
            this.btnToggleNewPassword.Click += new System.Windows.RoutedEventHandler(this.btnToggleNewPassword_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtConfirmPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.txtVisibleConfirmPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnToggleConfirmPassword = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\..\ForgotWindow.xaml"
            this.btnToggleConfirmPassword.Click += new System.Windows.RoutedEventHandler(this.btnToggleConfirmPassword_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 127 "..\..\..\..\ForgotWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Submit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

