using Not_Defteri.Fonksiyonlar;
using Not_Defteri.Model;

namespace Not_Defteri
{
    public partial class frmGip : Form
    {
        clsGipKayit gipKayitBilgi;
        dbOperations sql;
        public frmGip()
        {
            sql = new dbOperations();
            gipKayitBilgi = new clsGipKayit();         


            InitializeComponent();
        }

        private void frmGip_Load(object sender, EventArgs e)
        {
            Sirketler.DataSource = sql.sirketBilgisiAl();


            Sirketler.DataBindings.Add("SelectedValue", gipKayitBilgi, "sirket_id", true, DataSourceUpdateMode.OnPropertyChanged);
            UEVCB.DataBindings.Add("SelectedValue", gipKayitBilgi, "santral_id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAksaAciklama.DataBindings.Add("Text", gipKayitBilgi, "aksaAciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSantralAciklama.DataBindings.Add("Text", gipKayitBilgi, "santralAciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            dateIslemTarihi.DataBindings.Add("Value", gipKayitBilgi, "tarih", true, DataSourceUpdateMode.OnPropertyChanged);
            chkBlok.DataBindings.Add("Checked", gipKayitBilgi, "blok", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void Sirketler_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Sirketler.SelectedValue);
            UEVCB.DataSource = sql.santralBilgisiAl(id);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sql.gipKayit(gipKayitBilgi);
            MessageBox.Show("Kayıt Tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.gridDataSource();
        }
    }
}
