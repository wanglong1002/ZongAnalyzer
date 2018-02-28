﻿using AnalyzerLogic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZongContorls.Osc
{
    /// <summary>
    /// AddChannelWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddChannelWindow : Window
    {
        public AddChannelWindow()
        {
            InitializeComponent();
            BindChannels(ChannelManager.Signals);
        }

        public AddChannelWindow(ObservableCollection<Signal> signels)
        {
            InitializeComponent();
            BindChannels(signels);
        }
        public ObservableCollection<Signal> Signels;
        public void BindChannels(ObservableCollection<Signal> signels)
        {
            this.Signels = signels;
            signalListBox.ItemsSource = Signels;
        }
    }
}
