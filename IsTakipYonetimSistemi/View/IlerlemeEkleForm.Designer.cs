namespace IsTakipYonetimSistemi.View
{
    partial class IlerlemeEkleForm
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
            this.Progress_Listbox = new System.Windows.Forms.ListBox();
            this.AddProgress_Btn = new System.Windows.Forms.Button();
            this.IlerlemeAciklama_Richbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ilerleme_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Close_Btn = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // Progress_Listbox
            // 
            this.Progress_Listbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Progress_Listbox.FormattingEnabled = true;
            this.Progress_Listbox.HorizontalScrollbar = true;
            this.Progress_Listbox.ItemHeight = 23;
            this.Progress_Listbox.Location = new System.Drawing.Point(0, 212);
            this.Progress_Listbox.Name = "Progress_Listbox";
            this.Progress_Listbox.Size = new System.Drawing.Size(1023, 441);
            this.Progress_Listbox.TabIndex = 22;
            // 
            // AddProgress_Btn
            // 
            this.AddProgress_Btn.BackColor = System.Drawing.Color.Thistle;
            this.AddProgress_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProgress_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProgress_Btn.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddProgress_Btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddProgress_Btn.Location = new System.Drawing.Point(796, 159);
            this.AddProgress_Btn.Name = "AddProgress_Btn";
            this.AddProgress_Btn.Size = new System.Drawing.Size(212, 47);
            this.AddProgress_Btn.TabIndex = 3;
            this.AddProgress_Btn.Text = "İlerlemeyi Kaydet";
            this.AddProgress_Btn.UseVisualStyleBackColor = false;
            this.AddProgress_Btn.Click += new System.EventHandler(this.AddProgress_Btn_Click);
            // 
            // IlerlemeAciklama_Richbox
            // 
            this.IlerlemeAciklama_Richbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IlerlemeAciklama_Richbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IlerlemeAciklama_Richbox.Location = new System.Drawing.Point(436, 66);
            this.IlerlemeAciklama_Richbox.Name = "IlerlemeAciklama_Richbox";
            this.IlerlemeAciklama_Richbox.Size = new System.Drawing.Size(249, 105);
            this.IlerlemeAciklama_Richbox.TabIndex = 2;
            this.IlerlemeAciklama_Richbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(238, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "İlerleme Açıklaması";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ilerleme_Textbox
            // 
            this.Ilerleme_Textbox.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ilerleme_Textbox.Location = new System.Drawing.Point(436, 9);
            this.Ilerleme_Textbox.Name = "Ilerleme_Textbox";
            this.Ilerleme_Textbox.Size = new System.Drawing.Size(249, 30);
            this.Ilerleme_Textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(304, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "İlerleme (%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Figtree", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Proje Durumu ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Btn.Image = global::IsTakipYonetimSistemi.Properties.Resources.close2;
            this.Close_Btn.Location = new System.Drawing.Point(922, 12);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(86, 71);
            this.Close_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Btn.TabIndex = 28;
            this.Close_Btn.TabStop = false;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar1.AnimationSpeed = 500;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressBar1.InnerMargin = 2;
            this.progressBar1.InnerWidth = -1;
            this.progressBar1.Location = new System.Drawing.Point(21, 35);
            this.progressBar1.MarqueeAnimationSpeed = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.OuterColor = System.Drawing.Color.Gray;
            this.progressBar1.OuterMargin = -25;
            this.progressBar1.OuterWidth = 26;
            this.progressBar1.ProgressColor = System.Drawing.Color.Lime;
            this.progressBar1.ProgressWidth = 25;
            this.progressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.progressBar1.Size = new System.Drawing.Size(178, 171);
            this.progressBar1.StartAngle = 270;
            this.progressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.progressBar1.SubscriptText = ".23";
            this.progressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar1.SuperscriptText = "°C";
            this.progressBar1.TabIndex = 30;
            this.progressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // IlerlemeEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 650);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Close_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ilerleme_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IlerlemeAciklama_Richbox);
            this.Controls.Add(this.AddProgress_Btn);
            this.Controls.Add(this.Progress_Listbox);
            this.Font = new System.Drawing.Font("Figtree", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IlerlemeEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IlerlemeEkleForm";
            ((System.ComponentModel.ISupportInitialize)(this.Close_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Progress_Listbox;
        private System.Windows.Forms.Button AddProgress_Btn;
        private System.Windows.Forms.RichTextBox IlerlemeAciklama_Richbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ilerleme_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Close_Btn;
        private CircularProgressBar.CircularProgressBar progressBar1;
    }
}