﻿#pragma checksum "..\..\AdminPageEMP.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CD11ECCDBBCA98DEEEF7306F18A5F2BF8537D3AC937F537D3ED6C51A70423F71"
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
    /// AdminPageEMP
    /// </summary>
    public partial class AdminPageEMP : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\AdminPageEMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tablic;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AdminPageEMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text1;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AdminPageEMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text2;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AdminPageEMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text3;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AdminPageEMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cb1;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AdminPageEMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cb2;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\AdminPageEMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtDob;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AdminPageEMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtDel;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AdminPageEMP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtIzm;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AdminPageEMP.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PePract5;component/adminpageemp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminPageEMP.xaml"
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
            
            #line 28 "..\..\AdminPageEMP.xaml"
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
            this.text3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Cb1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Cb2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.BtDob = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\AdminPageEMP.xaml"
            this.BtDob.Click += new System.Windows.RoutedEventHandler(this.BtDob_Cl);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtDel = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\AdminPageEMP.xaml"
            this.BtDel.Click += new System.Windows.RoutedEventHandler(this.BtDel_Cl);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtIzm = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\AdminPageEMP.xaml"
            this.BtIzm.Click += new System.Windows.RoutedEventHandler(this.BtIzm_Cl);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Eror = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

