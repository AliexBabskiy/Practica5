﻿#pragma checksum "..\..\PageClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87E45C9819365D66F9EF999777E793A6CA94D09D11CD009A74B0BE8F9B343159"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PePract5;
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


namespace PePract5 {
    
    
    /// <summary>
    /// PageClient
    /// </summary>
    public partial class PageClient : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tablic;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text2;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtDob;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtDel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtIzm;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PageClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Eror;
        
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
            System.Uri resourceLocater = new System.Uri("/PePract5;component/pageclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageClient.xaml"
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
            this.tablic = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\PageClient.xaml"
            this.tablic.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tablic_Dob);
            
            #line default
            #line hidden
            return;
            case 2:
            this.text1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.text2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtDob = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\PageClient.xaml"
            this.BtDob.Click += new System.Windows.RoutedEventHandler(this.BtDob_Cl);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtDel = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\PageClient.xaml"
            this.BtDel.Click += new System.Windows.RoutedEventHandler(this.BtDel_Cl);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtIzm = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\PageClient.xaml"
            this.BtIzm.Click += new System.Windows.RoutedEventHandler(this.BtIzm_Cl);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Eror = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

