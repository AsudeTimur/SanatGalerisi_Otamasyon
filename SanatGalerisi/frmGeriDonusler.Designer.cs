
namespace SanatGalerisi
{
    partial class frmGeriDonusler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sanatGalerisiDataSet11 = new SanatGalerisi.SanatGalerisiDataSet11();
            this.iletisimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iletisimTableAdapter = new SanatGalerisi.SanatGalerisiDataSet11TableAdapters.iletisimTableAdapter();
            this.kllncIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatGalerisiDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iletisimBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(220)))), ((int)(((byte)(222)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kllncIDDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.konuDataGridViewTextBoxColumn,
            this.mesajDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iletisimBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(65)))), ((int)(((byte)(142)))));
            this.dataGridView1.Location = new System.Drawing.Point(150, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 594);
            this.dataGridView1.TabIndex = 0;
            // 
            // sanatGalerisiDataSet11
            // 
            this.sanatGalerisiDataSet11.DataSetName = "SanatGalerisiDataSet11";
            this.sanatGalerisiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iletisimBindingSource
            // 
            this.iletisimBindingSource.DataMember = "iletisim";
            this.iletisimBindingSource.DataSource = this.sanatGalerisiDataSet11;
            // 
            // iletisimTableAdapter
            // 
            this.iletisimTableAdapter.ClearBeforeFill = true;
            // 
            // kllncIDDataGridViewTextBoxColumn
            // 
            this.kllncIDDataGridViewTextBoxColumn.DataPropertyName = "kllncID";
            this.kllncIDDataGridViewTextBoxColumn.HeaderText = "kllncID";
            this.kllncIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kllncIDDataGridViewTextBoxColumn.Name = "kllncIDDataGridViewTextBoxColumn";
            this.kllncIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kllncIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "adSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "adSoyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // konuDataGridViewTextBoxColumn
            // 
            this.konuDataGridViewTextBoxColumn.DataPropertyName = "konu";
            this.konuDataGridViewTextBoxColumn.HeaderText = "konu";
            this.konuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.konuDataGridViewTextBoxColumn.Name = "konuDataGridViewTextBoxColumn";
            this.konuDataGridViewTextBoxColumn.Width = 125;
            // 
            // mesajDataGridViewTextBoxColumn
            // 
            this.mesajDataGridViewTextBoxColumn.DataPropertyName = "mesaj";
            this.mesajDataGridViewTextBoxColumn.HeaderText = "mesaj";
            this.mesajDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mesajDataGridViewTextBoxColumn.Name = "mesajDataGridViewTextBoxColumn";
            this.mesajDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmGeriDonusler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 720);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeriDonusler";
            this.Text = "frmGeriDonusler";
            this.Load += new System.EventHandler(this.frmGeriDonusler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanatGalerisiDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iletisimBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SanatGalerisiDataSet11 sanatGalerisiDataSet11;
        private System.Windows.Forms.BindingSource iletisimBindingSource;
        private SanatGalerisiDataSet11TableAdapters.iletisimTableAdapter iletisimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kllncIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajDataGridViewTextBoxColumn;
    }
}