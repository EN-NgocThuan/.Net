using Bunifu.UI.WinForms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo4
{
    public partial class Form_delItems : Form
    {
        BunifuLabel Values { get; set; }
        public Form_delItems(BunifuLabel values)
        {
            InitializeComponent();
            Values = values;   
        }
        private void Load_MaVL()
        {

            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                var temp = db.CTVATLIEUs.Where(r => r.IDVATLIEU == Values.Text).Select(r => r.MAVATLIEU);
                cBLoai.DataSource = temp;
            }
        }
        private void Form_delItems_Load(object sender, EventArgs e)
        {
            Load_MaVL();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                CTVATLIEU temp1 = db.CTVATLIEUs.Where(r => r.MAVATLIEU == cBLoai.Text).Select(r => r).FirstOrDefault();
                db.CTVATLIEUs.DeleteOnSubmit(temp1);
                db.SubmitChanges();
                MessageBox.Show("Xoá thành công","Thông báo");
            }
            this.Close();
        }

        private void cBLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QL_VATLIEUDataContext db = new QL_VATLIEUDataContext())
            {
                CTVATLIEU temp1 = db.CTVATLIEUs.Where(r => r.MAVATLIEU == cBLoai.Text).Select(r => r).FirstOrDefault();
                bLb_TenVL.Text = temp1.TENVATLIEU;
                bLb_GiaVL.Text = temp1.GIA.ToString();
                bLb_DonVi.Text = temp1.DONVI;
            }
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
