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
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }
        private void btn_isPlani_Click(object sender, EventArgs e)
        {
            frmGunlukIsler gunluk_isler = new frmGunlukIsler();
            gunluk_isler.ShowDialog();
        }
        private void btnTalimatlar_Click(object sender, EventArgs e)
        {
            frmTalimat talimatlar = new frmTalimat();
            talimatlar.ShowDialog();
        }

        private void btnTeiasSkf_Click(object sender, EventArgs e)
        {
            frmTeiasFaturaKayit teiasFatura = new frmTeiasFaturaKayit();
            teiasFatura.ShowDialog();
        }
        private void btnGip_Click(object sender, EventArgs e)
        {
            frmGip gip = new frmGip();
            gip.ShowDialog();
        }
    }
}
