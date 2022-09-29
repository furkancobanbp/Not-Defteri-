using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Defteri.Model
{
    public class clsTalimatlar
    {
        public int talimat_id { get; set; }
        public int santral_id { get; set; }
        public int santralYon_id { get; set; }
        public DateTime talimatTarih { get; set; }
        public int talimatSaat { get; set; }
        public decimal birakilanTalimatMiktar { get; set; }
        public decimal gelenTalimatMiktar { get; set; }
        public decimal talimatFiyat { get; set; }
        public decimal teslimEdilenTalimat { get; set; }    
        public decimal blokYapilanTalimat { get; set; }
        public decimal gipYapilanTalimatMiktar { get; set; }
        public decimal gipTalimatTutar { get; set; }
        public decimal PTF { get; set; }
        public decimal SMF { get; set; }
        public decimal EAK { get; set; }
        public decimal KGÜP { get; set; }
        public decimal guncellenenEak { get; set; }
    }
    public class clsTalimatBilgi
    {
        public int talimat_id { get; set; }
        public String santralAdi { get; set; }
        public String talimatYon { get; set; }
        public DateTime talimatTarih { get; set; }
        public int talimatSaat { get; set; }
        public decimal birakilanTalimatMiktar { get; set; }
        public decimal gelenTalimatMiktar { get; set; }
        public decimal talimatFiyat { get; set; }
        public decimal teslimEdilenTalimat { get; set; }
        public decimal blokYapilanTalimat { get; set; }
        public decimal gipYapilanTalimatMiktar { get; set; }
        public decimal gipTalimatTutar { get; set; }
        public decimal PTF { get; set; }
        public decimal SMF { get; set; }
        public decimal EAK { get; set; }
        public decimal KGÜP { get; set; }
        public decimal guncellenenEak { get; set; }
    }
}
