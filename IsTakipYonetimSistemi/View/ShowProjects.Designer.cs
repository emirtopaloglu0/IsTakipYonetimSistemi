namespace IsTakipYonetimSistemi.View
{
    partial class ShowProjects
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
            this.ShowFinished_Btn = new System.Windows.Forms.Button();
            this.ShowContinuing_Btn = new System.Windows.Forms.Button();
            this.Projeler_Listbox = new System.Windows.Forms.ListBox();
            this.ShowAssignment_Btn = new System.Windows.Forms.Button();
            this.AddProgress_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowFinished_Btn
            // 
            this.ShowFinished_Btn.BackColor = System.Drawing.Color.Thistle;
            this.ShowFinished_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowFinished_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowFinished_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowFinished_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowFinished_Btn.Location = new System.Drawing.Point(549, 3);
            this.ShowFinished_Btn.Name = "ShowFinished_Btn";
            this.ShowFinished_Btn.Size = new System.Drawing.Size(175, 108);
            this.ShowFinished_Btn.TabIndex = 20;
            this.ShowFinished_Btn.Text = "Bitmiş Projeleri Göster";
            this.ShowFinished_Btn.UseVisualStyleBackColor = false;
            this.ShowFinished_Btn.Click += new System.EventHandler(this.ShowFinished_Btn_Click);
            // 
            // ShowContinuing_Btn
            // 
            this.ShowContinuing_Btn.BackColor = System.Drawing.Color.Thistle;
            this.ShowContinuing_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowContinuing_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowContinuing_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowContinuing_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowContinuing_Btn.Location = new System.Drawing.Point(730, 3);
            this.ShowContinuing_Btn.Name = "ShowContinuing_Btn";
            this.ShowContinuing_Btn.Size = new System.Drawing.Size(175, 108);
            this.ShowContinuing_Btn.TabIndex = 20;
            this.ShowContinuing_Btn.Text = "Devam Eden Projeleri Göster";
            this.ShowContinuing_Btn.UseVisualStyleBackColor = false;
            this.ShowContinuing_Btn.Click += new System.EventHandler(this.ShowContinuing_Btn_Click);
            // 
            // Projeler_Listbox
            // 
            this.Projeler_Listbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Projeler_Listbox.FormattingEnabled = true;
            this.Projeler_Listbox.HorizontalScrollbar = true;
            this.Projeler_Listbox.ItemHeight = 23;
            this.Projeler_Listbox.Location = new System.Drawing.Point(4, 117);
            this.Projeler_Listbox.Name = "Projeler_Listbox";
            this.Projeler_Listbox.Size = new System.Drawing.Size(1023, 533);
            this.Projeler_Listbox.TabIndex = 21;
            this.Projeler_Listbox.DoubleClick += new System.EventHandler(this.AddProgress_Btn_Click);
            // 
            // ShowAssignment_Btn
            // 
            this.ShowAssignment_Btn.BackColor = System.Drawing.Color.Thistle;
            this.ShowAssignment_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowAssignment_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAssignment_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShowAssignment_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowAssignment_Btn.Location = new System.Drawing.Point(4, 3);
            this.ShowAssignment_Btn.Name = "ShowAssignment_Btn";
            this.ShowAssignment_Btn.Size = new System.Drawing.Size(184, 108);
            this.ShowAssignment_Btn.TabIndex = 20;
            this.ShowAssignment_Btn.Text = "Görevlendirmeler";
            this.ShowAssignment_Btn.UseVisualStyleBackColor = false;
            this.ShowAssignment_Btn.Click += new System.EventHandler(this.ShowAssignment_Btn_Click);
            // 
            // AddProgress_Btn
            // 
            this.AddProgress_Btn.BackColor = System.Drawing.Color.Thistle;
            this.AddProgress_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProgress_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProgress_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddProgress_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddProgress_Btn.Location = new System.Drawing.Point(194, 3);
            this.AddProgress_Btn.Name = "AddProgress_Btn";
            this.AddProgress_Btn.Size = new System.Drawing.Size(184, 108);
            this.AddProgress_Btn.TabIndex = 20;
            this.AddProgress_Btn.Text = "İlerleme Ekle";
            this.AddProgress_Btn.UseVisualStyleBackColor = false;
            this.AddProgress_Btn.Click += new System.EventHandler(this.AddProgress_Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IsTakipYonetimSistemi.Properties.Resources.stakeholder;
            this.pictureBox1.Location = new System.Drawing.Point(911, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ShowProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Projeler_Listbox);
            this.Controls.Add(this.ShowContinuing_Btn);
            this.Controls.Add(this.AddProgress_Btn);
            this.Controls.Add(this.ShowAssignment_Btn);
            this.Controls.Add(this.ShowFinished_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Figtree", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ShowProjects";
            this.Size = new System.Drawing.Size(1030, 655);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ShowFinished_Btn;
        private System.Windows.Forms.Button ShowContinuing_Btn;
        private System.Windows.Forms.ListBox Projeler_Listbox;
        private System.Windows.Forms.Button ShowAssignment_Btn;
        private System.Windows.Forms.Button AddProgress_Btn;
    }
}
