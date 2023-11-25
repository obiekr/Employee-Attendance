
namespace ProjekAkhir
{
    partial class FormKhususBossdanHRD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDCabangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaCabangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet1 = new ProjekAkhir.finalprojectDataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDPosisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPosisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gajiTetapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet2 = new ProjekAkhir.finalprojectDataSet2();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglLahirPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPosisiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCabangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet3 = new ProjekAkhir.finalprojectDataSet3();
            this.cabangTableAdapter = new ProjekAkhir.finalprojectDataSet1TableAdapters.CabangTableAdapter();
            this.posisiTableAdapter = new ProjekAkhir.finalprojectDataSet2TableAdapters.PosisiTableAdapter();
            this.pegawaiTableAdapter = new ProjekAkhir.finalprojectDataSet3TableAdapters.PegawaiTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formKhususBossDanHRDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeleteCabangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabel Cabang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tabel Posisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tabel Pegawai";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1069, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCabangDataGridViewTextBoxColumn,
            this.namaCabangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cabangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(771, 128);
            this.dataGridView1.TabIndex = 4;
            // 
            // iDCabangDataGridViewTextBoxColumn
            // 
            this.iDCabangDataGridViewTextBoxColumn.DataPropertyName = "IDCabang";
            this.iDCabangDataGridViewTextBoxColumn.HeaderText = "IDCabang";
            this.iDCabangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDCabangDataGridViewTextBoxColumn.Name = "iDCabangDataGridViewTextBoxColumn";
            this.iDCabangDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaCabangDataGridViewTextBoxColumn
            // 
            this.namaCabangDataGridViewTextBoxColumn.DataPropertyName = "NamaCabang";
            this.namaCabangDataGridViewTextBoxColumn.HeaderText = "NamaCabang";
            this.namaCabangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaCabangDataGridViewTextBoxColumn.Name = "namaCabangDataGridViewTextBoxColumn";
            this.namaCabangDataGridViewTextBoxColumn.Width = 150;
            // 
            // cabangBindingSource
            // 
            this.cabangBindingSource.DataMember = "Cabang";
            this.cabangBindingSource.DataSource = this.finalprojectDataSet1;
            // 
            // finalprojectDataSet1
            // 
            this.finalprojectDataSet1.DataSetName = "finalprojectDataSet1";
            this.finalprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPosisiDataGridViewTextBoxColumn,
            this.namaPosisiDataGridViewTextBoxColumn,
            this.gajiTetapDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.posisiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(40, 262);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(771, 143);
            this.dataGridView2.TabIndex = 5;
            // 
            // iDPosisiDataGridViewTextBoxColumn
            // 
            this.iDPosisiDataGridViewTextBoxColumn.DataPropertyName = "IDPosisi";
            this.iDPosisiDataGridViewTextBoxColumn.HeaderText = "IDPosisi";
            this.iDPosisiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPosisiDataGridViewTextBoxColumn.Name = "iDPosisiDataGridViewTextBoxColumn";
            this.iDPosisiDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaPosisiDataGridViewTextBoxColumn
            // 
            this.namaPosisiDataGridViewTextBoxColumn.DataPropertyName = "NamaPosisi";
            this.namaPosisiDataGridViewTextBoxColumn.HeaderText = "NamaPosisi";
            this.namaPosisiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaPosisiDataGridViewTextBoxColumn.Name = "namaPosisiDataGridViewTextBoxColumn";
            this.namaPosisiDataGridViewTextBoxColumn.Width = 150;
            // 
            // gajiTetapDataGridViewTextBoxColumn
            // 
            this.gajiTetapDataGridViewTextBoxColumn.DataPropertyName = "GajiTetap";
            this.gajiTetapDataGridViewTextBoxColumn.HeaderText = "GajiTetap";
            this.gajiTetapDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gajiTetapDataGridViewTextBoxColumn.Name = "gajiTetapDataGridViewTextBoxColumn";
            this.gajiTetapDataGridViewTextBoxColumn.Width = 150;
            // 
            // posisiBindingSource
            // 
            this.posisiBindingSource.DataMember = "Posisi";
            this.posisiBindingSource.DataSource = this.finalprojectDataSet2;
            // 
            // finalprojectDataSet2
            // 
            this.finalprojectDataSet2.DataSetName = "finalprojectDataSet2";
            this.finalprojectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPegawaiDataGridViewTextBoxColumn,
            this.namaPegawaiDataGridViewTextBoxColumn,
            this.alamatPegawaiDataGridViewTextBoxColumn,
            this.emailPegawaiDataGridViewTextBoxColumn,
            this.tglLahirPegawaiDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.teleponDataGridViewTextBoxColumn,
            this.iDPosisiDataGridViewTextBoxColumn1,
            this.iDCabangDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.pegawaiBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(40, 454);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1145, 246);
            this.dataGridView3.TabIndex = 6;
            // 
            // iDPegawaiDataGridViewTextBoxColumn
            // 
            this.iDPegawaiDataGridViewTextBoxColumn.DataPropertyName = "IDPegawai";
            this.iDPegawaiDataGridViewTextBoxColumn.HeaderText = "IDPegawai";
            this.iDPegawaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPegawaiDataGridViewTextBoxColumn.Name = "iDPegawaiDataGridViewTextBoxColumn";
            this.iDPegawaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaPegawaiDataGridViewTextBoxColumn
            // 
            this.namaPegawaiDataGridViewTextBoxColumn.DataPropertyName = "NamaPegawai";
            this.namaPegawaiDataGridViewTextBoxColumn.HeaderText = "NamaPegawai";
            this.namaPegawaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaPegawaiDataGridViewTextBoxColumn.Name = "namaPegawaiDataGridViewTextBoxColumn";
            this.namaPegawaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // alamatPegawaiDataGridViewTextBoxColumn
            // 
            this.alamatPegawaiDataGridViewTextBoxColumn.DataPropertyName = "AlamatPegawai";
            this.alamatPegawaiDataGridViewTextBoxColumn.HeaderText = "AlamatPegawai";
            this.alamatPegawaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatPegawaiDataGridViewTextBoxColumn.Name = "alamatPegawaiDataGridViewTextBoxColumn";
            this.alamatPegawaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailPegawaiDataGridViewTextBoxColumn
            // 
            this.emailPegawaiDataGridViewTextBoxColumn.DataPropertyName = "EmailPegawai";
            this.emailPegawaiDataGridViewTextBoxColumn.HeaderText = "EmailPegawai";
            this.emailPegawaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailPegawaiDataGridViewTextBoxColumn.Name = "emailPegawaiDataGridViewTextBoxColumn";
            this.emailPegawaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // tglLahirPegawaiDataGridViewTextBoxColumn
            // 
            this.tglLahirPegawaiDataGridViewTextBoxColumn.DataPropertyName = "TglLahirPegawai";
            this.tglLahirPegawaiDataGridViewTextBoxColumn.HeaderText = "TglLahirPegawai";
            this.tglLahirPegawaiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tglLahirPegawaiDataGridViewTextBoxColumn.Name = "tglLahirPegawaiDataGridViewTextBoxColumn";
            this.tglLahirPegawaiDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // teleponDataGridViewTextBoxColumn
            // 
            this.teleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon";
            this.teleponDataGridViewTextBoxColumn.HeaderText = "Telepon";
            this.teleponDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teleponDataGridViewTextBoxColumn.Name = "teleponDataGridViewTextBoxColumn";
            this.teleponDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDPosisiDataGridViewTextBoxColumn1
            // 
            this.iDPosisiDataGridViewTextBoxColumn1.DataPropertyName = "IDPosisi";
            this.iDPosisiDataGridViewTextBoxColumn1.HeaderText = "IDPosisi";
            this.iDPosisiDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.iDPosisiDataGridViewTextBoxColumn1.Name = "iDPosisiDataGridViewTextBoxColumn1";
            this.iDPosisiDataGridViewTextBoxColumn1.Width = 150;
            // 
            // iDCabangDataGridViewTextBoxColumn1
            // 
            this.iDCabangDataGridViewTextBoxColumn1.DataPropertyName = "IDCabang";
            this.iDCabangDataGridViewTextBoxColumn1.HeaderText = "IDCabang";
            this.iDCabangDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.iDCabangDataGridViewTextBoxColumn1.Name = "iDCabangDataGridViewTextBoxColumn1";
            this.iDCabangDataGridViewTextBoxColumn1.Width = 150;
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataMember = "Pegawai";
            this.pegawaiBindingSource.DataSource = this.finalprojectDataSet3;
            // 
            // finalprojectDataSet3
            // 
            this.finalprojectDataSet3.DataSetName = "finalprojectDataSet3";
            this.finalprojectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cabangTableAdapter
            // 
            this.cabangTableAdapter.ClearBeforeFill = true;
            // 
            // posisiTableAdapter
            // 
            this.posisiTableAdapter.ClearBeforeFill = true;
            // 
            // pegawaiTableAdapter
            // 
            this.pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formKhususBossDanHRDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formKhususBossDanHRDToolStripMenuItem
            // 
            this.formKhususBossDanHRDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem,
            this.addDeleteCabangToolStripMenuItem});
            this.formKhususBossDanHRDToolStripMenuItem.Name = "formKhususBossDanHRDToolStripMenuItem";
            this.formKhususBossDanHRDToolStripMenuItem.Size = new System.Drawing.Size(250, 29);
            this.formKhususBossDanHRDToolStripMenuItem.Text = "Form Khusus Boss dan HRD";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // addDeleteCabangToolStripMenuItem
            // 
            this.addDeleteCabangToolStripMenuItem.Name = "addDeleteCabangToolStripMenuItem";
            this.addDeleteCabangToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.addDeleteCabangToolStripMenuItem.Text = "Add/Delete Cabang";
            this.addDeleteCabangToolStripMenuItem.Click += new System.EventHandler(this.addDeleteCabangToolStripMenuItem_Click);
            // 
            // FormKhususBossdanHRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1206, 712);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormKhususBossdanHRD";
            this.Text = "FormKhususBossdanHRD";
            this.Load += new System.EventHandler(this.FormKhususBossdanHRD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private finalprojectDataSet1 finalprojectDataSet1;
        private System.Windows.Forms.BindingSource cabangBindingSource;
        private finalprojectDataSet1TableAdapters.CabangTableAdapter cabangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCabangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaCabangDataGridViewTextBoxColumn;
        private finalprojectDataSet2 finalprojectDataSet2;
        private System.Windows.Forms.BindingSource posisiBindingSource;
        private finalprojectDataSet2TableAdapters.PosisiTableAdapter posisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPosisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPosisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gajiTetapDataGridViewTextBoxColumn;
        private finalprojectDataSet3 finalprojectDataSet3;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private finalprojectDataSet3TableAdapters.PegawaiTableAdapter pegawaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglLahirPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPosisiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCabangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formKhususBossDanHRDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeleteCabangToolStripMenuItem;
    }
}