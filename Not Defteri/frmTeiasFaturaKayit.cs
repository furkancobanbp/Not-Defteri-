using ClosedXML.Excel;
using Not_Defteri.Fonksiyonlar;
using Not_Defteri.Model;
using System.Data;
using System.Diagnostics;

namespace Not_Defteri
{
    public partial class frmTeiasFaturaKayit : Form
    {
        clsTeiasFatura teiasFatura;
        dbOperations sql;
        public frmTeiasFaturaKayit()
        {
            teiasFatura = new clsTeiasFatura();
            sql = new dbOperations();

            InitializeComponent();
        }
        private void frmTeiasFaturaKayit_Load(object sender, EventArgs e)
        {
            comboSirket.DataSource = sql.sirketBilgisiAl();
            comboTip.DataSource = sql.faturaTipBilgiAl();

            comboSirket.SelectedValue = -1;
            

            comboSirket.DataBindings.Add("SelectedValue", teiasFatura, "sirket_id", true, DataSourceUpdateMode.OnPropertyChanged);
            comboSantral.DataBindings.Add("SelectedValue", teiasFatura, "santral_id", true, DataSourceUpdateMode.OnPropertyChanged);
            comboTip.DataBindings.Add("SelectedValue", teiasFatura, "tip_id", true, DataSourceUpdateMode.OnPropertyChanged);
            dateFaturaDonem.DataBindings.Add("Value", teiasFatura, "faturaDonem", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMalHizmet.DataBindings.Add("Text", teiasFatura, "malHizmetiToplamTutar", true, DataSourceUpdateMode.OnPropertyChanged);
            txtIskonto.DataBindings.Add("Text", teiasFatura, "iskonto", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKDV.DataBindings.Add("Text", teiasFatura, "KDV", true, DataSourceUpdateMode.OnPropertyChanged);
            txtToplamTutar.DataBindings.Add("Text", teiasFatura, "toplamTutar", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKDVDahil.DataBindings.Add("Text", teiasFatura, "kdvDahilToplamTutar", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void comboSirket_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sirketId = Convert.ToInt32(comboSirket.SelectedValue);
            comboSantral.DataSource = sql.teiasSantralBilgiAl(sirketId);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sql.teiasFaturaKayit(teiasFatura);
            MessageBox.Show("Kayıt Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            String basTar = dateFaturaDonem.Value.ToString("yyyy-MM-dd 00:00:00");
            String bitTar = dateFaturaDonem.Value.ToString("yyyy-MM-dd 23:59:59");

            dataGridView1.DataSource = sql.faturaTabloSource(false, 0, 0, basTar, bitTar, 0);
        }
        private void btnSirketeGoreAra_Click(object sender, EventArgs e)
        {
            String basTar = dateFaturaDonem.Value.ToString("yyyy-MM-dd 00:00:00");
            String bitTar = dateFaturaDonem.Value.ToString("yyyy-MM-dd 23:59:59");
            int sirketId = Convert.ToInt32(comboSirket.SelectedValue);

            dataGridView1.DataSource = sql.faturaTabloSource(false, sirketId, 0, basTar, bitTar, 0);
        }
        private void btnSantraleGoreAra_Click(object sender, EventArgs e)
        {
            String basTar = dateFaturaDonem.Value.ToString("yyyy-MM-dd 00:00:00");
            String bitTar = dateFaturaDonem.Value.ToString("yyyy-MM-dd 23:59:59");
            int santralId = Convert.ToInt32(comboSantral.SelectedValue);

            dataGridView1.DataSource = sql.faturaTabloSource(false, 0, santralId, basTar, bitTar, 0);
        }
        private void btnTipeGore_Click(object sender, EventArgs e)
        {
            String basTar = dateFaturaDonem.Value.ToString("yyyy-MM-dd 00:00:00");
            String bitTar = dateFaturaDonem.Value.ToString("yyyy-MM-dd 23:59:59");
            int faturaTip = Convert.ToInt32(comboTip.SelectedValue);

            dataGridView1.DataSource = sql.faturaTabloSource(false, 0, 0, basTar, bitTar, faturaTip);
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
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value;
                }
            }
            dt.Columns.Remove("Column1");
            string folderPath = @"..\..\Excel\";
            string name = folderPath + "TEİAŞ SKF EXCEL " + dateFaturaDonem.Value.ToString("MMMM-yyyy") + ".xlsx";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Talimat Listesi");
                wb.SaveAs(name);

            }
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(name)
            {
                UseShellExecute = true
            };
            p.Start();
        }

        private void btnTumList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.faturaTabloSource(false, 0, 0, null, null, 0);
        }

        private void btnDonemToplam_Click(object sender, EventArgs e)
        {
            String basTar = dateFaturaDonem.Value.ToString("yyyy-MM-dd 00:00:00");
            String bitTar = dateFaturaDonem.Value.ToString("yyyy-MM-dd 23:59:59");

            int sirketId = Convert.ToInt32(comboSirket.SelectedValue);
            int santralId = Convert.ToInt32(comboSantral.SelectedValue);

            dataGridView2.DataSource = sql.faturaTabloSource(true, sirketId, santralId, basTar, bitTar, 0);
        }
    }
}
