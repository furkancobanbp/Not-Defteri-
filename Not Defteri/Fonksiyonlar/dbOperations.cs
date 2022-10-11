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
            var sql = "delete from tblGunlukYapilacakIsler where is_id = " + id + "";
            await con.ExecuteAsync(sql);
            con.Close();


        }
        public async void isGuncelle(int id, clsGunluk_isler gunlukIs)
        {
            con.Open();
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
        public List<clsSantral> santralBilgisiAl(int? id)
        {
            String query = " where sirket_id = " + id + "";
            if (id == null)
            {
                query = "";
            }
            var results = new List<clsSantral>();
            con.Open();
            var sql = "select * from tblSantral" + query;
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
            con.Close();
            return results;
        }
        public List<clsTalimatYonu> talimatYonBilgi()
        {
            var results = new List<clsTalimatYonu>();
            var sql = "select * from tblTalimatYonu";
            con.Open();
            results = con.Query<clsTalimatYonu>(sql).ToList();
            con.Close();
            return results;

        }
        public async void talimatKayit(clsTalimatlar talimatKayit)
        {
            var sql = "insert into tblTalimatlar(santral_id, talimatYon_id, talimatTarih, talimatSaat, birakilanTalimat, talimatMiktar, " +
                "talimatFiyat, teslimEdilenTalimat, blokYapilanTalimat, gipYapilanTalimatMiktar, gipTalimatTutar, PTF, SMF, EAK, KGUP, guncellenenEak)" +
                " values(@santral_id, @talimatYon_id, @talimatTarih, @talimatSaat, @birakilanTalimat, @talimatMiktar, " +
                "@talimatFiyat, @teslimEdilenTalimat, @blokYapilanTalimat, @gipYapilanTalimatMiktar, @gipTalimatTutar, @PTF, @SMF, @EAK, @KGUP, @guncellenenEak)";
            con.Open();
            con.ExecuteAsync(sql, talimatKayit);
            con.Close();
        }
        public List<clsTalimatBilgi> talimatTablo(String? baslangicTarihi, String? bitisTarihi, int? santralId, int? talimatYonId, int sirketId)
        {
            var sqlDateQuery = "";
            var sqlYonQuery = "";
            var sqlSantralQuery = "";
            var sqlSirketQuery = "";
            var tblSirket = "";
            if (baslangicTarihi is not null && bitisTarihi is not null)
            {
                sqlDateQuery = "and t.talimatTarih between '" + baslangicTarihi + "' and '" + bitisTarihi + "' ";
            }
            if (santralId != 0)
            {
                sqlSantralQuery = "and t.santral_id = " + santralId + " ";
            }
            if (talimatYonId != 0)
            {
                sqlYonQuery = "and y.talimatYon_id = " + talimatYonId + " ";
            }
            if (sirketId != 0)
            {
                tblSirket = ",tblSirket c ";
                sqlSirketQuery = " and c.sirket_id = s.sirket_id and c.sirket_id = " + sirketId + " ";
            }
            var results = new List<clsTalimatBilgi>();
            var sql = "select t.talimat_id, s.santralAdi, y.talimatAd, t.talimatTarih, t.talimatSaat, t.birakilanTalimat, t.talimatMiktar, t.talimatFiyat, y.talimatAd, " +
                        "t.teslimEdilenTalimat, t.blokYapilanTalimat, t.gipYapilanTalimatMiktar, t.gipTalimatTutar, t.PTF, t.SMF, t.EAK, t.KGUP, t.guncellenenEak " +
                        "from tblTalimatlar t, tblSantral s, tblTalimatYonu y " + tblSirket +
                        "where t.talimatYon_id = y.talimatYon_id and t.santral_id = s.santral_id "
                        + sqlDateQuery + sqlYonQuery + sqlSantralQuery + sqlSirketQuery +
                        "order by t.talimatTarih, t.talimatSaat";

            con.Open();
            results = con.Query<clsTalimatBilgi>(sql).ToList();
            con.Close();
            return results;
        }
        public List<clsTip> teiasSantralBilgiAl(int? id)
        {
            String query = " where sirket_id = " + id + "";
            if (id == null)
            {
                query = "";
            }
            var results = new List<clsTip>();
            con.Open();
            var sql = "select santral_id id, santralAdi ad from tblTeiasSantral" + query;
            results = con.Query<clsTip>(sql).ToList();
            con.Close();
            return results;
        }
        public List<clsTip> faturaTipBilgiAl()
        {
            String query = "select tip_id id, faturaTipi ad from tblTeiasFaturaTip";
            var results = new List<clsTip>();
            con.Open();
            results = con.Query<clsTip>(query).ToList();
            con.Close();
            return results;
        }
        public async void teiasFaturaKayit(clsTeiasFatura faturaInsert)
        {
            var sql = "insert into tblTeiasFatura(faturaDonem, tip_id, sirket_id, santral_id, malHizmetiToplamTutar, iskonto, KDV, toplamTutar, kdvDahilToplamTutar)" +
                "values (@faturaDonem, @tip_id, @sirket_id, @santral_id, @malHizmetiToplamTutar, @iskonto, @KDV, @toplamTutar, @kdvDahilToplamTutar)";
            con.Open();
            con.ExecuteAsync(sql, faturaInsert);
            con.Close();
        }
        public List<clsTeiasBilgi> faturaTabloSource(bool sumSituation, int sirketId, int santralId, String basDonem, String bitDonem, int faturaTip)
        {
            var sirketQuery = "";
            var santralQuery = "";
            var faturaQuery = "";
            var tarihQuery = " and t.faturaDonem between '" + basDonem + "' and '" + bitDonem + "' ";
            var selectQuery = "t.fatura_id, t.faturaDonem, f.faturaTipi, s.sirketAdi, u.santralAdi, " +
                              "t.malHizmetiToplamTutar, t.iskonto, t.KDV, t.toplamTutar, t.kdvDahilToplamTutar ";
            var orderByQuery = " order by t.faturaDonem DESC, f.faturaTipi DESC ";

            if (sirketId != 0)
            {
                sirketQuery = " and t.sirket_id =" + sirketId + " ";
            }
            if (santralId != 0)
            {
                santralQuery = " and t.santral_id = " + santralId + " ";
            }
            if (faturaTip != 0)
            {
                faturaQuery = " and t.tip_id =" + faturaTip + " ";
            }
            if (basDonem is null && bitDonem is null)
            {
                tarihQuery = "";
            }
            if (sumSituation is true)
            {
                selectQuery = "f.faturaTipi, SUM(t.malHizmetiToplamTutar), " +
                    "SUM(t.iskonto), SUM(t.KDV), SUM(t.toplamTutar), SUM(t.kdvDahilToplamTutar)";
                faturaQuery = "";
                orderByQuery = "";
            }

            var sql = "select " + selectQuery +
                    " from tblTeiasFatura t, tblSirket s, tblTeiasFaturaTip f, tblTeiasSantral u " +
                    "where t.sirket_id = s.sirket_id and s.sirket_id = u.sirket_id and t.tip_id = f.tip_id and t.santral_id = u.santral_id " +
                    sirketQuery + santralQuery + faturaQuery + tarihQuery + orderByQuery;

            var results = new List<clsTeiasBilgi>();
            con.Open();
            results = con.Query<clsTeiasBilgi>(sql).ToList();
            con.Close();
            return results;
        }

    }
}
