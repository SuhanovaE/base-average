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
using workbase.Classes;
using System.IO;
using Microsoft.Win32;

namespace workbase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DtgListWorking.ItemsSource = ConnectHelper.men;
        }
        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            DtgListWorking.ItemsSource = ConnectHelper.men.ToList();
            DtgListWorking.SelectedIndex = -1;
            

        }
        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            //загрузка данных из файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if ((bool)openFileDialog.ShowDialog())
            {
                // получаем выбранный файл
                ConnectHelper.fileName = openFileDialog.FileName;
                ConnectHelper.ReadListFromFile(ConnectHelper.fileName);
                //ConnectHelper.ReadListFromFile(@"ListProduct.txt");
            }
            else
                return;


            DtgListWorking.ItemsSource = ConnectHelper.men.ToList();
        }
        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            DtgListWorking.ItemsSource = ConnectHelper.men.Where(x =>
                x.Name.ToLower().Contains(TxtSearch.Text.ToLower())).ToList();
        }
        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if ((bool)saveFileDialog.ShowDialog())
            {
                string file = saveFileDialog.FileName;
                ConnectHelper.SaveListToFile(file);
            }
        }
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            DtgListWorking.ItemsSource = null;
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var resMessage = MessageBox.Show("Удалить запись?", "Подтверждение",
               MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (resMessage == MessageBoxResult.Yes)
            {
                int ind = DtgListWorking.SelectedIndex;
                ConnectHelper.men.RemoveAt(ind);
                DtgListWorking.ItemsSource = ConnectHelper.men.ToList();
                ConnectHelper.SaveListToFile(@"dbase.txt");
            }
        }
        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPeople windowAdd = new AddPeople();
            windowAdd.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DtgListWorking.ItemsSource = ConnectHelper.men.ToList();
            TxtCount.Text = Convert.ToString(Math.Round(ConnectHelper.men.Average(x => x.Pay), 3));            
        }
    }
}
