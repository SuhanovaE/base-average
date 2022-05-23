using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;


namespace workbase.Classes
{
    class ConnectHelper
    {
        public static List<Man> men = new List<Man>();

        public static string fileName;

        public static void ReadListFromFile(string filename)
        {
            try
            {
                StreamReader streamReader = new StreamReader(filename, Encoding.UTF8);
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    string[] items = line.Split(';');
                    Man man = new Man()
                    {
                        Name = items[0].Trim(),
                        Birth_year = int.Parse(items[1].Trim()),
                        Pay = double.Parse(items[2].Trim())
                    };
                    men.Add(man);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверный формат данных!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        public static void SaveListToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, false, Encoding.UTF8);
            foreach (Man m in men)
            {
                streamWriter.WriteLine($"{m.Name};{m.Birth_year};{m.Pay}");
            }
            streamWriter.Close();
        }
    }
}
