﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9C75E2FBCB6714545399CA223253B4C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Cinch;
using MVVM.Demo;
using MVVM.ViewModels;
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


namespace MVVM.Demo {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Views\MainWindow.xaml"
        internal MVVM.Demo.MainWindow view;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Views\MainWindow.xaml"
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\MainWindow.xaml"
        internal System.Windows.Controls.Menu menu;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Views\MainWindow.xaml"
        internal System.Windows.Controls.Grid rectangle;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Views\MainWindow.xaml"
        internal MVVM.Demo.TabControlEx tabControl;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/MVVM.Demo;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.view = ((MVVM.Demo.MainWindow)(target));
            return;
            case 2:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 4:
            this.rectangle = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.tabControl = ((MVVM.Demo.TabControlEx)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
