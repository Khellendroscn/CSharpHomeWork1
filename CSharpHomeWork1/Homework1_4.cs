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
    public partial class Homework1_4 : Form
    {
        public Homework1_4()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            textOrigin.Text.ToList()
                .ForEach(c => textEncode.Text += encode(c));
        }

        private char encode(char c)
        {
            string digitCodes = "2345678901";
            string wordCodes = "DEFGHIJKLMNOPQRSTUVWXYZABC";
            if (char.IsDigit(c)) return digitCodes[c - '0'];
            else if (char.IsLower(c)) return wordCodes[c - 'a'];
            else if (char.IsUpper(c)) return char.ToLower(wordCodes[c - 'A']);
            else return c;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textOrigin.Clear();
            textEncode.Clear();
        }
    }
}
