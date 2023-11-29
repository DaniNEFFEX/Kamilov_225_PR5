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

namespace Задание_2
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
            if (!Double.TryParse(Number1.Text, out double a))
            { MessageBox.Show("Поле только для чисел"); }
            if (!Double.TryParse(Number2.Text, out double b))
            { MessageBox.Show("Поле только для чисел"); }
            if (a > b || b > 30000 || a < 1)
            {
                MessageBox.Show("данные введены некорректно");
            }
            double n = b - a + 1;
            if (n % 2 == 1 && a % 2 == 1)
            {
                n = n / 2 + 1;
                
            }
            else
            {
                n = n / 2;
                
            }
            Answer.Text += Math.Round(n);
        }
    }
}
