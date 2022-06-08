﻿#pragma checksum "..\..\..\Views\GuestView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F56CDB498E55F3F9ECBB850B09C8A0D32580622D8F37CA654279227F82771824"
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
using iHotel.Views;


namespace iHotel.Views {
    
    
    /// <summary>
    /// GuestView
    /// </summary>
    public partial class GuestView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Views\GuestView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRooms;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\GuestView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOffers;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\GuestView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnServices;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\GuestView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReservationGuest;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\GuestView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginButton;
        
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
            System.Uri resourceLocater = new System.Uri("/iHotel;component/views/guestview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\GuestView.xaml"
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
            this.btnRooms = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Views\GuestView.xaml"
            this.btnRooms.Click += new System.Windows.RoutedEventHandler(this.displayRooms);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnOffers = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Views\GuestView.xaml"
            this.btnOffers.Click += new System.Windows.RoutedEventHandler(this.displayOffers);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnServices = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Views\GuestView.xaml"
            this.btnServices.Click += new System.Windows.RoutedEventHandler(this.showServices);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnReservationGuest = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Views\GuestView.xaml"
            this.btnReservationGuest.Click += new System.Windows.RoutedEventHandler(this.showSignUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.loginButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Views\GuestView.xaml"
            this.loginButton.Click += new System.Windows.RoutedEventHandler(this.logIn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 26 "..\..\..\Views\GuestView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.showSignUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
