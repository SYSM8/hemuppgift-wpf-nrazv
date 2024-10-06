﻿using System;
using System.Collections.Generic;
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

namespace Hemuppgift_WPFtemplate.Windows
{
    /// <summary>
    /// Interaction logic for StackPanelWindow.xaml
    /// </summary>
    public partial class StackPanelWindow : Window
    {
        public StackPanelWindow()
        {
            InitializeComponent();
        }

        private void Horizontal_Checked(object sender, RoutedEventArgs e)
        {
            if (RectangleStack is not null)
            {

                RectangleStack.Orientation = Orientation.Horizontal;
            }

        }

        private void Vertical_Checked(object sender, RoutedEventArgs e)
        {
            if (RectangleStack is not null)
            {
                RectangleStack.Orientation = Orientation.Vertical;
            }
        }
    }
}
