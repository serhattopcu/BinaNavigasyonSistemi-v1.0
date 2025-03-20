using System;
using System.Windows.Forms;
namespace BinaNavigasyonSistemi
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        private void btnkat3_Click(object sender, EventArgs e)
        {
            Kat3 kt3 = new Kat3();
            kt3.Show();
            this.Hide();
        }
        private void btnkat2_Click(object sender, EventArgs e)
        {
            Kat2 kt2 = new Kat2();
            kt2.Show();
            this.Hide();
        }
        private void btnkat1_Click(object sender, EventArgs e)
        {
            Kat1 kt1 = new Kat1();
            kt1.Show();
            this.Hide();
        }
        private void btnzemin_Click(object sender, EventArgs e)
        {
            Zemin zmn = new Zemin();
            zmn.Show();
            this.Hide();
        }
        private void btneksi1_Click(object sender, EventArgs e)
        {
            Kat_eksi1 ktek1 = new Kat_eksi1();
            ktek1.Show();
            this.Hide();
        }
        private void btneksi2_Click(object sender, EventArgs e)
        {
            Kat_eksi2 ktek2 = new Kat_eksi2();
            ktek2.Show();
            this.Hide();
        }

        private void btnkat3_MouseMove(object sender, MouseEventArgs e)
        {
            btnkat3.BackgroundImage = Properties.Resources._33;
        }
        private void btnkat3_MouseLeave(object sender, EventArgs e)
        {
            btnkat3.BackgroundImage = Properties.Resources._3;
        }
        private void btnzemin_MouseMove(object sender, MouseEventArgs e)
        {
            btnzemin.BackgroundImage = Properties.Resources.z2;
        }
        private void btnzemin_MouseLeave(object sender, EventArgs e)
        {
            btnzemin.BackgroundImage = Properties.Resources.z1;
        }
        private void btnkat2_MouseMove(object sender, MouseEventArgs e)
        {
            btnkat2.BackgroundImage = Properties.Resources._22;
        }
        private void btnkat2_MouseLeave(object sender, EventArgs e)
        {
            btnkat2.BackgroundImage = Properties.Resources._2;
        }
        private void btnkat1_MouseMove(object sender, MouseEventArgs e)
        {
            btnkat1.BackgroundImage = Properties.Resources._11;
        }
        private void btnkat1_MouseLeave(object sender, EventArgs e)
        {
            btnkat1.BackgroundImage = Properties.Resources._1;
        }
        private void btneksi1_MouseMove(object sender, MouseEventArgs e)
        {
            btneksi1.BackgroundImage = Properties.Resources.ee1;
        }
        private void btneksi1_MouseLeave(object sender, EventArgs e)
        {
            btneksi1.BackgroundImage = Properties.Resources.e1;
        }
        private void btneksi2_MouseMove(object sender, MouseEventArgs e)
        {
            btneksi2.BackgroundImage = Properties.Resources.ee2;
        }
        private void btneksi2_MouseLeave(object sender, EventArgs e)
        {
            btneksi2.BackgroundImage = Properties.Resources.e2;
        }
        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.hahaha;
        }
        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackgroundImage = Properties.Resources.ile;
        }
        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            button9.BackgroundImage = Properties.Resources.haha;
        }
        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackgroundImage = Properties.Resources.hak;
        }
    }
}
