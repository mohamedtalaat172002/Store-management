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
    public partial class customers : Form
    {
        PostutEntities db = new PostutEntities();
        int id;
        public customers()
        {
            InitializeComponent();
            customerGridView1.DataSource = db.customers.ToList();
        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void customers_Load(object sender, EventArgs e)
        {

        }

        private void nme_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void src_btn_Click(object sender, EventArgs e)
        {

            if (nme_txt.Text == "")
            {
                customerGridView1.DataSource =
                 db.customers.Where(x => x.address.Contains(pcde_txt.Text)
                 ).ToList();
            }
            else
            {
                customerGridView1.DataSource =
                 db.customers.Where(x => x.address.Contains(pcde_txt.Text)
                 | x.C_name.Contains(nme_txt.Text)

                 ).ToList();
            }
        }

        private void pcde_txt_TextChanged(object sender, EventArgs e)
        {
            customerGridView1.DataSource = db.customers.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerGridView1.DataSource = db.customers.ToList();

        }

        private void customerGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(customerGridView1.CurrentRow.Cells[0].Value.ToString());
                var result      = db.customers.SingleOrDefault(x => x.id == id);
                cstName.Text    = result.C_name;
                cstEmail.Text   = result.email;
                cstPhone.Text   = result.phone.ToString();
                cstNts.Text     = result.notes;
                cstAdd.Text      = result.address; 
                cstCompany.Text = result.CompanyName;
                cstImg.ImageLocation = result.image;
                if (result.is_active == true)
                { cstActve.Checked = true; }
                else
                {
                    cstActve.Checked = false;
                }
            
            }
            catch { }
        }

        private void prdct_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_prct_btn_Click(object sender, EventArgs e)
        {
            id = int.Parse(customerGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = db.customers.SingleOrDefault(x => x.id == id);

            result.C_name = cstName.Text;
            result.email = cstEmail.Text;
            result.phone= cstPhone.Text;
            result.notes = cstNts.Text;
            result.CompanyName = cstCompany.Text;
            if (cstActve.Checked == true)
            { result.is_active =true; }
            else
            {
                cstActve.Checked = false;
            }

        }

        private void cstRmvebtn_Click(object sender, EventArgs e)
        {

        }

        private void cstImg_Click(object sender, EventArgs e)
        {

        }
    }
}
