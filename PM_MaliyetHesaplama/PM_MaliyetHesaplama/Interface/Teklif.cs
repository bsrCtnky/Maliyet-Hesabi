using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_MaliyetHesaplama
{
    public partial class Teklif : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=GRAFIK2\\SQLEXPRESS;Initial Catalog=PM_MaliyetDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        TeklifAttribute teklif = new TeklifAttribute();
        Teklifler teklifler = new Teklifler();
        public Teklif()
        {
            InitializeComponent();
        }

        private void Teklif_Load(object sender, EventArgs e)
        {
            sorgulalistView.Columns.Add("Ürün Adi", 180);
            sorgulalistView.Columns.Add("Ürün Adedi", 180);
            sorgulalistView.Columns.Add("Ürün Türü", 180);
            sorgulalistView.Columns.Add("Teklif Sahibi", 180);
            sorgulalistView.Columns.Add("Tarih", 180);
            sorgulalistView.Columns.Add("Maliyet", 180);
        }
        //ArrayList gelenler = new ArrayList();

        //string[] gelenler;
        private void bulBtn_Click(object sender, EventArgs e)
        {
            //teklif.TeklifUrunAdi = sorguUrunAdiTxt.Text;
            //teklif.TeklifurunTuru = sorguUrunTuruTxt.Text;


            //gelenler = teklifler.TeklifSorgusu(teklif.TeklifUrunAdi, teklif.TeklifurunTuru);
            //sorgulalistView.Items.Add(new ListViewItem(gelenler));


            //foreach(string item in gelenler)
            //{


            //    var items = new ListViewItem();
            //    items.Text = item;
            //    sorgulalistView.Items.Add(items);

            //}



            teklif.TeklifUrunAdi = sorguUrunAdiTxt.Text;
            teklif.TeklifurunTuru = sorguUrunTuruTxt.Text;
            baglanti.Open();



            string BaseQuery = "SELECT t.[urunAdi] as [URUNADI],t.[urunAdedi] as [URUNADEDI],u.[urunTur] as [URUNTURU],t.[teklifSahibi] as [TEKLIFSAHIBI],t.[tarih] as [TARIH],t.[maliyet] as [MALIYET] " +
                " FROM [PM_MaliyetDB].[dbo].[Teklifler] as t inner join [PM_MaliyetDB].[dbo].[UrunTuru] as u on t.urunID=u.urunID " +
                " WHERE  t.[urunAdi] ='" + teklif.TeklifUrunAdi + "' or u.[urunTur] ='" + teklif.TeklifurunTuru + "' ";

            SqlCommand cmd = new SqlCommand(BaseQuery, baglanti);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                teklif.TeklifUrunAdi = Convert.ToString((dr["URUNADI"]));
                teklif.TeklifUrunAdedi = Convert.ToInt32((dr["URUNADEDI"]));
                teklif.TeklifurunTuru = Convert.ToString((dr["URUNTURU"]));
                teklif.TeklifSahibi = Convert.ToString((dr["TEKLIFSAHIBI"]));
                teklif.Tarih = Convert.ToDateTime((dr["TARIH"]));
                teklif.Maliyet = Convert.ToDouble((dr["MALIYET"]));

                String[] teklifSorgu = { teklif.TeklifUrunAdi, teklif.TeklifUrunAdedi.ToString(), teklif.TeklifurunTuru, teklif.TeklifSahibi, teklif.Tarih.ToString(), teklif.Maliyet.ToString() };
                sorgulalistView.Items.Add(new ListViewItem(teklifSorgu));


            }



            baglanti.Close();




        }

        private void teklifEkleBtn_Click(object sender, EventArgs e)
        {
            teklif.TeklifUrunAdi = teklifEkleUrunAdiTxt.Text;
            teklif.TeklifUrunAdedi = Convert.ToInt32(teklifEkleUrunAdediTxt.Text);
            teklif.TeklifurunTuru = teklifEkleUrunTuruTxt.Text;
            teklif.TeklifSahibi = teklifEkleTeklifSahibiTxt.Text;
            teklif.Maliyet = Convert.ToDouble(teklifEkleUrunMaliyetiTxt.Text);
            teklifler.TeklifEkle(teklif.TeklifUrunAdi, teklif.TeklifUrunAdedi, teklif.TeklifurunTuru, teklif.TeklifSahibi, teklif.Maliyet);
        }

        private void yeniSorguBtn_Click(object sender, EventArgs e)
        {
            sorgulalistView.Items.Clear();
            sorguUrunAdiTxt.Clear();
            sorguUrunTuruTxt.Clear();

        }
    }
}
