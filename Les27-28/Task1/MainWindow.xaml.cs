using Microsoft.Win32;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string XmlFilePath = "";

        public MainWindow()
        {
            InitializeComponent();
            XmlDocView.SelectionChanged += ListBox_SelectionChanged;
            XmlDocViewTB.MouseUp += TextBlock_MouseUp;
            XmlDocViewTV.SelectedItemChanged += TreeView_SelectedItemChanged;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = XmlDocView.SelectedItem as string;
            if (selectedItem != null)
            {
                DelTextBox.Text = selectedItem;
            }
        }

        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {
            TextBlock selectedTextBlock = sender as TextBlock;
            if (selectedTextBlock != null)
            {
                DelTextBox.Text = selectedTextBlock.Text;
            }
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem selectedTreeViewItem = XmlDocViewTV.SelectedItem as TreeViewItem;
            if (selectedTreeViewItem != null)
            {
                DelTextBox.Text = selectedTreeViewItem.Header.ToString();
            }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                XmlFilePath = filePath;

                string fileName = System.IO.Path.GetFileName(filePath);
                XmlDocName.Text = fileName;

                // Обработка XML-документа
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(filePath);

                // Получение содержимого XML
                XmlNodeList products = xmlDocument.GetElementsByTagName("Товар");

                // Очистка содержимого элементов отображения
                XmlDocView.Items.Clear();
                XmlDocViewTB.Text = string.Empty;
                XmlDocViewTV.Items.Clear();

                // Формирование списка строк для ListBox
                foreach (XmlNode productNode in products)
                {
                    string productName = productNode.SelectSingleNode("Название").InnerText;
                    string expirationDate = productNode.SelectSingleNode("СрокГодности").InnerText;
                    string price = productNode.SelectSingleNode("Стоимость").InnerText;

                    string productInfo = $"Название товара: {productName}, Срок годности: {expirationDate}, Стоимость: {price}";

                    RadioButton selectedRadioButton = GetSelectedRadioButton();

                    if (selectedRadioButton == ListBoxCh)
                    {
                        XmlDocView.Visibility = Visibility.Visible;
                        XmlDocViewTB.Visibility = Visibility.Collapsed;
                        XmlDocViewTV.Visibility = Visibility.Collapsed;
                        XmlDocView.Items.Add(productInfo);
                    }
                    else if (selectedRadioButton == TextBlockCh)
                    {
                        XmlDocViewTB.Visibility = Visibility.Visible;
                        XmlDocView.Visibility = Visibility.Collapsed;
                        XmlDocViewTV.Visibility = Visibility.Collapsed;
                        XmlDocViewTB.Text += productInfo + "\n";
                    }
                    else if (selectedRadioButton == TreeViewCh)
                    {
                        XmlDocViewTV.Visibility = Visibility.Visible;
                        XmlDocViewTB.Visibility = Visibility.Collapsed;
                        XmlDocView.Visibility = Visibility.Collapsed;
                        TreeViewItem item = new TreeViewItem();
                        item.Header = productInfo;
                        XmlDocViewTV.Items.Add(item);
                    }
                }
            }
        }

        // Метод для получения выбранного RadioButton
        private RadioButton GetSelectedRadioButton()
        {
            if (ListBoxCh.IsChecked == true)
            {
                return ListBoxCh;
            }
            else if (TextBlockCh.IsChecked == true)
            {
                return TextBlockCh;
            }
            else if (TreeViewCh.IsChecked == true)
            {
                return TreeViewCh;
            }

            return null;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Создание экземпляра AddItemWindow
            AddItemWindow addItemWindow = new AddItemWindow();

            addItemWindow.XmlFilePath = XmlFilePath;
            addItemWindow.ItemAdded += AddItemWindow_ItemAdded;

            // Открытие окна AddItemWindow
            addItemWindow.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Получить выбранный элемент
            string selectedItem = null;
            if (ListBoxCh.IsChecked == true)
            {
                selectedItem = XmlDocView.SelectedItem as string;
            }
            else if (TreeViewCh.IsChecked == true)
            {
                TreeViewItem selectedTreeViewItem = XmlDocViewTV.SelectedItem as TreeViewItem;
                if (selectedTreeViewItem != null)
                {
                    selectedItem = selectedTreeViewItem.Header.ToString();
                }
            }

            // Проверить, что элемент выбран
            if (selectedItem != null)
            {
                try
                {
                    // Создать экземпляр XmlDocument
                    XmlDocument xmlDoc = new XmlDocument();

                    // Загрузить XML-документ из файла
                    xmlDoc.Load(XmlFilePath);

                    // Найти элемент для удаления
                    XmlNodeList products = xmlDoc.GetElementsByTagName("Товар");
                    foreach (XmlNode productNode in products)
                    {
                        string productName = productNode.SelectSingleNode("Название").InnerText;
                        string expirationDate = productNode.SelectSingleNode("СрокГодности").InnerText;
                        string price = productNode.SelectSingleNode("Стоимость").InnerText;

                        string productInfo = $"Название товара: {productName}, Срок годности: {expirationDate}, Стоимость: {price}";

                        if (productInfo == selectedItem)
                        {
                            // Удалить найденный элемент
                            productNode.ParentNode.RemoveChild(productNode);
                            break;
                        }
                    }

                    // Сохранить изменения обратно в файл
                    xmlDoc.Save(XmlFilePath);

                    // Обновить содержимое соответствующего элемента управления
                    if (ListBoxCh.IsChecked == true)
                    {
                        UpdateXmlDocView(XmlDocView);
                    }
                    else if (TextBlockCh.IsChecked == true)
                    {
                        UpdateXmlDocViewTB(XmlDocViewTB);
                    }
                    else if (TreeViewCh.IsChecked == true)
                    {
                        UpdateXmlDocViewTV(XmlDocViewTV);
                    }
                }
                catch (Exception ex)
                {
                    // Обработка ошибок при удалении элемента
                    MessageBox.Show("Ошибка удаления элемента: " + ex.Message);
                }
            }
        }

        private void AddItemWindow_ItemAdded(object sender, EventArgs e)
        {
            if (ListBoxCh.IsChecked == true)
            {
                UpdateXmlDocView(XmlDocView);
            }
            else if (TextBlockCh.IsChecked == true)
            {
                UpdateXmlDocViewTB(XmlDocViewTB);
            }
            else if (TreeViewCh.IsChecked == true)
            {
                UpdateXmlDocViewTV(XmlDocViewTV);
            }
        }

        private void UpdateXmlDocView(ListBox listBox)
        {
            // Обновление содержимого ListBox после добавления элемента
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlFilePath);

            // Получение содержимого XML
            XmlNodeList products = xmlDocument.GetElementsByTagName("Товар");

            // Формирование списка строк для ListBox
            List<string> productList = new List<string>();
            foreach (XmlNode productNode in products)
            {
                string productName = productNode.SelectSingleNode("Название").InnerText;
                string expirationDate = productNode.SelectSingleNode("СрокГодности").InnerText;
                string price = productNode.SelectSingleNode("Стоимость").InnerText;

                string productInfo = $"Название товара: {productName}, Срок годности: {expirationDate}, Стоимость: {price}";
                productList.Add(productInfo);
            }

            // Очистка содержимого ListBox
            listBox.Items.Clear();

            // Присвоение содержимого ListBox
            foreach (string productInfo in productList)
            {
                listBox.Items.Add(productInfo);
            }
        }

        private void UpdateXmlDocViewTV(TreeView treeView)
        {
            // Обновление содержимого TreeView после добавления элемента
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlFilePath);

            // Получение содержимого XML
            XmlNodeList products = xmlDocument.GetElementsByTagName("Товар");

            // Очистка содержимого TreeView
            treeView.Items.Clear();

            // Добавление элементов в TreeView
            foreach (XmlNode productNode in products)
            {
                string productName = productNode.SelectSingleNode("Название").InnerText;
                string expirationDate = productNode.SelectSingleNode("СрокГодности").InnerText;
                string price = productNode.SelectSingleNode("Стоимость").InnerText;

                string productInfo = $"Название товара: {productName}, Срок годности: {expirationDate}, Стоимость: {price}";

                TreeViewItem item = new TreeViewItem();
                item.Header = productInfo;
                treeView.Items.Add(item);
            }
        }

        private void UpdateXmlDocViewTB(TextBox textBox)
        {
            // Обновление содержимого TextBox после добавления элемента
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(XmlFilePath);

            // Получение содержимого XML
            XmlNodeList products = xmlDocument.GetElementsByTagName("Товар");

            // Формирование текста для TextBox
            StringBuilder sb = new StringBuilder();
            foreach (XmlNode productNode in products)
            {
                string productName = productNode.SelectSingleNode("Название").InnerText;
                string expirationDate = productNode.SelectSingleNode("СрокГодности").InnerText;
                string price = productNode.SelectSingleNode("Стоимость").InnerText;

                string productInfo = $"Название товара: {productName}, Срок годности: {expirationDate}, Стоимость: {price}";
                sb.AppendLine(productInfo);
            }

            // Присвоение текста TextBox
            textBox.Text = sb.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string searchQuery = SearchTextBox.Text.ToLower();

            // Поиск в ListBox
            if (XmlDocView.Visibility == Visibility.Visible)
            {
                foreach (var listBoxItem in XmlDocView.Items)
                {
                    var listBoxItemContainer = XmlDocView.ItemContainerGenerator.ContainerFromItem(listBoxItem) as ListBoxItem;
                    string productInfo = listBoxItem.ToString().ToLower();

                    // Если название товара содержит искомую фразу
                    if (productInfo.Contains(searchQuery))
                    {
                        // Пометить элемент как выбранный
                        listBoxItemContainer.IsSelected = true;

                        // Прокрутить к выбранному элементу
                        XmlDocView.ScrollIntoView(listBoxItem);
                    }
                }
            }

            // Поиск в TreeView
            if (XmlDocViewTV.Visibility == Visibility.Visible)
            {
                foreach (TreeViewItem treeViewItem in XmlDocViewTV.Items)
                {
                    string productInfo = treeViewItem.Header.ToString().ToLower();

                    // Если название товара содержит искомую фразу
                    if (productInfo.Contains(searchQuery))
                    {
                        // Выделить элемент
                        treeViewItem.IsSelected = true;

                        // Прокрутить к выбранному элементу
                        treeViewItem.BringIntoView();
                    }
                }
            }

            // Поиск в TextBox
            if (XmlDocViewTB.Visibility == Visibility.Visible)
            {
                string text = XmlDocViewTB.Text.ToLower();

                int startIndex = 0;
                while (startIndex < text.Length)
                {
                    int index = text.IndexOf(searchQuery, startIndex);
                    if (index != -1)
                    {
                        XmlDocViewTB.Select(index, searchQuery.Length);
                        XmlDocViewTB.Focus();
                        startIndex = index + searchQuery.Length;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonReload_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
            string filePath = XmlFilePath;

            // Обработка XML-документа
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);

            // Получение содержимого XML
            XmlNodeList products = xmlDocument.GetElementsByTagName("Товар");

            // Очистка содержимого элементов отображения
            XmlDocView.Items.Clear();
            XmlDocViewTB.Text = string.Empty;
            XmlDocViewTV.Items.Clear();

                // Формирование списка строк для ListBox
                foreach (XmlNode productNode in products)
                {
                    string productName = productNode.SelectSingleNode("Название").InnerText;
                    string expirationDate = productNode.SelectSingleNode("СрокГодности").InnerText;
                    string price = productNode.SelectSingleNode("Стоимость").InnerText;

                    string productInfo = $"Название товара: {productName}, Срок годности: {expirationDate}, Стоимость: {price}";

                    RadioButton selectedRadioButton = GetSelectedRadioButton();

                    if (selectedRadioButton == ListBoxCh)
                    {
                        XmlDocView.Visibility = Visibility.Visible;
                        XmlDocViewTB.Visibility = Visibility.Collapsed;
                        XmlDocViewTV.Visibility = Visibility.Collapsed;
                        XmlDocView.Items.Add(productInfo);
                    }
                    else if (selectedRadioButton == TextBlockCh)
                    {
                        XmlDocViewTB.Visibility = Visibility.Visible;
                        XmlDocView.Visibility = Visibility.Collapsed;
                        XmlDocViewTV.Visibility = Visibility.Collapsed;
                        XmlDocViewTB.Text += productInfo + "\n";
                    }
                    else if (selectedRadioButton == TreeViewCh)
                    {
                        XmlDocViewTV.Visibility = Visibility.Visible;
                        XmlDocViewTB.Visibility = Visibility.Collapsed;
                        XmlDocView.Visibility = Visibility.Collapsed;
                        TreeViewItem item = new TreeViewItem();
                        item.Header = productInfo;
                        XmlDocViewTV.Items.Add(item);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Путь к файлу не был выбран, пожалуйста, используйте кнопку 'Открыть'");
            }
        }
    }
}