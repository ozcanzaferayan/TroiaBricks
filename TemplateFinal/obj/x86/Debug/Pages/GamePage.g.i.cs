﻿#pragma checksum "C:\Users\-ZaferAYAN-\Desktop\SampleGame\TemplateFinal\Pages\GamePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FEB148E6E6931DEAE2717568CF50A2DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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


namespace TemplateFinal {
    
    
    public partial class GamePage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.DrawingSurfaceBackgroundGrid XnaSurface;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button btnNewGame;
        
        internal System.Windows.Controls.Button btnContinue;
        
        internal System.Windows.Controls.Button btnSelectLevel;
        
        internal System.Windows.Controls.Button btnAchievements;
        
        internal System.Windows.Controls.Button btnLeaderboard;
        
        internal System.Windows.Controls.Button btnAbout;
        
        internal System.Windows.Controls.Button btnExit;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TemplateFinal;component/Pages/GamePage.xaml", System.UriKind.Relative));
            this.XnaSurface = ((System.Windows.Controls.DrawingSurfaceBackgroundGrid)(this.FindName("XnaSurface")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnNewGame = ((System.Windows.Controls.Button)(this.FindName("btnNewGame")));
            this.btnContinue = ((System.Windows.Controls.Button)(this.FindName("btnContinue")));
            this.btnSelectLevel = ((System.Windows.Controls.Button)(this.FindName("btnSelectLevel")));
            this.btnAchievements = ((System.Windows.Controls.Button)(this.FindName("btnAchievements")));
            this.btnLeaderboard = ((System.Windows.Controls.Button)(this.FindName("btnLeaderboard")));
            this.btnAbout = ((System.Windows.Controls.Button)(this.FindName("btnAbout")));
            this.btnExit = ((System.Windows.Controls.Button)(this.FindName("btnExit")));
        }
    }
}

