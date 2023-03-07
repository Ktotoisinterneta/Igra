using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Comp_num = 0;
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            Comp_num = r.Next(0, 100);
        }
        int k = 0;
        int u = 0;
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            int Hum_num = Convert.ToInt32(textBox1.Text);
            k =k+1;
            if (k >= 7)
            {
                button1.Visible = false;
                button2.Visible = true;
                MessageBox.Show("Попытки кончились");
                label4.Text = "Кол-во набронных баллов:" + u;
            }

            if (Comp_num == Hum_num)
            { MessageBox.Show("Вы угадали!!!");
                button1.Visible = false;
                button2.Visible = true;
                u = u + 50;
                label4.Text = "Кол-во набронных баллов:" + u;

            }
            else

                if (Comp_num > Hum_num)
            {
                label5.Text =  Hum_num+ "> ";
                MessageBox.Show("Мое число больше! ");
                u = u + 10;
                label4.Text = "Кол-во набронных баллов:" + u;

            }
            else
            {
                if (Comp_num < Hum_num)
                {
                    label3.Text = "< " + Hum_num ;
                    MessageBox.Show("Мое число меньше!");
                    u = u + 10;
                    label4.Text = "Кол-во набронных баллов:" + u;

                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

