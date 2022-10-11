using ClosedXML.Excel;
using Not_Defteri.Fonksiyonlar;
using Not_Defteri.Model;
using System.Data;
using System.Diagnostics;

namespace Not_Defteri
{
    public partial class frmTalimat : Form
    {
        dbOperations sql;
        clsTalimatlar talimatInsert;
        public frmTalimat()
        {
            sql = new dbOperations();
            talimatInsert = new clsTalimatlar();           

            InitializeComponent();
        }
        private void frmTalimat_Load(object sender, EventArgs e)
        {
            
            comboUevcb.DataSource = sql.santralBilgisiAl(null);
            comboTalimatTip.DataSource = sql.talimatYonBilgi();
            comboSirket.DataSource = sql.sirketBilgisiAl();

            comboUevcb.DataBindings.Add("SelectedValue", talimatInsert, "santral_id", true, DataSourceUpdateMode.OnPropertyChanged);
            comboTalimatTip.DataBindings.Add("SelectedValue", talimatInsert, "talimatYon_id", true, DataSourceUpdateMode.OnPropertyChanged);
            numSaat.DataBindings.Add("Value", talimatInsert, "talimatSaat", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTalimatTarihi.DataBindings.Add("Value", talimatInsert, "talimatTarih", true, DataSourceUpdateMode.OnValidation);
            txtBirakilanTalimatMiktar.DataBindings.Add("Text", talimatInsert, "birakilanTalimat", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGelenTalimatMiktar.DataBindings.Add("Text", talimatInsert, "talimatMiktar", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTalimatFiyat.DataBindings.Add("Text", talimatInsert, "talimatFiyat", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTeslimEdilenTalimatMiktar.DataBindings.Add("Text", talimatInsert, "teslimEdilenTalimat", true, DataSourceUpdateMode.OnPropertyChanged);
            txtBlokTalimatMiktar.DataBindings.Add("Text", talimatInsert, "blokYapilanTalimat", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGipTalimatMiktar.DataBindings.Add("Text", talimatInsert, "gipYapilanTalimatMiktar", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGipTalimatTutar.DataBindings.Add("Text", talimatInsert, "gipTalimatTutar", true, DataSourceUpdateMode.OnPropertyChanged);
            txtPTF.DataBindings.Add("Text", talimatInsert, "PTF", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSMF.DataBindings.Add("Text", talimatInsert, "SMF", true, DataSourceUpdateMode.OnPropertyChanged);
            txtEak.DataBindings.Add("Text", talimatInsert, "EAK", true, DataSourceUpdateMode.OnPropertyChanged);
            txtKgup.DataBindings.Add("Text", talimatInsert, "KGUP", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRevizeEak.DataBindings.Add("Text", talimatInsert, "guncellenenEak", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void btnTalimatKaydet_Click(object sender, EventArgs e)
        {
            sql.talimatKayit(talimatInsert);
            MessageBox.Show("Kayıt İşlemi Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = sql.talimatTablo(null, null, 0, 0, 0);
        }
        private void btnTariheGoreAra_Click(object sender, EventArgs e)
        {

            String basTar = dateBasTar.Value.ToString("yyyy-MM-dd 00:00:00");
            String bitTar = dateBitTar.Value.ToString("yyyy-MM-dd 23:59:59");
            kryptonDataGridView1.DataSource = sql.talimatTablo(basTar, bitTar, Convert.ToInt32(comboUevcb.SelectedValue), Convert.ToInt32(comboTalimatTip.SelectedValue), 0);
        }
        private void btnSantraleGoreAra_Click(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = sql.talimatTablo(null, null, Convert.ToInt32(comboUevcb.SelectedValue), 0, 0);
        }
        private void btnYoneGoreAra_Click(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = sql.talimatTablo(null, null, Convert.ToInt32(comboUevcb.SelectedValue), Convert.ToInt32(comboTalimatTip.SelectedValue), 0);
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn column in kryptonDataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }
            foreach (DataGridViewRow row in kryptonDataGridView1.Rows)
            {
                dt.Rows.Add(row);
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value;
                }
            }
            dt.Columns.Remove("talimat_id");
            string folderPath = @"..\..\Excel\";
            string name = folderPath + "DGP Talimat İnceleme " + DateTime.Now.ToString("dd/MM/yyyy") + ".xlsx";
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
        private void btnSirketeGoreAra_Click(object sender, EventArgs e)
        {
            String basTar = dateBasTar.Value.ToString("yyyy-MM-dd 00:00:00");
            String bitTar = dateBitTar.Value.ToString("yyyy-MM-dd 23:59:59");

            kryptonDataGridView1.DataSource = sql.talimatTablo(basTar, bitTar, 0, 0, Convert.ToInt32(comboSirket.SelectedValue));
        }
    }
}
    


