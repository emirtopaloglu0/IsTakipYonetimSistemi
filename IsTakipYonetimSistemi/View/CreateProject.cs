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
        public List<int> calisanlarList = new List<int>();


        public CreateProject()
        {
            InitializeComponent();
            instance = this;
        }

        private void AddStaff_Btn_Click(object sender, EventArgs e)
        {
            PersonelEkleForm personelForm = new PersonelEkleForm();
            PersonelEkleForm.instance.LoadData(false, 0, false, string.Empty);
            PersonelEkleForm.instance.LoadDepartmanData();
            personelForm.ShowDialog();
        }

        internal void CalculateStaff()
        {
            try
            {
                Calisan_Label.Text = calisanlarList.Count.ToString();
                Personel_Listbox.Items.Clear();
                if (calisanlarList.Count > 0)
                {
                    foreach (var item in calisanlarList)
                    {
                        var calisan = DB_Connection.db.Calisanlar.Find(item);
                        var pozisyon = DB_Connection.db.Pozisyonlar.Find(calisan.Pozisyon_Id);
                        Personel_Listbox.Items.Add($"Ad: {calisan.Ad} {calisan.Soyad} - Pozisyon: {pozisyon.Ad}");
                    }
                }
            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }
        }

        private void CreateProject_Btn_Click(object sender, EventArgs e)
        {
            SoruMesajlari.instance.ProjeOlustur();
            if (SoruMesajlari.instance.res == DialogResult.No)
                return;
            try
            {
                string projectName = ProjectName_Richbox.Text.Trim();
                string projectDesc = ProjectDescp_Richbox.Text.Trim();
                var projectEndDate = EndDate_Datetime.Value;

                if (projectName == string.Empty && projectDesc == string.Empty &&
                    projectEndDate < DateTime.Now && calisanlarList.Count <= 0)
                {
                    HataMesajlari.KontrolEdiniz();
                    return;
                }

                AddProjectToDb(projectName, projectDesc, projectEndDate);
                AddProjectPersonelsToDb(projectName, projectDesc);
                BasariliMesajlar.ProjeOlusturuldu();

                ProjectName_Richbox.Text = string.Empty;
                ProjectDescp_Richbox.Text = string.Empty;
                EndDate_Datetime.Value = DateTime.Now;
                calisanlarList.Clear();
                Personel_Listbox.Items.Clear();
                Calisan_Label.Text = "0";
            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }
        }
        
        private static void AddProjectToDb(string projectName, string projectDesc, DateTime projectEndDate)
        {
            Proejeler proje = new Proejeler();
            proje.Ad = projectName;
            proje.Aciklama = projectDesc;
            proje.Ilerleme = 0;
            proje.Baslangic_Tarihi = DateTime.Now;
            proje.Bitis_Tarihi = projectEndDate;
            proje.IsDone = false;

            DB_Connection.db.Proejeler.Add(proje);
            DB_Connection.db.SaveChanges();
        }

        private void AddProjectPersonelsToDb(string projectName, string projectDesc)
        {
            var createdProject = DB_Connection.db.Proejeler.
                FirstOrDefault
                (x => (x.Ad == projectName && x.Aciklama == projectDesc) && x.IsDone == false);

            Proje_Calisanlari projeCalisanlari = new Proje_Calisanlari();
            foreach (var calisanItem in calisanlarList)
            {
                var calisan = DB_Connection.db.Calisanlar.Find(calisanItem);
                var pozs = DB_Connection.db.Pozisyonlar.Find(calisan.Pozisyon_Id);

                projeCalisanlari.Calisan_Id = calisanItem;
                projeCalisanlari.Proje_Id = createdProject.Id;
                projeCalisanlari.Calisan_Gorev = pozs.Ad;

                DB_Connection.db.Proje_Calisanlari.Add(projeCalisanlari);
                DB_Connection.db.SaveChanges();
            }
        }

    }
}
