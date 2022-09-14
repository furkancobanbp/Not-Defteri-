using System.Collections.ObjectModel;
using System.Data.SQLite;
using Dapper;
using Not_Defteri.Model;

namespace Not_Defteri.Fonksiyonlar
{
    public class dbOperations
    {
        
        SQLiteConnection con = new SQLiteConnection("Data Source = CeliklerNotation.db");
        
        public async void insertGunlukIsSQL(clsGunluk_isler gunlukIs)
        {
            var sql = "insert into tblGunlukYapilacakIsler(isAdi, isTarihi, isTamamlandimi, aciklama)" +
                "values (@isAdi, @isTarihi, @isTamamlandimi, @aciklama)";
            con.Open();
            await con.ExecuteAsync(sql, gunlukIs);

            con.Close();
        }
        public List<clsGunluk_isler> gunlukIslerTablosu()

        {
            var results = new List<clsGunluk_isler>();
            con.Open();
            var sql = "select * from tblGunlukYapilacakIsler";
            results = con.Query<clsGunluk_isler>(sql).ToList();
            
            con.Close();
            return results;

        }
        public async void isSil(int id)

        {
            var results = new List<clsGunluk_isler>();
            con.Open();
            var sql = "delete from tblGunlukYapilacakIsler where is_id = "+id+"";
            await con.ExecuteAsync(sql);
            con.Close();
            

        }
        public async void isGuncelle(int id, clsGunluk_isler gunlukIs)
        {   con.Open();
            await con.ExecuteAsync("update tblGunlukYapilacakIsler set " +
                "isAdi = @isAdi, isTarihi = @isTarihi, isTamamlandimi = @isTamamlandimi, aciklama = @aciklama" +
                "where is_id = " + id + "", gunlukIs);
            con.Close();
        }
        public List<clsSirket> sirketBilgisiAl()
        {
            var results = new List<clsSirket>();
            con.Open();
            var sql = "select * from tblSirket";
            results = con.Query<clsSirket>(sql).ToList();
            con.Close();
            return results;
        }
        public List<clsSantral> santralBilgisiAl(int id)
        {          
            String query = " where sirket_id = " + id + "";
            if (id == null)
            {
                query = "";                
            }
            var results = new List<clsSantral>();
            con.Open();
            var sql = "select * from tblSantral"+query;
            results = con.Query<clsSantral>(sql).ToList();
            con.Close();
            return results;
        }
        public async void gipKayit(clsGipKayit kayit)
        {
            var sql = "insert into tblGipIslemleri(sirket_id, santral_id, aksaAciklama, santralAciklama, blok, tarih)" +
                "values(@sirket_id, @santral_id, @aksaAciklama, @santralAciklama, @blok, @tarih)";
            con.Open();
            con.ExecuteAsync(sql, kayit);
            con.Close();
        }
        public List<clsGipView> gridDataSource()
        {           
            var results = new List<clsGipView>();            
            var sql = "select s.sirketAdi, u.santralAdi, g.aksaAciklama, g.santralAciklama, g.blok, g.tarih" +
                    " from tblGipIslemleri g, tblSirket s, tblSantral u" +
                    " where s.sirket_id = g.sirket_id" +
                    " and u.santral_id = g.santral_id";
            con.Open();
            results = con.Query<clsGipView>(sql).ToList();           
            return results;
        }

    }
}
