using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipYonetimSistemi.Mesajlar
{
    internal class BasariliMesajlar
    {
        internal static void ProjeBitti()
        {
            MessageBox.Show("Proje Tamamlandı!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void ProjeOlusturuldu()
        {
            MessageBox.Show("Proje Başarılı Bir Şekilde Oluşturuldu!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
