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

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            int A1 = int.Parse(firstMean.Text);
            int B1 = int.Parse(secondMean.Text);
            int C1 = int.Parse(thirdMean.Text);
            int A2 = int.Parse(fourthMean.Text);
            int B2 = int.Parse(fifthMean.Text);
            int C2 = int.Parse(sixthMean.Text);

            int D = A1 * B2 - A2 * B1;
            double x = (C1 * B2 - C2 * B1) / D;
            double y = (A1 * C2 - A2 * C1) / D;
            Answer.Text = ($"x = {x}\ny = {y}\nD = {D}");
        }
    }
}
