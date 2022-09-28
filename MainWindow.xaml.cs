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

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int res;
                string oper = textBoxOp.Text;

                switch (oper)
                {
                    case "+":
                        res = num1 + num2;
                        textBoxResultado.Text = res.ToString();
                        break;
                    case "-":
                        res = num1 - num2;
                        textBoxResultado.Text = res.ToString();
                        break;
                    case "*":
                        res = num1 * num2;
                        textBoxResultado.Text = res.ToString();
                        break;
                    case "/":
                        res = num1 / num2;
                        textBoxResultado.Text = res.ToString();
                        break;
                    default:
                        textBoxResultado.Text = "Operador incorrecto";
                        break;
                }
            }
            catch (Exception)
            {
                textBoxResultado.Text = "Error en la operación.";
            }
            

        }

        private void buttonLimpiar_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBoxOp.Clear();
            textBoxResultado.Clear();
        }

        private void textBoxOp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
