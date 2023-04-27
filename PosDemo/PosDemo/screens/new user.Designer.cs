
namespace PosDemo.screens
{
    partial class new_user
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userpic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtpassword.Location = new System.Drawing.Point(227, 190);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(363, 41);
            this.txtpassword.TabIndex = 11;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtuser.Location = new System.Drawing.Point(227, 98);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(363, 36);
            this.txtuser.TabIndex = 10;
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(227, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 91);
            this.button1.TabIndex = 9;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(220, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "creat new user";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(38, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(38, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "user name";
            // 
            // userpic
            // 
            this.userpic.Location = new System.Drawing.Point(227, 259);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(243, 171);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userpic.TabIndex = 12;
            this.userpic.TabStop = false;
            this.userpic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(38, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "image";
            // 
            // new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::PosDemo.Properties.Resources.blue_bg;
            this.ClientSize = new System.Drawing.Size(663, 592);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userpic);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "new_user";
            this.Text = "new_user";
            this.Load += new System.EventHandler(this.new_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.Label label4;
    }
}