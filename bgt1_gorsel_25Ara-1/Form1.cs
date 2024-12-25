using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt1_gorsel_25Ara_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] gunler = { "Pzt", "Sal", "Çar", "Per", "Cum", "Cmt", "Paz" };
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };
            double[] ondalikSayilar = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            bool[] dogruYanlis = { true, false, true, false, true, false, true }; 
            float[] sayilar2 = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f, 7.7f };

            // MessageBox.Show(gunler[3]);
            // MessageBox.Show(gunler.Length.ToString());

            for (int i = 0; i < gunler.Length ; i++)
            {
                listBox1.Items.Add(gunler[i]);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = textBox1.Text;
            string[] kelimeler = cumle.Split(' ');

            for (int i = 0; i < kelimeler.Length; i++)
            {
                listBox1.Items.Add(kelimeler[i]);
            }





        }
    }
}
