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
            if (!Double.TryParse(Number3.Text, out double c))
            { MessageBox.Show("Поле только для чисел"); }
            int i;
            static string Number1(byte maxSize = 300);
            i = 1;
            while (b != 0)
            {
                a[i] = b;
                i = i + 1;
            }

            c = i - 1;
            int d = 0;
            b = 0;

            for (i = 1; i <= c; i++)
            {
                if (a[i] > 99)
                {
                    b = b + a[i];
                    d = d + 1;
                }
            }

            if (b == 0)
            {
                Answer.Text += "NO";
            }
            else
            {
                Answer.Text += "" + b / d;
            }
        }
    }
}
