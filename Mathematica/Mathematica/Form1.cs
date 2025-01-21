using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Random random = new Random();
        private void Random_num(int radio)
        {
            int randomNumber;
            int randomNumber2;
            if (radio == 1)
            {
                randomNumber = random.Next(1, 10);
                label1.Text = $"{randomNumber}";
                randomNumber = random.Next(1, 10);
                label3.Text = $"{randomNumber}";
                randomNumber = random.Next(1, 10);
                label5.Text = $"{randomNumber}";
                randomNumber = random.Next(1, randomNumber);
                label7.Text = $"{randomNumber}";
                randomNumber = random.Next(1, 10);
                label9.Text = $"{randomNumber}";
                randomNumber = random.Next(1, 10);
                label11.Text = $"{randomNumber}";
                randomNumber = random.Next(1, 10);
                randomNumber2 = random.Next(2, 10);
                label13.Text = $"{randomNumber * randomNumber2}";
                label15.Text = $"{randomNumber2}";

                label1.Location = new Point(80, label1.Location.Y);
                label5.Location = new Point(80, label5.Location.Y);
                label9.Location = new Point(80, label9.Location.Y);
                label13.Location = new Point(60, label13.Location.Y);
            }
            else if (radio == 2)
            {
                randomNumber = random.Next(10, 100);
                label1.Text = $"{randomNumber}";
                randomNumber = random.Next(10, 100);
                label3.Text = $"{randomNumber}";
                randomNumber = random.Next(10, 100);
                label5.Text = $"{randomNumber}";
                randomNumber = random.Next(10, randomNumber);
                label7.Text = $"{randomNumber}";
                randomNumber = random.Next(10, 100);
                label9.Text = $"{randomNumber}";
                randomNumber = random.Next(10, 100);
                label11.Text = $"{randomNumber}";
                randomNumber = random.Next(10, 100);
                randomNumber2 = random.Next(10, 100);
                label13.Text = $"{randomNumber*randomNumber2}";
                label15.Text = $"{randomNumber2}";
                label1.Location = new Point(60, label1.Location.Y);
                label5.Location = new Point(60, label5.Location.Y);
                label9.Location = new Point(60, label9.Location.Y);
                label13.Location = new Point(30, label13.Location.Y);
            }
            else if (radio == 3)
            {
                randomNumber = random.Next(100, 1000);
                label1.Text = $"{randomNumber}";
                randomNumber = random.Next(100, 1000);
                label3.Text = $"{randomNumber}";
                randomNumber = random.Next(100, 1000);
                label5.Text = $"{randomNumber}";
                randomNumber = random.Next(100, randomNumber);
                label7.Text = $"{randomNumber}";
                randomNumber = random.Next(100, 1000);
                label9.Text = $"{randomNumber}";
                randomNumber = random.Next(100, 1000);
                label11.Text = $"{randomNumber}";
                randomNumber = random.Next(10, 100);
                randomNumber2 = random.Next(100, 1000);
                label13.Text = $"{randomNumber * randomNumber2}";
                label15.Text = $"{randomNumber2}";
                label1.Location = new Point(40, label1.Location.Y);
                label5.Location = new Point(40, label5.Location.Y);
                label9.Location = new Point(40, label9.Location.Y);
                label13.Location = new Point(0, label13.Location.Y);
            }
            label18.Text = "Пустое";
            label19.Text = "Пустое";
            label20.Text = "Пустое";
            label21.Text = "Пустое";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random_num(1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                Random_num(1);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                Random_num(2);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                Random_num(3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int radio=1;
            if (radioButton1.Checked == true)
            {
                radio = 1;
            }
            else if (radioButton2.Checked == true)
            {
                radio = 2;
            }
            else if (radioButton3.Checked == true)
            {
                radio = 3;
            }
            Random_num(radio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int result) && textBox1.Text != null)
            {
                if (int.Parse(label1.Text) + int.Parse(label3.Text) == int.Parse(textBox1.Text)) {
                    label18.Text = "+";
                }
                else
                {
                    label18.Text = "-";
                }
            }
            if (int.TryParse(textBox2.Text, out int result2) && textBox2.Text != null)
            {
                if (int.Parse(label5.Text) - int.Parse(label7.Text) == int.Parse(textBox2.Text))
                {
                    label19.Text = "+";
                }
                else
                {
                    label19.Text = "-";
                }
            }
            if (int.TryParse(textBox3.Text, out int result3) && textBox3.Text != null)
            {
                if (int.Parse(label9.Text) * int.Parse(label11.Text) == int.Parse(textBox3.Text))
                {
                    label20.Text = "+";
                }
                else
                {
                    label20.Text = "-";
                }
            }
            if (int.TryParse(textBox4.Text, out int result4) && textBox4.Text != null)
            {
                if (int.Parse(label13.Text) / int.Parse(label15.Text) == int.Parse(textBox4.Text))
                {
                    label21.Text = "+";
                }
                else
                {
                    label21.Text = "-";
                }
            }

            
        }
    }
}
