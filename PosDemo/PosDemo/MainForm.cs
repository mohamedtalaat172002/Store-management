using PosDemo.screens;
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

namespace PosDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(OpenProducts);
            th.Start();
          //th.SetApartmentState(ApartmentState.STA);
            void OpenProducts() { Application.Run(new screens.Prdct_list()); }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void clsoeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(OpenCustomers);
            th.Start();
            //th.SetApartmentState(ApartmentState.STA);
            void OpenCustomers() { Application.Run(new screens.customers()); }
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread form = new Thread(openform);
            form.Start();

            void openform() { Application.Run(new add_product()); }

        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread form = new Thread(openuser);
            form.Start();

            void openuser() { Application.Run(new screens.new_user()); }
        }

        private void button5_Click(object sender, EventArgs e)

        {
            Thread th = new Thread(OpenProducts);
            th.Start();
            //th.SetApartmentState(ApartmentState.STA);
            void OpenProducts()
            {
                Application.Run(new screens.Prdct_list());

            }
        }

        private void listProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(OpenProducts);
            th.Start();
            //th.SetApartmentState(ApartmentState.STA);
            void OpenProducts()
            {
                Application.Run(new screens.Prdct_list());
            }
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(OpenProducts);
            th.Start();
            //th.SetApartmentState(ApartmentState.STA);
            void OpenProducts()
            {
                Application.Run(new screens.Prdct_list());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(Opensuppliers);
            th.Start();
            //th.SetApartmentState(ApartmentState.STA);
            void Opensuppliers()
            {
                Application.Run(new screens.suppliers());
            }
        }
    }
}
