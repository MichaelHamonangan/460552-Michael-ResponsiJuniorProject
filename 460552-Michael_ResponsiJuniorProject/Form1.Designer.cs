namespace _460552_Michael_ResponsiJuniorProject
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblDepartemen = new System.Windows.Forms.Label();
            this.cbKaryawan = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblPM = new System.Windows.Forms.Label();
            this.lblEng = new System.Windows.Forms.Label();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblHR = new System.Windows.Forms.Label();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(31, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 63);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(125, 112);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(121, 20);
            this.tbnama.TabIndex = 1;
            this.tbnama.Text = "field";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(133, 52);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(31, 13);
            this.lblLogo.TabIndex = 2;
            this.lblLogo.Text = "Logo";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(28, 115);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(91, 13);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama Karyawan :";
            // 
            // lblDepartemen
            // 
            this.lblDepartemen.AutoSize = true;
            this.lblDepartemen.Location = new System.Drawing.Point(33, 140);
            this.lblDepartemen.Name = "lblDepartemen";
            this.lblDepartemen.Size = new System.Drawing.Size(86, 13);
            this.lblDepartemen.TabIndex = 4;
            this.lblDepartemen.Text = "Dep. Karyawan :";
            // 
            // cbKaryawan
            // 
            this.cbKaryawan.FormattingEnabled = true;
            this.cbKaryawan.Location = new System.Drawing.Point(125, 137);
            this.cbKaryawan.Name = "cbKaryawan";
            this.cbKaryawan.Size = new System.Drawing.Size(121, 21);
            this.cbKaryawan.TabIndex = 5;
            this.cbKaryawan.Text = "dropdown";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(31, 168);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(171, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(353, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFin);
            this.panel1.Controls.Add(this.lblPM);
            this.panel1.Controls.Add(this.lblEng);
            this.panel1.Controls.Add(this.lblDev);
            this.panel1.Controls.Add(this.lblHR);
            this.panel1.Controls.Add(this.lblLegenda);
            this.panel1.Location = new System.Drawing.Point(282, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 118);
            this.panel1.TabIndex = 9;
            // 
            // lblFin
            // 
            this.lblFin.Location = new System.Drawing.Point(5, 95);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(130, 17);
            this.lblFin.TabIndex = 5;
            this.lblFin.Text = "Fin : Finance";
            // 
            // lblPM
            // 
            this.lblPM.Location = new System.Drawing.Point(5, 78);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(130, 17);
            this.lblPM.TabIndex = 4;
            this.lblPM.Text = "PM : Product Manager";
            // 
            // lblEng
            // 
            this.lblEng.Location = new System.Drawing.Point(5, 44);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(130, 17);
            this.lblEng.TabIndex = 3;
            this.lblEng.Text = "ENG : Engineer";
            // 
            // lblDev
            // 
            this.lblDev.Location = new System.Drawing.Point(5, 61);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(130, 17);
            this.lblDev.TabIndex = 2;
            this.lblDev.Text = "DEV : Developer";
            // 
            // lblHR
            // 
            this.lblHR.Location = new System.Drawing.Point(5, 27);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(130, 17);
            this.lblHR.TabIndex = 1;
            this.lblHR.Text = "HR : HR";
            // 
            // lblLegenda
            // 
            this.lblLegenda.Location = new System.Drawing.Point(5, 8);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(130, 17);
            this.lblLegenda.TabIndex = 0;
            this.lblLegenda.Text = "ID Departemen :";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(31, 208);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(397, 219);
            this.dgvData.TabIndex = 10;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(353, 433);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 462);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cbKaryawan);
            this.Controls.Add(this.lblDepartemen);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblDepartemen;
        private System.Windows.Forms.ComboBox cbKaryawan;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnLoad;
    }
}

