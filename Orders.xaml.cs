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

namespace LABA_11
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        public Orders()
        {
            InitializeComponent();

            games.ItemsSource = new TextBlock[]
            {
                new TextBlock {Text = "Left 4 Dead"},
                new TextBlock {Text = "Call of Duty WW2"},
                new TextBlock {Text = "Call of Duty Modern Warfare"},
                new TextBlock {Text = "S.T.A.L.K.E.R. Тень Чернобыля"},
                new TextBlock {Text = "S.T.A.L.K.E.R. Чистое небо"},
                new TextBlock {Text = "S.T.A.L.K.E.R. Вариант Омега"},
                new TextBlock {Text = "S.T.A.L.K.E.R. Зов Припяти"},
                new TextBlock {Text = "S.T.A.L.K.E.R. Dead Air"},
                new TextBlock {Text = "S.T.A.L.K.E.R. Anomaly"},
                new TextBlock {Text = "The Forest"},
                new TextBlock {Text = "The Elder Scrolls IV: Oblivion"},
                new TextBlock {Text = "The Elder Scrolls V: Skyrim"},
                new TextBlock {Text = "Magicka"},
                new TextBlock {Text = "Dragon Age Origins"},
                new TextBlock {Text = "Age of Civilizations II"},
                new TextBlock {Text = "Fallout: New Vegas"}
             };

            education.ItemsSource = new TextBlock[]
            {
                new TextBlock {Text = "Массаж"},
                new TextBlock {Text = "Бокс"},
                new TextBlock {Text = "Зоопарк для малышей"},
                new TextBlock {Text = "Йога"},
                new TextBlock {Text = "Формула безопасности"},
                new TextBlock {Text = "Плетение фенечек из бисера"},
                new TextBlock {Text = "Веревочный массаж"},
                new TextBlock {Text = "Учим цифры"},
                new TextBlock {Text = "Школа Тенниса"},
                new TextBlock {Text = "Боевое самбо"},
                new TextBlock {Text = "Гадание на домино"},
                new TextBlock {Text = "Спортивный туризм"}
            };

        }

        private void AddtoOrder(object sender, RoutedEventArgs e)
        {
            var gamesItem = games.SelectedItem;
            var educationItem = education.SelectedItem;


            if (gamesItem is not null)
            {
                orders.Items.Add(games.SelectedItem);
                games.SelectedItem = null;
            }

            if (educationItem is not null)
            {
                orders.Items.Add(education.SelectedItem);
            }

        }

        private void DeleteFromOrder(object sender, RoutedEventArgs e)
        {
            orders.Items.Remove(orders.SelectedItem);
        }
    }
}
