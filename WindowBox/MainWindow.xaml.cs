﻿namespace WindowBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : SpexialWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DeviceVm(new Device("TFS"));
        }
    }
}
