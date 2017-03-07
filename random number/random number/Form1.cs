using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_number
{
    public partial class Form1 : Form
    {
        class number
        {
            public void _arithmos(int x) { num = x; }
            public void _arithmos2(int y) { num2 = y; }
            public void _arithmos3(int z) { num3 = z; }
            public void _arithmos4(int w) { num4 = w; }
            public void _arithmos5(int f) { num5 = f; }
            public int arithmos()
            {
                Random rnd = new Random();
                int val = rnd.Next(1, 50);
                num = val;
                return num;
            }
            public int arithmos2()
            {
                Random rnd2 = new Random();
                int val2 = rnd2.Next(1, 100) + 3;
                num2 = val2;
                return num2;
            }
            public int arithmos3()
            {
                Random rnd3 = new Random();
                int val3 = rnd3.Next(100) + 2;
                num3 = val3;
                return num3;
            }
            public int arithmos4()
            {
                Random rnd4 = new Random();
                int val4 = rnd4.Next(100) + 7;
                num4 = val4;
                return num4;
            }
            public int arithmos5()
            {
                Random rnd5 = new Random();
                int val5 = rnd5.Next(1, 100) ;
                num5 = val5;
                return num5;
            }
            private int num, num2, num3, num4, num5;
        }

        public Form1()
        {
            
            InitializeComponent();
            
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            number numb = new number();
            textBox1.Text = (numb.arithmos().ToString());
            textBox2.Text = (numb.arithmos2().ToString());
            textBox3.Text = (numb.arithmos3().ToString());
            textBox4.Text = (numb.arithmos4().ToString());
            textBox5.Text = (numb.arithmos5().ToString());
            textBox5.Text = (numb.arithmos5().ToString());
            ++count;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void mouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();

            int a, b, c, d, f;
            int result;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            d = int.Parse(textBox4.Text);
            f = int.Parse(textBox5.Text);
            result = a + b + c + d + f;
            MessageBox.Show((result.ToString()),"Το αποτέλεσμα ειναι: ");

        }
    }
}
