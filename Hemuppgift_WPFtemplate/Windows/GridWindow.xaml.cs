using System;
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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        private const int CELL_NUMBER = 4;
        private const int MAX_INDEX = CELL_NUMBER - 1;
        public GridWindow()
        {
            InitializeComponent();
            CreatGrid();
        }

        private void CreatGrid()
        {

            for (int i = 0; i < CELL_NUMBER; i++)
            {
                WindowGrid.RowDefinitions.Add(new RowDefinition());
                WindowGrid.ColumnDefinitions.Add(new ColumnDefinition());

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowGrid.Children.Clear();
            int row = Int32.Parse(RowTextBox.Text);
            int column = Int32.Parse(ColumnTextBox.Text);


            var button = new Button();
            button.Content = $"Row: {row} Column: {column}";
            button.Background = new SolidColorBrush(Colors.ForestGreen);
            Grid.SetRow(button, row);
            Grid.SetColumn(button, column);
            WindowGrid.Children.Add(button);

        }

        private void ValidateRowInput(object sender, RoutedEventArgs e)
        {
            ValidateInput(RowLabel, RowTextBox, "Row :");
        }

        private void ValidateColumnInput(object sender, RoutedEventArgs e)
        {
            ValidateInput(ColumnLabel, ColumnTextBox, "Column :");
        }

        private void ValidateInput(Label label, TextBox textBox, string content)
        {
            BtnApply.IsEnabled = true;
            label.Content = content;
            label.Foreground = new SolidColorBrush(Colors.Black);
            var redForeground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5733"));

            try
            {
                int index = Int32.Parse(textBox.Text);

                bool outOfIndex = (index < 0 || index > MAX_INDEX);


                if (outOfIndex)
                {
                    BtnApply.IsEnabled = false;
                    label.Content = "Number out of index !";
                    label.Foreground = redForeground;
                }
            }

            catch (FormatException ex)
            {
                BtnApply.IsEnabled = false;
                label.Content = "Not a number !";
                label.Foreground = redForeground;
            }
        }
    }
}
