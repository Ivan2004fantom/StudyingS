using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDiscrUrav1.NET
{
    public partial class Form1 : Form
    {
        static double D, x1, x2;

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            string input = textBoxINPUT.Text;
            a = int.Parse(textBoxA.Text);
            b = int.Parse(textBoxB.Text);
            c = int.Parse(textBoxC.Text);
            if(a == 0 || b == 0 || c == 0)
            {
                textBox1.Text = "Real?";
                return;
            }    
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                textBox1.Text = $"x1= {x1}\n x2= {x2}";
                textBoxX1.Text = $"{x1}";
                textBoxX2.Text = $"{x2}";
            }
            else
            {
                textBox1.Text = "Нет корней!";
            }
            int cha1 = 0;
            if (cha1 == 0)
            {
                chart1.ChartAreas.Add("X,Y");
                chart1.Series.Add("X");
                chart1.Series.Add("Y");
                cha1++;
            }
            /*
            for (int i = 1; i < 300; i++)
            {
                int num1 = 237;
                textBoxMatrix.Text = " \n " + $"{num1}";
                num1++;
            }
            */
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
