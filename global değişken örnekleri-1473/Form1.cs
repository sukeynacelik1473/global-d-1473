using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace global_değişken_örnekleri_1473
{


    public partial class Form1 : Form
    {
        // buradaki değişkenler globaldir.,
        double bakiye = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakıye.Text = "bakiye:" + bakiye.ToString();
            lblBakıye.ForeColor= Color.Green;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            bakiye += 50;
            lblBakıye.Text = "bakiye:" + bakiye.ToString();
            lblBakıye.ForeColor= Color.Green;

        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if(bakiye>= 8)
            {
                bakiye = bakiye - 8;
                lblBakıye.Text= "bakiye :"+ bakiye.ToString();
            }
            else
            {
                lblBakıye.Text = "paraniz yok fakirler ....";
                lblBakıye.ForeColor= Color.Red;
            }
       

        }
    }

}

