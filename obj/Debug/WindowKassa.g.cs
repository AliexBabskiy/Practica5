﻿#pragma checksum "..\..\WindowKassa.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0C012F897FAFC471348444C5E4C73810B85DA7836A31B9CB3817849D2F675543"
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
    /// WindowKassa
    /// </summary>
    public partial class WindowKassa : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\WindowKassa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtCheckk;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WindowKassa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtCheckk_Histori;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WindowKassa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtClient;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\WindowKassa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameP;
        
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
            System.Uri resourceLocater = new System.Uri("/PePract5;component/windowkassa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowKassa.xaml"
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
            this.BtCheckk = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\WindowKassa.xaml"
            this.BtCheckk.Click += new System.Windows.RoutedEventHandler(this.Checkk_Cl);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtCheckk_Histori = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\WindowKassa.xaml"
            this.BtCheckk_Histori.Click += new System.Windows.RoutedEventHandler(this.Checkk_Histori_Cl);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtClient = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\WindowKassa.xaml"
            this.BtClient.Click += new System.Windows.RoutedEventHandler(this.Client_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FrameP = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
