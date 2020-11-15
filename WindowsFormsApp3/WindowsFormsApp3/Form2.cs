using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d, x1, x2; //объявляем дискриминант и иксы
                double a = Convert.ToDouble(textBox1.Text); //конвертируем
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                d = (b * b) - (4 * a * c); //считаем дискриминант
                if (d > 0) //дис больше нуля, считаем корни и выводим
                {
                    x1 = ((-1 * b) + Math.Sqrt(d)) / (2 * a);
                    x2 = ((-1 * b) - Math.Sqrt(d)) / (2 * a);
                    MessageBox.Show("Дискриминант = " + d + " , корень Х1 = " + x1 + " , корень Х2 = " + x2);
                }
                if (d == 0) //дис равен 0, считаем один корень и выводим
                {
                    x1 = ((-1 * b) + Math.Sqrt(d)) / (2 * a);
                    MessageBox.Show("Дискриминант = " + d + " , корень = " + x1);
                }
                if (d < 0) //дис меньше нуля, выводим
                {
                    MessageBox.Show("Нет корней, дискриминант = " + d);
                }

            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
