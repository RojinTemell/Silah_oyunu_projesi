using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyuncu_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oyuncu oyuncu = new Oyuncu();
            oyuncu.Ad = textBox1.Text;
            oyuncu.Yas = Convert.ToInt16(textBox5.Text);

            Silah silah = new Silah();
            silah.Marka = textBox2.Text;
            silah.Model = textBox3.Text;
            silah.Agirlik = Convert.ToDouble(textBox4.Text);

            Atesli_silah atesli = new Atesli_silah();
            Kesici_silah kesici = new Kesici_silah();

            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add(oyuncu.Ad);
                listBox1.Items.Add( oyuncu.Yas.ToString());
                listBox1.Items.Add(silah.Marka);
                listBox1.Items.Add(silah.Model);
                listBox1.Items.Add(silah.Agirlik.ToString());
                listBox1.Items.Add(atesli.Yakinlastirma_davranisi());
                

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add(oyuncu.Ad);
                listBox1.Items.Add(oyuncu.Yas.ToString());
                listBox1.Items.Add(silah.Marka);
                listBox1.Items.Add(silah.Model);
                listBox1.Items.Add(silah.Agirlik.ToString());
                listBox1.Items.Add( atesli.Gez_goz_arpacik_davranisi());

            }
            else
            {
                listBox1.Items.Add(oyuncu.Ad);
                listBox1.Items.Add(oyuncu.Yas.ToString());
                listBox1.Items.Add(silah.Marka);
                listBox1.Items.Add(silah.Model);
                listBox1.Items.Add(silah.Agirlik.ToString());
                listBox1.Items.Add( kesici.Bicak_cekme());
               

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            label4.Text = "";
            listBox1.Items.Clear();
        }
    }
}
