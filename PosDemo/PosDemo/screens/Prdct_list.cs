using PosDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosDemo.screens
{
    public partial class Prdct_list : Form
    {
        PostutEntities db = new PostutEntities();
        int id;
        public Prdct_list()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.products.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nme_txt.Text == "")
            {
                dataGridView1.DataSource =
                 db.products.Where(x => x.code.ToString() == pcde_txt.Text  
                 ).ToList();
            }
            else
            {
                dataGridView1.DataSource =
                 db.products.Where(x => x.code.ToString() == pcde_txt.Text
                 | x.C_name.Contains(nme_txt.Text)

                 ).ToList();
            }
        }

        private void Prdct_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'postutDataSet.products' table. You can move, or remove it, as needed.
        //    this.productsTableAdapter.Fill(this.postutDataSet.products);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var result = db.products.SingleOrDefault(x => x.id == id);
                prdct_name.Text = result.C_name;
                prdct_price.Text = result.price.ToString();
                prdct_parcode.Text = result.code.ToString();
                prdct_qntity.Text = result.Quantity.ToString();
                prdct_nts.Text = result.notes;
                prct_img.ImageLocation = result.image;
            }
            catch { }
        }

        private void prct_img_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.products.ToList();
        }

        private void add_prct_btn_Click(object sender, EventArgs e)
        {
            if (prdct_name.Text!=null& prdct_parcode!= null& prdct_price!=null)
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var update = db.products.SingleOrDefault(x => x.id == id);
                update.C_name = prdct_name.Text;
                // handle the int values
                int price;
                int.TryParse(prdct_price.Text, out price);
                update.price = price;
                int codee;
                int.TryParse(prdct_parcode.Text, out codee) ;
                update.code = codee;
                int qt;
                int.TryParse(prdct_qntity.Text, out qt);
                update.Quantity = qt;
                update.notes = prdct_nts.Text;
                update.image = prct_img.ImageLocation;

                db.SaveChanges();
                MessageBox.Show("update is done succefully");
                dataGridView1.DataSource = db.products.ToList();
            }
            else
            { MessageBox.Show("make sure to fill the name,price and parcode "); }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Are u sure u want to delete permanently?"
                ,"deleting item", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var remve = db.products.Find(id);
                db.products.Remove(remve);
                db.SaveChanges();
                MessageBox.Show($"{prdct_name.Text}is deleted succefully ");
                dataGridView1.DataSource = db.products.ToList();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread th = new Thread(openform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            void openform()
            {
                Application.Run(new add_product());
            }
        }
    }
}
