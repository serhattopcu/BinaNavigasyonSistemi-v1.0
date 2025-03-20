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
    public partial class Kat_eksi1 : Form
    {
        public Kat_eksi1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Kat_eksi1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }
    }
}
