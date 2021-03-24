namespace BookStore
{
    partial class PlaceOrder
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
            this.LabelForAuthor = new System.Windows.Forms.Label();
            this.BookOptions = new System.Windows.Forms.ComboBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddTitle = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Label();
            this.ChoosenBooks = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.Subtotal = new System.Windows.Forms.TextBox();
            this.Tax = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerOptions = new System.Windows.Forms.ComboBox();
            this.CustomerText = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChoosenBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelForAuthor
            // 
            this.LabelForAuthor.AutoSize = true;
            this.LabelForAuthor.Location = new System.Drawing.Point(17, 109);
            this.LabelForAuthor.Name = "LabelForAuthor";
            this.LabelForAuthor.Size = new System.Drawing.Size(58, 17);
            this.LabelForAuthor.TabIndex = 0;
            this.LabelForAuthor.Text = "Author: ";
            // 
            // BookOptions
            // 
            this.BookOptions.FormattingEnabled = true;
            this.BookOptions.Location = new System.Drawing.Point(81, 66);
            this.BookOptions.Name = "BookOptions";
            this.BookOptions.Size = new System.Drawing.Size(593, 24);
            this.BookOptions.TabIndex = 1;
            this.BookOptions.Text = "Select a Title";
            this.BookOptions.SelectedIndexChanged += new System.EventHandler(this.BookOptions_SelectedIndexChanged);
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(81, 109);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(245, 22);
            this.Author.TabIndex = 2;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(428, 109);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(246, 22);
            this.ISBN.TabIndex = 3;
            this.ISBN.TextChanged += new System.EventHandler(this.ISBN_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ISBN: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price: ";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(286, 151);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(178, 22);
            this.Price.TabIndex = 7;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(312, 205);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 22);
            this.quantity.TabIndex = 8;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity:";
            // 
            // AddTitle
            // 
            this.AddTitle.Location = new System.Drawing.Point(286, 233);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(151, 23);
            this.AddTitle.TabIndex = 11;
            this.AddTitle.Text = "Add Title";
            this.AddTitle.UseVisualStyleBackColor = true;
            this.AddTitle.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Sum.Location = new System.Drawing.Point(261, 287);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(193, 29);
            this.Sum.TabIndex = 12;
            this.Sum.Text = "Order Summary";
            this.Sum.Click += new System.EventHandler(this.label5_Click);
            // 
            // ChoosenBooks
            // 
            this.ChoosenBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChoosenBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Title2,
            this.QTY,
            this.LineTotal});
            this.ChoosenBooks.Location = new System.Drawing.Point(71, 335);
            this.ChoosenBooks.Name = "ChoosenBooks";
            this.ChoosenBooks.RowHeadersWidth = 51;
            this.ChoosenBooks.RowTemplate.Height = 24;
            this.ChoosenBooks.Size = new System.Drawing.Size(553, 143);
            this.ChoosenBooks.TabIndex = 13;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Title2
            // 
            this.Title2.HeaderText = "Author";
            this.Title2.MinimumWidth = 6;
            this.Title2.Name = "Title2";
            this.Title2.ReadOnly = true;
            this.Title2.Width = 125;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 125;
            // 
            // LineTotal
            // 
            this.LineTotal.HeaderText = "Line Total";
            this.LineTotal.MinimumWidth = 6;
            this.LineTotal.Name = "LineTotal";
            this.LineTotal.Width = 125;
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(57, 509);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(64, 17);
            this.SubtotalLabel.TabIndex = 14;
            this.SubtotalLabel.Text = "Subtotal:";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(273, 509);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(35, 17);
            this.TaxLabel.TabIndex = 15;
            this.TaxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(466, 509);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 17);
            this.totalLabel.TabIndex = 16;
            this.totalLabel.Text = "Total:";
            // 
            // Subtotal
            // 
            this.Subtotal.Location = new System.Drawing.Point(127, 506);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(120, 22);
            this.Subtotal.TabIndex = 17;
            // 
            // Tax
            // 
            this.Tax.Location = new System.Drawing.Point(314, 506);
            this.Tax.Name = "Tax";
            this.Tax.Size = new System.Drawing.Size(119, 22);
            this.Tax.TabIndex = 18;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(519, 506);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(105, 22);
            this.Total.TabIndex = 19;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(153, 555);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(163, 23);
            this.Confirm.TabIndex = 20;
            this.Confirm.Text = "Confirm Order";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(358, 555);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(154, 23);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Cancel Order";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerOptions
            // 
            this.CustomerOptions.FormattingEnabled = true;
            this.CustomerOptions.Location = new System.Drawing.Point(81, 22);
            this.CustomerOptions.Name = "CustomerOptions";
            this.CustomerOptions.Size = new System.Drawing.Size(593, 24);
            this.CustomerOptions.TabIndex = 23;
            this.CustomerOptions.Text = "Select a customer";
            this.CustomerOptions.SelectedIndexChanged += new System.EventHandler(this.CustomerOptions_SelectedIndexChanged);
            // 
            // CustomerText
            // 
            this.CustomerText.AutoSize = true;
            this.CustomerText.Location = new System.Drawing.Point(7, 25);
            this.CustomerText.Name = "CustomerText";
            this.CustomerText.Size = new System.Drawing.Size(68, 17);
            this.CustomerText.TabIndex = 24;
            this.CustomerText.Text = "Customer";
            // 
            // Book
            // 
            this.Book.AutoSize = true;
            this.Book.Location = new System.Drawing.Point(13, 66);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(40, 17);
            this.Book.TabIndex = 26;
            this.Book.Text = "Book";
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 649);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.CustomerText);
            this.Controls.Add(this.CustomerOptions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.SubtotalLabel);
            this.Controls.Add(this.ChoosenBooks);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.AddTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.BookOptions);
            this.Controls.Add(this.LabelForAuthor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Name = "PlaceOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChoosenBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelForAuthor;
        private System.Windows.Forms.ComboBox BookOptions;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddTitle;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.DataGridView ChoosenBooks;
        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox Subtotal;
        private System.Windows.Forms.TextBox Tax;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title2;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CustomerOptions;
        private System.Windows.Forms.Label CustomerText;
        private System.Windows.Forms.Label Book;
    }
}

