using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.Data.OleDb;
namespace TezNTVHaberCekme
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Sefa\\Documents\\haberdb.accdb;Persist Security Info=True");
        OleDbDataAdapter adtr;
        DataTable tablo = new DataTable();
        private void verileriGetir()
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = con;
            komut.CommandText = ( "Select * From haber" );
            adtr = new OleDbDataAdapter(komut);
            adtr.Fill(tablo);
            listHaber.DataSource = tablo;   
            con.Close();

        }
        string[] link=new String[72];
        string[] content = new String[72];
        string[] title=new String[72];
        string[] category=new String[100];
        int k = 0, l = 0 , m = 0 , n = 0;
        private void linkGonder(String a)
        {
            a = a.Replace("&#39;", " ");
            a = a.Replace("&#160;", " ");
            link[k] = a;
            k++;
            /*con.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = con;
            komut.CommandText = ("INSERT INTO haber(link) VALUES ('" + a + "') ");
            komut.ExecuteNonQuery();
            con.Close();*/
            
        }
        private void contentGonder(String a)
        {
            a = a.Replace("&#8217;", " ");
            a = a.Replace("&quot;", "");
            a = a.Replace("&#39;", " ");
            a = a.Replace("&#160;", " ");
            content[l] = a;
            l++;
            /*con.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = con;
            komut.CommandText = ("INSERT INTO haber(content) VALUES ('" + a + "') ");
            komut.ExecuteNonQuery();
            con.Close();*/
        }

        private void titleGonder(String a)
        {
            a = a.Replace("&quot;", "");
            a = a.Replace("&#39;", " ");
            a = a.Replace("&#160;", " ");
            title[m] = a;
            m++;
            /*con.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = con;
            komut.CommandText = ("INSERT INTO haber(title) VALUES ('" + a + "') ");
            komut.ExecuteNonQuery();
            con.Close();*/
        }
        private void categoryGonder(String a)
        {
            a = a.Replace("&#39;", " ");
            a = a.Replace("&#160;", " ");
            category[n] = a;
            n++;
            /*con.Open(); 
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = con;
            komut.CommandText = ("INSERT INTO haber(category) VALUES ('" + a + "') ");
            komut.ExecuteNonQuery();
            con.Close();*/
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void haberal_Click(object sender, EventArgs e)
        {

            

            for (int i = 1; i < 5; i++)
            {
                Uri url = new Uri("https://www.ntv.com.tr/son-dakika/?sayfa="+ i);
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument hdoc = new HtmlAgilityPack.HtmlDocument();
                hdoc.LoadHtml(html);
                HtmlNodeCollection haber = hdoc.DocumentNode.SelectNodes("//h2[@class='title']");
                HtmlNodeCollection link = hdoc.DocumentNode.SelectNodes("//a[@href]");
                
                linkBox.Items.Add("----------------------------" + i + ".Sayfa Haber Linkleri ----------------------------");
                int index = 1;
                int index2 = 1;
                int index3 = 1;
                foreach (var haberGet in link)
                {

                    string hrefValue = haberGet.GetAttributeValue("href", string.Empty);

                    if (hrefValue.Length > 40 && hrefValue.IndexOf("Descending") == -1 && hrefValue.IndexOf("kralmuzik") == -1)
                    {
                        linkBox.Items.Add(i + ".Sayfa" + index++ + ". Haber Linki =  https://www.ntv.com.tr" + hrefValue);
                        String newLink = "https://www.ntv.com.tr" + hrefValue;
                        linkGonder(newLink);
        

                        Uri url1 = new Uri(newLink);
                        
                        WebClient client1 = new WebClient();
                        client1.Encoding = Encoding.UTF8;
                        string html1 = client1.DownloadString(url1);
                        HtmlAgilityPack.HtmlDocument hdoc1 = new HtmlAgilityPack.HtmlDocument();
                        hdoc1.LoadHtml(html1);
                        HtmlNodeCollection haber1 = hdoc1.DocumentNode.SelectNodes("//a[@property='v:title']");
                        HtmlNodeCollection habericerik = hdoc1.DocumentNode.SelectNodes("//meta[@property='og:description']");
                        

                        foreach (var haber2Get in habericerik)
                        {
                            String haberString1 = haber2Get.GetAttributeValue("content", string.Empty);
                                newsBox.Items.Add("------------------------------------------");
                                newsBox.Items.Add(i + ".Sayfa" + index3++ + ".Haber iceriği");
                                newsBox.Items.Add("------------------------------------------");
                                newsBox.Items.Add(haberString1);
                                contentGonder(haberString1);
                               
                        }

                        headBox.Items.Add("------------------------------------------");
                        headBox.Items.Add(i + ".Sayfa" + index2++ + ".Haber Başlığı");
                        headBox.Items.Add("------------------------------------------");

                        foreach (var haber1Get in haber1)
                        {
                            headBox.Items.Add(haber1Get.InnerText);
                            String category = haber1Get.InnerText;
                            if (category != "Haber")
                                categoryGonder(category);
                        }
                    }
                } 
                
                haberler.Items.Add("----------------------------" + i + ".Sayfa Haberleri ----------------------------");

                foreach (var haberGet in haber)
                {
                    haberler.Items.Add(haberGet.InnerText);
                    titleGonder(haberGet.InnerText);
                }   
            }
           
        }

        private void haberler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dbKaydet_Click(object sender, EventArgs e)
        {
            gonderDb();
        }

        private void listHaber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void veriGet_Click(object sender, EventArgs e)
        {
            verileriGetir();
        }
        
        private void gonderDb()
        {
            for(int c=0; c<72;c++)
            { 
                 con.Open();
                 OleDbCommand komut = new OleDbCommand();
                 komut.Connection = con;
                 komut.CommandText = ("INSERT INTO haber(content,link,category,title) VALUES ('" + content[c] + "','" + link[c] + "','" + category[c] + "','" + title[c] + "') ");
                 komut.ExecuteNonQuery();
                 con.Close();
            }
        }
    }
}
//Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sefa\Documents\haberdb.accdb;Persist Security Info=True