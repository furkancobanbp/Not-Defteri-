namespace Not_Defteri
{
    partial class frmGip
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
            this.Sirketler = new System.Windows.Forms.ListBox();
            this.UEVCB = new System.Windows.Forms.ListBox();
            this.txtAksaAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSantralAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSirketeGoreAra = new System.Windows.Forms.Button();
            this.btnSantraleGoreAra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTarihArasıAra = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.chkBlok = new System.Windows.Forms.CheckBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sirketler
            // 
            this.Sirketler.DisplayMember = "sirketAdi";
            this.Sirketler.FormattingEnabled = true;
            this.Sirketler.ItemHeight = 15;
            this.Sirketler.Location = new System.Drawing.Point(12, 12);
            this.Sirketler.MultiColumn = true;
            this.Sirketler.Name = "Sirketler";
            this.Sirketler.ScrollAlwaysVisible = true;
            this.Sirketler.Size = new System.Drawing.Size(231, 199);
            this.Sirketler.TabIndex = 0;
            this.Sirketler.ValueMember = "sirket_id";
            this.Sirketler.DoubleClick += new System.EventHandler(this.Sirketler_Click);
            // 
            // UEVCB
            // 
            this.UEVCB.DisplayMember = "santralAdi";
            this.UEVCB.FormattingEnabled = true;
            this.UEVCB.ItemHeight = 15;
            this.UEVCB.Location = new System.Drawing.Point(249, 12);
            this.UEVCB.MultiColumn = true;
            this.UEVCB.Name = "UEVCB";
            this.UEVCB.ScrollAlwaysVisible = true;
            this.UEVCB.Size = new System.Drawing.Size(231, 199);
            this.UEVCB.TabIndex = 1;
            this.UEVCB.ValueMember = "santral_id";
            // 
            // txtAksaAciklama
            // 
            this.txtAksaAciklama.Location = new System.Drawing.Point(249, 217);
            this.txtAksaAciklama.Multiline = true;
            this.txtAksaAciklama.Name = "txtAksaAciklama";
            this.txtAksaAciklama.Size = new System.Drawing.Size(231, 63);
            this.txtAksaAciklama.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aksa Açıklama";
            // 
            // txtSantralAciklama
            // 
            this.txtSantralAciklama.Location = new System.Drawing.Point(249, 285);
            this.txtSantralAciklama.Multiline = true;
            this.txtSantralAciklama.Name = "txtSantralAciklama";
            this.txtSantralAciklama.Size = new System.Drawing.Size(231, 63);
            this.txtSantralAciklama.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Santral Açıklama";
            // 
            // dateIslemTarihi
            // 
            this.dateIslemTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIslemTarihi.Location = new System.Drawing.Point(249, 354);
            this.dateIslemTarihi.Name = "dateIslemTarihi";
            this.dateIslemTarihi.Size = new System.Drawing.Size(231, 23);
            this.dateIslemTarihi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarih";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(249, 383);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(231, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet!";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(486, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 297);
            this.panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(631, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "gip_id";
            this.Column1.HeaderText = "gip_id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sirketAdi";
            this.Column2.HeaderText = "Şirket";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "santralAdi";
            this.Column3.HeaderText = "Santral";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "aksaAciklama";
            this.Column4.HeaderText = "Aksa Açıklaması";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "santralAciklama";
            this.Column5.HeaderText = "Santral Açıklaması";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "blok";
            this.Column6.HeaderText = "Blok Durumu";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tarih";
            this.Column7.HeaderText = "İşlem Tarihi";
            this.Column7.Name = "Column7";
            // 
            // btnSirketeGoreAra
            // 
            this.btnSirketeGoreAra.Location = new System.Drawing.Point(486, 23);
            this.btnSirketeGoreAra.Name = "btnSirketeGoreAra";
            this.btnSirketeGoreAra.Size = new System.Drawing.Size(146, 23);
            this.btnSirketeGoreAra.TabIndex = 10;
            this.btnSirketeGoreAra.Text = "Şirkete Göre Ara";
            this.btnSirketeGoreAra.UseVisualStyleBackColor = true;
            // 
            // btnSantraleGoreAra
            // 
            this.btnSantraleGoreAra.Location = new System.Drawing.Point(486, 52);
            this.btnSantraleGoreAra.Name = "btnSantraleGoreAra";
            this.btnSantraleGoreAra.Size = new System.Drawing.Size(146, 23);
            this.btnSantraleGoreAra.TabIndex = 11;
            this.btnSantraleGoreAra.Text = "Santrale Göre Ara";
            this.btnSantraleGoreAra.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Başlangıç Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(735, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 23);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(735, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 23);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bitiş Tarihi";
            // 
            // btnTarihArasıAra
            // 
            this.btnTarihArasıAra.Location = new System.Drawing.Point(852, 23);
            this.btnTarihArasıAra.Name = "btnTarihArasıAra";
            this.btnTarihArasıAra.Size = new System.Drawing.Size(146, 23);
            this.btnTarihArasıAra.TabIndex = 16;
            this.btnTarihArasıAra.Text = "İki Tarih Arası Ara";
            this.btnTarihArasıAra.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(852, 52);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(146, 23);
            this.btnExcel.TabIndex = 17;
            this.btnExcel.Text = "Excel\'e At";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // chkBlok
            // 
            this.chkBlok.AutoSize = true;
            this.chkBlok.Location = new System.Drawing.Point(12, 220);
            this.chkBlok.Name = "chkBlok";
            this.chkBlok.Size = new System.Drawing.Size(96, 19);
            this.chkBlok.TabIndex = 18;
            this.chkBlok.Text = "Blok Durumu";
            this.chkBlok.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(486, 81);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(146, 23);
            this.btnListele.TabIndex = 19;
            this.btnListele.Text = "Tümünü Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // frmGip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 430);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.chkBlok);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnTarihArasıAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSantraleGoreAra);
            this.Controls.Add(this.btnSirketeGoreAra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateIslemTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSantralAciklama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAksaAciklama);
            this.Controls.Add(this.UEVCB);
            this.Controls.Add(this.Sirketler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGip";
            this.Text = "Gip İşlemleri";
            this.Load += new System.EventHandler(this.frmGip_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Sirketler;
        private ListBox UEVCB;
        private TextBox txtAksaAciklama;
        private Label label1;
        private TextBox txtSantralAciklama;
        private Label label2;
        private DateTimePicker dateIslemTarihi;
        private Label label3;
        private Button btnKaydet;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btnSirketeGoreAra;
        private Button btnSantraleGoreAra;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Button btnTarihArasıAra;
        private Button btnExcel;
        private CheckBox chkBlok;
        private Button btnListele;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewCheckBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}