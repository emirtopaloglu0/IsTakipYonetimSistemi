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
    public partial class CreateProject : UserControl
    {
        //Çalışan görev kısmına "Pozisyonu ile aynı görev" veya "Kendim yazacağım" düğmeleri olsun. 
        //Kendim yazacağım dediği zaman textbox görünür olsun.
        //PERSONELİN BAŞKA AKTİF BİR PROJEDE OLUP OLMADIĞINI KONTROL ETMELİYİZ.

        public static CreateProject instance = new CreateProject();
        public List<int> calisanlar = new List<int>();


        public CreateProject()
        {
            InitializeComponent();
            instance = this;
        }

        private void AddStaff_Btn_Click(object sender, EventArgs e)
        {
            PersonelEkleForm f = new PersonelEkleForm();
            PersonelEkleForm.instance.LoadData(false, 0, false, string.Empty);
            PersonelEkleForm.instance.LoadDepartmanData();
            f.ShowDialog();
        }


        internal void CalculateStaff()
        {
            try
            {
                Calisan_Label.Text = calisanlar.Count.ToString();
                Personel_Listbox.Items.Clear();
                if (calisanlar.Count > 0)
                {
                    foreach (var item in calisanlar)
                    {
                        var calisan = DB_Connection.db.Calisanlar.Find(item);
                        var pozisyon = DB_Connection.db.Pozisyonlar.Find(calisan.Pozisyon_Id);
                        Personel_Listbox.Items.Add($"Ad: {calisan.Ad} {calisan.Soyad} - Pozisyon: {pozisyon.Ad}");
                    }
                }

            }
            catch
            {

            }
        }

        private void CreateProject_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                SoruMesajlari.instance.ProjeOlustur();
                if (SoruMesajlari.instance.res == DialogResult.No)
                    return;

                if (ProjectName_Richbox.Text != string.Empty && ProjectDescp_Richbox.Text != string.Empty &&
                    EndDate_Datetime.Value > DateTime.Now && calisanlar.Count > 0)
                {
                    Proejeler proje = new Proejeler();
                    proje.Ad = ProjectName_Richbox.Text.Trim();
                    proje.Aciklama = ProjectDescp_Richbox.Text.Trim();
                    proje.Ilerleme = 0;
                    proje.Baslangic_Tarihi = DateTime.Now;
                    proje.Bitis_Tarihi = EndDate_Datetime.Value;
                    proje.IsDone = false;

                    DB_Connection.db.Proejeler.Add(proje);
                    DB_Connection.db.SaveChanges();

                    var prj = DB_Connection.db.Proejeler.FirstOrDefault(x => x.Ad == ProjectName_Richbox.Text.Trim() && x.IsDone == false);

                    Proje_Calisanlari proje_ = new Proje_Calisanlari();
                    foreach (var item in calisanlar)
                    {
                        var calisan = DB_Connection.db.Calisanlar.Find(item);
                        var pozs = DB_Connection.db.Pozisyonlar.Find(calisan.Pozisyon_Id);
                        proje_.Calisan_Id = item;
                        proje_.Proje_Id = prj.Id;
                        proje_.Calisan_Gorev = pozs.Ad;
                        DB_Connection.db.Proje_Calisanlari.Add(proje_);
                        DB_Connection.db.SaveChanges();
                    }


                    BasariliMesajlar.ProjeOlusturuldu();
                    ProjectName_Richbox.Text = string.Empty;
                    ProjectDescp_Richbox.Text = string.Empty;
                    EndDate_Datetime.Value = DateTime.Now;
                    calisanlar.Clear();
                    Personel_Listbox.Items.Clear();
                    Calisan_Label.Text = "0";

                }
                else
                    HataMesajlari.KontrolEdiniz();
            }
            catch
            {

            }
        }
    }
}
