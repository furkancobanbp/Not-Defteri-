using System.ComponentModel.DataAnnotations;

namespace Not_Defteri.Model
{
    public class clsGunluk_isler
    {
        public int is_id { get; set; }
        public String? isAdi { get; set; }
        [Required(ErrorMessage = "Tarih Seçilmek Zorundadır.")]
        public DateTime isTarihi { get; set; }
        public bool? isTamamlandimi { get; set; }
        [Required(ErrorMessage = "Açıklama Girilmek Zorundadır.")]
        public String? Aciklama { get; set; }

    }
}
