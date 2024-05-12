using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipYonetimSistemi.Mesajlar
{
    internal class HataMesajlari
    {
        internal static void PersonelSeciniz()
        {
            MessageBox.Show("Personel Seçilmedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void CatchError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void ZatenProjede()
        {
            MessageBox.Show("Personel zaten projede bulunuyor!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void KontrolEdiniz()
        {
            MessageBox.Show("Alanları kontrol ediniz! Boş alan kalmamalı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void ProjeSeciniz()
        {
            MessageBox.Show("Lütfen proje seçiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void IlerlemeYanlis()
        {
            MessageBox.Show("İlerleme geriye gidemez, aynı olamaz, 0'dan küçük, 100'den büyük olamaz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
