using IsTakipYonetimSistemi.Class;
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

        internal void LoadData()
        {
            Progress_Listbox.Items.Clear();

            var progresses = GetProgressList();
            var project = GetProject();

            Progress_Listbox.Items.Add($"Proje: {project.Ad}");
            Progress_Listbox.Items.Add($"Açıklama: {project.Aciklama}");

            CheckProgressLevel(project);

            if (IsProgressCountLowerZero(progresses))
                return;

            foreach (var progress in progresses)
            {
                Progress_Listbox.Items.
                    Add($"İlerleme: %{progress.Ilerleme_Yuzdesi} - Açıklama: {progress.Aciklama}");
                progressBar1.Value = progress.Ilerleme_Yuzdesi;
            }
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

        private void CheckProgressLevel(Proejeler project)
        {
            if ((project.Ilerleme == 100))
            {
                Ilerleme_Textbox.Enabled = false;
                IlerlemeAciklama_Richbox.Enabled = false;
                AddProgress_Btn.Enabled = false;
            }
        }

        private bool IsProgressCountLowerZero(List<Ilerlemeler> progresses)
        {
            if (progresses.Count <= 0)
            {
                Progress_Listbox.Items.Add("Şu Anda Projede Hiçbir İlerleme Bulunmamaktadır.");
                progressBar1.Value = 0;
                return true;
            }
            return false;
        }


       

        private void AddProgress_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                SoruMesajlari.instance.IlerlemeKayit();
                if (SoruMesajlari.instance.res == DialogResult.Yes)
                {
                    var aciklama = IlerlemeAciklama_Richbox.Text.Trim();
                    var ilerlemeYuzdesi = Ilerleme_Textbox.Text.Trim();
                    var convertedIlerlemeYuzdesi = Int16.Parse(ilerlemeYuzdesi);


                    if (!IsProgressLevelCorrect(convertedIlerlemeYuzdesi))
                        return;

                    if (IsEmpty(aciklama, ilerlemeYuzdesi))
                        return;

                    if (!IsProjectOver(convertedIlerlemeYuzdesi))
                        return;

                    var progresses = DB_Connection.db.Ilerlemeler.Where(x => x.Proje_Id == proje_Id).ToList();

                    if (!IsNewProgressLevelValid(progresses, convertedIlerlemeYuzdesi))
                        return;

                    AddProgressToDb(proje_Id, convertedIlerlemeYuzdesi, aciklama);

                    IlerlemeAciklama_Richbox.Text = string.Empty;
                    Ilerleme_Textbox.Text = string.Empty;

                    LoadData();
                }
            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }

        }

        private void AddProgressToDb(int proje_Id, short convertedIlerlemeYuzdesi, string aciklama)
        {
            Ilerlemeler ilerleme = new Ilerlemeler();
            ilerleme.Proje_Id = proje_Id;
            ilerleme.Ilerleme_Yuzdesi = convertedIlerlemeYuzdesi;
            ilerleme.Aciklama = aciklama;
            DB_Connection.db.Ilerlemeler.Add(ilerleme);

            var proje = DB_Connection.db.Proejeler.Find(proje_Id);
            proje.Ilerleme = convertedIlerlemeYuzdesi;

            if (convertedIlerlemeYuzdesi == 100)
            {
                proje.IsDone = true;
                BasariliMesajlar.ProjeBitti();
            }

            DB_Connection.db.SaveChanges();
        }

        private bool IsNewProgressLevelValid(List<Ilerlemeler> progresses, short convertedIlerlemeYuzdesi)
        {
            foreach (var progress in progresses)
            {
                if (convertedIlerlemeYuzdesi <= progress.Ilerleme_Yuzdesi)
                {
                    HataMesajlari.IlerlemeYanlis();
                    return false;
                }
            }
            return true;
        }

        private static bool IsProgressLevelCorrect(short convertedIlerlemeYuzdesi)
        {
            if (convertedIlerlemeYuzdesi < 0 || convertedIlerlemeYuzdesi > 100)
            {
                HataMesajlari.IlerlemeYanlis();
                return false;
            }
            return true;
        }

        private bool IsEmpty(string aciklama, string ilerlemeYuzdesi)
        {
            if (aciklama != string.Empty && ilerlemeYuzdesi != string.Empty)
            {
                return false;
            }
            return true;
        }

        private static bool IsProjectOver(short convertedIlerlemeYuzdesi)
        {
            if (convertedIlerlemeYuzdesi == 100)
            {
                SoruMesajlari.instance.ProjeBitiyor();
                if (SoruMesajlari.instance.res == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }


        private void Close_Btn_Click(object sender, EventArgs e)
        {

            ShowProjects.instance.LoadData(CallProjects.OngoingProjects());
            Close();
        }
    }
}
