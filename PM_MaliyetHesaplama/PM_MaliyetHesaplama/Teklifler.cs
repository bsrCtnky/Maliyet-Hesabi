using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_MaliyetHesaplama
{
    class Teklifler
    {

        SqlConnection baglanti = new SqlConnection("Data Source=GRAFIK2\\SQLEXPRESS;Initial Catalog=PM_MaliyetDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        TeklifAttribute teklif = new TeklifAttribute();

        public void TeklifEkle(string urunAdi,int urunAded,string urunTur,string teklifSahibi,double maliyet)
        {
            try
            {
                string BaseQueryy = "SELECT [urunID]  FROM [PM_MaliyetDB].[dbo].[UrunTuru] WHERE [urunTur] = '" + urunTur + "'";

                SqlCommand Query1 = new SqlCommand(BaseQueryy, baglanti);
                baglanti.Open();
                //MessageBox.Show("Bağlandı");
                SqlDataReader rdr = Query1.ExecuteReader();
                while (rdr.Read())
                {
                    teklif.TeklifUrunTuruID = Convert.ToInt32(rdr["urunID"]);



                }
                baglanti.Close();
                //MessageBox.Show(teklif.TeklifUrunTuruID.ToString());

                DateTime tarih = DateTime.Now;
                //MessageBox.Show(tarih.ToString());
                string BaseQuery = "Insert into PM_MaliyetDB.dbo.Teklifler  Values(@urunAdi,@urunAded,@urunID,@teklifSahibi,@tarih,@maliyet )";
                SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
                baglanti.Open();
                //MessageBox.Show("Bağlandı");
                Query.Parameters.AddWithValue("@urunAdi", urunAdi);
                Query.Parameters.AddWithValue("@urunAded", urunAded);
                Query.Parameters.AddWithValue("@urunID", teklif.TeklifUrunTuruID);
                Query.Parameters.AddWithValue("@teklifSahibi", teklifSahibi);
                Query.Parameters.AddWithValue("@tarih", tarih);
                Query.Parameters.AddWithValue("@maliyet", maliyet);

                Query.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarı ile Eklendi");

            }
            catch (Exception )
            {
                
                throw;
            }
            
        }

        //public string[] teklifSorgu;
        //public String[] TeklifSorgusu(string urunAdi, string urunTuru)
        //{
        //    baglanti.Open();

        //    //ArrayList listem = new ArrayList();
            

        //    string BaseQuery = "SELECT t.[urunAdi] as [URUNADI],t.[urunAdedi] as [URUNADEDI],u.[urunTur] as [URUNTURU],t.[teklifSahibi] as [TEKLIFSAHIBI],t.[tarih] as [TARIH],t.[maliyet] as [MALIYET] " +
        //        " FROM [PM_MaliyetDB].[dbo].[Teklifler] as t inner join [PM_MaliyetDB].[dbo].[UrunTuru] as u on t.urunID=u.urunID " +
        //        " WHERE  t.[urunAdi] ='" + urunAdi + "' or u.[urunTur] ='" + urunTuru + "' ";

        //    SqlCommand cmd = new SqlCommand(BaseQuery, baglanti);

        //    SqlDataReader dr = cmd.ExecuteReader();

        //    while (dr.Read())
        //    {

        //        teklif.TeklifUrunAdi = Convert.ToString((dr["URUNADI"]));
        //        teklif.TeklifUrunAdedi = Convert.ToInt32((dr["URUNADEDI"]));
        //        teklif.TeklifurunTuru = Convert.ToString((dr["URUNTURU"]));
        //        teklif.TeklifSahibi = Convert.ToString((dr["TEKLIFSAHIBI"]));
        //        teklif.Tarih = Convert.ToDateTime((dr["TARIH"]));
        //        teklif.Maliyet = Convert.ToDouble((dr["MALIYET"]));

        //        //listem.Add(dr["URUNADI"]);
        //        //listem.Add(dr["URUNADEDI"].ToString());
        //        //listem.Add(dr["URUNTURU"]);
        //        //listem.Add(dr["TEKLIFSAHIBI"]);
        //        //listem.Add(dr["TARIH"].ToString());
        //        //listem.Add(dr["MALIYET"].ToString());
        //         string[] teklifSorgu =  { teklif.TeklifUrunAdi, teklif.TeklifUrunAdedi.ToString(), teklif.TeklifurunTuru, teklif.TeklifSahibi, teklif.Tarih.ToString(), teklif.Maliyet.ToString() };
        //    }
            


        //    baglanti.Close();

        //    return teklifSorgu;


        //}







    }






    

}
