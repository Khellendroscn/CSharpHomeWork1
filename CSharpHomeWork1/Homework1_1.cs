using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpHomeWork1
{
    public partial class Homework1_1 : Form
    {
        private delegate B combine<A, B>(A a, A b);
        private static Dictionary<char, combine<double, double>> dict;
        private combine<double, double> func = null;
        
        static Homework1_1()
        {
            dict = new Dictionary<char, combine<double, double>>();
            dict['+'] = (a, b) => a + b;
            dict['-'] = (a, b) => a - b;
            dict['*'] = (a, b) => a * b;
            dict['/'] = (a, b) => a / b;
        }
        public Homework1_1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (func != null)
            {
                var num1 = double.Parse(textBox1.Text);
                var num2 = double.Parse(textBox2.Text);
                labelResult.Text = string.Format("{0:0.00}", func(num1, num2));
            }
        }

        private void signBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (signBox.Text != "")
            {
                var sign = signBox.Text.First();
                func = dict[sign];
            }
            else
            {
                func = null;
            }
        }
    }
}
