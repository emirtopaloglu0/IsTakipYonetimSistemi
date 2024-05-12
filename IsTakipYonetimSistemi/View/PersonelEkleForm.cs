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
    public partial class PersonelEkleForm : Form
    {
        public static PersonelEkleForm instance;

        public PersonelEkleForm()
        {
            InitializeComponent();
            instance = this;
        }

        internal void LoadData(bool isDepartment, int dep_Id, bool isPosition, string pos_Ad)
        {
            try
            {
                Personel_Listbox.Items.Clear();
                var proje_calisanlari = DB_Connection.db.Proje_Calisanlari.ToList();
                var calisan = DB_Connection.db.Calisanlar.ToList();


                foreach (var c in calisan)
                {
                    foreach (var item in proje_calisanlari)
                    {
                        if (item.Calisan_Id == c.Id)
                        {
                            var proje = DB_Connection.db.Proejeler.Find(item.Proje_Id);

                            if(proje.IsDone == false)
                                goto devam;

                        }
                    }

                    if (isDepartment)
                    {
                        if (c.Departman_Id == dep_Id)
                        {
                            var departman1 = DB_Connection.db.Departmanlar.Find(c.Departman_Id);
                            var pozisyon1 = DB_Connection.db.Pozisyonlar.Find(c.Pozisyon_Id);
                            Personel_Listbox.Items.Add($"PNo: {c.Id} - Ad: {c.Ad} {c.Soyad} - " +
                                $"Pozisyon: {pozisyon1.Ad}");
                        }
                    }
                    else if (isPosition)
                    {
                        var pozs = DB_Connection.db.Pozisyonlar.Find(c.Pozisyon_Id);
                        if (pozs.Ad == pos_Ad)
                        {
                            var departman1 = DB_Connection.db.Departmanlar.Find(c.Departman_Id);
                            var pozisyon1 = DB_Connection.db.Pozisyonlar.Find(c.Pozisyon_Id);
                            Personel_Listbox.Items.Add($"PNo: {c.Id} - Ad: {c.Ad} {c.Soyad}");
                        }
                    }
                    else
                    {
                        var departman = DB_Connection.db.Departmanlar.Find(c.Departman_Id);
                        var pozisyon = DB_Connection.db.Pozisyonlar.Find(c.Pozisyon_Id);
                        Personel_Listbox.Items.Add($"PNo: {c.Id} - Ad: {c.Ad} {c.Soyad}" +
                            $"Departman: {departman.Ad} - Pozisyon: {pozisyon.Ad}");
                    }


                devam:;
                }
            }
            catch
            {

            }
        }


        internal void LoadDepartmanData()
        {
            Departman_Combobox.Items.Clear();
            var departman = DB_Connection.db.Departmanlar.ToList();

            foreach (var item in departman)
            {
                Departman_Combobox.Items.Add(item.Ad.Trim());
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            CreateProject.instance.CalculateStaff();
            Close();
        }

        private void AddStaff_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Personel_Listbox.SelectedIndex > -1)
                {
                    var personel = Personel_Listbox.SelectedItem.ToString().Split(':', '-');

                    if (Projedekiler_Listbox.Items.Count > 0)
                    {
                        foreach (var item in Projedekiler_Listbox.Items)
                        {
                            var projedekiler = item.ToString().Split(':', '-');
                            if (personel[1] == projedekiler[1])
                            {
                                HataMesajlari.ZatenProjede();
                                return;
                            }
                        }

                    }

                    var p_Id = Int32.Parse(personel[1]);
                    CreateProject.instance.calisanlar.Add(p_Id);

                    var c = DB_Connection.db.Calisanlar.Find(p_Id);

                    var departman = DB_Connection.db.Departmanlar.Find(c.Departman_Id);
                    var pozisyon = DB_Connection.db.Pozisyonlar.Find(c.Pozisyon_Id);

                    Projedekiler_Listbox.Items.Add($"PNo: {c.Id} - Ad: {c.Ad} {c.Soyad} - " +
                        $"Departman: {departman.Ad} - Pozisyon: {pozisyon.Ad}");

                }
                else
                    HataMesajlari.PersonelSeciniz();
            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }

        }

        private void Departman_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pozisyon_Combobox.Items.Clear();
            if (Departman_Combobox.SelectedIndex > -1)
            {
                var pozisyonlar = DB_Connection.db.Pozisyonlar.Where(x => x.Departman_Id == Departman_Combobox.SelectedIndex + 1).ToList();
                foreach (var item in pozisyonlar)
                {
                    Pozisyon_Combobox.Items.Add(item.Ad.Trim());
                }

                LoadData(true, Departman_Combobox.SelectedIndex + 1, false, string.Empty);
            }
            else
            {
                LoadData(false, 0, false, string.Empty);
            }
        }



        private void Pozisyon_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pozisyon_Combobox.SelectedIndex > -1)
            {
                LoadData(false, 0, true, Pozisyon_Combobox.SelectedItem.ToString().Trim());
            }
            else
            {
                LoadData(true, Departman_Combobox.SelectedIndex + 1, false, string.Empty);
            }
        }



        private void ClearPozisyon_Btn_Click(object sender, EventArgs e)
        {
            if (Pozisyon_Combobox.SelectedIndex > -1)
            {
                Pozisyon_Combobox.SelectedIndex = -1;

            }
        }

        private void ClearDepartman_Btn_Click(object sender, EventArgs e)
        {
            if (Departman_Combobox.SelectedIndex > -1)
            {
                Departman_Combobox.SelectedIndex = -1;
            }

        }

        private void ClearStaff_Btn_Click(object sender, EventArgs e)
        {
            Projedekiler_Listbox.Items.Clear();
            CreateProject.instance.calisanlar.Clear();
        }

        private void RemoveStaff_Btn_Click(object sender, EventArgs e)
        {
            if (Projedekiler_Listbox.SelectedIndex > -1)
            {
                var projedekiler = Projedekiler_Listbox.SelectedItem.ToString().Split(':', '-');

                Projedekiler_Listbox.Items.Remove(Projedekiler_Listbox.SelectedIndex);
                CreateProject.instance.calisanlar.Remove(Int32.Parse(projedekiler[1]));
            }
            else
                HataMesajlari.PersonelSeciniz();
        }
    }
}
