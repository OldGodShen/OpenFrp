﻿#pragma checksum "..\..\..\..\Frpc\FrpcCover.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8012133A02D46906BC1908B43A4031C0085DFA4BF47DDBFE8FE8A0F9FD5D686B"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using OGFrp.UI;
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


namespace OGFrp.UI {
    
    
    /// <summary>
    /// FrpcCover
    /// </summary>
    public partial class FrpcCover : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 91 "..\..\..\..\Frpc\FrpcCover.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bd_main;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Frpc\FrpcCover.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_ProxyName;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Frpc\FrpcCover.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_Switch;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Frpc\FrpcCover.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_serverName;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\Frpc\FrpcCover.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_ViewLog;
        
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
            System.Uri resourceLocater = new System.Uri("/OGFrp.UI;component/frpc/frpccover.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Frpc\FrpcCover.xaml"
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
            this.bd_main = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.lb_ProxyName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.cb_Switch = ((System.Windows.Controls.CheckBox)(target));
            
            #line 100 "..\..\..\..\Frpc\FrpcCover.xaml"
            this.cb_Switch.Click += new System.Windows.RoutedEventHandler(this.cb_Switch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lb_serverName = ((System.Windows.Controls.Label)(target));
            
            #line 101 "..\..\..\..\Frpc\FrpcCover.xaml"
            this.lb_serverName.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.lb_serverName_MouseUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lb_ViewLog = ((System.Windows.Controls.Label)(target));
            
            #line 102 "..\..\..\..\Frpc\FrpcCover.xaml"
            this.lb_ViewLog.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Lb_ViewLog_MouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
