using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishTest_Gavrilova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn2Klass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klass2 kl2 = new Klass2();
            kl2.ShowDialog();
        }

        private void btn3Klass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klass3 kl3 = new Klass3();
            kl3.ShowDialog();
        }

        private void btn4Klass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klass4 kl4 = new Klass4();
            kl4.ShowDialog();
        }
    }
}
