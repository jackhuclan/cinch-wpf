﻿#pragma checksum "..\..\..\Views\SearchCustomersView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "09540C4CBF9AAA4B29BB5C8220CFB82B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MVVM.Demo;
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
    /// SearchCustomersView
    /// </summary>
    public partial class SearchCustomersView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 100 "..\..\..\Views\SearchCustomersView.xaml"
        internal System.Windows.Controls.ComboBox cmbProperty;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Views\SearchCustomersView.xaml"
        internal System.Windows.Controls.ComboBox cmbCondition;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Views\SearchCustomersView.xaml"
        internal System.Windows.Controls.TextBox txtValue;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\..\Views\SearchCustomersView.xaml"
        internal System.Windows.Controls.ContextMenu menu;
        
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
            System.Uri resourceLocater = new System.Uri("/MVVM.Demo;component/views/searchcustomersview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SearchCustomersView.xaml"
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
            this.cmbProperty = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.cmbCondition = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.txtValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.menu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}