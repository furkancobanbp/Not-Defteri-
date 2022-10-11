namespace Not_Defteri.Model
{
    public class clsTeiasFatura
    {
        public int fatura_id { get; set; }
        public  DateTime faturaDonem { get; set; }
        public int tip_id { get; set; }
        public int sirket_id { get; set; }
        public int santral_id { get; set; }
        public decimal malHizmetiToplamTutar { get;set; }
        public decimal iskonto { get; set; }
        public decimal KDV { get; set; }
        public decimal toplamTutar { get; set; }
        public decimal kdvDahilToplamTutar { get; set; }        
    }
    public class clsTeiasBilgi
    {
        public int fatura_id { get; set; }
        public DateTime faturaDonem { get; set; }
        public String faturaTipi { get; set; }
        public String sirketAdi { get; set; }
        public String santralAdi { get; set; }
        public decimal malHizmetiToplamTutar { get; set; }
        public decimal iskonto { get; set; }
        public decimal KDV { get; set; }
        public decimal toplamTutar { get; set; }
        public decimal kdvDahilToplamTutar { get; set; }

    }
}
