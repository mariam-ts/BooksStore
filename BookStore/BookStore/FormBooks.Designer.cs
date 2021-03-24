
namespace BookStore
{
    partial class FormBooks
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
            this.Options = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.NewBook = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.FormattingEnabled = true;
            this.Options.Location = new System.Drawing.Point(143, 56);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(372, 24);
            this.Options.TabIndex = 0;
            this.Options.Text = "Edit an Existing Book";
            this.Options.SelectedIndexChanged += new System.EventHandler(this.Options_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price:";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(143, 133);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(476, 22);
            this.Title.TabIndex = 5;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(143, 189);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(381, 22);
            this.Author.TabIndex = 6;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(143, 260);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(381, 22);
            this.ISBN.TabIndex = 7;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(143, 334);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(291, 22);
            this.Price.TabIndex = 8;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(666, 56);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(102, 23);
            this.Back.TabIndex = 9;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // NewBook
            // 
            this.NewBook.Location = new System.Drawing.Point(666, 85);
            this.NewBook.Name = "NewBook";
            this.NewBook.Size = new System.Drawing.Size(102, 23);
            this.NewBook.TabIndex = 10;
            this.NewBook.Text = "New Book";
            this.NewBook.UseVisualStyleBackColor = true;
            this.NewBook.Click += new System.EventHandler(this.NewBook_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(666, 114);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(102, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(666, 143);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(102, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.NewBook);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Options);
            this.Name = "FormBooks";
            this.Text = "FormBooks";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Options;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button NewBook;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
    }
}