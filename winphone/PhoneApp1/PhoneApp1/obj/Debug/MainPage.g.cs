﻿#pragma checksum "D:\git_data\metropolia\winphone\PhoneApp1\PhoneApp1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FBFFB8656293D1A6A31DA20A0269F49B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PhoneApp1 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox p1_login_email;
        
        internal System.Windows.Controls.PasswordBox p1_passwordBox;
        
        internal System.Windows.Controls.Image image1;
        
        internal System.Windows.Controls.TextBlock p1_txtblock_username;
        
        internal System.Windows.Controls.TextBlock p1_txtblock_password;
        
        internal System.Windows.Controls.Button p1_button_picasalogin;
        
        internal System.Windows.Controls.Button p1_button_flikrlogin;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.p1_login_email = ((System.Windows.Controls.TextBox)(this.FindName("p1_login_email")));
            this.p1_passwordBox = ((System.Windows.Controls.PasswordBox)(this.FindName("p1_passwordBox")));
            this.image1 = ((System.Windows.Controls.Image)(this.FindName("image1")));
            this.p1_txtblock_username = ((System.Windows.Controls.TextBlock)(this.FindName("p1_txtblock_username")));
            this.p1_txtblock_password = ((System.Windows.Controls.TextBlock)(this.FindName("p1_txtblock_password")));
            this.p1_button_picasalogin = ((System.Windows.Controls.Button)(this.FindName("p1_button_picasalogin")));
            this.p1_button_flikrlogin = ((System.Windows.Controls.Button)(this.FindName("p1_button_flikrlogin")));
        }
    }
}

