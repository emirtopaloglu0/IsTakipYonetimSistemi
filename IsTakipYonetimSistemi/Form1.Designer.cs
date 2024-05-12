namespace IsTakipYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowProjects_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createProject1 = new IsTakipYonetimSistemi.View.CreateProject();
            this.showProjects1 = new IsTakipYonetimSistemi.View.ShowProjects();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Exit_Btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ShowProjects_Btn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 657);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(20, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Yönetici Paneline\r\nHoş Geldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IsTakipYonetimSistemi.Properties.Resources.project_management;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.BackColor = System.Drawing.Color.Red;
            this.Exit_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exit_Btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit_Btn.Location = new System.Drawing.Point(3, 589);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(194, 65);
            this.Exit_Btn.TabIndex = 16;
            this.Exit_Btn.Text = "Çıkış";
            this.Exit_Btn.UseVisualStyleBackColor = false;
            this.Exit_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(3, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 65);
            this.button1.TabIndex = 16;
            this.button1.Text = "Yeni Proje Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ShowCreateProject);
            // 
            // ShowProjects_Btn
            // 
            this.ShowProjects_Btn.BackColor = System.Drawing.Color.Lavender;
            this.ShowProjects_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowProjects_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowProjects_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowProjects_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowProjects_Btn.Location = new System.Drawing.Point(3, 243);
            this.ShowProjects_Btn.Name = "ShowProjects_Btn";
            this.ShowProjects_Btn.Size = new System.Drawing.Size(194, 65);
            this.ShowProjects_Btn.TabIndex = 16;
            this.ShowProjects_Btn.Text = "Projeleri Göster";
            this.ShowProjects_Btn.UseVisualStyleBackColor = false;
            this.ShowProjects_Btn.Click += new System.EventHandler(this.ShowProjects_Btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.createProject1);
            this.panel2.Controls.Add(this.showProjects1);
            this.panel2.Location = new System.Drawing.Point(218, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 657);
            this.panel2.TabIndex = 1;
            // 
            // createProject1
            // 
            this.createProject1.Font = new System.Drawing.Font("Figtree", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createProject1.Location = new System.Drawing.Point(4, 3);
            this.createProject1.Name = "createProject1";
            this.createProject1.Size = new System.Drawing.Size(1030, 655);
            this.createProject1.TabIndex = 1;
            // 
            // showProjects1
            // 
            this.showProjects1.Font = new System.Drawing.Font("Figtree", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showProjects1.Location = new System.Drawing.Point(4, 3);
            this.showProjects1.Name = "showProjects1";
            this.showProjects1.Size = new System.Drawing.Size(1030, 655);
            this.showProjects1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Figtree", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShowProjects_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private View.CreateProject createProject1;
        private View.ShowProjects showProjects1;
    }
}

