using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PM_MaliyetHesaplama
{
    class MukavvaBilgileri
    {
        SqlConnection baglanti = new SqlConnection("Data Source=GRAFIK2\\SQLEXPRESS;Initial Catalog=PM_MaliyetDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        MukavvaAttribute mukavva = new MukavvaAttribute();

        public int BireKacDegerler(string BireKacAd)
        {
            string BaseQuery = "SELECT [BireKacDeger] FROM [PM_MaliyetDB].[dbo].[BireKac] WHERE  [BireKacAd] ='"+BireKacAd+"' ";    

            SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
            baglanti.Open();
            //MessageBox.Show("Bağlandı");
            SqlDataReader rdr = Query.ExecuteReader();
            while (rdr.Read())
            {
                mukavva.BireKacDeger = Convert.ToInt32(rdr["BireKacDeger"]);
                


            }
            baglanti.Close();
         

            return mukavva.BireKacDeger;
            
        }

        public int MukavvaAdetBilgisi(string mukavvaTuru)
        {
            

            string BaseQuery = "SELECT  [mukavvaAdet] FROM [PM_MaliyetDB].[dbo].[Mukavva] WHERE [mukavvaTuru] = '"+mukavvaTuru+"' ";   

            SqlCommand Query = new SqlCommand(BaseQuery, baglanti);
            baglanti.Open();

            SqlDataReader rdr = Query.ExecuteReader();
            //MessageBox.Show("Bağlandı");
            while (rdr.Read())
            {
                mukavva.MukavvaAdet = Convert.ToInt32(rdr["mukavvaAdet"]);
                
            }
            baglanti.Close();
            

            return mukavva.MukavvaAdet;


        }





    }
}
