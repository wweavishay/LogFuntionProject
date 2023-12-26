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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void DectoBin(string input)
        {
           
            richTextBox1.Text = "";
            int num = int.Parse(textBox1.Text);
            int power = Convert.ToInt32(Math.Log(num) / Math.Log(2));
            // int b = 0;
            int[] arr = new int[150];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            int length = 1;
         
            if (num <= 100)
            {
                richTextBox1.Text ="\n"+ "We take the number " + num + "and log it in 2";
                richTextBox1.Text += "\n" + "Log(" + num + ") / Log(2) ="+ power +"=power";
                richTextBox1.Text += "\n" + "Taking the num and minus in power to of 2";
               
                while (num > 0)
                {
                   
                    if (power > 0)
                    {
                        arr[power] = 1;
                    }
                    if (length < power)
                    {
                        length = power;
                    }

                    int x = 1;
                    for (int i = 1; i <= power; i++)
                    {
                        x *= 2;
                    }
                    num = (num - x);

                    if (num > 0)
                    {

                        power = (Convert.ToInt32((Math.Log(num) / Math.Log(2))));


                    }
                    else
                    {
                        break;
                    }
                    richTextBox1.Text += "number-((power)^2) =" + num + "-" +power +"="+   power;
                    richTextBox1.Text += " the meaning is that in this location that power= " + power + "arr[i] is 1";


                }
                /*  richTextBox1.Text += "\n"+"The Binary number is" ;
                  for (int i = length; i >= 0; i--)
                  {
                      richTextBox1.Text += arr[i] + "";
                  }
                  */
               
            }
            else
            {

                richTextBox1.Text = "This is very sofisticated";
                
            }
         
            richTextBox1.Text += "\n" + "The Binary number is " + textBox2.Text;

        }
            private void Button1_Click(object sender, EventArgs e)
        {
            if (IsNumeric(textBox1.Text))
            {
                int decimalNumber = int.Parse(textBox1.Text);

                int remainder;
                string result = string.Empty;
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;

                    DectoBin(textBox1.Text);
                }


                textBox2.Text = result;
                if(textBox1.Text=="0")
                {
                    textBox2.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("fields not a number!");
            }
           
        }
        public int BinaryToDec(string input)
        {
            richTextBox1.Text = "";

            char[] array = input.ToCharArray();
            // Reverse since 16-8-4-2-1 not 1-2-4-8-16. 
            Array.Reverse(array);
            string arr = "";
            for (int i = 0; i < array.Length; i++)
            {
               arr +=array[i]; ;
               
            }
            richTextBox1.Text += "The Reverse Number :  " + arr;
            richTextBox1.Text += "\n";


       int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Method uses raising 2 to the power of the index. 
                    if (i == 0)
                    { 
                            sum += 1;
                        richTextBox1.Text += "index=" + i + ":" + ", Value=" + array[i] + "; (1*2)^" + i + " Total =" + +sum + ";\n";

                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i);
                        richTextBox1.Text += "index=" + i + ":" + ", Value=" + array[i] + "; (1*2)^" + i +" = "+ (1*Math.Pow(2,i)) +" Total :" + +sum + ";\n";
                    }
                   
                }
                else
                {

                    richTextBox1.Text += "index=" + i +":" +", Value=" + array[i] + " ;(0*2) "+" Total =0 ;"+ "\n";
                }
              
                
            }

            return sum;
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bool flag = true;
            
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (textBox2.Text[i] != '0' && textBox2.Text[i] != '1')
                {
               
                    flag = false;
                }
            }

            if (IsNumeric(textBox2.Text))
            {
                if (flag)
                {
                    textBox1.Text = BinaryToDec(textBox2.Text).ToString();
                }
                else
                {
                    MessageBox.Show("The Number is not Binary!!!");
                }
            }
            else
            {
                MessageBox.Show("fields not a number!");
            }
        }

        private void RichTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Visible == true)
            {
                richTextBox1.Visible = false;
            }
            else
            {
                richTextBox1.Visible = true;

            }
        }
    }
}
