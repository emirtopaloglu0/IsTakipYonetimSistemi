using IsTakipYonetimSistemi.Class;
using IsTakipYonetimSistemi.Mesajlar;
using IsTakipYonetimSistemi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipYonetimSistemi.View
{
    public partial class ShowProjects : UserControl
    {

        public static ShowProjects instance;

        //PERSONELİN BAŞKA AKTİF BİR PROJEDE OLUP OLMADIĞINI KONTROL ETMELİYİZ.

        public ShowProjects()
        {
            InitializeComponent();
            instance = this;
        }


        internal void LoadData(bool isOngoing)
        {
            try
            {
                Projeler_Listbox.Items.Clear();
                List<Proejeler> projeler = new List<Proejeler>();
                if (isOngoing)
                {
                    projeler = DB_Connection.db.Proejeler.Where(x => x.IsDone == false).ToList();
                }
                else
                {
                    projeler = DB_Connection.db.Proejeler.Where(x => x.IsDone == true).ToList();
                }

                foreach (var p in projeler)
                {
                    var baslangic = p.Baslangic_Tarihi.ToString();
                    var bitis = p.Bitis_Tarihi.ToString();
                    Projeler_Listbox.Items.Add($"PKodu: {p.Id} - Ad: {p.Ad} - İlerleme: %{p.Ilerleme} - " +
                        $"Başlangıç Tarihi: {baslangic.Substring(0, baslangic.Length - 8)} - Bitiş Tarihi: {bitis.Substring(0, bitis.Length - 8)} - Açıklama: {p.Aciklama}");
                }
                AddProgress_Btn.Enabled = true;

            }
            catch
            {

            }
        }

        private void ShowContinuing_Btn_Click(object sender, EventArgs e)
        {
            LoadData(true);
        }

        private void ShowFinished_Btn_Click(object sender, EventArgs e)
        {
            LoadData(false);
        }

        private void ShowAssignment_Btn_Click(object sender, EventArgs e)
        {
            if (Projeler_Listbox.SelectedIndex > -1)
            {
                var selected_Project = Projeler_Listbox.SelectedItem.ToString().Split(':', '-');
                var proje = DB_Connection.db.Proejeler.Find(Int32.Parse(selected_Project[1]));
                var detay = DB_Connection.db.Proje_Calisanlari.Where(x => x.Proje_Id == proje.Id);
                Projeler_Listbox.Items.Clear();
                Projeler_Listbox.Items.Add($"Proje Adı: {proje.Ad}");
                foreach (var item in detay)
                {
                    var calisan = DB_Connection.db.Calisanlar.Find(item.Calisan_Id);
                    Projeler_Listbox.Items.Add($"Çalışan: {calisan.Ad} {calisan.Soyad} - Görev: {item.Calisan_Gorev}");

                }
                AddProgress_Btn.Enabled = false;

            }
            else
                HataMesajlari.ProjeSeciniz();
        }

        private void AddProgress_Btn_Click(object sender, EventArgs e)
        {
            if (Projeler_Listbox.SelectedIndex > -1)
            {
                var selected_Project = Projeler_Listbox.SelectedItem.ToString().Split(':', '-');
                IlerlemeEkleForm f = new IlerlemeEkleForm();
                IlerlemeEkleForm.instance.proje_Id = Int32.Parse(selected_Project[1]);
                IlerlemeEkleForm.instance.LoadData();
                f.ShowDialog();
            }
            else
                HataMesajlari.ProjeSeciniz();
        }
    }
}
