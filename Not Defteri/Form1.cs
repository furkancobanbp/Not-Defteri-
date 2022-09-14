using ClosedXML.Excel;
using Not_Defteri.Fonksiyonlar;
using Not_Defteri.Model;
using System.Data;
using System.Diagnostics;

namespace Not_Defteri
{
    public partial class frmGunlukIsler : Form
    {
        clsGunluk_isler gunlukisListesi;
        List<clsGunluk_isler> gunlukIsTablosu;
        dbOperations sql;
        int id = 0;

        public frmGunlukIsler()
        {
            gunlukisListesi = new clsGunluk_isler();
            gunlukIsTablosu = new List<clsGunluk_isler>();
            sql = new dbOperations();
            

            InitializeComponent();
        }
        

        private void frmGunlukIsler_Load(object sender, EventArgs e)
        {
                       

            gunlukIsTablosu = sql.gunlukIslerTablosu();
            dataGridView1.DataSource = gunlukIsTablosu;

            txtYapilan_is.DataBindings.Add("Text", gunlukisListesi, "isAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            date_isTarihi.DataBindings.Add("Value", gunlukisListesi, "isTarihi", true, DataSourceUpdateMode.OnPropertyChanged);
            rtxtAciklama.DataBindings.Add("Text", gunlukisListesi, "aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            chk_isDurum.DataBindings.Add("Checked", gunlukisListesi, "isTamamlandimi", true, DataSourceUpdateMode.OnPropertyChanged);
            
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sql = new dbOperations();
            sql.insertGunlukIsSQL(gunlukisListesi);
            gunlukIsTablosu = sql.gunlukIslerTablosu();
            dataGridView1.DataSource = gunlukIsTablosu;

            MessageBox.Show("Kayýt Tamamlandý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            gunlukIsTablosu = sql.gunlukIslerTablosu();
            dataGridView1.DataSource = gunlukIsTablosu;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtYapilan_is.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            date_isTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            chk_isDurum.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            rtxtAciklama.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if ( id == 0)
            {
                MessageBox.Show("Lütfen Veri Seçimi Yapýnýz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql.isGuncelle(id, gunlukisListesi);
            MessageBox.Show("Güncelleme Tamamlandý", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            id = 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Lütfen Veri Seçimi Yapýnýz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql.isSil(id);
            MessageBox.Show("Veri silme iþlemi tamamlandý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            id = 0;

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add(row);
                foreach(DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value;
                }
                dt.Columns.Remove("Column1");
                string folderPath = @"..\..\Excel\";
                string name = folderPath + "Yapilan Ýþ Listesi.xlsx";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Ýþ Listesi");
                    wb.SaveAs(name);

                }
                var p = new Process();
                p.StartInfo = new ProcessStartInfo(name)
                {
                    UseShellExecute = true
                };
                p.Start();
            }
        }
    }
}