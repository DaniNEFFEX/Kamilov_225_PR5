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

namespace Задание_5
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
            int[] i = Enumerable.Range(1, ∞).ToArray();
            double u[], v[];
            if (u1 = u2 = 0) &(v1 = v2 = 1);
            {
                u[i] = (u[i - 1] - u[i - 2] * v[i - 1] - v[i - 2]) / 1 + Math.Pow(u[i - 1], 2) + Math.Pow(v[i - 1], 2);
                v[i] = u[i - 1] - v[i - 1] / Math.Abs(u[i - 2] + v[i - 1]) + 2;
            }

        }
    }
}
