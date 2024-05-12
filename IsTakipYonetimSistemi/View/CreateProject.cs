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
            PersonelEkleForm.instance.LoadData(false,0,false,string.Empty);
            PersonelEkleForm.instance.LoadDepartmanData();
            f.ShowDialog();
        }


        internal void CalculateStaff()
        {
            try
            {
               Calisan_Label.Text = calisanlar.Count.ToString();
            }
            catch
            {

            }
        }

        private void CreateProject_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
