
namespace ProjekAkhir
{
    partial class FormKhususManajer
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
            this.iDPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglLahirPegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPosisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCabangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet4 = new ProjekAkhir.finalprojectDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.absenTableAdapter2 = new ProjekAkhir.UASDataSetTableAdapters.AbsenTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pegawaiTableAdapter = new ProjekAkhir.finalprojectDataSet4TableAdapters.PegawaiTableAdapter();
            this.finalprojectDataSet5 = new ProjekAkhir.finalprojectDataSet5();
            this.absenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.absenTableAdapter = new ProjekAkhir.finalprojectDataSet5TableAdapters.AbsenTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuManajerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDataKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDataBerdasarCabangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDataKeTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absenBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPegawaiDataGridViewTextBoxColumn,
            this.namaPegawaiDataGridViewTextBoxColumn,
            this.alamatPegawaiDataGridViewTextBoxColumn,
            this.emailPegawaiDataGridViewTextBoxColumn,
            this.tglLahirPegawaiDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.teleponDataGridViewTextBoxColumn,
            this.iDPosisiDataGridViewTextBoxColumn,
            this.iDCabangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pegawaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(60, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // iDPosisiDataGridViewTextBoxColumn
            // 
            this.iDPosisiDataGridViewTextBoxColumn.DataPropertyName = "IDPosisi";
            this.iDPosisiDataGridViewTextBoxColumn.HeaderText = "IDPosisi";
            this.iDPosisiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPosisiDataGridViewTextBoxColumn.Name = "iDPosisiDataGridViewTextBoxColumn";
            this.iDPosisiDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDCabangDataGridViewTextBoxColumn
            // 
            this.iDCabangDataGridViewTextBoxColumn.DataPropertyName = "IDCabang";
            this.iDCabangDataGridViewTextBoxColumn.HeaderText = "IDCabang";
            this.iDCabangDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDCabangDataGridViewTextBoxColumn.Name = "iDCabangDataGridViewTextBoxColumn";
            this.iDCabangDataGridViewTextBoxColumn.Width = 150;
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataMember = "Pegawai";
            this.pegawaiBindingSource.DataSource = this.finalprojectDataSet4;
            // 
            // finalprojectDataSet4
            // 
            this.finalprojectDataSet4.DataSetName = "finalprojectDataSet4";
            this.finalprojectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Karyawan";
            // 
            // absenTableAdapter2
            // 
            this.absenTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(945, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pegawaiTableAdapter
            // 
            this.pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // finalprojectDataSet5
            // 
            this.finalprojectDataSet5.DataSetName = "finalprojectDataSet5";
            this.finalprojectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // absenBindingSource
            // 
            this.absenBindingSource.DataMember = "Absen";
            this.absenBindingSource.DataSource = this.finalprojectDataSet5;
            // 
            // absenTableAdapter
            // 
            this.absenTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManajerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuManajerToolStripMenuItem
            // 
            this.menuManajerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printDataKaryawanToolStripMenuItem,
            this.printDataBerdasarCabangToolStripMenuItem,
            this.printDataKeTxtToolStripMenuItem});
            this.menuManajerToolStripMenuItem.Name = "menuManajerToolStripMenuItem";
            this.menuManajerToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.menuManajerToolStripMenuItem.Text = "Menu Manajer";
            // 
            // printDataKaryawanToolStripMenuItem
            // 
            this.printDataKaryawanToolStripMenuItem.Name = "printDataKaryawanToolStripMenuItem";
            this.printDataKaryawanToolStripMenuItem.Size = new System.Drawing.Size(331, 34);
            this.printDataKaryawanToolStripMenuItem.Text = "Print Data Karyawan";
            this.printDataKaryawanToolStripMenuItem.Click += new System.EventHandler(this.printDataKaryawanToolStripMenuItem_Click);
            // 
            // printDataBerdasarCabangToolStripMenuItem
            // 
            this.printDataBerdasarCabangToolStripMenuItem.Name = "printDataBerdasarCabangToolStripMenuItem";
            this.printDataBerdasarCabangToolStripMenuItem.Size = new System.Drawing.Size(331, 34);
            this.printDataBerdasarCabangToolStripMenuItem.Text = "Print Data Berdasar Cabang";
            this.printDataBerdasarCabangToolStripMenuItem.Click += new System.EventHandler(this.printDataBerdasarCabangToolStripMenuItem_Click);
            // 
            // printDataKeTxtToolStripMenuItem
            // 
            this.printDataKeTxtToolStripMenuItem.Name = "printDataKeTxtToolStripMenuItem";
            this.printDataKeTxtToolStripMenuItem.Size = new System.Drawing.Size(331, 34);
            this.printDataKeTxtToolStripMenuItem.Text = "Print Data Ke CSV";
            this.printDataKeTxtToolStripMenuItem.Click += new System.EventHandler(this.printDataKeTxtToolStripMenuItem_Click);
            // 
            // FormKhususManajer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1196, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormKhususManajer";
            this.Text = "FormKhususManajer";
            this.Load += new System.EventHandler(this.FormKhususManajer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource absenBindingSource2;
        private UASDataSetTableAdapters.AbsenTableAdapter absenTableAdapter2;
        private System.Windows.Forms.Button button1;
        private finalprojectDataSet4 finalprojectDataSet4;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private finalprojectDataSet4TableAdapters.PegawaiTableAdapter pegawaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglLahirPegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPosisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCabangDataGridViewTextBoxColumn;
        private finalprojectDataSet5 finalprojectDataSet5;
        private System.Windows.Forms.BindingSource absenBindingSource;
        private finalprojectDataSet5TableAdapters.AbsenTableAdapter absenTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuManajerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printDataKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printDataBerdasarCabangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printDataKeTxtToolStripMenuItem;
    }
}