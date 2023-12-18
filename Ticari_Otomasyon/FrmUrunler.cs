using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele() 
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da=new SqlDataAdapter("Select * From TBL_URUNLER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void breadCrumbEdit6_PathChanged(object sender, DevExpress.XtraEditors.BreadCrumbPathChangedEventArgs e)
        {

        }

        private void breadCrumbEdit5_PathChanged(object sender, DevExpress.XtraEditors.BreadCrumbPathChangedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void breadCrumbEdit3_PathChanged(object sender, DevExpress.XtraEditors.BreadCrumbPathChangedEventArgs e)
        {

        }

        private void breadCrumbEdit2_PathChanged(object sender, DevExpress.XtraEditors.BreadCrumbPathChangedEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void breadCrumbEdit1_PathChanged(object sender, DevExpress.XtraEditors.BreadCrumbPathChangedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_PathChanged(object sender, DevExpress.XtraEditors.BreadCrumbPathChangedEventArgs e)
        {

        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
