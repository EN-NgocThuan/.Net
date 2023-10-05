using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTL_B7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (BikeStoresDataContext db = new BikeStoresDataContext())
            {
                //var temp = db.brands
                //    .Where(r => r.brand_id > 5)
                //    .GroupBy(r => r.brand_id)
                //    .Select(r => r);

                var temp = from r in db.brands
                           //where r.brand_id > 5
                           //orderby r.brand_id descending
                           select r;
                DGV_1.DataSource = temp;
            }
        }
        private void Btn_Load_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadCell();
        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            using (BikeStoresDataContext db = new BikeStoresDataContext())
            {
                brand temp = new brand();
                temp.brand_name = txtName.Text;
                db.brands.InsertOnSubmit(temp);
                db.SubmitChanges();
            }
            LoadData();
        }
        private void LoadCell()
        {
            if (DGV_1.SelectedCells.Count == 0)
            {
                return;
            }
            int id = (int)DGV_1.SelectedCells[0].OwningRow.Cells[0].Value;
            using (BikeStoresDataContext db = new BikeStoresDataContext())
            {
                brand temp = db.brands.Where(r => r.brand_id == id).FirstOrDefault();
                if (temp != null)
                {
                    LB_id.Text = temp.brand_id.ToString();
                    txtName.Text = temp.brand_name;
                }
            }
        }

        private void DGV_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            LoadCell();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DGV_1.SelectedCells.Count == 0)
            {
                return;
            }
            int id = (int)DGV_1.SelectedCells[0].OwningRow.Cells[0].Value;
            using (BikeStoresDataContext db = new BikeStoresDataContext())
            {
                brand temp = db.brands.Where(r => r.brand_id == id).FirstOrDefault();
                if (temp != null)
                {
                     temp.brand_name = txtName.Text;
                     db.SubmitChanges();
                }
            }
            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DGV_1.SelectedCells.Count == 0)
            {
                return;
            }
            int id = (int)DGV_1.SelectedCells[0].OwningRow.Cells[0].Value;
            using (BikeStoresDataContext db = new BikeStoresDataContext())
            {
                brand temp = db.brands.Where(r => r.brand_id == id).FirstOrDefault();
                if (temp != null)
                {
                    db.brands.DeleteOnSubmit(temp);
                    db.SubmitChanges();
                }
            }
            LoadData();
        }



    }
}
