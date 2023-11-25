
namespace ProjekAkhir
{
    partial class Menu
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
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.absenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.visprogDataSet = new ProjekAkhir.visprogDataSet();
            this.absenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.absen = new ProjekAkhir.Absen();
            this.absenTableAdapter = new ProjekAkhir.AbsenTableAdapters.AbsenTableAdapter();
            this.absenTableAdapter1 = new ProjekAkhir.visprogDataSetTableAdapters.AbsenTableAdapter();
            this.finalprojectDataSet = new ProjekAkhir.finalprojectDataSet();
            this.absenBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.absenTableAdapter2 = new ProjekAkhir.finalprojectDataSetTableAdapters.AbsenTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuBossDanHRDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManajerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatReportUntukManajerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visprogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(682, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(278, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // absenBindingSource1
            // 
            this.absenBindingSource1.DataMember = "Absen";
            this.absenBindingSource1.DataSource = this.visprogDataSet;
            // 
            // visprogDataSet
            // 
            this.visprogDataSet.DataSetName = "visprogDataSet";
            this.visprogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // absenBindingSource
            // 
            this.absenBindingSource.DataMember = "Absen";
            this.absenBindingSource.DataSource = this.absen;
            // 
            // absen
            // 
            this.absen.DataSetName = "Absen";
            this.absen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // absenTableAdapter
            // 
            this.absenTableAdapter.ClearBeforeFill = true;
            // 
            // absenTableAdapter1
            // 
            this.absenTableAdapter1.ClearBeforeFill = true;
            // 
            // finalprojectDataSet
            // 
            this.finalprojectDataSet.DataSetName = "finalprojectDataSet";
            this.finalprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // absenBindingSource2
            // 
            this.absenBindingSource2.DataMember = "Absen";
            this.absenBindingSource2.DataSource = this.finalprojectDataSet;
            // 
            // absenTableAdapter2
            // 
            this.absenTableAdapter2.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBossDanHRDToolStripMenuItem,
            this.menuManajerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuBossDanHRDToolStripMenuItem
            // 
            this.menuBossDanHRDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatReportToolStripMenuItem});
            this.menuBossDanHRDToolStripMenuItem.Name = "menuBossDanHRDToolStripMenuItem";
            this.menuBossDanHRDToolStripMenuItem.Size = new System.Drawing.Size(192, 32);
            this.menuBossDanHRDToolStripMenuItem.Text = "Menu Boss dan HRD";
            // 
            // lihatReportToolStripMenuItem
            // 
            this.lihatReportToolStripMenuItem.Name = "lihatReportToolStripMenuItem";
            this.lihatReportToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.lihatReportToolStripMenuItem.Text = "Buka Form Boss";
            this.lihatReportToolStripMenuItem.Click += new System.EventHandler(this.lihatReportToolStripMenuItem_Click);
            // 
            // menuManajerToolStripMenuItem
            // 
            this.menuManajerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lihatReportUntukManajerToolStripMenuItem});
            this.menuManajerToolStripMenuItem.Name = "menuManajerToolStripMenuItem";
            this.menuManajerToolStripMenuItem.Size = new System.Drawing.Size(141, 32);
            this.menuManajerToolStripMenuItem.Text = "Menu Manajer";
            // 
            // lihatReportUntukManajerToolStripMenuItem
            // 
            this.lihatReportUntukManajerToolStripMenuItem.Name = "lihatReportUntukManajerToolStripMenuItem";
            this.lihatReportUntukManajerToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.lihatReportUntukManajerToolStripMenuItem.Text = "Buka Form Manajer";
            this.lihatReportUntukManajerToolStripMenuItem.Click += new System.EventHandler(this.lihatReportUntukManajerToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "WELCOME TO PT.BANK JAYA ABSENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Click untuk mendaftarkan kepulanganmu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Click untuk mendaftarkan absenmu";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 98);
            this.button2.TabIndex = 13;
            this.button2.Text = "Pulang";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 98);
            this.button1.TabIndex = 12;
            this.button1.Text = "Masuk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Click untuk melihat slip gajimu";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(397, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 98);
            this.button3.TabIndex = 16;
            this.button3.Text = "Gaji";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1031, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visprogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.absenBindingSource2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Absen absen;
        private System.Windows.Forms.BindingSource absenBindingSource;
        private AbsenTableAdapters.AbsenTableAdapter absenTableAdapter;
        private visprogDataSet visprogDataSet;
        private System.Windows.Forms.BindingSource absenBindingSource1;
        private visprogDataSetTableAdapters.AbsenTableAdapter absenTableAdapter1;
        private finalprojectDataSet finalprojectDataSet;
        private System.Windows.Forms.BindingSource absenBindingSource2;
        private finalprojectDataSetTableAdapters.AbsenTableAdapter absenTableAdapter2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuBossDanHRDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuManajerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatReportUntukManajerToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}