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

namespace PR_20._101_Titaeva_1
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

        private void Done_btn_Click(object sender, RoutedEventArgs e)
        { 
            try
            {
                string input = Convert.ToString(Input_txtbx.Text);
                if (input.Length != 12)
                {
                    MessageBox.Show("Введите 12-ти значное число");
                }
                else
                {
                    if (Convert.ToInt64(input[0] * input[1] * input[2]) == Convert.ToInt64(input[3] + input[4] + input[5] + input[6] + input[7] + input[8] + input[9] + input[10] + input[11]))
                    {
                        Output_txtbx.Text = "Равно!!!";
                    }
                    else
                    {
                        Output_txtbx.Text = "Не равно(((";
                    }
                }
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Неправильный формат ввода!");
            }
        }
        private void Input_txtbx_PreviewTextInput(object sender, TextCompositionEventArgs e)//вводятся только числа!!!
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }
    }
}
