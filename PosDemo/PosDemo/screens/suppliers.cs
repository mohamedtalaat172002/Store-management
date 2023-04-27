using PosDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosDemo.screens
{
    public partial class suppliers : Form
    {
        PostutEntities db = new PostutEntities();
        int id;
        public suppliers()
        {
            InitializeComponent();
            supGridView1.DataSource = db.suppliers.ToList();
        }

        private void suppliers_Load(object sender, EventArgs e)
        {

        }

        private void supGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void src_btn_Click(object sender, EventArgs e)
        {

            if (nme_txt.Text == "")
            {
               supGridView1.DataSource =
                 db.suppliers.Where(x => x.address.Contains(nme_txt.Text)
                 ).ToList();
            }
            else 
            {
                supGridView1.DataSource =
                 db.suppliers.Where(x => x.address.Contains(cty_txt.Text)
                 | x.C_name.Contains(nme_txt.Text)

                 ).ToList();
            }
        }

        private void supGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(supGridView1.CurrentRow.Cells[0].Value.ToString());
                var result      = db.suppliers.SingleOrDefault(x => x.id == id);
                supName.Text    = result.C_name;
                supEmail.Text   = result.email;
                supPhone.Text   = result.phone.ToString();
                supNts.Text     = result.notes;
                supAdd.Text     = result.address;
                supCompany.Text = result.CompanyName;
                supImg.ImageLocation = result.image;
                if (result.is_active == true)
                { supActve.Checked = true; }
                else
                {
                    supActve.Checked = false;
                }

            }
            catch { }
        }

        private void update_cst_btn_Click(object sender, EventArgs e)
        {

            id = int.Parse(supGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = db.suppliers.SingleOrDefault(x => x.id == id);

            result.C_name = supName.Text;
            result.email = supEmail.Text;
            result.phone = supPhone.Text;
            result.notes = supNts.Text;
            result.CompanyName = supCompany.Text;
            if (result.is_active == true)
            { supActve.Checked = true; }
            else
            {
                supActve.Checked = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            supGridView1.DataSource = db.suppliers.ToList();
        }
    }
}
