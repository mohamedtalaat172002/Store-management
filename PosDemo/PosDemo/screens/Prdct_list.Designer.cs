
namespace PosDemo.screens
{
    partial class Prdct_list
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postutDataSet = new PosDemo.PostutDataSet();
            this.nme_txt = new System.Windows.Forms.TextBox();
            this.pcde_txt = new System.Windows.Forms.TextBox();
            this.src_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new PosDemo.PostutDataSetTableAdapters.productsTableAdapter();
            this.clrbtn = new System.Windows.Forms.Button();
            this.prct_img = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.update_prct_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.prdct_nts = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prdct_qntity = new System.Windows.Forms.TextBox();
            this.prdct_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prdct_parcode = new System.Windows.Forms.TextBox();
            this.prdct_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prct_img)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(748, 198);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(665, 494);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "_name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "_name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.postutDataSet;
            // 
            // postutDataSet
            // 
            this.postutDataSet.DataSetName = "PostutDataSet";
            this.postutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nme_txt
            // 
            this.nme_txt.Location = new System.Drawing.Point(886, 91);
            this.nme_txt.Multiline = true;
            this.nme_txt.Name = "nme_txt";
            this.nme_txt.Size = new System.Drawing.Size(190, 38);
            this.nme_txt.TabIndex = 1;
            this.nme_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pcde_txt
            // 
            this.pcde_txt.Location = new System.Drawing.Point(886, 147);
            this.pcde_txt.Multiline = true;
            this.pcde_txt.Name = "pcde_txt";
            this.pcde_txt.Size = new System.Drawing.Size(190, 38);
            this.pcde_txt.TabIndex = 2;
            // 
            // src_btn
            // 
            this.src_btn.BackColor = System.Drawing.Color.Black;
            this.src_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.src_btn.ForeColor = System.Drawing.Color.Transparent;
            this.src_btn.Location = new System.Drawing.Point(1096, 107);
            this.src_btn.Name = "src_btn";
            this.src_btn.Size = new System.Drawing.Size(107, 74);
            this.src_btn.TabIndex = 3;
            this.src_btn.Text = "Search";
            this.src_btn.UseVisualStyleBackColor = false;
            this.src_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1209, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(748, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(748, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "parcode:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.clrbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clrbtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.clrbtn.FlatAppearance.BorderSize = 3;
            this.clrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrbtn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.clrbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clrbtn.Location = new System.Drawing.Point(436, 512);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(251, 63);
            this.clrbtn.TabIndex = 43;
            this.clrbtn.Text = "Delete";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // prct_img
            // 
            this.prct_img.BackColor = System.Drawing.Color.Gray;
            this.prct_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.prct_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prct_img.Location = new System.Drawing.Point(444, 115);
            this.prct_img.Name = "prct_img";
            this.prct_img.Size = new System.Drawing.Size(264, 252);
            this.prct_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prct_img.TabIndex = 42;
            this.prct_img.TabStop = false;
            this.prct_img.Click += new System.EventHandler(this.prct_img_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(129, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 24);
            this.label10.TabIndex = 41;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(92, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 24);
            this.label9.TabIndex = 40;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(104, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "*";
            // 
            // update_prct_btn
            // 
            this.update_prct_btn.BackColor = System.Drawing.SystemColors.ControlText;
            this.update_prct_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_prct_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.update_prct_btn.FlatAppearance.BorderSize = 3;
            this.update_prct_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_prct_btn.Font = new System.Drawing.Font("Tahoma", 20F);
            this.update_prct_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_prct_btn.Location = new System.Drawing.Point(435, 412);
            this.update_prct_btn.Name = "update_prct_btn";
            this.update_prct_btn.Size = new System.Drawing.Size(252, 62);
            this.update_prct_btn.TabIndex = 38;
            this.update_prct_btn.Text = "update";
            this.update_prct_btn.UseVisualStyleBackColor = false;
            this.update_prct_btn.Click += new System.EventHandler(this.add_prct_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(516, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 36);
            this.label7.TabIndex = 37;
            this.label7.Text = "photo";
            // 
            // prdct_nts
            // 
            this.prdct_nts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prdct_nts.Location = new System.Drawing.Point(118, 412);
            this.prdct_nts.Multiline = true;
            this.prdct_nts.Name = "prdct_nts";
            this.prdct_nts.Size = new System.Drawing.Size(297, 251);
            this.prdct_nts.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(6, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 36);
            this.label6.TabIndex = 35;
            this.label6.Text = "Notes";
            // 
            // prdct_qntity
            // 
            this.prdct_qntity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prdct_qntity.Location = new System.Drawing.Point(171, 304);
            this.prdct_qntity.Multiline = true;
            this.prdct_qntity.Name = "prdct_qntity";
            this.prdct_qntity.Size = new System.Drawing.Size(228, 41);
            this.prdct_qntity.TabIndex = 34;
            // 
            // prdct_price
            // 
            this.prdct_price.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prdct_price.Location = new System.Drawing.Point(171, 161);
            this.prdct_price.Multiline = true;
            this.prdct_price.Name = "prdct_price";
            this.prdct_price.Size = new System.Drawing.Size(228, 43);
            this.prdct_price.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(5, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 36);
            this.label5.TabIndex = 31;
            this.label5.Text = "Price";
            // 
            // prdct_parcode
            // 
            this.prdct_parcode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prdct_parcode.Location = new System.Drawing.Point(171, 233);
            this.prdct_parcode.Multiline = true;
            this.prdct_parcode.Name = "prdct_parcode";
            this.prdct_parcode.Size = new System.Drawing.Size(228, 41);
            this.prdct_parcode.TabIndex = 30;
            // 
            // prdct_name
            // 
            this.prdct_name.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prdct_name.Location = new System.Drawing.Point(171, 90);
            this.prdct_name.Multiline = true;
            this.prdct_name.Name = "prdct_name";
            this.prdct_name.Size = new System.Drawing.Size(228, 43);
            this.prdct_name.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(249, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 50);
            this.label3.TabIndex = 28;
            this.label3.Text = "The product";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(6, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 36);
            this.label11.TabIndex = 27;
            this.label11.Text = "BarCode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(6, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 36);
            this.label12.TabIndex = 26;
            this.label12.Text = "Name";
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
            this.button1.Location = new System.Drawing.Point(436, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 63);
            this.button1.TabIndex = 44;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Prdct_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1447, 736);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.prct_img);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.update_prct_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prdct_nts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prdct_qntity);
            this.Controls.Add(this.prdct_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prdct_parcode);
            this.Controls.Add(this.prdct_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.src_btn);
            this.Controls.Add(this.pcde_txt);
            this.Controls.Add(this.nme_txt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Prdct_list";
            this.Text = "Prdct_list";
            this.Load += new System.EventHandler(this.Prdct_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prct_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nme_txt;
        private System.Windows.Forms.TextBox pcde_txt;
        private System.Windows.Forms.Button src_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PostutDataSet postutDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private PostutDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.PictureBox prct_img;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button update_prct_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prdct_nts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prdct_qntity;
        private System.Windows.Forms.TextBox prdct_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prdct_parcode;
        private System.Windows.Forms.TextBox prdct_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}