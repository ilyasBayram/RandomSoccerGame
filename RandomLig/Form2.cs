using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //aynı random defaatle kullanılacağı için public olarak yazıldı.
        Random rastgele = new Random();
        
        //maç sonucundaki puanların arttırarark yazılabilmesi için oluşturulan sayaç
        //değişkenleri
        int gsPuan=0;
        int fenerPuan = 0;
        int tsPuan =0;
        int besPuan = 0;
       
        //Oynanan oyun, beraberlik ve galibiyet sayılarını yazmak için oluşturulan sayaçlar

        int oynananMac = 0;
        int beraberMac1 = 0;
        int beraberMac2 = 0;
        int beraberMac3 = 0;
        int beraberMac4 = 0;
        int galibiyetGs = 0;
        int galibiyetFener = 0;
        int galibiyetTs = 0;
        int galibiyetBes = 0;
        int yenilgiGs = 0;
        int yenilgiFener = 0;
        int yenilgiTs = 0;
        int yenilgiBes = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            //7her hafta maçlar 1 kez oynanacağı için butona ikinci kez basılamaması 
            //için burda butonun çalışma özelliğini false yapıyoruz.
            button1.Enabled = false;
            
            //form yüklenince 2. hafta butonu aktif olmayacağaından ikinci hafta oynandıktan sonra
            //2. hafta butonun aktif olması için ebaled özellliği true oldu
            button2.Enabled = true;

            //bu kısımda oynanan maç sayısını arttırmak için belirlenen sayaç arttırılarak
            //oynanan maç sayısı kısmındaki labellara yazıdırlıyor.
            oynananMac = oynananMac + 1;
            label43.Text = oynananMac.ToString();
            label44.Text = oynananMac.ToString();
            label45.Text = oynananMac.ToString();
            label46.Text = oynananMac.ToString();

            //random özelliğinden çekilecek değişkenleri belirliyoruz. Bu değişkenlerin
            //değeri bu sayede rasgele belirlerniyor.
            int galaGol = rastgele.Next (0, 5);
            int fenerGol = rastgele.Next(0, 5);
            int trabGol = rastgele.Next(0, 5);
            int besikGol = rastgele.Next(0, 5);
            
            //Rasgele belirtlenen skorlar maç sonucu olarak textboxlara yazıdrılıyor.
            //textboxa yazıdırılabilmesi için strginge çevriliyor.
            label5.Text = galaGol.ToString();
            label6.Text = fenerGol.ToString();
            label7.Text = trabGol.ToString();
            label8.Text = besikGol.ToString();

            //if komutlarıyla  değişkenlerin değerleri karşılaştırılıyor ve maç sonucu olarak
            //puan tablosundaki labellara yazdırılıyor. Büyükse 3 puan eşitse 1 puan arttırılıyor.

            if (Convert.ToInt32(label5.Text)>Convert.ToInt32(label6.Text))
            {
                gsPuan = gsPuan + 3;
                labelgsPuan.Text = gsPuan.ToString();
                galibiyetGs = galibiyetGs + 1;
                yenilgiFener = yenilgiFener + 1;
                label54.Text = galibiyetGs.ToString();
                label58.Text = yenilgiFener.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label5.Text))
            {
                fenerPuan = fenerPuan + 3;
                labelfenerPuan.Text = fenerPuan.ToString();
                galibiyetFener = galibiyetFener + 1;
                yenilgiGs = yenilgiGs + 1;
                label53.Text = galibiyetFener.ToString();
                label59.Text = yenilgiGs.ToString();
            }
            if (Convert.ToInt32(label5.Text) == Convert.ToInt32(label6.Text))
            {
                gsPuan = gsPuan + 1;
                labelgsPuan.Text = gsPuan.ToString();
                fenerPuan = fenerPuan + 1;
                labelfenerPuan.Text = fenerPuan.ToString();
                beraberMac1 = beraberMac1 + 1;
                beraberMac2 = beraberMac2 + 1;
                label50.Text = beraberMac1.ToString();
                label49.Text = beraberMac2.ToString();
            }
            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label8.Text))
            {
                tsPuan = tsPuan + 3;
                labeltsPuan.Text = tsPuan.ToString();
                galibiyetTs = galibiyetTs + 1;
                yenilgiBes = yenilgiBes + 1;
                label52.Text = galibiyetTs.ToString();
                label56.Text = yenilgiBes.ToString();

            }
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label7.Text))
            {
                besPuan = besPuan + 3;
                labelbesPuan.Text = besPuan.ToString();
                galibiyetBes = galibiyetBes + 1;
                yenilgiTs = yenilgiTs + 1;
                label51.Text = galibiyetBes.ToString();
                label57.Text = yenilgiTs.ToString();
            }
            if (Convert.ToInt32(label8.Text) == Convert.ToInt32(label7.Text))
            {
                tsPuan = tsPuan + 1;
                labeltsPuan.Text = tsPuan.ToString();
                besPuan = besPuan + 1;
                labelbesPuan.Text = besPuan.ToString();
                beraberMac3 = beraberMac3 + 1;
                beraberMac4 = beraberMac4 + 1;
                label48.Text = beraberMac3.ToString();
                label47.Text = beraberMac4.ToString();
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //7her hafta maçlar 1 kez oynanacağı için butona ikinci kez basılamaması 
            //için burda butonun çalışma özelliğini false yapıyoruz.
            //2. butona yazdığımız için lable isimlerini değiştridik.
            button2.Enabled = false;
            
            //form yüklenince 3. hafta butonu aktif olmayacağaından ikinci hafta oynandıktan sonra
            //3. hafta butonun aktif olması için ebaled özellliği true oldu
            button3.Enabled = true;

            //bu kısımda oynanan maç sayısını arttırmak için belirlenen sayaç arttırılarak
            //oynanan maç sayısı kısmındaki labellara yazıdırlıyor.
            oynananMac = oynananMac + 1;
            label43.Text = oynananMac.ToString();
            label44.Text = oynananMac.ToString();
            label45.Text = oynananMac.ToString();
            label46.Text = oynananMac.ToString();

            //random özelliğinden çekilecek değişkenleri belirliyoruz. Bu değişkenlerin
            //değeri bu sayede rasgele belirlerniyor.
            int galaGol = rastgele.Next(0, 5);
            int fenerGol = rastgele.Next(0, 5);
            int trabGol = rastgele.Next(0, 5);
            int besGol = rastgele.Next(0, 5);

            //Rasgele belirtlenen skorlar maç sonucu olarak textboxlara yazıdrılıyor.
            //textboxa yazıdırılabilmesi için strginge çevriliyor.
            label17.Text = galaGol.ToString();
            label15.Text = fenerGol.ToString();
            label16.Text = trabGol.ToString();
            label14.Text = besGol.ToString();

            //if komutlarıyla  değişkenlerin değerleri karşılaştırılıyor ve maç sonucu olarak
            //puan tablosundaki labellara yazdırılıyor. Büyükse 3 puan eşitse 1 puan arttırılıyor.

            if (Convert.ToInt32(label17.Text) > Convert.ToInt32(label16.Text))
            {
                gsPuan = gsPuan + 3;
                labelgsPuan.Text = gsPuan.ToString();
                galibiyetGs = galibiyetGs + 1;
                yenilgiTs = yenilgiTs + 1;
                label54.Text = galibiyetGs.ToString();
                label57.Text = yenilgiTs.ToString();
            }
            if (Convert.ToInt32(label16.Text) > Convert.ToInt32(label17.Text))
            {
                tsPuan = tsPuan + 3;
                labeltsPuan.Text = tsPuan.ToString();
                galibiyetTs = galibiyetTs + 1;
                yenilgiGs = yenilgiGs + 1;
                label52.Text = galibiyetTs.ToString();
                label59.Text = yenilgiGs.ToString();
            }
            if (Convert.ToInt32(label17.Text) == Convert.ToInt32(label16.Text))
            {
                gsPuan = gsPuan + 1;
                labelgsPuan.Text = gsPuan.ToString();
                tsPuan = tsPuan + 1;
                labeltsPuan.Text = tsPuan.ToString();
                beraberMac1 = beraberMac1 + 1;
                beraberMac3 = beraberMac3 + 1;
                label50.Text = beraberMac1.ToString();
                label48.Text = beraberMac3.ToString();
            }
            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label14.Text))
            {
                fenerPuan = fenerPuan + 3;
                labelfenerPuan.Text = fenerPuan.ToString();
                galibiyetFener = galibiyetFener + 1;
                yenilgiBes = yenilgiBes + 1;
                label53.Text = galibiyetFener.ToString();
                label56.Text = yenilgiBes.ToString();
            }
            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label15.Text))
            {
                besPuan = besPuan + 3;
                labelbesPuan.Text = besPuan.ToString();
                galibiyetBes = galibiyetBes + 1;
                yenilgiFener = yenilgiFener + 1;
                label51.Text = galibiyetBes.ToString();
                label58.Text = yenilgiFener.ToString();

            }
            if (Convert.ToInt32(label15.Text) == Convert.ToInt32(label14.Text))
            {
                fenerPuan = fenerPuan + 3;
                labelfenerPuan.Text = fenerPuan.ToString();
                besPuan = besPuan + 1;
                labelbesPuan.Text = besPuan.ToString();
                beraberMac2 = beraberMac2 + 1;
                beraberMac4 = beraberMac4 + 1;
                label49.Text = beraberMac2.ToString();
                label47.Text = beraberMac4.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //7her hafta maçlar 1 kez oynanacağı için butona ikinci kez basılamaması 
            //için burda butonun çalışma özelliğini false yapıyoruz.
            //3. butona yazdığımız için lable isimlerini değiştridik.
            button3.Enabled = false;
            
            //bu kısımda oynanan maç sayısını arttırmak için belirlenen sayaç arttırılarak
            //oynanan maç sayısı kısmındaki labellara yazıdırlıyor.
            oynananMac = oynananMac + 1;
            label43.Text = oynananMac.ToString();
            label44.Text = oynananMac.ToString();
            label45.Text = oynananMac.ToString();
            label46.Text = oynananMac.ToString();
           
            //random özelliğinden çekilecek değişkenleri belirliyoruz. Bu değişkenlerin
            //değeri bu sayede rasgele belirlerniyor.
            int galaGol = rastgele.Next(0, 5);
            int fenerGol = rastgele.Next(0, 5);
            int trabGol = rastgele.Next(0, 5);
            int besGol = rastgele.Next(0, 5);

            //Rasgele belirtlenen skorlar maç sonucu olarak textboxlara yazıdrılıyor.
            //textboxa yazıdırılabilmesi için strginge çevriliyor.
            label31.Text = galaGol.ToString();
            label29.Text = fenerGol.ToString();
            label28.Text = trabGol.ToString();
            label30.Text = besGol.ToString();

            //if komutlarıyla  değişkenlerin değerleri karşılaştırılıyor ve maç sonucu olarak
            //puan tablosundaki labellara yazdırılıyor. Büyükse 3 puan eşitse 1 puan arttırılıyor.

            if (Convert.ToInt32(label31.Text) > Convert.ToInt32(label30.Text))
            {
                gsPuan = gsPuan + 3;
                labelgsPuan.Text = gsPuan.ToString();
                galibiyetGs = galibiyetGs + 1;
                yenilgiBes = yenilgiBes + 1;
                label54.Text = galibiyetGs.ToString();
                label56.Text = yenilgiBes.ToString();
            }
            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label31.Text))
            {
                besPuan = besPuan + 3;
                labelbesPuan.Text = besPuan.ToString();
                galibiyetBes = galibiyetBes + 1;
                yenilgiGs = yenilgiGs + 1;
                label51.Text = galibiyetBes.ToString();
                label59.Text = yenilgiGs.ToString();

            }
            if (Convert.ToInt32(label17.Text) == Convert.ToInt32(label16.Text))
            {
                gsPuan = gsPuan + 1;
                labelgsPuan.Text = gsPuan.ToString();
                besPuan = besPuan + 1;
                labelbesPuan.Text = besPuan.ToString();
                beraberMac1 = beraberMac1 + 1;
                beraberMac4 = beraberMac4 + 1;
                label50.Text = beraberMac1.ToString();
                label47.Text = beraberMac4.ToString();
            }
            if (Convert.ToInt32(label29.Text) > Convert.ToInt32(label28.Text))
            {
                fenerPuan = fenerPuan + 3;
                labelfenerPuan.Text = fenerPuan.ToString();
                galibiyetFener = galibiyetFener + 1;
                yenilgiTs = yenilgiTs + 1;
                label53.Text = galibiyetFener.ToString();
                label57.Text = yenilgiTs.ToString();
            }
            if (Convert.ToInt32(label28.Text) > Convert.ToInt32(label29.Text))
            {
                tsPuan = tsPuan + 3;
                labeltsPuan.Text = tsPuan.ToString();
                galibiyetTs = galibiyetTs + 1;
                yenilgiFener = yenilgiFener + 1;
                label52.Text = galibiyetTs.ToString();
                label58.Text = yenilgiFener.ToString();

            }
            if (Convert.ToInt32(label15.Text) == Convert.ToInt32(label14.Text))
            {
                fenerPuan = fenerPuan + 1;
                labelfenerPuan.Text = fenerPuan.ToString();
                tsPuan = tsPuan + 1;
                labeltsPuan.Text = tsPuan.ToString();
                beraberMac2 = beraberMac2 + 1;
                beraberMac3 = beraberMac3 + 1;
                label49.Text = beraberMac2.ToString();
                label48.Text = beraberMac3.ToString();
            }
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}
