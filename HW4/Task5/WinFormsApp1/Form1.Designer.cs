namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddProduct = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.ExpirationDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtNumPages = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthors = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(1022, 241);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(161, 34);
            this.AddProduct.TabIndex = 0;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(1022, 281);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(161, 34);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1022, 321);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(161, 34);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(16, 51);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(54, 25);
            this.Price.TabIndex = 4;
            this.Price.Text = "Price";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(12, 86);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(159, 25);
            this.Country.TabIndex = 5;
            this.Country.Text = "Country of origin";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(12, 120);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(128, 25);
            this.Date.TabIndex = 6;
            this.Date.Text = "Package Date";
            this.Date.Click += new System.EventHandler(this.label4_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(16, 163);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(109, 25);
            this.Description.TabIndex = 7;
            this.Description.Text = "Description";
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AutoSize = true;
            this.ExpirationDate.Location = new System.Drawing.Point(306, 9);
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Size = new System.Drawing.Size(139, 25);
            this.ExpirationDate.TabIndex = 8;
            this.ExpirationDate.Text = "ExpirationDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(610, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Publisher";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(610, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Authors";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(458, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 25);
            this.label12.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Number of Pages";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 31);
            this.txtName.TabIndex = 15;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(196, 83);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 31);
            this.txtCountry.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(146, 45);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 31);
            this.txtPrice.TabIndex = 17;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(146, 120);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 31);
            this.txtDate.TabIndex = 18;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(146, 157);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 31);
            this.txtDescription.TabIndex = 19;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(454, 8);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(150, 31);
            this.txtExpDate.TabIndex = 20;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(454, 48);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(150, 31);
            this.txtNumber.TabIndex = 21;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(454, 91);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(150, 31);
            this.txtUnit.TabIndex = 22;
            // 
            // txtNumPages
            // 
            this.txtNumPages.Location = new System.Drawing.Point(784, 8);
            this.txtNumPages.Name = "txtNumPages";
            this.txtNumPages.Size = new System.Drawing.Size(150, 31);
            this.txtNumPages.TabIndex = 23;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(784, 48);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(150, 31);
            this.txtPublisher.TabIndex = 24;
            // 
            // txtAuthors
            // 
            this.txtAuthors.Location = new System.Drawing.Point(784, 92);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.Size = new System.Drawing.Size(150, 31);
            this.txtAuthors.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(16, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(972, 381);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Country of origin";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Package Date";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Expiration Date";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Number";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Unit";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Number of Pages";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Publisher";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Authors";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAuthors);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtNumPages);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExpirationDate);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.AddProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddProduct;
        private Button AddBook;
        private Button Delete;
        private Label label1;
        private Label Price;
        private Label Country;
        private Label Date;
        private Label Description;
        private Label ExpirationDate;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label9;
        private TextBox txtName;
        private TextBox txtCountry;
        private TextBox txtPrice;
        private TextBox txtDate;
        private TextBox txtDescription;
        private TextBox txtExpDate;
        private TextBox txtNumber;
        private TextBox txtUnit;
        private TextBox txtNumPages;
        private TextBox txtPublisher;
        private TextBox txtAuthors;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}