using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kelimeler = { "masa", "kitap", "klavye", "monitör", "asparagas", "çekoslavakya" };
        string kelime;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random gen = new Random();
            int sayi = gen.Next(kelimeler.Length);
            //sayi dizi içindeki bir kelimenin indexi
            kelime = kelimeler[sayi];
            int x = 12, y = 12;
            for (int i = 0; i < kelime.Length; i++)//kelime içindeki harf sayısı kadar bir textbox grubu oluşturup forma eklenir
            {
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(x, y);
                txt.Name = "textBox"+i;
                txt.Size = new System.Drawing.Size(50, 50);
                txt.TabIndex = 0;
                txt.Font=new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                x += 55;
                this.Controls.Add(txt);
            }
            this.Text = kelime;
        }

        private void btnHarfVer_Click(object sender, EventArgs e)
        {
            Random gen = new Random();
            ArrayList harfSirasi = new ArrayList();

            int sayi = 0;

            while (true)
            {
               sayi=  gen.Next(kelime.Length);//hangi harf gösterilecek
            //kelime[sayi] şeklinde sadece 1 harf kullanıcıya gösterilecek
               if (!harfSirasi.Contains(sayi))
               {
                   harfSirasi.Add(sayi);
                   foreach (var item in this.Controls)
                   {
                       if (item is TextBox)
                       {
                           if (((TextBox)item).Name == "textBox" + sayi)
                               ((TextBox)item).Text = kelime[sayi].ToString();
                       }
                   }
                   break;
               }
            }


        }
    }
}
