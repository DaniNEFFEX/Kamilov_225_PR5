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

namespace Задание_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!Double.TryParse(Number1.Text, out double n))
            { MessageBox.Show("Поле только для чисел"); }
            double m, k=1, max=0, i;
            for (i = 1; i <= n; i++)
            {
                if (m % 10 == n/3)
                {
                    if (k == -1)
                    {
                        max = m;
                        k = 0;
                    }
                    if (max < m)
                    {
                        max = m;
                    }
                }
            }
            if (k!=-1)
            {
                Answer.Text += $"Ответ:\n{max}";
            }
            else
            {
                Answer.Text = $"Ответ:\n Чисел кратных на 3 нет";
            }
        }
    }
}
