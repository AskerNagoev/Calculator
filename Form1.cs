using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_Нагоева
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;

            textBox4.Enabled = true;

            if (textBox1.Text == "" ^ textBox2.Text == "" ^ comboBox1.Text == "")
            {
                textBox3.Text = "";
                textBox4.Text = "Заполнены не все поля!";
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);

                switch (comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(a + b);
                        textBox4.Text = "Выполнено";
                        break;

                    case "-":
                        textBox3.Text = Convert.ToString(a - b);
                        textBox4.Text = "Выполнено";
                        break;

                    case "/":
                        if (b == 0)
                        {
                            textBox3.Text = "";
                            textBox4.Text = "На ноль делить нельзя!";
                        }
                        else
                        {
                            textBox3.Text = Convert.ToString(a / b);
                            textBox4.Text = "Выполнено";
                        }
                        break;

                    case "*":
                        textBox3.Text = Convert.ToString(a * b);
                        textBox4.Text = "Выполнено";
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox4.Enabled = false;
        }
    }
}
