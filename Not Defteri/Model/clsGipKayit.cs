using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Defteri.Model
{
    public class clsGipKayit
    {

        public int gip_id { get; set; }
        public int sirket_id { get; set; }
        public int santral_id { get; set; }
        public String aksaAciklama { get; set; }
        public String santralAciklama { get; set; }
        public bool blok { get; set; }
        public DateTime tarih { get; set; }
    }
    public class clsGipView
    {
        public int gip_id { get; set; }
        public String? sirketAdi { get; set; }
        public String? santralAdi { get; set; }
        public String? aksaAciklama { get; set; }
        public String? santralAciklama { get; set; }
        public bool? blok { get; set; }
        public DateTime tarih { get; set; }
    }
}
