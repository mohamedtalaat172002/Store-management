
namespace PosDemo.screens
{
    partial class suppliers
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
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.src_btn = new System.Windows.Forms.Button();
            this.nme_txt = new System.Windows.Forms.TextBox();
            this.supGridView1 = new System.Windows.Forms.DataGridView();
            this.supActve = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.supCompany = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cstRmvebtn = new System.Windows.Forms.Button();
            this.supImg = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.update_cst_btn = new System.Windows.Forms.Button();
            this.supNts = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.supAdd = new System.Windows.Forms.TextBox();
            this.supEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.supPhone = new System.Windows.Forms.TextBox();
            this.supName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cty_txt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(555, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 36);
            this.label7.TabIndex = 63;
            this.label7.Text = "photo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(191, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 50);
            this.label3.TabIndex = 54;
            this.label3.Text = "The Suppliers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(773, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 50;
            this.label1.Text = "Name:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1294, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 74);
            this.button2.TabIndex = 49;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // src_btn
            // 
            this.src_btn.BackColor = System.Drawing.Color.Black;
            this.src_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.src_btn.ForeColor = System.Drawing.Color.Transparent;
            this.src_btn.Location = new System.Drawing.Point(1169, 46);
            this.src_btn.Name = "src_btn";
            this.src_btn.Size = new System.Drawing.Size(107, 74);
            this.src_btn.TabIndex = 48;
            this.src_btn.Text = "Search";
            this.src_btn.UseVisualStyleBackColor = false;
            this.src_btn.Click += new System.EventHandler(this.src_btn_Click);
            // 
            // nme_txt
            // 
            this.nme_txt.Location = new System.Drawing.Point(933, 30);
            this.nme_txt.Multiline = true;
            this.nme_txt.Name = "nme_txt";
            this.nme_txt.Size = new System.Drawing.Size(190, 38);
            this.nme_txt.TabIndex = 46;
            // 
            // supGridView1
            // 
            this.supGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supGridView1.Location = new System.Drawing.Point(767, 151);
            this.supGridView1.MultiSelect = false;
            this.supGridView1.Name = "supGridView1";
            this.supGridView1.ReadOnly = true;
            this.supGridView1.RowHeadersWidth = 51;
            this.supGridView1.RowTemplate.Height = 26;
            this.supGridView1.Size = new System.Drawing.Size(665, 494);
            this.supGridView1.TabIndex = 45;
            this.supGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supGridView1_CellContentClick);
            this.supGridView1.SelectionChanged += new System.EventHandler(this.supGridView1_SelectionChanged);
            // 
            // supActve
            // 
            this.supActve.AutoSize = true;
            this.supActve.Location = new System.Drawing.Point(201, 590);
            this.supActve.Name = "supActve";
            this.supActve.Size = new System.Drawing.Size(18, 17);
            this.supActve.TabIndex = 94;
            this.supActve.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(20, 572);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 36);
            this.label13.TabIndex = 93;
            this.label13.Text = "Active";
            // 
            // supCompany
            // 
            this.supCompany.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.supCompany.Location = new System.Drawing.Point(185, 484);
            this.supCompany.Multiline = true;
            this.supCompany.Name = "supCompany";
            this.supCompany.Size = new System.Drawing.Size(228, 41);
            this.supCompany.TabIndex = 92;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(19, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 36);
            this.label14.TabIndex = 91;
            this.label14.Text = "Company";
            // 
            // cstRmvebtn
            // 
            this.cstRmvebtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.cstRmvebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cstRmvebtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cstRmvebtn.FlatAppearance.BorderSize = 3;
            this.cstRmvebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cstRmvebtn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.cstRmvebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cstRmvebtn.Location = new System.Drawing.Point(446, 528);
            this.cstRmvebtn.Name = "cstRmvebtn";
            this.cstRmvebtn.Size = new System.Drawing.Size(251, 63);
            this.cstRmvebtn.TabIndex = 90;
            this.cstRmvebtn.Text = "Delete";
            this.cstRmvebtn.UseVisualStyleBackColor = false;
            // 
            // supImg
            // 
            this.supImg.BackColor = System.Drawing.Color.Gray;
            this.supImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.supImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.supImg.Location = new System.Drawing.Point(454, 131);
            this.supImg.Name = "supImg";
            this.supImg.Size = new System.Drawing.Size(264, 252);
            this.supImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.supImg.TabIndex = 89;
            this.supImg.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(139, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 24);
            this.label10.TabIndex = 88;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(102, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 24);
            this.label9.TabIndex = 87;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(114, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 24);
            this.label8.TabIndex = 86;
            this.label8.Text = "*";
            // 
            // update_cst_btn
            // 
            this.update_cst_btn.BackColor = System.Drawing.SystemColors.ControlText;
            this.update_cst_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_cst_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.update_cst_btn.FlatAppearance.BorderSize = 3;
            this.update_cst_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_cst_btn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.update_cst_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_cst_btn.Location = new System.Drawing.Point(445, 428);
            this.update_cst_btn.Name = "update_cst_btn";
            this.update_cst_btn.Size = new System.Drawing.Size(252, 62);
            this.update_cst_btn.TabIndex = 85;
            this.update_cst_btn.Text = "update";
            this.update_cst_btn.UseVisualStyleBackColor = false;
            this.update_cst_btn.Click += new System.EventHandler(this.update_cst_btn_Click);
            // 
            // supNts
            // 
            this.supNts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.supNts.Location = new System.Drawing.Point(185, 406);
            this.supNts.Multiline = true;
            this.supNts.Name = "supNts";
            this.supNts.Size = new System.Drawing.Size(228, 45);
            this.supNts.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(16, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 36);
            this.label6.TabIndex = 83;
            this.label6.Text = "Notes";
            // 
            // supAdd
            // 
            this.supAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.supAdd.Location = new System.Drawing.Point(185, 332);
            this.supAdd.Multiline = true;
            this.supAdd.Name = "supAdd";
            this.supAdd.Size = new System.Drawing.Size(228, 41);
            this.supAdd.TabIndex = 82;
            // 
            // supEmail
            // 
            this.supEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.supEmail.Location = new System.Drawing.Point(185, 182);
            this.supEmail.Multiline = true;
            this.supEmail.Name = "supEmail";
            this.supEmail.Size = new System.Drawing.Size(228, 43);
            this.supEmail.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 36);
            this.label4.TabIndex = 80;
            this.label4.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(16, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 36);
            this.label5.TabIndex = 79;
            this.label5.Text = "email";
            // 
            // supPhone
            // 
            this.supPhone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.supPhone.Location = new System.Drawing.Point(185, 258);
            this.supPhone.Multiline = true;
            this.supPhone.Name = "supPhone";
            this.supPhone.Size = new System.Drawing.Size(228, 41);
            this.supPhone.TabIndex = 78;
            // 
            // supName
            // 
            this.supName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.supName.Location = new System.Drawing.Point(185, 106);
            this.supName.Multiline = true;
            this.supName.Name = "supName";
            this.supName.Size = new System.Drawing.Size(228, 43);
            this.supName.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(16, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 36);
            this.label11.TabIndex = 76;
            this.label11.Text = "phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(16, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 36);
            this.label12.TabIndex = 75;
            this.label12.Text = "Name";
            // 
            // cty_txt
            // 
            this.cty_txt.Location = new System.Drawing.Point(933, 90);
            this.cty_txt.Multiline = true;
            this.cty_txt.Name = "cty_txt";
            this.cty_txt.Size = new System.Drawing.Size(190, 38);
            this.cty_txt.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(784, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 34);
            this.label15.TabIndex = 51;
            this.label15.Text = "City:";
            // 
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::PosDemo.Properties.Resources.blue_bg;
            this.ClientSize = new System.Drawing.Size(1456, 686);
            this.Controls.Add(this.supActve);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.supCompany);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cstRmvebtn);
            this.Controls.Add(this.supImg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.update_cst_btn);
            this.Controls.Add(this.supNts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.supAdd);
            this.Controls.Add(this.supEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.supPhone);
            this.Controls.Add(this.supName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cty_txt);
            this.Controls.Add(this.src_btn);
            this.Controls.Add(this.nme_txt);
            this.Controls.Add(this.supGridView1);
            this.Name = "suppliers";
            this.Text = "suppliers";
            this.Load += new System.EventHandler(this.suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button src_btn;
        private System.Windows.Forms.TextBox nme_txt;
        private System.Windows.Forms.DataGridView supGridView1;
        private System.Windows.Forms.CheckBox supActve;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox supCompany;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cstRmvebtn;
        private System.Windows.Forms.PictureBox supImg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button update_cst_btn;
        private System.Windows.Forms.TextBox supNts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox supAdd;
        private System.Windows.Forms.TextBox supEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox supPhone;
        private System.Windows.Forms.TextBox supName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cty_txt;
        private System.Windows.Forms.Label label15;
    }
}