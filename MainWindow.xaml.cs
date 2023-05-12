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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LABA_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 1; i<=72; i++)
            {
                fontSize.Items.Add(new Label { Content = $"{i}" });
            }

            fontStyle.ItemsSource = new Label[]
            {
                new Label { Content = "Arial" },
                new Label { Content = "MS Sans Serif" },
                new Label { Content = "Times New Roman" },
                new Label { Content = "Lucida Console" }
            };

            fontProperties.ItemsSource = new Label[]
            {
                new Label { Content = "Bold" },
                new Label { Content = "Underline" },
                new Label { Content = "Strikethrough" }
            };

        }

        private void fontChange(Object sender, RoutedEventArgs e)
        {
            string[] splitted = fontStyle.SelectedItem.ToString().Split(" ");
            int index = splitted.Length - 1;
            string style = splitted[index];

            switch (style) {

                case "Serif": example.FontFamily = new FontFamily("MS Sans Serif"); break;

                case "Arial": example.FontFamily = new FontFamily("Arial"); break;

                case "Roman": example.FontFamily = new FontFamily("Times New Roman"); break;

                case "Console":  example.FontFamily = new FontFamily("Lucida Console"); break;
            }
            
        }

        private void sizeChange(object sender, SelectionChangedEventArgs e)
        {
            string[] splitted = fontSize.SelectedItem.ToString().Split(" ");
            int index = splitted.Length - 1;
            string size = splitted[index];

            example.FontSize = double.Parse(size);
        }



        private void propertiesChange(object sender, SelectionChangedEventArgs e)
        {
            string[] splitted = fontProperties.SelectedItem.ToString().Split(" ");
            int index = splitted.Length - 1;
            string property = splitted[index];

            switch (property)
            {
                case "Underline": example.TextDecorations = TextDecorations.Underline; break;
                case "Strikethrough": example.TextDecorations = TextDecorations.Strikethrough; break;
                case "Bold": example.FontWeight = FontWeights.Bold; break;
            }
        }


        private void task2(object sender, RoutedEventArgs e)
        {
            Orders task2 = new Orders();
            task2.Show();
            this.Close();
        }
    }
}
