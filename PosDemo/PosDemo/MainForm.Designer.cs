
namespace PosDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clsoeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clsoeFileToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::PosDemo.Properties.Resources.file;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clsoeFileToolStripMenuItem
            // 
            this.clsoeFileToolStripMenuItem.Image = global::PosDemo.Properties.Resources.close_icon;
            this.clsoeFileToolStripMenuItem.Name = "clsoeFileToolStripMenuItem";
            this.clsoeFileToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.clsoeFileToolStripMenuItem.Text = "clsoe file";
            this.clsoeFileToolStripMenuItem.Click += new System.EventHandler(this.clsoeFileToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Image = global::PosDemo.Properties.Resources.users_icon;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.usersToolStripMenuItem.Text = "users";
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Image = global::PosDemo.Properties.Resources.add_icon;
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.addUsersToolStripMenuItem.Text = "Add users";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Checked = true;
            this.productsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductsToolStripMenuItem,
            this.manageProductsToolStripMenuItem,
            this.listProductsToolStripMenuItem});
            this.productsToolStripMenuItem.Image = global::PosDemo.Properties.Resources.product;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.productsToolStripMenuItem.Text = "products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // addProductsToolStripMenuItem
            // 
            this.addProductsToolStripMenuItem.Image = global::PosDemo.Properties.Resources.add_icon;
            this.addProductsToolStripMenuItem.Name = "addProductsToolStripMenuItem";
            this.addProductsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.addProductsToolStripMenuItem.Text = "add products";
            this.addProductsToolStripMenuItem.Click += new System.EventHandler(this.addProductsToolStripMenuItem_Click);
            // 
            // manageProductsToolStripMenuItem
            // 
            this.manageProductsToolStripMenuItem.Image = global::PosDemo.Properties.Resources.mange_icon;
            this.manageProductsToolStripMenuItem.Name = "manageProductsToolStripMenuItem";
            this.manageProductsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.manageProductsToolStripMenuItem.Text = "manage products";
            this.manageProductsToolStripMenuItem.Click += new System.EventHandler(this.manageProductsToolStripMenuItem_Click);
            // 
            // listProductsToolStripMenuItem
            // 
            this.listProductsToolStripMenuItem.Image = global::PosDemo.Properties.Resources.list_icon;
            this.listProductsToolStripMenuItem.Name = "listProductsToolStripMenuItem";
            this.listProductsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.listProductsToolStripMenuItem.Text = "list products";
            this.listProductsToolStripMenuItem.Click += new System.EventHandler(this.listProductsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Image = global::PosDemo.Properties.Resources.users_icon;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.customersToolStripMenuItem.Text = "customers";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesBillToolStripMenuItem,
            this.purchasesBillToolStripMenuItem});
            this.suppliersToolStripMenuItem.Image = global::PosDemo.Properties.Resources.bill;
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.suppliersToolStripMenuItem.Text = "bill";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // salesBillToolStripMenuItem
            // 
            this.salesBillToolStripMenuItem.Image = global::PosDemo.Properties.Resources.bill;
            this.salesBillToolStripMenuItem.Name = "salesBillToolStripMenuItem";
            this.salesBillToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.salesBillToolStripMenuItem.Text = "sales bill";
            // 
            // purchasesBillToolStripMenuItem
            // 
            this.purchasesBillToolStripMenuItem.Image = global::PosDemo.Properties.Resources.bill;
            this.purchasesBillToolStripMenuItem.Name = "purchasesBillToolStripMenuItem";
            this.purchasesBillToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.purchasesBillToolStripMenuItem.Text = "Purchases bill";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Image = global::PosDemo.Properties.Resources.reports_icon;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.reportsToolStripMenuItem.Text = "reports";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::PosDemo.Properties.Resources.suppliers_img;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(29, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 154);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::PosDemo.Properties.Resources.bill;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(292, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 160);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::PosDemo.Properties.Resources.Customers_img;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(301, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 154);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::PosDemo.Properties.Resources.bill;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(554, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 160);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::PosDemo.Properties.Resources.products_img;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(554, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 154);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::PosDemo.Properties.Resources.file;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(29, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 160);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(579, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(300, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "customers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Suppliers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(567, 581);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 40);
            this.label4.TabIndex = 13;
            this.label4.Text = "Salles Bill";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(285, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 40);
            this.label5.TabIndex = 14;
            this.label5.Text = "purchase bill";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(74, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 40);
            this.label6.TabIndex = 15;
            this.label6.Text = "Reports";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::PosDemo.Properties.Resources.blue_bg;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clsoeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasesBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}