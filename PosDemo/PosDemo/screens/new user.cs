using PosDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosDemo.screens
{
    public partial class new_user : Form
        
    {
        PostutEntities db = new PostutEntities();
        string imagepath;
        public new_user()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            USer obj = new USer();
            {
                obj.UserName = txtuser.Text;
                obj.password = txtpassword.Text;
                //obj.image = imagepath;
            }
            db.USers.Add(obj);
            db.SaveChanges();
            string newpath = Environment.CurrentDirectory+
             "\\images\\UserImg\\"+obj.id+".jpg";
            File.Copy(imagepath,newpath);
            
            db.SaveChanges();
            MessageBox.Show($"{txtuser.Text} is added to database ");
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog()== DialogResult.OK)
            {
                userpic.ImageLocation = dialog.FileName;
                imagepath = dialog.FileName;
            }
        }

        private void new_user_Load(object sender, EventArgs e)
        {

        }
    }
}
