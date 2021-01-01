using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            Button button = (Button)sender;

            if (button.Name == "button18") {
                textBox.Clear();
            }

            textBox.Text += button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;
            if (operatorButton.Text == "+") {
                textBox.Text = "You have pressed the +";
            }
        }
    }
}
