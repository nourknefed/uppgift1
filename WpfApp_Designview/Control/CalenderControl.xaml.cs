﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Designview.Control
{
    /// <summary>
    /// Interaction logic for CalenderControl.xaml
    /// </summary>
    public partial class CalenderControl : UserControl
    {
        public CalenderControl()
        {
            InitializeComponent();
        }
        public ImageSource calenderImage
        {
            get { return CalenderImage.Source; }
            set { CalenderImage.Source = value; }
        }
    }
}