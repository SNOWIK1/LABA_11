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

            games.ItemsSource = new string[]
            {
                "Left 4 Dead",
                "Call of Duty WW2",
                "Call of Duty Modern Warfare",
                "S.T.A.L.K.E.R. Тень Чернобыля",
                "S.T.A.L.K.E.R. Чистое небо",
                "S.T.A.L.K.E.R. Вариант Омега",
                "S.T.A.L.K.E.R. Зов Припяти",
                "S.T.A.L.K.E.R. Dead Air",
                "S.T.A.L.K.E.R. Anomaly",
                "The Forest",
                "The Elder Scrolls IV: Oblivion",
                "The Elder Scrolls V: Skyrim",
                "Magicka",
                "Dragon Age Origins",
                "Age of Civilizations II",
                "Fallout: New Vegas"
             };

            education.ItemsSource = new string[]
            {
                "Массаж",
                "Бокс",
                "Зоопарк для малышей",
                "Йога",
                "Формула безопасности",
                "Плетение фенечек из бисера",
                "Веревочный массаж",
                "Учим цифры",
                "Школа Тенниса",
                "Боевое самбо",
                "Гадание на домино",
                "Спортивный туризм"
            };

        }

        void NumberOfOrders()
        {
            if (orders.Items.Count != 0)
            {
                numberOfOrders.Content = $"Количество заказов: {orders.Items.Count}";
            }
            else if (orders.Items.Count == 0)
            {
                numberOfOrders.Content = "";
            }
        }

        private void AddtoOrder(object sender, RoutedEventArgs e)
        {
            string selectedGame = games.SelectedItem as string;
            string selectedEdu = education.SelectedItem as string;
            
            if (selectedGame != null)
            {
                orders.Items.Add(selectedGame);
                games.SelectedItem = null;
            }
            else if (selectedEdu != null)
            {
                orders.Items.Add(selectedEdu);
                education.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного элемента!", "Ошибка добавления", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            NumberOfOrders();

        }

        private void DeleteFromOrder(object sender, RoutedEventArgs e)
        {
            orders.Items.Remove(orders.SelectedItem);
            NumberOfOrders();
        }
    }
}
