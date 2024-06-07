﻿using IsTakipYonetimSistemi.Class;
using IsTakipYonetimSistemi.Class.Projects;
using IsTakipYonetimSistemi.Mesajlar;
using IsTakipYonetimSistemi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipYonetimSistemi.View
{
    public partial class IlerlemeEkleForm : Form
    {
        public static IlerlemeEkleForm instance;
        public int proje_Id;
        public IlerlemeEkleForm()
        {
            InitializeComponent();
            instance = this;
        }

        internal Proejeler GetProject()
        {
            return DB_Connection.db.Proejeler.Find(proje_Id);
        }

        internal List<Ilerlemeler> GetProgressList()
        {
            var proje = GetProject();
            return DB_Connection.db.Ilerlemeler.Where(x => x.Proje_Id == proje.Id).ToList();
        }



        internal void LoadData()
        {
            Progress_Listbox.Items.Clear();

            var progresses = GetProgressList();
            var project = GetProject();

            if ((project.Ilerleme == 100))
            {
                Ilerleme_Textbox.Enabled = false;
                IlerlemeAciklama_Richbox.Enabled = false;
                AddProgress_Btn.Enabled = false;
            }

            Progress_Listbox.Items.Add($"Proje: {project.Ad}");
            Progress_Listbox.Items.Add($"Açıklama: {project.Aciklama}");

            if (progresses.Count <= 0)
            {
                Progress_Listbox.Items.Add("Şu Anda Projede Hiçbir İlerleme Bulunmamaktadır.");
                progressBar1.Value = 0;
                return;
            }

            foreach (var progress in progresses)
            {
                Progress_Listbox.Items.
                    Add($"İlerleme: %{progress.Ilerleme_Yuzdesi} - Açıklama: {progress.Aciklama}");
                progressBar1.Value = progress.Ilerleme_Yuzdesi;
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {

            ShowProjects.instance.LoadData(CallProjects.OngoingProjects());
            Close();
        }

        private void AddProgress_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IlerlemeAciklama_Richbox.Text != string.Empty && Ilerleme_Textbox.Text != string.Empty)
                {
                    if (Int16.Parse(Ilerleme_Textbox.Text) == 100)
                    {
                        SoruMesajlari.instance.ProjeBitiyor();
                        if (SoruMesajlari.instance.res == DialogResult.No)
                        {
                            return;
                        }
                        else
                            goto devam;
                    }


                    SoruMesajlari.instance.IlerlemeKayit();
                devam:
                    if (SoruMesajlari.instance.res == DialogResult.Yes)
                    {

                        var progress = DB_Connection.db.Ilerlemeler.Where(x => x.Proje_Id == proje_Id).ToList();

                        foreach (var item in progress)
                        {
                            if (Int32.Parse(Ilerleme_Textbox.Text) <= item.Ilerleme_Yuzdesi || Int32.Parse(Ilerleme_Textbox.Text) < 0 || Int32.Parse(Ilerleme_Textbox.Text) > 100)
                            {
                                HataMesajlari.IlerlemeYanlis();
                                return;
                            }

                        }




                        Ilerlemeler ilerleme = new Ilerlemeler();
                        ilerleme.Proje_Id = proje_Id;
                        ilerleme.Ilerleme_Yuzdesi = Int16.Parse(Ilerleme_Textbox.Text);
                        ilerleme.Aciklama = IlerlemeAciklama_Richbox.Text.Trim();
                        DB_Connection.db.Ilerlemeler.Add(ilerleme);

                        var proje = DB_Connection.db.Proejeler.Find(proje_Id);

                        proje.Ilerleme = Int16.Parse(Ilerleme_Textbox.Text);

                        if (Int16.Parse(Ilerleme_Textbox.Text) == 100)
                        {
                            proje.IsDone = true;
                            BasariliMesajlar.ProjeBitti();
                        }
                        DB_Connection.db.SaveChanges();
                        IlerlemeAciklama_Richbox.Text = string.Empty;
                        Ilerleme_Textbox.Text = string.Empty;
                        LoadData();
                    }

                }
                else
                    HataMesajlari.KontrolEdiniz();
            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }

        }
    }
}
