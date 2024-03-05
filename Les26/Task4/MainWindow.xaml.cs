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


namespace Task4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;

            // Создаем новую кнопку
            Button newButton = new Button
            {
                Content = "Нажмите на меня",
                Width = 130,
                Height = 30
            };

            // Устанавливаем обработчик события клика на новую кнопку
            newButton.Click += NewButton_Click;

            // Добавляем новую кнопку в StackPanel
            stackPanel.Children.Add(newButton);
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            // Удаляем кнопку из StackPanel
            stackPanel.Children.Remove(button);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

