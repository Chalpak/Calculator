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
        public string Operate;
        public string N1;
        public bool flag;
        public Form1()
        {
            flag = false;

            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            if (flag)
            {
                flag = false;
                textBox1.Text = "0";
            }

            
            Button bt = (Button)sender;
            
            if (textBox1.Text == "0")
            {
                textBox1.Text = bt.Text;

            }
            else
            {
                textBox1.Text = textBox1.Text + bt.Text;
            }
            textBox2.Text = textBox2.Text + bt.Text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            textBox2.Text = textBox2.Text + bt.Text;
            Operate = bt.Text;
            N1 = textBox1.Text;
            flag = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            textBox2.Text = textBox2.Text + bt.Text;
            double dn1, dn2, res;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            res = 0;


            if (Operate == "+")
            {
                res = dn1 + dn2;
                textBox1.Text = Convert.ToString((Math.Round(res, 2, MidpointRounding.ToEven)));
            }
            else if (Operate == "-")
            {
                res = dn1 - dn2;
                textBox1.Text = Convert.ToString((Math.Round(res, 2, MidpointRounding.ToEven)));
            }
            else if (Operate == "*")
            {
                res = dn1 * dn2;
                textBox1.Text = Convert.ToString((Math.Round(res, 2, MidpointRounding.ToEven)));
            }
            else if (Operate == "/")
            {
                res = dn1 / dn2;
                textBox1.Text = Convert.ToString((Math.Round(res, 2, MidpointRounding.ToEven)));
            }
            flag = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double Value, res; 
            Value = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(Value, 2);
            textBox1.Text = Convert.ToString((Math.Round(res, 2, MidpointRounding.ToEven)));
            Button bt = (Button)sender;
            textBox2.Text = textBox2.Text + bt.Text;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            double Value, res; 
            Value = Convert.ToDouble(textBox1.Text);
           

            if (Value >= 0 )
            {
                res = Math.Sqrt(Value);
                textBox1.Text = Convert.ToString(Math.Round(res, 2, MidpointRounding.ToEven));
                Button bt = (Button)sender;
                textBox2.Text = textBox2.Text + bt.Text;
            }
            else
            {
                textBox1.Text = "Ошибка";
            }
            

        }

        private void button19_Click(object sender, EventArgs e)
        {
            double Value, res;
            Value = Convert.ToDouble(textBox1.Text);
            res = -Value;
            textBox1.Text = Convert.ToString(Math.Round(res, 2, MidpointRounding.ToEven));
            textBox2.Text = Convert.ToString(Math.Round(res, 2, MidpointRounding.ToEven));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ",";
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
