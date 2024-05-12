namespace IsTakipYonetimSistemi.View
{
    partial class PersonelEkleForm
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
            this.Personel_Listbox = new System.Windows.Forms.ListBox();
            this.Projedekiler_Listbox = new System.Windows.Forms.ListBox();
            this.AddStaff_Btn = new System.Windows.Forms.Button();
            this.RemoveStaff_Btn = new System.Windows.Forms.Button();
            this.ClearStaff_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Departman_Combobox = new System.Windows.Forms.ComboBox();
            this.Pozisyon_Combobox = new System.Windows.Forms.ComboBox();
            this.ClearPozisyon_Btn = new System.Windows.Forms.PictureBox();
            this.Close_Btn = new System.Windows.Forms.PictureBox();
            this.ClearDepartman_Btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClearPozisyon_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearDepartman_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Personel_Listbox
            // 
            this.Personel_Listbox.Font = new System.Drawing.Font("Figtree", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Personel_Listbox.FormattingEnabled = true;
            this.Personel_Listbox.HorizontalScrollbar = true;
            this.Personel_Listbox.ItemHeight = 20;
            this.Personel_Listbox.Location = new System.Drawing.Point(3, 95);
            this.Personel_Listbox.Name = "Personel_Listbox";
            this.Personel_Listbox.Size = new System.Drawing.Size(442, 504);
            this.Personel_Listbox.TabIndex = 22;
            // 
            // Projedekiler_Listbox
            // 
            this.Projedekiler_Listbox.Font = new System.Drawing.Font("Figtree", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Projedekiler_Listbox.FormattingEnabled = true;
            this.Projedekiler_Listbox.HorizontalScrollbar = true;
            this.Projedekiler_Listbox.ItemHeight = 20;
            this.Projedekiler_Listbox.Location = new System.Drawing.Point(650, 95);
            this.Projedekiler_Listbox.Name = "Projedekiler_Listbox";
            this.Projedekiler_Listbox.Size = new System.Drawing.Size(442, 504);
            this.Projedekiler_Listbox.TabIndex = 22;
            // 
            // AddStaff_Btn
            // 
            this.AddStaff_Btn.BackColor = System.Drawing.Color.Thistle;
            this.AddStaff_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStaff_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStaff_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddStaff_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddStaff_Btn.Location = new System.Drawing.Point(451, 232);
            this.AddStaff_Btn.Name = "AddStaff_Btn";
            this.AddStaff_Btn.Size = new System.Drawing.Size(193, 58);
            this.AddStaff_Btn.TabIndex = 23;
            this.AddStaff_Btn.Text = "Personel Ekle";
            this.AddStaff_Btn.UseVisualStyleBackColor = false;
            this.AddStaff_Btn.Click += new System.EventHandler(this.AddStaff_Btn_Click);
            // 
            // RemoveStaff_Btn
            // 
            this.RemoveStaff_Btn.BackColor = System.Drawing.Color.Thistle;
            this.RemoveStaff_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveStaff_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveStaff_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RemoveStaff_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveStaff_Btn.Location = new System.Drawing.Point(451, 296);
            this.RemoveStaff_Btn.Name = "RemoveStaff_Btn";
            this.RemoveStaff_Btn.Size = new System.Drawing.Size(193, 58);
            this.RemoveStaff_Btn.TabIndex = 23;
            this.RemoveStaff_Btn.Text = "Personeli Çıkart";
            this.RemoveStaff_Btn.UseVisualStyleBackColor = false;
            this.RemoveStaff_Btn.Click += new System.EventHandler(this.RemoveStaff_Btn_Click);
            // 
            // ClearStaff_Btn
            // 
            this.ClearStaff_Btn.BackColor = System.Drawing.Color.Thistle;
            this.ClearStaff_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearStaff_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearStaff_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearStaff_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearStaff_Btn.Location = new System.Drawing.Point(451, 360);
            this.ClearStaff_Btn.Name = "ClearStaff_Btn";
            this.ClearStaff_Btn.Size = new System.Drawing.Size(193, 58);
            this.ClearStaff_Btn.TabIndex = 23;
            this.ClearStaff_Btn.Text = "Proje Personellerini Temizle";
            this.ClearStaff_Btn.UseVisualStyleBackColor = false;
            this.ClearStaff_Btn.Click += new System.EventHandler(this.ClearStaff_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Departman";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pozisyon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Departman_Combobox
            // 
            this.Departman_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Departman_Combobox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Departman_Combobox.FormattingEnabled = true;
            this.Departman_Combobox.Location = new System.Drawing.Point(140, 14);
            this.Departman_Combobox.Name = "Departman_Combobox";
            this.Departman_Combobox.Size = new System.Drawing.Size(267, 31);
            this.Departman_Combobox.TabIndex = 25;
            this.Departman_Combobox.SelectedIndexChanged += new System.EventHandler(this.Departman_Combobox_SelectedIndexChanged);
            // 
            // Pozisyon_Combobox
            // 
            this.Pozisyon_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pozisyon_Combobox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Pozisyon_Combobox.FormattingEnabled = true;
            this.Pozisyon_Combobox.Location = new System.Drawing.Point(140, 55);
            this.Pozisyon_Combobox.Name = "Pozisyon_Combobox";
            this.Pozisyon_Combobox.Size = new System.Drawing.Size(267, 31);
            this.Pozisyon_Combobox.TabIndex = 25;
            this.Pozisyon_Combobox.SelectedIndexChanged += new System.EventHandler(this.Pozisyon_Combobox_SelectedIndexChanged);
            // 
            // ClearPozisyon_Btn
            // 
            this.ClearPozisyon_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearPozisyon_Btn.Image = global::IsTakipYonetimSistemi.Properties.Resources.dustbin;
            this.ClearPozisyon_Btn.Location = new System.Drawing.Point(413, 55);
            this.ClearPozisyon_Btn.Name = "ClearPozisyon_Btn";
            this.ClearPozisyon_Btn.Size = new System.Drawing.Size(32, 31);
            this.ClearPozisyon_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClearPozisyon_Btn.TabIndex = 26;
            this.ClearPozisyon_Btn.TabStop = false;
            this.ClearPozisyon_Btn.Click += new System.EventHandler(this.ClearPozisyon_Btn_Click);
            // 
            // Close_Btn
            // 
            this.Close_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Btn.Image = global::IsTakipYonetimSistemi.Properties.Resources.close2;
            this.Close_Btn.Location = new System.Drawing.Point(1007, 12);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(86, 71);
            this.Close_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Btn.TabIndex = 26;
            this.Close_Btn.TabStop = false;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // ClearDepartman_Btn
            // 
            this.ClearDepartman_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearDepartman_Btn.Image = global::IsTakipYonetimSistemi.Properties.Resources.dustbin;
            this.ClearDepartman_Btn.Location = new System.Drawing.Point(413, 14);
            this.ClearDepartman_Btn.Name = "ClearDepartman_Btn";
            this.ClearDepartman_Btn.Size = new System.Drawing.Size(32, 31);
            this.ClearDepartman_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClearDepartman_Btn.TabIndex = 26;
            this.ClearDepartman_Btn.TabStop = false;
            this.ClearDepartman_Btn.Click += new System.EventHandler(this.ClearDepartman_Btn_Click);
            // 
            // PersonelEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 617);
            this.Controls.Add(this.ClearDepartman_Btn);
            this.Controls.Add(this.ClearPozisyon_Btn);
            this.Controls.Add(this.Close_Btn);
            this.Controls.Add(this.Pozisyon_Combobox);
            this.Controls.Add(this.Departman_Combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClearStaff_Btn);
            this.Controls.Add(this.RemoveStaff_Btn);
            this.Controls.Add(this.AddStaff_Btn);
            this.Controls.Add(this.Projedekiler_Listbox);
            this.Controls.Add(this.Personel_Listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkleForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClearPozisyon_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearDepartman_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Personel_Listbox;
        private System.Windows.Forms.ListBox Projedekiler_Listbox;
        private System.Windows.Forms.Button AddStaff_Btn;
        private System.Windows.Forms.Button RemoveStaff_Btn;
        private System.Windows.Forms.Button ClearStaff_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Departman_Combobox;
        private System.Windows.Forms.ComboBox Pozisyon_Combobox;
        private System.Windows.Forms.PictureBox Close_Btn;
        private System.Windows.Forms.PictureBox ClearPozisyon_Btn;
        private System.Windows.Forms.PictureBox ClearDepartman_Btn;
    }
}