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

namespace WpfApp4
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
            Double rateDollar = Convert.ToDouble(rate.Text);
            Double sumDollar = Convert.ToDouble(sum.Text);
            Double resultDollar = rateDollar * sumDollar;
            result.Text = resultDollar.ToString();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Double rateDollar = Convert.ToDouble(rate1.Text);
            Double sumDollar = Convert.ToDouble(sum1.Text);
            Double resultDollar = rateDollar * sumDollar;
            result1.Text = resultDollar.ToString();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Double rateDollar = Convert.ToDouble(rate2.Text);
            Double sumDollar = Convert.ToDouble(sum2.Text);
            Double resultDollar = rateDollar * sumDollar;
            result2.Text = resultDollar.ToString();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Double rateDollar = Convert.ToDouble(rate3.Text);
            Double sumDollar = Convert.ToDouble(sum3.Text);
            Double resultDollar = rateDollar * sumDollar;
            result3.Text = resultDollar.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Double rateD = Convert.ToDouble(rate4.Text);
            Double resultD = rateD * 0.0254;
            result4.Text = resultD.ToString();
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            Double rateF = Convert.ToDouble(rate5.Text);
            Double resultF = rateF * 0.3048;
            result5.Text = resultF.ToString();
           
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            Double rateM = Convert.ToDouble(rate6.Text);
            Double resultM = rateM * 1609.34;
            result6.Text = resultM.ToString();
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            Double rateV = Convert.ToDouble(rate7.Text);
            Double resultV = rateV * 1066.8;
            result7.Text = resultV.ToString();
        }
    }
}
