using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Defteri.Model
{
    public class clsSirket
    {
        public int sirket_id { get; set; }
        public String sirketAdi { get; set; }
    }
    public class clsSantral
    {
        public int santral_id { get; set; }
        public int sirket_id { get; set; }
        public String santralAdi { get; set; }
    }   
    public class clsTalimatYonu
    {
        public int talimatYon_id { get; set; }
        public String talimatAd { get; set; }
        public int talimatKod { get; set; }
    }
}
