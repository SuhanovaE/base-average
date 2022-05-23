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

namespace workbase
{
    /// <summary>
    /// Логика взаимодействия для AddPeople.xaml
    /// </summary>
    public partial class AddPeople : Window
    {
        int mode;
        public AddPeople()
        {
            InitializeComponent();
            mode = 0;
        }
        public AddPeople(Man peop)
        {
            InitializeComponent();
            TxbName.Text = peop.Name;
            TxbBirth_year.Text = peop.Birth_year.ToString();
            TxbPay.Text = peop.Pay.ToString();
            mode = 1;
            BtnAddPeople.Content = "Сохранить";
        }

        private void BtnAddPeople_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 0)
            {
                try
                {
                    Man man = new Man()
                    {
                        Name = TxbName.Text,
                        Birth_year = int.Parse(TxbBirth_year.Text),
                        Pay = double.Parse(TxbPay.Text),
                    };
                    ConnectHelper.men.Add(man);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Проверьте входные данные: {ex}", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

            }
            else
            {
                try
                {
                    for (int i = 0; i < ConnectHelper.men.Count; i++)
                    {
                        if (ConnectHelper.men[i].Name == TxbName.Text)
                        {
                            ConnectHelper.men[i].Birth_year = int.Parse(TxbBirth_year.Text);
                            ConnectHelper.men[i].Pay = double.Parse(TxbPay.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Проверьте входные данные: {ex}", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

            }
            
            ConnectHelper.SaveListToFile(@"dbase.txt");
            this.Close();


        }
    }
}
