namespace IsTakipYonetimSistemi.View
{
    partial class CreateProject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateProject_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectName_Richbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectDescp_Richbox = new System.Windows.Forms.RichTextBox();
            this.EndDate_Datetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.AddStaff_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Calisan_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Personel_Listbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateProject_Btn
            // 
            this.CreateProject_Btn.BackColor = System.Drawing.Color.Thistle;
            this.CreateProject_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateProject_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProject_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CreateProject_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateProject_Btn.Location = new System.Drawing.Point(413, 594);
            this.CreateProject_Btn.Name = "CreateProject_Btn";
            this.CreateProject_Btn.Size = new System.Drawing.Size(249, 58);
            this.CreateProject_Btn.TabIndex = 6;
            this.CreateProject_Btn.Text = "Projeyi Oluştur";
            this.CreateProject_Btn.UseVisualStyleBackColor = false;
            this.CreateProject_Btn.Click += new System.EventHandler(this.CreateProject_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(284, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Proje Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectName_Richbox
            // 
            this.ProjectName_Richbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProjectName_Richbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProjectName_Richbox.Location = new System.Drawing.Point(413, 3);
            this.ProjectName_Richbox.Name = "ProjectName_Richbox";
            this.ProjectName_Richbox.Size = new System.Drawing.Size(249, 59);
            this.ProjectName_Richbox.TabIndex = 1;
            this.ProjectName_Richbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(219, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Proje Açıklaması";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectDescp_Richbox
            // 
            this.ProjectDescp_Richbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProjectDescp_Richbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProjectDescp_Richbox.Location = new System.Drawing.Point(413, 88);
            this.ProjectDescp_Richbox.Name = "ProjectDescp_Richbox";
            this.ProjectDescp_Richbox.Size = new System.Drawing.Size(249, 59);
            this.ProjectDescp_Richbox.TabIndex = 2;
            this.ProjectDescp_Richbox.Text = "";
            // 
            // EndDate_Datetime
            // 
            this.EndDate_Datetime.CalendarFont = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EndDate_Datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate_Datetime.Location = new System.Drawing.Point(413, 192);
            this.EndDate_Datetime.Name = "EndDate_Datetime";
            this.EndDate_Datetime.Size = new System.Drawing.Size(249, 21);
            this.EndDate_Datetime.TabIndex = 3;
            this.EndDate_Datetime.Value = new System.DateTime(2024, 5, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(222, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Proje Bitiş Tarihi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddStaff_Btn
            // 
            this.AddStaff_Btn.BackColor = System.Drawing.Color.Thistle;
            this.AddStaff_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStaff_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStaff_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddStaff_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddStaff_Btn.Location = new System.Drawing.Point(413, 271);
            this.AddStaff_Btn.Name = "AddStaff_Btn";
            this.AddStaff_Btn.Size = new System.Drawing.Size(249, 58);
            this.AddStaff_Btn.TabIndex = 4;
            this.AddStaff_Btn.Text = "Projeye Personel Ekle";
            this.AddStaff_Btn.UseVisualStyleBackColor = false;
            this.AddStaff_Btn.Click += new System.EventHandler(this.AddStaff_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(194, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Çalışan Sayısı: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calisan_Label
            // 
            this.Calisan_Label.AutoSize = true;
            this.Calisan_Label.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Calisan_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Calisan_Label.Location = new System.Drawing.Point(374, 289);
            this.Calisan_Label.Name = "Calisan_Label";
            this.Calisan_Label.Size = new System.Drawing.Size(22, 23);
            this.Calisan_Label.TabIndex = 23;
            this.Calisan_Label.Text = "0";
            this.Calisan_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IsTakipYonetimSistemi.Properties.Resources.project;
            this.pictureBox1.Location = new System.Drawing.Point(912, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Personel_Listbox
            // 
            this.Personel_Listbox.Font = new System.Drawing.Font("Figtree", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Personel_Listbox.FormattingEnabled = true;
            this.Personel_Listbox.HorizontalScrollbar = true;
            this.Personel_Listbox.ItemHeight = 20;
            this.Personel_Listbox.Location = new System.Drawing.Point(305, 359);
            this.Personel_Listbox.Name = "Personel_Listbox";
            this.Personel_Listbox.Size = new System.Drawing.Size(464, 144);
            this.Personel_Listbox.TabIndex = 5;
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Personel_Listbox);
            this.Controls.Add(this.EndDate_Datetime);
            this.Controls.Add(this.ProjectDescp_Richbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectName_Richbox);
            this.Controls.Add(this.Calisan_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddStaff_Btn);
            this.Controls.Add(this.CreateProject_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Figtree", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "CreateProject";
            this.Size = new System.Drawing.Size(1030, 655);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CreateProject_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ProjectName_Richbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ProjectDescp_Richbox;
        private System.Windows.Forms.DateTimePicker EndDate_Datetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddStaff_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Calisan_Label;
        private System.Windows.Forms.ListBox Personel_Listbox;
    }
}
