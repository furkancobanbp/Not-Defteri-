namespace Not_Defteri
{
    partial class frmGunlukIsler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtYapilan_is = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_isTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_isDurum = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.is_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isTamamlandimi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBasTar = new System.Windows.Forms.DateTimePicker();
            this.dateBitTar = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rtxtAciklama = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYapilan_is
            // 
            this.txtYapilan_is.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYapilan_is.Location = new System.Drawing.Point(191, 12);
            this.txtYapilan_is.Name = "txtYapilan_is";
            this.txtYapilan_is.Size = new System.Drawing.Size(380, 23);
            this.txtYapilan_is.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yapılan İş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // date_isTarihi
            // 
            this.date_isTarihi.CustomFormat = "dd-mm-yyyy";
            this.date_isTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_isTarihi.Location = new System.Drawing.Point(191, 143);
            this.date_isTarihi.Name = "date_isTarihi";
            this.date_isTarihi.Size = new System.Drawing.Size(380, 23);
            this.date_isTarihi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "İş Tarihi";
            // 
            // chk_isDurum
            // 
            this.chk_isDurum.AutoSize = true;
            this.chk_isDurum.Location = new System.Drawing.Point(191, 172);
            this.chk_isDurum.Name = "chk_isDurum";
            this.chk_isDurum.Size = new System.Drawing.Size(156, 19);
            this.chk_isDurum.TabIndex = 7;
            this.chk_isDurum.Text = "İş Tamamlanma Durumu";
            this.chk_isDurum.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(353, 169);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(218, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet!";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.is_id,
            this.isAdi,
            this.isTarihi,
            this.isTamamlandimi,
            this.aciklama});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 225);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // is_id
            // 
            this.is_id.DataPropertyName = "is_id";
            this.is_id.HeaderText = "Column1";
            this.is_id.Name = "is_id";
            this.is_id.ReadOnly = true;
            this.is_id.Visible = false;
            // 
            // isAdi
            // 
            this.isAdi.DataPropertyName = "isAdi";
            this.isAdi.HeaderText = "İş Adı";
            this.isAdi.Name = "isAdi";
            this.isAdi.ReadOnly = true;
            // 
            // isTarihi
            // 
            this.isTarihi.DataPropertyName = "isTarihi";
            this.isTarihi.HeaderText = "İş Tarihi";
            this.isTarihi.Name = "isTarihi";
            this.isTarihi.ReadOnly = true;
            // 
            // isTamamlandimi
            // 
            this.isTamamlandimi.DataPropertyName = "isTamamlandimi";
            this.isTamamlandimi.HeaderText = "İş Tamamlanma Durumu";
            this.isTamamlandimi.Name = "isTamamlandimi";
            this.isTamamlandimi.ReadOnly = true;
            this.isTamamlandimi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isTamamlandimi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // aciklama
            // 
            this.aciklama.DataPropertyName = "aciklama";
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.Name = "aciklama";
            this.aciklama.ReadOnly = true;
            // 
            // dateBasTar
            // 
            this.dateBasTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBasTar.Location = new System.Drawing.Point(191, 197);
            this.dateBasTar.Name = "dateBasTar";
            this.dateBasTar.Size = new System.Drawing.Size(156, 23);
            this.dateBasTar.TabIndex = 10;
            // 
            // dateBitTar
            // 
            this.dateBitTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBitTar.Location = new System.Drawing.Point(191, 226);
            this.dateBitTar.Name = "dateBitTar";
            this.dateBitTar.Size = new System.Drawing.Size(156, 23);
            this.dateBitTar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Başlangıç Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bitiş Tarihi";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(191, 255);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "İki Tarih Arası Sorgula";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // rtxtAciklama
            // 
            this.rtxtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtAciklama.Location = new System.Drawing.Point(191, 44);
            this.rtxtAciklama.Multiline = true;
            this.rtxtAciklama.Name = "rtxtAciklama";
            this.rtxtAciklama.Size = new System.Drawing.Size(380, 93);
            this.rtxtAciklama.TabIndex = 15;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(353, 255);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(218, 23);
            this.btnListele.TabIndex = 16;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(353, 195);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(218, 23);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(353, 224);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(218, 23);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(577, 255);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(218, 23);
            this.btnExcel.TabIndex = 19;
            this.btnExcel.Text = "Excel\'e Aktar";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmGunlukIsler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.rtxtAciklama);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateBitTar);
            this.Controls.Add(this.dateBasTar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.chk_isDurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_isTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYapilan_is);
            this.MaximizeBox = false;
            this.Name = "frmGunlukIsler";
            this.Text = "Günlük İşler";
            this.Load += new System.EventHandler(this.frmGunlukIsler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtYapilan_is;
        private Label label1;
        private Label label2;
        private DateTimePicker date_isTarihi;
        private Label label4;
        private CheckBox chk_isDurum;
        private Button btnKaydet;
        private DataGridView dataGridView1;
        private DateTimePicker dateBasTar;
        private DateTimePicker dateBitTar;
        private Label label5;
        private Label label6;
        private Button btnSearch;
        private TextBox rtxtAciklama;
        private Button btnListele;
        private DataGridViewTextBoxColumn is_id;
        private DataGridViewTextBoxColumn isAdi;
        private DataGridViewTextBoxColumn isTarihi;
        private DataGridViewCheckBoxColumn isTamamlandimi;
        private DataGridViewTextBoxColumn aciklama;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnExcel;
    }
}