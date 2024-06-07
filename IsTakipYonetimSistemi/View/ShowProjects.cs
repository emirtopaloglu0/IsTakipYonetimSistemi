using IsTakipYonetimSistemi.Class;
using IsTakipYonetimSistemi.Class.Projects;
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

        internal Label CreateLabel(int labelTag, string name, bool autoSize = true)
        {
            Label label = new Label();
            label.Text = name;
            label.Font = new Font("Figtree", 14, FontStyle.Bold);
            label.AutoSize = autoSize;
            label.Tag = labelTag;

            return label;
        }


        internal Button CreateButton(int buttonTag, string name, bool autoSize = true, 
            Color? backColor = null, Color? foreColor = null)
        {
            Button button = new Button();
            button.Tag = buttonTag;
            button.Text = name;
            button.Font = new Font("Figtree", 14, FontStyle.Bold);
            button.AutoSize = autoSize;
            button.BackColor = backColor ?? Color.White;
            button.ForeColor = foreColor ?? Color.Black;
            return button;
        }

        internal void LoadData(List<Proejeler> projeler)
        {
            try
            {
                ProjelerPanel.Controls.Clear();
                Projeler_Listbox.Items.Clear();
                Projeler_Listbox.SendToBack();
                int pointCounter = 1;

                foreach (var proje in projeler)
                {
                    var baslangicTarihi = proje.Baslangic_Tarihi.ToString();
                    var bitisTarihi = proje.Bitis_Tarihi.ToString();

                    Label projectNameLabel = CreateLabel(proje.Id, proje.Ad);
                    projectNameLabel.Location = new Point(20, 40 * pointCounter);

                    var progress = proje.Ilerleme.ToString().Trim();
                    Label progressLevelLabel = CreateLabel(proje.Id, progress);
                    progressLevelLabel.Location = new Point(40, 40 * pointCounter);

                    //Label descriptionLabel = CreateLabel(proje.Id, proje.Aciklama, autoSize: false);
                    //descriptionLabel.Location = new Point(40, 100 * pointCounter);
                    //descriptionLabel.Dock = DockStyle.Fill;

                    Label startDateLabel = CreateLabel(proje.Id, $"Başlangıç Tarihi: {baslangicTarihi}");
                    startDateLabel.Location = new Point(80, 80 * pointCounter);

                    Label endDateLabel = CreateLabel(proje.Id, $"Bitiş Tarihi {bitisTarihi}");
                    endDateLabel.Location = new Point(100, 80 * pointCounter);

                    Button addProgressButton = CreateButton(proje.Id, "İlerlemeler");
                    addProgressButton.Location = new Point(420, 40 * pointCounter);
                    addProgressButton.Click += AddProgress_Btn_Click;

                    Button showAssigmentsButton = CreateButton(proje.Id, "Görevlendirmeler");
                    showAssigmentsButton.Location = new Point(620, 40 * pointCounter);
                    showAssigmentsButton.Click += ShowAssignment_Btn_Click;

                    ProjelerPanel.Controls.Add(projectNameLabel);
                    ProjelerPanel.Controls.Add(progressLevelLabel);
                    //ProjelerPanel.Controls.Add(descriptionLabel);
                    //ProjelerPanel.Controls.Add(startDateLabel);
                    //ProjelerPanel.Controls.Add(endDateLabel);

                    ProjelerPanel.Controls.Add(addProgressButton);
                    ProjelerPanel.Controls.Add(showAssigmentsButton);

                    //var baslangic = proje.Baslangic_Tarihi.ToString();
                    //var bitis = proje.Bitis_Tarihi.ToString();
                    //Projeler_Listbox.Items.Add
                    //    ($"PKodu: {proje.Id} - Ad: {proje.Ad} - İlerleme: %{proje.Ilerleme} - " +
                    //    $"Başlangıç Tarihi: {baslangic.Substring(0, baslangic.Length - 8)}" +
                    //    $" - Bitiş Tarihi: {bitis.Substring(0, bitis.Length - 8)} - Açıklama: {proje.Aciklama}");

                    pointCounter++;
                }

                AddProgress_Btn.Enabled = true;



            }
            catch (Exception ex)
            {
                HataMesajlari.CatchError(ex);
            }
        }

        private void ShowContinuing_Btn_Click(object sender, EventArgs e)
        {
            LoadData(CallProjects.OngoingProjects());
        }

        private void ShowFinished_Btn_Click(object sender, EventArgs e)
        {
            LoadData(CallProjects.FinishedProjects());
        }

        private void ShowAssignment_Btn_Click(object sender, EventArgs e)
        {
            Projeler_Listbox.BringToFront();
            Projeler_Listbox.Items.Clear();


            var senderButton = sender as Button;
            int senderButtonTag = Convert.ToInt32(senderButton.Tag);

            var proje = DB_Connection.db.Proejeler.Find(senderButtonTag);
            var detay = DB_Connection.db.Proje_Calisanlari.Where(x => x.Proje_Id == proje.Id);

            Projeler_Listbox.Items.Add($"Proje Adı: {proje.Ad}");

            foreach (var item in detay)
            {
                var calisan = DB_Connection.db.Calisanlar.Find(item.Calisan_Id);
                Projeler_Listbox.Items.
                    Add($"Çalışan: {calisan.Ad} {calisan.Soyad} - Görev: {item.Calisan_Gorev}");

            }

            //if (Projeler_Listbox.SelectedIndex > -1)
            //{
            //    var selected_Project = Projeler_Listbox.SelectedItem.ToString().Split(':', '-');
            //    var proje = DB_Connection.db.Proejeler.Find(Int32.Parse(selected_Project[1]));
            //    var detay = DB_Connection.db.Proje_Calisanlari.Where(x => x.Proje_Id == proje.Id);
            //    Projeler_Listbox.Items.Clear();
            //    Projeler_Listbox.Items.Add($"Proje Adı: {proje.Ad}");
            //    foreach (var item in detay)
            //    {
            //        var calisan = DB_Connection.db.Calisanlar.Find(item.Calisan_Id);
            //        Projeler_Listbox.Items.Add($"Çalışan: {calisan.Ad} {calisan.Soyad} - Görev: {item.Calisan_Gorev}");

            //    }
            //    AddProgress_Btn.Enabled = false;

            //}
            //else
            //    HataMesajlari.ProjeSeciniz();
        }

        private void AddProgress_Btn_Click(object sender, EventArgs e)
        {
            var senderButton = sender as Button;
            IlerlemeEkleForm ilerlemeForm = new IlerlemeEkleForm();
            IlerlemeEkleForm.instance.proje_Id = Convert.ToInt32(senderButton.Tag);
            IlerlemeEkleForm.instance.LoadData();
            ilerlemeForm.ShowDialog();


            //if (Projeler_Listbox.SelectedIndex > -1)
            //{
            //    var selected_Project = Projeler_Listbox.SelectedItem.ToString().Split(':', '-');
            //    IlerlemeEkleForm f = new IlerlemeEkleForm();
            //    IlerlemeEkleForm.instance.proje_Id = Int32.Parse(selected_Project[1]);
            //    IlerlemeEkleForm.instance.LoadData();
            //    f.ShowDialog();
            //}
            //else
            //    HataMesajlari.ProjeSeciniz();
        }
    }
}
