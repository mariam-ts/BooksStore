
namespace BookStore
{
    partial class Menu
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
            this.FormCustomer = new System.Windows.Forms.Button();
            this.FormBooks = new System.Windows.Forms.Button();
            this.PlaceOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormCustomer
            // 
            this.FormCustomer.Location = new System.Drawing.Point(131, 135);
            this.FormCustomer.Name = "FormCustomer";
            this.FormCustomer.Size = new System.Drawing.Size(147, 36);
            this.FormCustomer.TabIndex = 0;
            this.FormCustomer.Text = "Manage Customers";
            this.FormCustomer.UseVisualStyleBackColor = true;
            this.FormCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBooks
            // 
            this.FormBooks.Location = new System.Drawing.Point(131, 203);
            this.FormBooks.Name = "FormBooks";
            this.FormBooks.Size = new System.Drawing.Size(147, 36);
            this.FormBooks.TabIndex = 1;
            this.FormBooks.Text = "Manage Books";
            this.FormBooks.UseVisualStyleBackColor = true;
            this.FormBooks.Click += new System.EventHandler(this.FormBooks_Click);
            // 
            // PlaceOrder
            // 
            this.PlaceOrder.Location = new System.Drawing.Point(131, 272);
            this.PlaceOrder.Name = "PlaceOrder";
            this.PlaceOrder.Size = new System.Drawing.Size(147, 37);
            this.PlaceOrder.TabIndex = 2;
            this.PlaceOrder.Text = "Place Order";
            this.PlaceOrder.UseVisualStyleBackColor = true;
            this.PlaceOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select the option: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlaceOrder);
            this.Controls.Add(this.FormBooks);
            this.Controls.Add(this.FormCustomer);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FormCustomer;
        private System.Windows.Forms.Button FormBooks;
        private System.Windows.Forms.Button PlaceOrder;
        private System.Windows.Forms.Label label1;
    }
}