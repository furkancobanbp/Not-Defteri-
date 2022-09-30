using Not_Defteri.Fonksiyonlar;
using Not_Defteri.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            comboUevcb.DataBindings.Add("SelectedValue", talimatInsert, "santral_id", true, DataSourceUpdateMode.OnPropertyChanged);
            comboTalimatTip.DataBindings.Add("SelectedValue", talimatInsert, "talimatYon_id", true, DataSourceUpdateMode.OnPropertyChanged);
            numSaat.DataBindings.Add("Value", talimatInsert, "talimatSaat", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTalimatTarihi.DataBindings.Add("Value", talimatInsert, "talimatTarih", true, DataSourceUpdateMode.OnPropertyChanged);
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
            txtKgup.DataBindings.Add("Text", talimatInsert, "KGÜP", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRevizeEak.DataBindings.Add("Text", talimatInsert, "guncellenenEak", true, DataSourceUpdateMode.OnPropertyChanged);           
            
        }
        
        private void btnTalimatKaydet_Click(object sender, EventArgs e)
        {
            sql.talimatKayit(talimatInsert);  
            MessageBox.Show("Kayıt İşlemi Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTumunuListele_Click(object sender, EventArgs e)
        {
            kryptonDataGridView1.DataSource = sql.talimatTablo();
        }
    }
}

