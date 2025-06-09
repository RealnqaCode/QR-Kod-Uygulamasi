namespace QrKodOkuyucu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbQrCode = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQrCreate = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnOku = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // txtInput
            // 
            this.txtInput.Animated = true;
            this.txtInput.BorderRadius = 5;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.DefaultText = "";
            this.txtInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInput.Location = new System.Drawing.Point(100, 71);
            this.txtInput.Name = "txtInput";
            this.txtInput.PlaceholderText = "Metin Girin";
            this.txtInput.SelectedText = "";
            this.txtInput.Size = new System.Drawing.Size(300, 36);
            this.txtInput.TabIndex = 0;
            // 
            // pbQrCode
            // 
            this.pbQrCode.BorderRadius = 5;
            this.pbQrCode.ImageRotate = 0F;
            this.pbQrCode.Location = new System.Drawing.Point(100, 256);
            this.pbQrCode.Name = "pbQrCode";
            this.pbQrCode.Size = new System.Drawing.Size(300, 300);
            this.pbQrCode.TabIndex = 1;
            this.pbQrCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "QR Kod Olusturucu";
            // 
            // btnQrCreate
            // 
            this.btnQrCreate.Animated = true;
            this.btnQrCreate.AnimatedGIF = true;
            this.btnQrCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnQrCreate.BorderRadius = 5;
            this.btnQrCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQrCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQrCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQrCreate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQrCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQrCreate.FillColor = System.Drawing.Color.DarkGreen;
            this.btnQrCreate.FillColor2 = System.Drawing.Color.Lime;
            this.btnQrCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnQrCreate.ForeColor = System.Drawing.Color.White;
            this.btnQrCreate.Location = new System.Drawing.Point(31, 143);
            this.btnQrCreate.Name = "btnQrCreate";
            this.btnQrCreate.Size = new System.Drawing.Size(118, 48);
            this.btnQrCreate.TabIndex = 3;
            this.btnQrCreate.Text = "QR Olustur";
            this.btnQrCreate.Click += new System.EventHandler(this.btnQrCreate_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Animated = true;
            this.btnKaydet.AnimatedGIF = true;
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BorderRadius = 5;
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.FillColor = System.Drawing.Color.DarkGreen;
            this.btnKaydet.FillColor2 = System.Drawing.Color.Lime;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(186, 143);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 48);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnOku
            // 
            this.btnOku.Animated = true;
            this.btnOku.AnimatedGIF = true;
            this.btnOku.BackColor = System.Drawing.Color.Transparent;
            this.btnOku.BorderRadius = 5;
            this.btnOku.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOku.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOku.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOku.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOku.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOku.FillColor = System.Drawing.Color.DarkGreen;
            this.btnOku.FillColor2 = System.Drawing.Color.Lime;
            this.btnOku.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnOku.ForeColor = System.Drawing.Color.White;
            this.btnOku.Location = new System.Drawing.Point(345, 143);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(118, 48);
            this.btnOku.TabIndex = 5;
            this.btnOku.Text = "QR Oku";
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(499, 605);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnQrCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbQrCode);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Kod Olusturucu";
            ((System.ComponentModel.ISupportInitialize)(this.pbQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtInput;
        private Guna.UI2.WinForms.Guna2PictureBox pbQrCode;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnQrCreate;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnOku;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnKaydet;
    }
}

