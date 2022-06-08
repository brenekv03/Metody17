using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void GenerovaniCisel(double a, double b, double[] pole)
        {
            Random rnd = new Random();
            if(b>a)
            {
                double c = b;
                b = a;
                a = c;
            }
            for(int i = 0; i<pole.Length;i++)
            {
                pole[i] = rnd.NextDouble() * (a - b) + b;
            }
        }
        public static void ZobrazitPole(double[] pole, ListBox listbox)
        {
            for(int i = 0; i <pole.Length;i++)
            {
                listbox.Items.Add(pole[i]);
            }
        }
        public static void VymenaCisel(double[] pole)
        {
            double max = pole.Min();
            double posledni = pole.Last();
            int indexmax = 0;
            for(int i = 0; i < pole.Length;i++)
            {
                if(max<pole[i])
                {
                    max = pole[i];
                    indexmax = i;
                }
            }
            pole[indexmax] = posledni;
            pole[pole.Length - 1] = max;
        }
        int n = int.Parse(textBox1.Text);
        double[] pole = new double[n];
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1.GenerovaniCisel(1, 10, pole);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ZobrazitPole(pole, listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.VymenaCisel(pole);
        }
    }
}
