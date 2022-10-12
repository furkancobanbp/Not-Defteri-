namespace Not_Defteri
{
    partial class frmTeiasFaturaKayit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboSirket = new System.Windows.Forms.ComboBox();
            this.comboSantral = new System.Windows.Forms.ComboBox();
            this.comboTip = new System.Windows.Forms.ComboBox();
            this.dateFaturaDonem = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMalHizmet = new System.Windows.Forms.TextBox();
            this.txtIskonto = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTumunuListele = new System.Windows.Forms.Button();
            this.btnSirketeGoreAra = new System.Windows.Forms.Button();
            this.btnSantraleGoreAra = new System.Windows.Forms.Button();
            this.txtKDVDahil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTipeGore = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnTumList = new System.Windows.Forms.Button();
            this.btnDonemToplam = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSirket
            // 
            this.comboSirket.DisplayMember = "sirketAdi";
            this.comboSirket.FormattingEnabled = true;
            this.comboSirket.Location = new System.Drawing.Point(103, 12);
            this.comboSirket.Name = "comboSirket";
            this.comboSirket.Size = new System.Drawing.Size(151, 23);
            this.comboSirket.TabIndex = 0;
            this.comboSirket.ValueMember = "sirket_id";
            this.comboSirket.SelectedIndexChanged += new System.EventHandler(this.comboSirket_SelectedIndexChanged);
            // 
            // comboSantral
            // 
            this.comboSantral.DisplayMember = "ad";
            this.comboSantral.FormattingEnabled = true;
            this.comboSantral.Location = new System.Drawing.Point(103, 41);
            this.comboSantral.Name = "comboSantral";
            this.comboSantral.Size = new System.Drawing.Size(151, 23);
            this.comboSantral.TabIndex = 1;
            this.comboSantral.ValueMember = "id";
            // 
            // comboTip
            // 
            this.comboTip.DisplayMember = "ad";
            this.comboTip.FormattingEnabled = true;
            this.comboTip.Location = new System.Drawing.Point(103, 70);
            this.comboTip.Name = "comboTip";
            this.comboTip.Size = new System.Drawing.Size(151, 23);
            this.comboTip.TabIndex = 2;
            this.comboTip.ValueMember = "id";
            // 
            // dateFaturaDonem
            // 
            this.dateFaturaDonem.CustomFormat = "yyyy-MMMM";
            this.dateFaturaDonem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFaturaDonem.Location = new System.Drawing.Point(103, 99);
            this.dateFaturaDonem.Name = "dateFaturaDonem";
            this.dateFaturaDonem.Size = new System.Drawing.Size(151, 23);
            this.dateFaturaDonem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şirket:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Santral:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fatura Tip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fatura Dönem:";
            // 
            // txtMalHizmet
            // 
            this.txtMalHizmet.Location = new System.Drawing.Point(470, 12);
            this.txtMalHizmet.Name = "txtMalHizmet";
            this.txtMalHizmet.Size = new System.Drawing.Size(151, 23);
            this.txtMalHizmet.TabIndex = 8;
            // 
            // txtIskonto
            // 
            this.txtIskonto.Location = new System.Drawing.Point(470, 41);
            this.txtIskonto.Name = "txtIskonto";
            this.txtIskonto.Size = new System.Drawing.Size(151, 23);
            this.txtIskonto.TabIndex = 9;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(470, 70);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(151, 23);
            this.txtKDV.TabIndex = 10;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(470, 99);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(151, 23);
            this.txtToplamTutar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mal Hizmeti Toplam Tutarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "İskonto Tutarı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "KDV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Toplam Tutar:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(470, 157);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(151, 23);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Fatura Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column8,
            this.Column9});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(822, 210);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fatura_id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "faturaDonem";
            dataGridViewCellStyle1.Format = "MMMM-yyyy";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Fatura Dönemi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "faturaTipi";
            this.Column3.HeaderText = "Fatura Tipi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sirketAdi";
            this.Column4.HeaderText = "Şirket Adı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "santralAdi";
            this.Column5.HeaderText = "Santral Adı";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "malHizmetiToplamTutar";
            this.Column6.HeaderText = "Mal Hizmeti Toplam Tutarı";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "iskonto";
            this.Column7.HeaderText = "İskonto";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "KDV";
            this.Column10.HeaderText = "KDV";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "toplamTutar";
            this.Column8.HeaderText = "Toplam Tutar";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "kdvDahilToplamTutar";
            this.Column9.HeaderText = "Ödenecek Tutar";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // btnTumunuListele
            // 
            this.btnTumunuListele.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTumunuListele.Location = new System.Drawing.Point(103, 128);
            this.btnTumunuListele.Name = "btnTumunuListele";
            this.btnTumunuListele.Size = new System.Drawing.Size(151, 23);
            this.btnTumunuListele.TabIndex = 18;
            this.btnTumunuListele.Text = "Döneme Göre Tümünü Listele";
            this.btnTumunuListele.UseVisualStyleBackColor = true;
            this.btnTumunuListele.Click += new System.EventHandler(this.btnTumunuListele_Click);
            // 
            // btnSirketeGoreAra
            // 
            this.btnSirketeGoreAra.Location = new System.Drawing.Point(103, 186);
            this.btnSirketeGoreAra.Name = "btnSirketeGoreAra";
            this.btnSirketeGoreAra.Size = new System.Drawing.Size(151, 23);
            this.btnSirketeGoreAra.TabIndex = 19;
            this.btnSirketeGoreAra.Text = "Şirkete Göre Ara";
            this.btnSirketeGoreAra.UseVisualStyleBackColor = true;
            this.btnSirketeGoreAra.Click += new System.EventHandler(this.btnSirketeGoreAra_Click);
            // 
            // btnSantraleGoreAra
            // 
            this.btnSantraleGoreAra.Location = new System.Drawing.Point(103, 215);
            this.btnSantraleGoreAra.Name = "btnSantraleGoreAra";
            this.btnSantraleGoreAra.Size = new System.Drawing.Size(151, 23);
            this.btnSantraleGoreAra.TabIndex = 20;
            this.btnSantraleGoreAra.Text = "Santrale Göre Ara";
            this.btnSantraleGoreAra.UseVisualStyleBackColor = true;
            this.btnSantraleGoreAra.Click += new System.EventHandler(this.btnSantraleGoreAra_Click);
            // 
            // txtKDVDahil
            // 
            this.txtKDVDahil.Location = new System.Drawing.Point(470, 128);
            this.txtKDVDahil.Name = "txtKDVDahil";
            this.txtKDVDahil.Size = new System.Drawing.Size(151, 23);
            this.txtKDVDahil.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ödenecek Tutar:";
            // 
            // btnTipeGore
            // 
            this.btnTipeGore.Location = new System.Drawing.Point(103, 244);
            this.btnTipeGore.Name = "btnTipeGore";
            this.btnTipeGore.Size = new System.Drawing.Size(151, 23);
            this.btnTipeGore.TabIndex = 23;
            this.btnTipeGore.Text = "Fatura Tipine Göre Ara";
            this.btnTipeGore.UseVisualStyleBackColor = true;
            this.btnTipeGore.Click += new System.EventHandler(this.btnTipeGore_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(103, 273);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(151, 23);
            this.btnExcel.TabIndex = 24;
            this.btnExcel.Text = "Tabloyu Excel\'e Kaydet";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnTumList
            // 
            this.btnTumList.Location = new System.Drawing.Point(103, 157);
            this.btnTumList.Name = "btnTumList";
            this.btnTumList.Size = new System.Drawing.Size(151, 23);
            this.btnTumList.TabIndex = 25;
            this.btnTumList.Text = "Tümünü Listele";
            this.btnTumList.UseVisualStyleBackColor = true;
            this.btnTumList.Click += new System.EventHandler(this.btnTumList_Click);
            // 
            // btnDonemToplam
            // 
            this.btnDonemToplam.Location = new System.Drawing.Point(659, 157);
            this.btnDonemToplam.Name = "btnDonemToplam";
            this.btnDonemToplam.Size = new System.Drawing.Size(151, 23);
            this.btnDonemToplam.TabIndex = 26;
            this.btnDonemToplam.Text = "Dönem Toplamı Al";
            this.btnDonemToplam.UseVisualStyleBackColor = true;
            this.btnDonemToplam.Click += new System.EventHandler(this.btnDonemToplam_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridView2.Location = new System.Drawing.Point(260, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(562, 139);
            this.dataGridView2.TabIndex = 27;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "malHizmetiToplamTutar";
            this.Column11.HeaderText = "Mal Hizmeti Toplam Tutar";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "iskonto";
            this.Column12.HeaderText = "İskonto";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "KDV";
            this.Column13.HeaderText = "KDV";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "toplamTutar";
            this.Column14.HeaderText = "Toplam Tutar";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "kdvDahilToplamTutar";
            this.Column15.HeaderText = "Vergiler Dahil Toplam Tutar";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // frmTeiasFaturaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 541);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnDonemToplam);
            this.Controls.Add(this.btnTumList);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnTipeGore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtKDVDahil);
            this.Controls.Add(this.btnSantraleGoreAra);
            this.Controls.Add(this.btnSirketeGoreAra);
            this.Controls.Add(this.btnTumunuListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.txtIskonto);
            this.Controls.Add(this.txtMalHizmet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateFaturaDonem);
            this.Controls.Add(this.comboTip);
            this.Controls.Add(this.comboSantral);
            this.Controls.Add(this.comboSirket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTeiasFaturaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEİAŞ Fatura Kayıt";
            this.Load += new System.EventHandler(this.frmTeiasFaturaKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboSirket;
        private ComboBox comboSantral;
        private ComboBox comboTip;
        private DateTimePicker dateFaturaDonem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMalHizmet;
        private TextBox txtIskonto;
        private TextBox txtKDV;
        private TextBox txtToplamTutar;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnKaydet;
        private DataGridView dataGridView1;
        private Button btnTumunuListele;
        private Button btnSirketeGoreAra;
        private Button btnSantraleGoreAra;
        private TextBox txtKDVDahil;
        private Label label9;
        private Button btnTipeGore;
        private Button btnExcel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button btnTumList;
        private Button btnDonemToplam;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
    }
}