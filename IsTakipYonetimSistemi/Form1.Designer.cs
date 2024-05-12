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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShowProjects_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Exit_Btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ShowProjects_Btn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 657);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(218, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 657);
            this.panel2.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Figtree", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ShowProjects_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit_Btn;
    }
}

