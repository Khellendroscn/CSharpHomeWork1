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
    public partial class Homework1_3 : Form
    {
        public Homework1_3()
        {
            InitializeComponent();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            var counter = new Dictionary<string, int>()
            {
                { "digit", 0 },
                { "letter", 0 },
                { "punc", 0 },
                { "symbol", 0 },
                { "space", 0 },
                { "other", 0 }
            };
            foreach(char c in textBox1.Text)
            {
                if (char.IsDigit(c)) ++counter["digit"];
                else if (char.IsLetter(c)) ++counter["letter"];
                else if (char.IsPunctuation(c)) ++counter["punc"];
                else if (char.IsSymbol(c)) ++counter["symbol"];
                else if (char.IsWhiteSpace(c)) ++counter["space"];
                else ++counter["other"];
            }
            labelDigit.Text = counter["digit"].ToString();
            labelLetter.Text = counter["letter"].ToString();
            labelPunctuation.Text = counter["punc"].ToString();
            labelSymbol.Text = counter["symbol"].ToString();
            labelWhitespace.Text = counter["space"].ToString();
            labelOther.Text = counter["other"].ToString();
        }

        private void btnClear_Click(object sender, EventArgs e) => textBox1.Clear();
    }
}
