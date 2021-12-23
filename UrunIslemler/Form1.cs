using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunIslemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        urun u = new urun();
        private void button1_Click(object sender, EventArgs e)
        {
            //Değişkenleri halletme
            u.urunno = textBox1.Text;
            u.uruncesiti = textBox2.Text;
            u.kategori = textBox3.Text;
            u.fiyat = int.Parse(textBox4.Text);
            u.stokmiktari = int.Parse(textBox5.Text);

            listBox1.Items.Add(u.urunno + " " + u.uruncesiti + " " + u.kategori + " " + u.fiyat + " " + u.stokmiktari + " " +u.fiyat);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Bakiye yazdırma
            u.bakiye();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Label para yazdırma
            label6.Text = ("Para miktarınız :"+ u.para.ToString());
        }
    }
}
