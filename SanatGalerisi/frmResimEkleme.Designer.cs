
namespace SanatGalerisi
{
    partial class frmResimEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResimEkleme));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnKaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtMuzayedeAdi = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtResimUzantisi = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.ActiveBorderThickness = 1;
            this.btnEkle.ActiveCornerRadius = 20;
            this.btnEkle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.btnEkle.ActiveForecolor = System.Drawing.Color.White;
            this.btnEkle.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.ButtonText = "EKLE";
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.IndianRed;
            this.btnEkle.IdleBorderThickness = 1;
            this.btnEkle.IdleCornerRadius = 20;
            this.btnEkle.IdleFillColor = System.Drawing.Color.White;
            this.btnEkle.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.btnEkle.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.btnEkle.Location = new System.Drawing.Point(36, 168);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEkle.Size = new System.Drawing.Size(170, 44);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEkle.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ActiveBorderThickness = 1;
            this.btnKaydet.ActiveCornerRadius = 20;
            this.btnKaydet.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.btnKaydet.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaydet.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.ButtonText = "KAYDET";
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.IndianRed;
            this.btnKaydet.IdleBorderThickness = 1;
            this.btnKaydet.IdleCornerRadius = 20;
            this.btnKaydet.IdleFillColor = System.Drawing.Color.White;
            this.btnKaydet.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.btnKaydet.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.btnKaydet.Location = new System.Drawing.Point(214, 168);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKaydet.Size = new System.Drawing.Size(170, 44);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(624, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtMuzayedeAdi
            // 
            this.txtMuzayedeAdi.AcceptsReturn = false;
            this.txtMuzayedeAdi.AcceptsTab = false;
            this.txtMuzayedeAdi.AnimationSpeed = 200;
            this.txtMuzayedeAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMuzayedeAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMuzayedeAdi.AutoSizeHeight = true;
            this.txtMuzayedeAdi.BackColor = System.Drawing.Color.Transparent;
            this.txtMuzayedeAdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMuzayedeAdi.BackgroundImage")));
            this.txtMuzayedeAdi.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.txtMuzayedeAdi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(220)))), ((int)(((byte)(222)))));
            this.txtMuzayedeAdi.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.txtMuzayedeAdi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.txtMuzayedeAdi.BorderRadius = 1;
            this.txtMuzayedeAdi.BorderThickness = 1;
            this.txtMuzayedeAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMuzayedeAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMuzayedeAdi.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtMuzayedeAdi.DefaultText = "";
            this.txtMuzayedeAdi.FillColor = System.Drawing.Color.White;
            this.txtMuzayedeAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.txtMuzayedeAdi.HideSelection = true;
            this.txtMuzayedeAdi.IconLeft = null;
            this.txtMuzayedeAdi.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMuzayedeAdi.IconPadding = 10;
            this.txtMuzayedeAdi.IconRight = null;
            this.txtMuzayedeAdi.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMuzayedeAdi.Lines = new string[0];
            this.txtMuzayedeAdi.Location = new System.Drawing.Point(72, 57);
            this.txtMuzayedeAdi.MaxLength = 32767;
            this.txtMuzayedeAdi.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMuzayedeAdi.Modified = false;
            this.txtMuzayedeAdi.Multiline = false;
            this.txtMuzayedeAdi.Name = "txtMuzayedeAdi";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMuzayedeAdi.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(220)))), ((int)(((byte)(222)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMuzayedeAdi.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMuzayedeAdi.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMuzayedeAdi.OnIdleState = stateProperties12;
            this.txtMuzayedeAdi.Padding = new System.Windows.Forms.Padding(3);
            this.txtMuzayedeAdi.PasswordChar = '\0';
            this.txtMuzayedeAdi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMuzayedeAdi.PlaceholderText = "Müzayede Adı";
            this.txtMuzayedeAdi.ReadOnly = false;
            this.txtMuzayedeAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMuzayedeAdi.SelectedText = "";
            this.txtMuzayedeAdi.SelectionLength = 0;
            this.txtMuzayedeAdi.SelectionStart = 0;
            this.txtMuzayedeAdi.ShortcutsEnabled = true;
            this.txtMuzayedeAdi.Size = new System.Drawing.Size(260, 43);
            this.txtMuzayedeAdi.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtMuzayedeAdi.TabIndex = 26;
            this.txtMuzayedeAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMuzayedeAdi.TextMarginBottom = 0;
            this.txtMuzayedeAdi.TextMarginLeft = 3;
            this.txtMuzayedeAdi.TextMarginTop = 1;
            this.txtMuzayedeAdi.TextPlaceholder = "Müzayede Adı";
            this.txtMuzayedeAdi.UseSystemPasswordChar = false;
            this.txtMuzayedeAdi.WordWrap = true;
            // 
            // txtResimUzantisi
            // 
            this.txtResimUzantisi.AcceptsReturn = false;
            this.txtResimUzantisi.AcceptsTab = false;
            this.txtResimUzantisi.AnimationSpeed = 200;
            this.txtResimUzantisi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtResimUzantisi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtResimUzantisi.AutoSizeHeight = true;
            this.txtResimUzantisi.BackColor = System.Drawing.Color.Transparent;
            this.txtResimUzantisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtResimUzantisi.BackgroundImage")));
            this.txtResimUzantisi.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.txtResimUzantisi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(220)))), ((int)(((byte)(222)))));
            this.txtResimUzantisi.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.txtResimUzantisi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.txtResimUzantisi.BorderRadius = 1;
            this.txtResimUzantisi.BorderThickness = 1;
            this.txtResimUzantisi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtResimUzantisi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResimUzantisi.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtResimUzantisi.DefaultText = "";
            this.txtResimUzantisi.FillColor = System.Drawing.Color.White;
            this.txtResimUzantisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.txtResimUzantisi.HideSelection = true;
            this.txtResimUzantisi.IconLeft = null;
            this.txtResimUzantisi.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResimUzantisi.IconPadding = 10;
            this.txtResimUzantisi.IconRight = null;
            this.txtResimUzantisi.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResimUzantisi.Lines = new string[0];
            this.txtResimUzantisi.Location = new System.Drawing.Point(72, 106);
            this.txtResimUzantisi.MaxLength = 32767;
            this.txtResimUzantisi.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtResimUzantisi.Modified = false;
            this.txtResimUzantisi.Multiline = false;
            this.txtResimUzantisi.Name = "txtResimUzantisi";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtResimUzantisi.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(220)))), ((int)(((byte)(222)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtResimUzantisi.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtResimUzantisi.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtResimUzantisi.OnIdleState = stateProperties16;
            this.txtResimUzantisi.Padding = new System.Windows.Forms.Padding(3);
            this.txtResimUzantisi.PasswordChar = '\0';
            this.txtResimUzantisi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtResimUzantisi.PlaceholderText = "Resim Uzantısı";
            this.txtResimUzantisi.ReadOnly = false;
            this.txtResimUzantisi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResimUzantisi.SelectedText = "";
            this.txtResimUzantisi.SelectionLength = 0;
            this.txtResimUzantisi.SelectionStart = 0;
            this.txtResimUzantisi.ShortcutsEnabled = true;
            this.txtResimUzantisi.Size = new System.Drawing.Size(260, 43);
            this.txtResimUzantisi.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtResimUzantisi.TabIndex = 27;
            this.txtResimUzantisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtResimUzantisi.TextMarginBottom = 0;
            this.txtResimUzantisi.TextMarginLeft = 3;
            this.txtResimUzantisi.TextMarginTop = 1;
            this.txtResimUzantisi.TextPlaceholder = "Resim Uzantısı";
            this.txtResimUzantisi.UseSystemPasswordChar = false;
            this.txtResimUzantisi.WordWrap = true;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.White;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.txtResimUzantisi);
            this.bunifuGroupBox1.Controls.Add(this.btnEkle);
            this.bunifuGroupBox1.Controls.Add(this.txtMuzayedeAdi);
            this.bunifuGroupBox1.Controls.Add(this.btnKaydet);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Adobe Garamond Pro Bold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(60, 209);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(408, 243);
            this.bunifuGroupBox1.TabIndex = 28;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Resim Ekleme";
            // 
            // frmResimEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 720);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResimEkleme";
            this.Text = "frmResimEkleme";
            this.Load += new System.EventHandler(this.frmResimEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnEkle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.UI.WinForms.BunifuTextBox txtMuzayedeAdi;
        private Bunifu.UI.WinForms.BunifuTextBox txtResimUzantisi;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
    }
}