﻿#pragma checksum "..\..\..\UserControls\FancyButton.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD44F14F1D4D590C1FA7E4DB8AE93C4E"
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
    /// FancyButton
    /// </summary>
    public partial class FancyButton : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 151 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Media.Animation.BeginStoryboard enterHotspot_BeginStoryboard1;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Controls.Grid overAnimationGrid;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Ellipse _base4;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Ellipse _base3;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Ellipse _base2;
        
        #line default
        #line hidden
        
        
        #line 233 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Path rotating1;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Ellipse _base;
        
        #line default
        #line hidden
        
        
        #line 279 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Path rotating02;
        
        #line default
        #line hidden
        
        
        #line 296 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Ellipse centerShadow3;
        
        #line default
        #line hidden
        
        
        #line 302 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Ellipse centerShadow2;
        
        #line default
        #line hidden
        
        
        #line 308 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Ellipse centerShadow1;
        
        #line default
        #line hidden
        
        
        #line 315 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Ellipse centerBase;
        
        #line default
        #line hidden
        
        
        #line 326 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Shapes.Path centerReflex;
        
        #line default
        #line hidden
        
        
        #line 356 "..\..\..\UserControls\FancyButton.xaml"
        internal System.Windows.Controls.Button btn;
        
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
            System.Uri resourceLocater = new System.Uri("/MVVM.Demo;component/usercontrols/fancybutton.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\FancyButton.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.enterHotspot_BeginStoryboard1 = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 2:
            this.overAnimationGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this._base4 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 4:
            this._base3 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 5:
            this._base2 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 6:
            this.rotating1 = ((System.Windows.Shapes.Path)(target));
            return;
            case 7:
            this._base = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 8:
            this.rotating02 = ((System.Windows.Shapes.Path)(target));
            return;
            case 9:
            this.centerShadow3 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 10:
            this.centerShadow2 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 11:
            this.centerShadow1 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 12:
            this.centerBase = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 13:
            this.centerReflex = ((System.Windows.Shapes.Path)(target));
            return;
            case 14:
            this.btn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
