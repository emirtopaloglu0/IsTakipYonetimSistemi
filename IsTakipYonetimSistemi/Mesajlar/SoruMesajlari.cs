using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipYonetimSistemi.Mesajlar
{
    internal class SoruMesajlari
    {
        public static SoruMesajlari instance = new SoruMesajlari();
        public DialogResult res;

        public void CloseApp()
        {
            res = MessageBox.Show("Çıkmak İstediğinze Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void IlerlemeKayit()
        {
            res = MessageBox.Show("İlerlemeyi Kaydetmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void ProjeBitiyor()
        {
            res = MessageBox.Show("Projeyi Bitirmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal void ProjeOlustur()
        {
            res = MessageBox.Show("Projeyi Oluşturmak İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
