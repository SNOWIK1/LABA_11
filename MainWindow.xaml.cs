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
            this.fontStyle.Items.Add(new Label { Content = "Arial" });
            this.fontStyle.Items.Add(new Label { Content = "MS Sans Serif" });
            this.fontStyle.Items.Add(new Label { Content = "Times New Roman" });

            for (int i = 1; i<=100; i++)
            {
                this.size.Items.Add(new Label { Content = $"{i}" });
            }

            this.properties.Items.Add(new Label { Content = "Italic" });
            this.properties.Items.Add(new Label { Content = "Bold" });
            this.properties.Items.Add(new Label { Content = "Underlined" });
            this.properties.Items.Add(new Label { Content = "Strikethrough" });
        }

        private void fontChange (Object sender, RoutedEventArgs e)
        {
            ComboBox fontList = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)fontList.SelectedItem;
            string value = fontList.Text;

            MessageBox.Show(value);
        }





        
    }
}
