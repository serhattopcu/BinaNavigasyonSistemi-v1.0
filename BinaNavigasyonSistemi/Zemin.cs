using System;
using System.Linq;
using System.Windows.Forms;
namespace BinaNavigasyonSistemi
{
    public partial class Zemin : Form
    {
        public Zemin()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        //Degiskenler
        public static bool OnCıkıs, Cıkıs1, Cıkıs2, Cıkıs3, Cıkıs4, Cıkıs5, Cıkıs6, ArkaCıkıs;
        public string güzergah;
        public double yolUzunlugu = 0;
        public int[] yolDizi = new int[5] { 0, 0, 0, 0, 0 };
        int sayac = 0,yolDiziElemanSayisi = 0;
        double[,] grafMatrisi =
       {
           // 0   1   2   3   4   5   6  7  8  9  10  11  12  
            { 0,  0,  0,  11, 0,  0,  0, 0, 0, 0,  0,  0,   0}, // 0
            { 0,  0, 0,  10,  0,  0,  0, 0, 0, 0,  0,  0,   0}, // 1
            { 0,  0,  0,  10, 0,  0,  0, 0, 0, 0,  0,  0,   0}, // 2
            { 11, 10, 10, 0,  0, 15.5,  15,0, 0, 0,  0,  0,   0}, // 3
            { 0,  0,  0,  0,  0,  7,  0, 0, 0, 0,  0,  0,   0}, // 4
            { 0,  0,  0,  15.5, 7,  0,  0, 0, 2, 14, 0,  0,   0}, // 5
            { 0,  0,  0,  15, 0,  0,  0, 7, 0, 0, 14,  0,    0}, // 6
            { 0,  0,  0,  0,  0,  0,  7, 0, 0, 0,  0,  0,   0}, // 7
            { 0,  0,  0,  0,  0,  1,  0, 0, 0, 0,  0,  0,   0}, // 8
            { 0,  0,  0,  0,  0,  14, 0, 0, 0, 0,  3,  0,   8}, // 9
            { 0,  0,  0,  0,  0,  0,  14, 0, 0, 3, 0,  9,    0}, // 10
            { 0,  0,  0,  0,  0,  0,  0, 0, 0, 0,  9,  0,   0}, // 11
            { 0,  0,  0,  0,  0,  0,  0, 0, 0, 8,  0,  0,   0}, // 12
           
        };
        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            sıfırla();
            int secilenDeger = Convert.ToInt32(comboBox1.SelectedItem);
            timer1.Enabled = true;
            if (secilenDeger == 3)
            {
                if (OnCıkıs)
                {
                    yoluYaz(grafMatrisi, 3, 0);
                    Araislem();
                }
                else if (Cıkıs1)
                {
                    yoluYaz(grafMatrisi, 3, 1);
                    Araislem();
                }
                else if (Cıkıs2)
                {
                    yoluYaz(grafMatrisi, 3, 2);
                    Araislem();
                }
                else if (Cıkıs3)
                {
                    yoluYaz(grafMatrisi, 3, 4);
                    Araislem();
                }
                else if (Cıkıs4)
                {
                    yoluYaz(grafMatrisi, 3, 7);
                    Araislem();
                }
                else if (Cıkıs5)
                {
                    yoluYaz(grafMatrisi, 3, 12);
                    Araislem();
                }
                else if (ArkaCıkıs)
                {
                    yoluYaz(grafMatrisi, 3, 11);
                    Araislem();
                }
                else if (Cıkıs6)
                {
                    yoluYaz(grafMatrisi, 3, 8);
                    Araislem();
                }
                else
                    MessageBox.Show("geçersiz yol");
            }
            else if (secilenDeger == 5)
            {
                if (Cıkıs3)
                {
                    yoluYaz(grafMatrisi, 5, 4);
                    Araislem();
                }
                else if (Cıkıs5)
                {
                    yoluYaz(grafMatrisi, 5, 12);
                    Araislem();
                }
                else if (OnCıkıs)
                {
                    yoluYaz(grafMatrisi, 5, 0);
                    Araislem();
                }
                else if (ArkaCıkıs)
                {
                    yoluYaz(grafMatrisi, 5, 11);
                    Araislem();
                }
                else if (Cıkıs1)
                {
                    yoluYaz(grafMatrisi, 5, 1);
                    Araislem();
                }
                else if (Cıkıs2)
                {
                    yoluYaz(grafMatrisi, 5, 2);
                    Araislem();
                }
                else if (Cıkıs4)
                {
                    yoluYaz(grafMatrisi, 5, 7);
                    Araislem();
                }
                else if (Cıkıs6)
                {
                    yoluYaz(grafMatrisi, 5, 8);
                    Araislem();
                }
                else
                    MessageBox.Show("geçersiz yol");
            }
            else if (secilenDeger == 6)
            {
                if (Cıkıs4)
                {
                    yoluYaz(grafMatrisi, 6, 7);
                    Araislem();
                }
                else if (Cıkıs2)
                {
                    yoluYaz(grafMatrisi, 6, 2);
                    Araislem();
                }
                else if (ArkaCıkıs)
                {
                    yoluYaz(grafMatrisi, 6, 11);
                    Araislem();
                }
                else if (Cıkıs5)
                {
                    yoluYaz(grafMatrisi, 6, 12);
                    Araislem();
                }
                else if (OnCıkıs)
                {
                    yoluYaz(grafMatrisi, 6, 0);
                    Araislem();
                }
                else if (Cıkıs1)
                {
                    yoluYaz(grafMatrisi, 6, 1);
                    Araislem();
                }
                else if (Cıkıs3)
                {
                    yoluYaz(grafMatrisi, 6, 3);
                    Araislem();
                }
                else
                    MessageBox.Show("Geçersiz Yol");
            }
            else if (secilenDeger == 9)
            {
                if (Cıkıs5)
                {
                    yoluYaz(grafMatrisi, 9, 12);
                    Araislem();
                }
                else if (ArkaCıkıs)
                {
                    yoluYaz(grafMatrisi, 9, 11);
                    Araislem();
                }
                else if (Cıkıs3)
                {
                    yoluYaz(grafMatrisi, 9, 4);
                    Araislem();
                }
                else if (Cıkıs4)
                {
                    yoluYaz(grafMatrisi, 9, 7);
                    Araislem();
                }
                else if (Cıkıs1)
                {
                    yoluYaz(grafMatrisi, 9, 1);
                    Araislem();
                }
                else if (Cıkıs2)
                {
                    yoluYaz(grafMatrisi, 9, 2);
                    Araislem();
                }
                else if (OnCıkıs)
                {
                    yoluYaz(grafMatrisi, 9, 0);
                    Araislem();
                }
                else
                    MessageBox.Show("geçersiz yol");
            }
            else if (secilenDeger == 10)
            {
                if (ArkaCıkıs)
                {
                    yoluYaz(grafMatrisi, 10, 11);
                    Araislem();
                }
                else if (Cıkıs5)
                {
                    yoluYaz(grafMatrisi, 10, 12);
                    Araislem();
                }
                else if (Cıkıs3)
                {
                    yoluYaz(grafMatrisi, 10, 4);
                    Araislem();
                }
                else if (OnCıkıs)
                {
                    yoluYaz(grafMatrisi, 10, 0);
                    Araislem();
                }
                else if (Cıkıs1)
                {
                    yoluYaz(grafMatrisi, 10, 1);
                    Araislem();
                }
                else if (Cıkıs2)
                {
                    yoluYaz(grafMatrisi, 10, 2);
                    Araislem();
                }
                else
                    MessageBox.Show("geçersiz yol");
            }
            sayac = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            yönlendir();
            if (sayac > (yolDiziElemanSayisi - 3))
            {
                timer1.Stop();
                MessageBox.Show(güzergah, "İzlenilen Rota");
                //MessageBox.Show(" Timer durdu");
                sayac = 0;
            }
            sayac++;
        }
        public void Araislem()
        {
            yolDiziElemanSayisi = yolDizi.Count();
            label18.Text = Convert.ToString(yolUzunlugu) + "m";
            label34.Text = Convert.ToInt32(yolUzunlugu / 3) + "sn";
            timer1.Start();
        }
        public void yönlendir()
        {
            if ((yolDizi[sayac] == 0 && yolDizi[sayac + 1] == 3) || (yolDizi[sayac] == 3 && yolDizi[sayac + 1] == 0))
            {
                lineShape7.BorderColor = System.Drawing.Color.Green;
                OnKapi.BorderColor = System.Drawing.Color.Green;
                ovOn.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 3 && yolDizi[sayac + 1] == 1) || (yolDizi[sayac] == 1 && yolDizi[sayac + 1] == 3))
            {
                lineShape1.BorderColor = System.Drawing.Color.Green;
                ovOn.BorderColor = System.Drawing.Color.Green;
                ovC1.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 3 && yolDizi[sayac + 1] == 2) || (yolDizi[sayac] == 2 && yolDizi[sayac + 1] == 3))
            {
                lineShape4.BorderColor = System.Drawing.Color.Green;
                ovOn.BorderColor = System.Drawing.Color.Green;
                ovC4.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 3 && yolDizi[sayac + 1] == 5) || (yolDizi[sayac] == 5 && yolDizi[sayac + 1] == 3))
            {
                lineShape29.BorderColor = System.Drawing.Color.Green;
                lineShape31.BorderColor = System.Drawing.Color.Green;
                lineShape17.BorderColor = System.Drawing.Color.Green;
                lineShape32.BorderColor = System.Drawing.Color.Green;
                lineShape33.BorderColor = System.Drawing.Color.Green;
                lineShape34.BorderColor = System.Drawing.Color.Green;
                lineShape35.BorderColor = System.Drawing.Color.Green;
                lineShape36.BorderColor = System.Drawing.Color.Green;
                lineShape37.BorderColor = System.Drawing.Color.Green;
                ln8.BorderColor = System.Drawing.Color.Green;
                ovOn.BorderColor = System.Drawing.Color.Green;
                ovC6.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 3 && yolDizi[sayac + 1] == 6) || (yolDizi[sayac] == 6 && yolDizi[sayac + 1] == 3))
            {
                lineShape38.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                lineShape43.BorderColor = System.Drawing.Color.Green;
                lineShape44.BorderColor = System.Drawing.Color.Green;
                lineShape45.BorderColor = System.Drawing.Color.Green;
                lineShape46.BorderColor = System.Drawing.Color.Green;
                lineShape47.BorderColor = System.Drawing.Color.Green;
                lineShape48.BorderColor = System.Drawing.Color.Green;
                lineShape49.BorderColor = System.Drawing.Color.Green;
                lineShape50.BorderColor = System.Drawing.Color.Green;
                ovOn.BorderColor = System.Drawing.Color.Green;
                ovAs.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 5 && yolDizi[sayac + 1] == 4) || (yolDizi[sayac] == 4 && yolDizi[sayac + 1] == 5))
            {
                ln33.BorderColor = System.Drawing.Color.Green;
                ovC6.BorderColor = System.Drawing.Color.Green;
                ovC2.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 5 && yolDizi[sayac + 1] == 8) || (yolDizi[sayac] == 8 && yolDizi[sayac + 1] == 5))
            {
                lineShape10.BorderColor = System.Drawing.Color.Green;
                ovalShape6.BorderColor = System.Drawing.Color.Green;
                ovalShape8.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 5 && yolDizi[sayac + 1] == 9) || (yolDizi[sayac] == 9 && yolDizi[sayac + 1] == 5))
            {
                lineShape8.BorderColor = System.Drawing.Color.Green;
                lineShape51.BorderColor = System.Drawing.Color.Green;
                lineShape52.BorderColor = System.Drawing.Color.Green;
                lineShape53.BorderColor = System.Drawing.Color.Green;
                lineShape16.BorderColor = System.Drawing.Color.Green;
                lineShape55.BorderColor = System.Drawing.Color.Green;
                lineShape56.BorderColor = System.Drawing.Color.Green;
                lineShape57.BorderColor = System.Drawing.Color.Green;
                ovC6.BorderColor = System.Drawing.Color.Green;
                ov11.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 9 && yolDizi[sayac + 1] == 12) || (yolDizi[sayac] == 12 && yolDizi[sayac + 1] == 9))
            {
                lineShape18.BorderColor = System.Drawing.Color.Green;
                lineShape3.BorderColor = System.Drawing.Color.Green;
                ov11.BorderColor = System.Drawing.Color.Green;
                ovC3.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 9 && yolDizi[sayac + 1] == 10) || (yolDizi[sayac] == 10 && yolDizi[sayac + 1] == 9))
            {
                lineShape19.BorderColor = System.Drawing.Color.Green;
                ov11.BorderColor = System.Drawing.Color.Green;
                ov14.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 10 && yolDizi[sayac + 1] == 11) || (yolDizi[sayac] == 11 && yolDizi[sayac + 1] == 10))
            {
                lineShape20.BorderColor = System.Drawing.Color.Green;
                lineShape6.BorderColor = System.Drawing.Color.Green;
                arkaKapi.BorderColor = System.Drawing.Color.Green;
                ov14.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 6 && yolDizi[sayac + 1] == 7) || (yolDizi[sayac] == 7 && yolDizi[sayac + 1] == 6))
            {
                ln5.BorderColor = System.Drawing.Color.Green;
                ovC5.BorderColor = System.Drawing.Color.Green;
                ovAs.BorderColor = System.Drawing.Color.Green;
            }
            if ((yolDizi[sayac] == 6 && yolDizi[sayac + 1] == 10) || (yolDizi[sayac] == 10 && yolDizi[sayac + 1] == 6))
            {
                lineShape14.BorderColor = System.Drawing.Color.Green;
                lineShape15.BorderColor = System.Drawing.Color.Green;
                lineShape58.BorderColor = System.Drawing.Color.Green;
                lineShape54.BorderColor = System.Drawing.Color.Green;
                lineShape59.BorderColor = System.Drawing.Color.Green;
                lineShape15.BorderColor = System.Drawing.Color.Green;
                lineShape60.BorderColor = System.Drawing.Color.Green;
                lineShape61.BorderColor = System.Drawing.Color.Green;
                lineShape62.BorderColor = System.Drawing.Color.Green;
                lineShape63.BorderColor = System.Drawing.Color.Green;
                lineShape64.BorderColor = System.Drawing.Color.Green;
                ovAs.BorderColor = System.Drawing.Color.Green;
                ov14.BorderColor = System.Drawing.Color.Green;
            }
        }
        public void sıfırla()
        {
            lineShape9.Visible = false;
            lineShape13.Visible = false;
            ovalShape4.Visible = false;
            ovalShape9.Visible = false;
            lineShape40.Visible = false;
            lineShape65.Visible = false;
            ln33.BorderColor = System.Drawing.Color.Gray;
            ln5.BorderColor = System.Drawing.Color.Gray;
            ln8.BorderColor = System.Drawing.Color.Gray;
            lineShape1.BorderColor = System.Drawing.Color.Gray;
            lineShape2.BorderColor = System.Drawing.Color.Gray;
            lineShape3.BorderColor = System.Drawing.Color.Gray;
            lineShape4.BorderColor = System.Drawing.Color.Gray;
            lineShape5.BorderColor = System.Drawing.Color.Gray;
            lineShape6.BorderColor = System.Drawing.Color.Gray;
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
            lineShape57.BorderColor = System.Drawing.Color.Gray;
            lineShape58.BorderColor = System.Drawing.Color.Gray;
            lineShape59.BorderColor = System.Drawing.Color.Gray;
            lineShape60.BorderColor = System.Drawing.Color.Gray;
            lineShape61.BorderColor = System.Drawing.Color.Gray;
            lineShape62.BorderColor = System.Drawing.Color.Gray;
            lineShape63.BorderColor = System.Drawing.Color.Gray;
            lineShape64.BorderColor = System.Drawing.Color.Gray;
            lineShape65.BorderColor = System.Drawing.Color.Gray;
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
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ovC3_Click(object sender, EventArgs e)
        {
            sıfırla();
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
        private void Zemin_Load(object sender, EventArgs e)
        {
            if (OnCıkıs)
            {
                OnKapi.BorderColor = System.Drawing.Color.Green;
            }
            if (!OnCıkıs)
            {
                OnKapi.BorderColor = System.Drawing.Color.Red;
            }
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
                ovalShape8.BorderColor = System.Drawing.Color.Green;
            }
            if (!Cıkıs6)
            {
                ovalShape8.BorderColor = System.Drawing.Color.Red;
            }
            if (ArkaCıkıs)
            {
                arkaKapi.BorderColor = System.Drawing.Color.Green;
            }
            if (!ArkaCıkıs)
            {
                arkaKapi.BorderColor = System.Drawing.Color.Red;
            }
            if (Kat1.merdivenGecis)
            {
                MerdivenSonuYolYaz();
            }
        }
        private void MerdivenSonuYolYaz()
        {
            if (Cıkıs3)
            {
                yoluYaz(grafMatrisi, 8, 4);
                yolUzunlugu += Kat1.yolUzunlugu;
                Araislem();
            }
            else if (Cıkıs5)
            {
                yoluYaz(grafMatrisi, 8, 12);
                yolUzunlugu += Kat1.yolUzunlugu;
                Araislem();
            }
            else if (Cıkıs1)
            {
                yoluYaz(grafMatrisi, 8, 1);
                yolUzunlugu += Kat1.yolUzunlugu;
                Araislem();
            }
            else if (ArkaCıkıs)
            {
                yoluYaz(grafMatrisi, 8, 11);
                yolUzunlugu += Kat1.yolUzunlugu;
                Araislem();
            }
            else if (OnCıkıs)
            {
                yoluYaz(grafMatrisi, 8, 0);
                lineShape41.BorderColor = System.Drawing.Color.Green;
                yolUzunlugu += Kat1.yolUzunlugu;
                Araislem();
            }
            else if (Cıkıs2)
            {
                yoluYaz(grafMatrisi, 8, 2);
                lineShape41.BorderColor = System.Drawing.Color.Green;
                lineShape42.BorderColor = System.Drawing.Color.Green;
                yolUzunlugu += Kat1.yolUzunlugu;
                Araislem();
            }
            else if (Cıkıs4)
            {
                yoluYaz(grafMatrisi, 8, 7);
                lineShape41.BorderColor = System.Drawing.Color.Green;
                lineShape42.BorderColor = System.Drawing.Color.Green;
                yolUzunlugu += Kat1.yolUzunlugu;
                Araislem();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Close();
            mn.Show();
        }
        private void btn_Hesapla_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Hesapla.BackgroundImage = Properties.Resources.h;
        }
        private void btn_Hesapla_MouseLeave(object sender, EventArgs e)
        {
            btn_Hesapla.BackgroundImage = Properties.Resources.hesss;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult rs = new DialogResult();
            rs = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uygulama kapatma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                Application.Exit();
        }
        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.k;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources.kkkk;
        }
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.g;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = Properties.Resources.gg;
        }
        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.aaaaaaaa;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.aaaa;
        }
        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            sıfırla();
            lineShape9.Visible = true;
            lineShape13.Visible = true;
            ovalShape4.Visible = true;
            sayac = 0;
            yolDizi[0] = 0;
            yolDizi[1] = 0;
            yolDizi[2] = 0;
            yolDizi[3] = 0;
            yolDizi[4] = 0;
            ovalShape4.BorderColor = System.Drawing.Color.Green;
            lineShape13.BorderColor = System.Drawing.Color.Green;
            lineShape9.BorderColor = System.Drawing.Color.Green;
            if (Cıkıs1)
            {
                ln8.BorderColor = System.Drawing.Color.Green;
                lineShape31.BorderColor = System.Drawing.Color.Green;
                lineShape29.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 3, 1);
                yolUzunlugu = yolUzunlugu + 4.5;
                Araislem();
            }
            else if (OnCıkıs)
            {
                ln8.BorderColor = System.Drawing.Color.Green;
                lineShape31.BorderColor = System.Drawing.Color.Green;
                lineShape41.BorderColor = System.Drawing.Color.Green;
                lineShape29.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 3, 0);
                yolUzunlugu = yolUzunlugu + 6.5;
                Araislem();
            }
            else if (Cıkıs3)
            {
                lineShape17.BorderColor = System.Drawing.Color.Green;
                lineShape32.BorderColor = System.Drawing.Color.Green;
                lineShape33.BorderColor = System.Drawing.Color.Green;
                lineShape34.BorderColor = System.Drawing.Color.Green;
                lineShape35.BorderColor = System.Drawing.Color.Green;
                lineShape36.BorderColor = System.Drawing.Color.Green;
                lineShape37.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 5, 4);
                yolUzunlugu = yolUzunlugu + 10.5;
                Araislem();
            }
            else if (Cıkıs2)
            {
                ln8.BorderColor = System.Drawing.Color.Green;
                lineShape31.BorderColor = System.Drawing.Color.Green;
                lineShape41.BorderColor = System.Drawing.Color.Green;
                lineShape42.BorderColor = System.Drawing.Color.Green;
                lineShape29.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 3, 2);
                yolUzunlugu = yolUzunlugu + 8.5;
                Araislem();
            }
            else if (Cıkıs4)
            {
                ln8.BorderColor = System.Drawing.Color.Green;
                lineShape31.BorderColor = System.Drawing.Color.Green;
                lineShape41.BorderColor = System.Drawing.Color.Green;
                lineShape42.BorderColor = System.Drawing.Color.Green;
                lineShape29.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 3, 7);
                yolUzunlugu = yolUzunlugu + 8.5;
                Araislem();
            }
            else if (Cıkıs5)
            {
                lineShape17.BorderColor = System.Drawing.Color.Green;
                lineShape32.BorderColor = System.Drawing.Color.Green;
                lineShape33.BorderColor = System.Drawing.Color.Green;
                lineShape34.BorderColor = System.Drawing.Color.Green;
                lineShape35.BorderColor = System.Drawing.Color.Green;
                lineShape36.BorderColor = System.Drawing.Color.Green;
                lineShape37.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 5, 12);
                yolUzunlugu = yolUzunlugu + 10.5;
                Araislem();
            }
            else if (ArkaCıkıs)
            {
                lineShape17.BorderColor = System.Drawing.Color.Green;
                lineShape32.BorderColor = System.Drawing.Color.Green;
                lineShape33.BorderColor = System.Drawing.Color.Green;
                lineShape34.BorderColor = System.Drawing.Color.Green;
                lineShape35.BorderColor = System.Drawing.Color.Green;
                lineShape36.BorderColor = System.Drawing.Color.Green;
                lineShape37.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 5, 11);
                yolUzunlugu = yolUzunlugu + 10.5;
                Araislem();
            }
        }
        private void ln8_Click(object sender, EventArgs e)
        {
        }
        private void ln9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("df");
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            sıfırla();
            ovalShape9.BorderColor = System.Drawing.Color.Green;
            lineShape40.BorderColor = System.Drawing.Color.Green;
            lineShape65.BorderColor = System.Drawing.Color.Green;
            ovalShape9.Visible = true;
            lineShape40.Visible = true;
            lineShape65.Visible = true;
            sayac = 0;
            yolDizi[0] = 0;
            yolDizi[1] = 0;
            yolDizi[2] = 0;
            yolDizi[3] = 0;
            yolDizi[4] = 0;
            if (Cıkıs4)
            {
                lineShape48.BorderColor = System.Drawing.Color.Green;
                lineShape49.BorderColor = System.Drawing.Color.Green;
                lineShape50.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 6, 7);
                yolUzunlugu = yolUzunlugu + 6;
                Araislem();
            }
            else if (Cıkıs2)
            {
                lineShape44.BorderColor = System.Drawing.Color.Green;
                lineShape45.BorderColor = System.Drawing.Color.Green;
                lineShape46.BorderColor = System.Drawing.Color.Green;
                lineShape47.BorderColor = System.Drawing.Color.Green;
                lineShape38.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                lineShape43.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 3, 2);
                yolUzunlugu = yolUzunlugu + 9;
                Araislem();
            }
            else if (OnCıkıs)
            {
                lineShape44.BorderColor = System.Drawing.Color.Green;
                lineShape45.BorderColor = System.Drawing.Color.Green;
                lineShape47.BorderColor = System.Drawing.Color.Green;
                lineShape46.BorderColor = System.Drawing.Color.Green;
                lineShape38.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                lineShape43.BorderColor = System.Drawing.Color.Green;
                lineShape42.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 3, 0);
                yolUzunlugu = yolUzunlugu + 11;
                Araislem();
            }
            else if (Cıkıs1)
            {
                lineShape44.BorderColor = System.Drawing.Color.Green;
                lineShape45.BorderColor = System.Drawing.Color.Green;
                lineShape47.BorderColor = System.Drawing.Color.Green;
                lineShape46.BorderColor = System.Drawing.Color.Green;
                lineShape38.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                lineShape42.BorderColor = System.Drawing.Color.Green;
                lineShape41.BorderColor = System.Drawing.Color.Green;
                lineShape43.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 3, 1);
                yolUzunlugu = yolUzunlugu + 13;
                Araislem();
            }
            else if (ArkaCıkıs)
            {
                lineShape48.BorderColor = System.Drawing.Color.Green;
                lineShape49.BorderColor = System.Drawing.Color.Green;
                lineShape50.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 6, 11);
                yolUzunlugu = yolUzunlugu + 6;
                Araislem();
            }
            else if (Cıkıs5)
            {
                lineShape48.BorderColor = System.Drawing.Color.Green;
                lineShape49.BorderColor = System.Drawing.Color.Green;
                lineShape50.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 6, 12);
                yolUzunlugu = yolUzunlugu + 6;
                Araislem();
            }
            else if (Cıkıs3)
            {
                lineShape44.BorderColor = System.Drawing.Color.Green;
                lineShape45.BorderColor = System.Drawing.Color.Green;
                lineShape47.BorderColor = System.Drawing.Color.Green;
                lineShape46.BorderColor = System.Drawing.Color.Green;
                lineShape38.BorderColor = System.Drawing.Color.Green;
                lineShape39.BorderColor = System.Drawing.Color.Green;
                lineShape41.BorderColor = System.Drawing.Color.Green;
                lineShape42.BorderColor = System.Drawing.Color.Green;
                lineShape43.BorderColor = System.Drawing.Color.Green;
                yoluYaz(grafMatrisi, 3, 4);
                yolUzunlugu = yolUzunlugu + 13;
                Araislem();
            }
        }
        private void ovC1_Click(object sender, EventArgs e)
        {
            sıfırla();
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
        private void OnKapi_Click(object sender, EventArgs e)
        {
            sıfırla();
            if (!OnCıkıs)
            {
                OnCıkıs = true;
                OnKapi.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                OnCıkıs = false;
                OnKapi.BorderColor = System.Drawing.Color.Red;
            }
        }
        private void ovC4_Click(object sender, EventArgs e)
        {
            sıfırla();
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
            sıfırla();
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
            sıfırla();
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
        private void ovalShape8_Click(object sender, EventArgs e)
        {
            sıfırla();
            if (!Cıkıs6)
            {
                Cıkıs6 = true;
                ovalShape8.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                Cıkıs6 = false;
                ovalShape8.BorderColor = System.Drawing.Color.Red;
            }
        }
        private void arkaKapi_Click(object sender, EventArgs e)
        {
            sıfırla();
            if (!ArkaCıkıs)
            {
                ArkaCıkıs = true;
                arkaKapi.BorderColor = System.Drawing.Color.Green;
            }
            else
            {
                ArkaCıkıs = false;
                arkaKapi.BorderColor = System.Drawing.Color.Red;
            }
        }
    }
}
