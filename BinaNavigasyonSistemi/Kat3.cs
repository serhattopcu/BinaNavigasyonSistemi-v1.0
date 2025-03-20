using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaNavigasyonSistemi
{
    public partial class Kat3 : Form
    {
        public Kat3()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Kat3_Load(object sender, EventArgs e)
        {

        }

        private void btn3Geri_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }

        private void btn3Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
