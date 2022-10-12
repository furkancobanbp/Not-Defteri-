namespace Not_Defteri
{
    partial class frmAnaEkran
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
            this.btn_isPlani = new System.Windows.Forms.Button();
            this.btnTalimatlar = new System.Windows.Forms.Button();
            this.btnTeiasSkf = new System.Windows.Forms.Button();
            this.btnGip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_isPlani
            // 
            this.btn_isPlani.Location = new System.Drawing.Point(12, 12);
            this.btn_isPlani.Name = "btn_isPlani";
            this.btn_isPlani.Size = new System.Drawing.Size(241, 58);
            this.btn_isPlani.TabIndex = 0;
            this.btn_isPlani.Text = "İş Planı";
            this.btn_isPlani.UseVisualStyleBackColor = true;
            this.btn_isPlani.Click += new System.EventHandler(this.btn_isPlani_Click);
            // 
            // btnTalimatlar
            // 
            this.btnTalimatlar.Location = new System.Drawing.Point(12, 76);
            this.btnTalimatlar.Name = "btnTalimatlar";
            this.btnTalimatlar.Size = new System.Drawing.Size(241, 58);
            this.btnTalimatlar.TabIndex = 1;
            this.btnTalimatlar.Text = "Talimatlar";
            this.btnTalimatlar.UseVisualStyleBackColor = true;
            this.btnTalimatlar.Click += new System.EventHandler(this.btnTalimatlar_Click);
            // 
            // btnTeiasSkf
            // 
            this.btnTeiasSkf.Location = new System.Drawing.Point(12, 140);
            this.btnTeiasSkf.Name = "btnTeiasSkf";
            this.btnTeiasSkf.Size = new System.Drawing.Size(241, 58);
            this.btnTeiasSkf.TabIndex = 2;
            this.btnTeiasSkf.Text = "TEİAŞ SKF";
            this.btnTeiasSkf.UseVisualStyleBackColor = true;
            this.btnTeiasSkf.Click += new System.EventHandler(this.btnTeiasSkf_Click);
            // 
            // btnGip
            // 
            this.btnGip.Location = new System.Drawing.Point(12, 204);
            this.btnGip.Name = "btnGip";
            this.btnGip.Size = new System.Drawing.Size(241, 58);
            this.btnGip.TabIndex = 3;
            this.btnGip.Text = "GİP";
            this.btnGip.UseVisualStyleBackColor = true;
            this.btnGip.Click += new System.EventHandler(this.btnGip_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 272);
            this.Controls.Add(this.btnGip);
            this.Controls.Add(this.btnTeiasSkf);
            this.Controls.Add(this.btnTalimatlar);
            this.Controls.Add(this.btn_isPlani);
            this.Name = "frmAnaEkran";
            this.Text = "Not Defteri";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_isPlani;
        private Button btnTalimatlar;
        private Button btnTeiasSkf;
        private Button btnGip;
    }
}