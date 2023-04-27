using PosDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosDemo.screens
{
    public partial class add_product : Form
    {
        PostutEntities db = new PostutEntities();

        string imgpath=null;
        public add_product()
        {
            InitializeComponent();
        }

        private void add_product_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prdct_name.Text != null && prdct_parcode.Text != null && prdct_price.Text != " ")
            {
                product add_prct = new product();
                {
                    add_prct.C_name = prdct_name.Text;
                    int price;
                    int.TryParse(prdct_price.Text, out price);
                    add_prct.price = price;
                    add_prct.notes = prdct_nts.Text;
                    int Qunatity;
                    int.TryParse(prdct_qntity.Text, out Qunatity);
                    add_prct.Quantity = Qunatity;
                    int pcode;
                    int.TryParse(prdct_parcode.Text, out pcode);
                    add_prct.code = pcode;
                }
                db.products.Add(add_prct);
                db.SaveChanges();
                if (imgpath != null)
                {
                    string newpath = Environment.CurrentDirectory +
                    "\\images\\prdt_img\\" + add_prct.id + ".jpg";
                    File.Copy(imgpath, newpath);
                }
                else { MessageBox.Show("choose a fuckin photo"); }

                db.SaveChanges();
                MessageBox.Show($"{prdct_name.Text} is added to database ");
            }
            else { MessageBox.Show("make sure that price,name and bar code is done"); }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            Thread th = new Thread(setimg);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

            void setimg(){
            if (dialog.ShowDialog() == DialogResult.OK)   
            {   
                    
                prct_img.ImageLocation = dialog.FileName;
                imgpath = dialog.FileName;
                }
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            product clr = new product();
            {
              prdct_name.Text=null;
              prdct_price.Text= null;
               prdct_nts.Text=null;
               prdct_qntity.Text=null;
               prdct_parcode.Text=null;
               prct_img.ImageLocation = null;
            }  
        }
    }
}
