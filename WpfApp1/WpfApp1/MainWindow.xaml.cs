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
using static System.Math;

namespace WpfApp1
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

        static double Gipotenuza(int a, int b)
        {
            double c = Sqrt(Pow(a, 2) + Pow(b, 2));
            return c;
        }

        static double Pirimetr(int a, int b, double c)
        {
            double p = a + b + c;
            return p;
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(firstMean.Text);
            int b = int.Parse(secondMean.Text);
            double c = Gipotenuza(a, b);
            double p = Pirimetr(a, b, c);
            Answer.Text = $"Гипотенуза = {c:f2}\nПериметр = {p:f2}";
        }
    }
}
