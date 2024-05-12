using IsTakipYonetimSistemi.Mesajlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipYonetimSistemi
{
    public partial class Form1 : Form
    {
        //PERSONELİN BAŞKA AKTİF BİR PROJEDE OLUP OLMADIĞINI KONTROL ETMELİYİ.

        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            SoruMesajlari.instance.CloseApp();
            if(SoruMesajlari.instance.res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
