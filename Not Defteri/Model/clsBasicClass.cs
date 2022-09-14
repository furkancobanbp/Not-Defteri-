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
}
