using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace howto_tooltip_user_equation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Soloution: \n" ;
          
            if (IsNumeric(textBox1.Text) && IsNumeric(textBox2.Text))
            {
                int num = int.Parse(textBox2.Text);
                int base1 = int.Parse(textBox1.Text);
                textBox3.Text = (Math.Log(num) / Math.Log(base1)).ToString();
                richTextBox1.Text += "(" + textBox3.Text + ")^(" + textBox1.Text + ") =" + textBox2.Text;
            }
            else
            {
                MessageBox.Show("fields not a number");
            }
           
           
        }
    }
}