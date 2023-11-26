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

namespace Задание_4
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
            if (!Double.TryParse(Number1.Text, out double x))
            { MessageBox.Show("Поле только для чисел"); }
            if (!Double.TryParse(Number2.Text, out double n))
            { MessageBox.Show("Поле только для чисел"); }
            float x1 = 1, n1 = 1, rez = 1.0f;
            for (int i = 1; i <= n; ++i)
            {
                n1 *= (float)i;
                x1 *= x;
                rez += x1 / n1;
            }
            Answer.Text += $"{rez}";
        }
    }
}