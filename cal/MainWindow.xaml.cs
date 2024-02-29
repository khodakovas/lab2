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
using System.Xml.Linq;
using Microsoft.Win32;
using NCalc;

namespace cal
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            text.Text += button.Content.ToString();
        }
        /*private void_equals(object sender, RoutedEventArgs e)
        {
            NCalc.Expression expression = new NCalc.Expression(text.Text);
            text.Text = Math.Round(Convert.ToDouble(expression.Evaluate()), 8).ToString();
            if (check_save.IsChecked == true) save_result.Text += " " + text.Text;
       }*/

        /*private void b_Click_equas(object sender, TextChangedEventArgs e)
        {
            NCalc.Expression expression = new NCalc.Expression(text.Text);
            text.Text = Math.Round(Convert.ToDouble(expression.Evaluate()), 8).ToString();
            //if (check_save.IsChecked == true) save_result.Text += " " + text.Text;
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NCalc.Expression expression = new NCalc.Expression(text.Text);
            text.Text = Math.Round(Convert.ToDouble(expression.Evaluate()), 8).ToString();
        }
        /*private void Button_Click(object sender, RoutedEventArgs e)
{
save_result.Text < "";
}
private void Unvisible_Checked(object sender, RoutedEventArgs e)
{
if (unvisible.IsChecked == true)
{
save_result.Visibility = Visibility.Midden;
chek_save.Visibility = Visibility.Midden;
backspace.Visibility = Visibility.Midden;
clear.Visibility = Visibility.Midden;
}
}*/
    }
}
