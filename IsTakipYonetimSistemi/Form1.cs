using IsTakipYonetimSistemi.Mesajlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipYonetimSistemi
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            SoruMesajlari.instance.CloseApp();
            if(SoruMesajlari.instance.res == DialogResult.Yes)
            {
                Close();
            }
        }

        internal void ShowProjects()
        {
            showProjects1.Show();
            createProject1.Hide();
        }
        internal void ShowCreateProject()
        {
            showProjects1.Hide();
            createProject1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowProjects();
        }

        private void ShowCreateProject(object sender, EventArgs e)
        {
            ShowCreateProject();
        }

        private void ShowProjects_Btn_Click(object sender, EventArgs e)
        {
            ShowProjects();
        }
    }
}
