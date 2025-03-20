using System;
using System.Linq;
using System.Windows.Forms;
namespace BinaNavigasyonSistemi
{
    public partial class Kat1 : Form
    {
        public static bool Cıkıs1 = false, Cıkıs2 = false, Cıkıs3 = false, Cıkıs4 = false, Cıkıs5 = false, Cıkıs7 = false, Cıkıs6 = false, merdivenGecis = false;
        public string güzergah;
        public static double yolUzunlugu = 0;
        public int[] yolDizi = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int sayac = 0, yolDiziElemanSayisi = 0;
        Zemin zmn = new Zemin();
        double[,] grafMatrisi =
     {
           // 0   1     2   3    4   5   6   7   8   9   10  11   12  13   14    
            { 0,   0,  4.5, 4.5, 0,  0,  0,  0,  0,  0,  0,  0,   0,  0,    0 }, // 0
            { 0,   0,  8,   0,   0,  0,  0,  0,  0,  0,  0,  0,   0,  0,    0 }, // 1
            { 4.5, 8,  0,   0,   0,  0,  15, 0,  0,  0,  0,  0,   0,  0,    0 }, // 2
            { 4.5, 0,  0,   0,   8,  0,  0,  0,  15, 0,  0,  0,   0,  0,    0 }, // 3
            { 0,   0,  0,   8,   0,  0,  0,  0,  0,  0,  0,  0,   0,  0,    0 }, // 4
            { 0,   0,  0,   0,   0,  0,  6,  0,  0,  0,  0,  0,   0,  0,    0 }, // 5
            { 0,   0,  15,   0,  0,  6,  0,  2,  0,  0,  0,  9,   0,  0,    0 }, // 6
            { 0,   0,  0,   0,   0,  0,  2,  0,  0,  0,  0,  0,   0,  0,    0 }, // 7
            { 0,   0,  0,   15,  0,  0,  0,  0,  0,  6,  0,  0,   9,  0,    0 }, // 8
            { 0,   0,  0,   0,   0,  0,  0,  0,  6,  0,  0,  0,   0,  0,    0 }, // 9
            { 0,   0,  0,   0,   0,  0,  0,  0,  0,  0,  0,  8,   0,  0,    0 }, // 10
            { 0,   0,  0,   0,   0,  0,  9,  0,  0,  0,  8,  0,   3,  0,    0 }, // 11
            { 0,   0,  0,   0,   0,  0,  0,  0,  9,  0,  0,  3,   0,  5,    0 }, // 12
            { 0,   0,  0,   0,   0,  0,  0,  0,  0,  0,  0,  0,   5,  0,    8 }, // 13
            { 0,   0,  0,   0,   0,  0,  0,  0,  0,  0,  0,  0,   0,  8,    0 }, // 14

        };
        public Kat1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        private void ovC3_Click(object sender, EventArgs e)
        {
            sıfırlan();
            if (!Cıkıs5)
            {
                Cıkıs5 = true;
                ovC3.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                Cıkıs5 = false;
                ovC3.BorderColor = System.Drawing.Color.Red;
            }
        }
        public void yoluYaz(double[,] pr_graf, int pr_kD, int pr_hD)
        {
            var yol = KuyruksuzDijstraAlgoritmasi.DijkstraAlgoritmasi(pr_graf, pr_kD, pr_hD);
            if (yol == null)
            {
                //textBox1.Text = ("Yol Yok!");
            }
            else
            {
                yolUzunlugu = 0;
                for (int i = 0; i < yol.Count - 1; i++)
                {
                    yolUzunlugu += pr_graf[yol[i], yol[i + 1]];
                }
                for (int k = 0; k < yol.Count; k++)
                {
                    yolDizi[k] = yol[k];
                }
                var güncellenenYol = string.Join("->", yol);
                güzergah = güncellenenYol;
            }
        }
        private void Kat1_Load(object sender, EventArgs e)
        {
            if (Cıkıs1)
            {
                ovC1.BorderColor = System.Drawing.Color.Green;
            }
            if (!Cıkıs1)
            {
                ovC1.BorderColor = System.Drawing.Color.Red;
            }
            if (Cıkıs2)
            {
                ovC4.BorderColor = System.Drawing.Color.Green;
            }
            if (!Cıkıs2)
            {
                ovC4.BorderColor = System.Drawing.Color.Red;
            }
            if (Cıkıs3)
            {
                ovC2.BorderColor = System.Drawing.Color.Green;
            }
            if (!Cıkıs3)
            {
                ovC2.BorderColor = System.Drawing.Color.Red;
            }
            if (Cıkıs4)
            {
                ovC5.BorderColor = System.Drawing.Color.Green;
            }
            if (!Cıkıs4)
            {
                ovC5.BorderColor = System.Drawing.Color.Red;
            }
            if (Cıkıs5)
            {
                ovC3.BorderColor = System.Drawing.Color.Green;
            }
            if (!Cıkıs5)
            {
                ovC3.BorderColor = System.Drawing.Color.Red;
            }
            if (Cıkıs6)
            {
                ovalShape1.BorderColor = System.Drawing.Color.Green;
            }
            if (!Cıkıs6)
            {
                ovalShape1.BorderColor = System.Drawing.Color.Red;
            }
            if (Cıkıs7)
            {
                ovalShape2.BorderColor = System.Drawing.Color.Green;
            }
            if (!Cıkıs7)
            {
                ovalShape2.BorderColor = System.Drawing.Color.Red;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }
        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
        }
        public void sıfırlan()
        {
            lineShape1.BorderColor = System.Drawing.Color.Gray;
            lineShape2.BorderColor = System.Drawing.Color.Gray;
            lineShape3.BorderColor = System.Drawing.Color.Gray;
            lineShape4.BorderColor = System.Drawing.Color.Gray;
            lineShape5.BorderColor = System.Drawing.Color.Gray;
            lineShape7.BorderColor = System.Drawing.Color.Gray;
            lineShape8.BorderColor = System.Drawing.Color.Gray;
            lineShape9.BorderColor = System.Drawing.Color.Gray;
            lineShape10.BorderColor = System.Drawing.Color.Gray;
            lineShape11.BorderColor = System.Drawing.Color.Gray;
            lineShape12.BorderColor = System.Drawing.Color.Gray;
            lineShape13.BorderColor = System.Drawing.Color.Gray;
            lineShape14.BorderColor = System.Drawing.Color.Gray;
            lineShape15.BorderColor = System.Drawing.Color.Gray;
            lineShape16.BorderColor = System.Drawing.Color.Gray;
            lineShape17.BorderColor = System.Drawing.Color.Gray;
            lineShape18.BorderColor = System.Drawing.Color.Gray;
            lineShape19.BorderColor = System.Drawing.Color.Gray;
            lineShape20.BorderColor = System.Drawing.Color.Gray;
            lineShape21.BorderColor = System.Drawing.Color.Gray;
            lineShape22.BorderColor = System.Drawing.Color.Gray;
            lineShape23.BorderColor = System.Drawing.Color.Gray;
            lineShape24.BorderColor = System.Drawing.Color.Gray;
            lineShape25.BorderColor = System.Drawing.Color.Gray;
            lineShape26.BorderColor = System.Drawing.Color.Gray;
            lineShape27.BorderColor = System.Drawing.Color.Gray;
            lineShape28.BorderColor = System.Drawing.Color.Gray;
            lineShape29.BorderColor = System.Drawing.Color.Gray;
            lineShape30.BorderColor = System.Drawing.Color.Gray;
            lineShape31.BorderColor = System.Drawing.Color.Gray;
            lineShape32.BorderColor = System.Drawing.Color.Gray;
            lineShape33.BorderColor = System.Drawing.Color.Gray;
            lineShape34.BorderColor = System.Drawing.Color.Gray;
            lineShape35.BorderColor = System.Drawing.Color.Gray;
            lineShape36.BorderColor = System.Drawing.Color.Gray;
            lineShape37.BorderColor = System.Drawing.Color.Gray;
            lineShape38.BorderColor = System.Drawing.Color.Gray;
            lineShape39.BorderColor = System.Drawing.Color.Gray;
            lineShape40.BorderColor = System.Drawing.Color.Gray;
            lineShape41.BorderColor = System.Drawing.Color.Gray;
            lineShape42.BorderColor = System.Drawing.Color.Gray;
            lineShape43.BorderColor = System.Drawing.Color.Gray;
            lineShape44.BorderColor = System.Drawing.Color.Gray;
            lineShape45.BorderColor = System.Drawing.Color.Gray;
            lineShape46.BorderColor = System.Drawing.Color.Gray;
            lineShape47.BorderColor = System.Drawing.Color.Gray;
            lineShape48.BorderColor = System.Drawing.Color.Gray;
            lineShape49.BorderColor = System.Drawing.Color.Gray;
            lineShape50.BorderColor = System.Drawing.Color.Gray;
            lineShape51.BorderColor = System.Drawing.Color.Gray;
            lineShape52.BorderColor = System.Drawing.Color.Gray;
            lineShape53.BorderColor = System.Drawing.Color.Gray;
            lineShape54.BorderColor = System.Drawing.Color.Gray;
            lineShape55.BorderColor = System.Drawing.Color.Gray;
            lineShape56.BorderColor = System.Drawing.Color.Gray;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        public void Araislem()
        {
            yolDiziElemanSayisi = yolDizi.Count();
            label18.Text = Convert.ToString(yolUzunlugu) + "m";
            label34.Text = Convert.ToInt32(yolUzunlugu / 3) + "sn";
            timer1.Start();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            lineShape55.Visible = true;
            ovalShape14.Visible = true;
            lineShape55.BorderColor = System.Drawing.Color.Green;
            sayac = 0;
            yolDizi[0] = 0;
            yolDizi[1] = 0;
            yolDizi[2] = 0;
            yolDizi[3] = 0;
            yolDizi[4] = 0;
            if (Cıkıs4)
            {
                lineShape56.BorderColor = System.Drawing.Color.Green;
                lineShape48.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 8, 9);
                yolUzunlugu += +6;
                Araislem();
            }
            else if (Cıkıs2)
            {
                lineShape36.BorderColor = System.Drawing.Color.Green;
                lineShape37.BorderColor = System.Drawing.Color.Green;
                lineShape38.BorderColor = System.Drawing.Color.Green;
                lineShape40.BorderColor = System.Drawing.Color.Green;
                lineShape41.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 3, 4);
                yolUzunlugu += +10;
                Araislem();
            }
            else if (Cıkıs5)
            {
                lineShape56.BorderColor = System.Drawing.Color.Green;
                lineShape48.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 8, 10);
                yolUzunlugu += +6;
                Araislem();
            }
            else if (Cıkıs1)
            {
                lineShape36.BorderColor = System.Drawing.Color.Green;
                lineShape37.BorderColor = System.Drawing.Color.Green;
                lineShape38.BorderColor = System.Drawing.Color.Green;
                lineShape40.BorderColor = System.Drawing.Color.Green;
                lineShape41.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 3, 1);
                yolUzunlugu += 10;
                Araislem();
            }
            else if (Cıkıs6)
            {
                lineShape56.BorderColor = System.Drawing.Color.Green;
                lineShape48.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 8, 14);
                yolUzunlugu += 6;
                Araislem();
            }
            else if (Cıkıs3)
            {
                lineShape56.BorderColor = System.Drawing.Color.Green;
                lineShape48.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 8, 5);
                yolUzunlugu += 6;
                Araislem();
            }
            else if (Cıkıs7)
            {
                lineShape56.BorderColor = System.Drawing.Color.Green;
                lineShape48.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 8, 7);
                yolUzunlugu += 6;
                merdivenGecis = true;
                Araislem();
            }
        }
        public void yönlendir()
        {
            if ((yolDizi[sayac] == 0 && yolDizi[sayac + 1] == 2) || (yolDizi[sayac] == 2 && yolDizi[sayac + 1] == 0))
            {
                lineShape52.BorderColor = System.Drawing.Color.Green;
                lineShape53.BorderColor = System.Drawing.Color.Green;
                lineShape54.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 0 && yolDizi[sayac + 1] == 3) || (yolDizi[sayac] == 3 && yolDizi[sayac + 1] == 0))
            {
                lineShape49.BorderColor = System.Drawing.Color.Green;
                lineShape50.BorderColor = System.Drawing.Color.Green;
                lineShape51.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 2 && yolDizi[sayac + 1] == 1) || (yolDizi[sayac] == 1 && yolDizi[sayac + 1] == 2))
            {
                lineShape5.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 3 && yolDizi[sayac + 1] == 4) || (yolDizi[sayac] == 4 && yolDizi[sayac + 1] == 3))
            {
                lineShape4.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 2 && yolDizi[sayac + 1] == 6) || (yolDizi[sayac] == 6 && yolDizi[sayac + 1] == 2))
            {
                lineShape1.BorderColor = System.Drawing.Color.Green;
                lineShape2.BorderColor = System.Drawing.Color.Green;
                lineShape3.BorderColor = System.Drawing.Color.Green;
                lineShape10.BorderColor = System.Drawing.Color.Green;
                lineShape15.BorderColor = System.Drawing.Color.Green;
                lineShape14.BorderColor = System.Drawing.Color.Green;
                lineShape7.BorderColor = System.Drawing.Color.Green;
                lineShape16.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 3 && yolDizi[sayac + 1] == 8) || (yolDizi[sayac] == 8 && yolDizi[sayac + 1] == 3))
            {
                lineShape36.BorderColor = System.Drawing.Color.Green;
                lineShape37.BorderColor = System.Drawing.Color.Green;
                lineShape38.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                lineShape40.BorderColor = System.Drawing.Color.Green;
                lineShape41.BorderColor = System.Drawing.Color.Green;
                lineShape56.BorderColor = System.Drawing.Color.Green;
                lineShape48.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 5 && yolDizi[sayac + 1] == 6) || (yolDizi[sayac] == 6 && yolDizi[sayac + 1] == 5))
            {
                lineShape19.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 7 && yolDizi[sayac + 1] == 6) || (yolDizi[sayac] == 6 && yolDizi[sayac + 1] == 7))
            {
                lineShape32.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 8 && yolDizi[sayac + 1] == 9) || (yolDizi[sayac] == 9 && yolDizi[sayac + 1] == 8))
            {
                lineShape13.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 6 && yolDizi[sayac + 1] == 11) || (yolDizi[sayac] == 11 && yolDizi[sayac + 1] == 6))
            {
                lineShape17.BorderColor = System.Drawing.Color.Green;
                lineShape18.BorderColor = System.Drawing.Color.Green;
                lineShape29.BorderColor = System.Drawing.Color.Green;
                lineShape33.BorderColor = System.Drawing.Color.Green;
                lineShape35.BorderColor = System.Drawing.Color.Green;
                lineShape34.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 8 && yolDizi[sayac + 1] == 12) || (yolDizi[sayac] == 12 && yolDizi[sayac + 1] == 8))
            {
                lineShape42.BorderColor = System.Drawing.Color.Green;
                lineShape43.BorderColor = System.Drawing.Color.Green;
                lineShape44.BorderColor = System.Drawing.Color.Green;
                lineShape45.BorderColor = System.Drawing.Color.Green;
                lineShape46.BorderColor = System.Drawing.Color.Green;
                lineShape47.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 11 && yolDizi[sayac + 1] == 12) || (yolDizi[sayac] == 12 && yolDizi[sayac + 1] == 11))
            {
                lineShape20.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 10 && yolDizi[sayac + 1] == 11) || (yolDizi[sayac] == 11 && yolDizi[sayac + 1] == 10))
            {
                lineShape8.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 12 && yolDizi[sayac + 1] == 13) || (yolDizi[sayac] == 13 && yolDizi[sayac + 1] == 12))
            {
                lineShape31.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 13 && yolDizi[sayac + 1] == 14) || (yolDizi[sayac] == 14 && yolDizi[sayac + 1] == 13))
            {
                lineShape9.BorderColor = System.Drawing.Color.Green;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            yönlendir();
            if (sayac > (yolDiziElemanSayisi - 3))
            {
                timer1.Stop();
                MessageBox.Show(güzergah, "Rota");
                if (merdivenGecis == true)
                {
                    Zemin zm = new Zemin();
                    zm.Show();
                    merdivenGecis = false;
                    this.Close();
                }
                //MessageBox.Show(" Timer durdu");
                sayac = 0;
            }
            sayac++;
        }
        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uygulama kapatma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }
        private void ovC1_Click(object sender, EventArgs e)
        {
            sıfırlan();
            if (!Cıkıs1)
            {
                Cıkıs1 = true;
                ovC1.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                Cıkıs1 = false;
                ovC1.BorderColor = System.Drawing.Color.Red;
            }
        }
        private void ovC4_Click(object sender, EventArgs e)
        {
            sıfırlan();
            if (!Cıkıs2)
            {
                Cıkıs2 = true;
                ovC4.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                Cıkıs2 = false;
                ovC4.BorderColor = System.Drawing.Color.Red;
            }
        }
        private void ovC2_Click(object sender, EventArgs e)
        {
            sıfırlan();
            if (!Cıkıs3)
            {
                Cıkıs3 = true;
                ovC2.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                Cıkıs3 = false;
                ovC2.BorderColor = System.Drawing.Color.Red;
            }
        }
        private void ovC5_Click(object sender, EventArgs e)
        {
            sıfırlan();
            if (!Cıkıs4)
            {
                Cıkıs4 = true;
                ovC5.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                Cıkıs4 = false;
                ovC5.BorderColor = System.Drawing.Color.Red;
            }
        }
        private void ovalShape1_Click(object sender, EventArgs e)
        {
            sıfırlan();
            if (!Cıkıs6)
            {
                Cıkıs6 = true;
                ovalShape1.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                Cıkıs6 = false;
                ovalShape1.BorderColor = System.Drawing.Color.Red;
            }
        }
        private void ovalShape2_Click(object sender, EventArgs e)
        {
            sıfırlan();
            if (!Cıkıs7)
            {
                Cıkıs7 = true;
                ovalShape2.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                Cıkıs7 = false;
                ovalShape2.BorderColor = System.Drawing.Color.Red;
            }
        }
    }
}
