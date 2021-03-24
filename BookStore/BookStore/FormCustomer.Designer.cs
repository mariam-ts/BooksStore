
namespace BookStore
{
    partial class FormCustomer
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.NewCustomer = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.TextBox();
            this.Zip = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.FormattingEnabled = true;
            this.Options.Location = new System.Drawing.Point(94, 31);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(377, 24);
            this.Options.TabIndex = 0;
            this.Options.Text = "Edit An Existing Customer";
            this.Options.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(94, 83);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(195, 22);
            this.FirstName.TabIndex = 2;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(400, 86);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(184, 22);
            this.LastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(662, 31);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(130, 23);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // NewCustomer
            // 
            this.NewCustomer.Location = new System.Drawing.Point(662, 60);
            this.NewCustomer.Name = "NewCustomer";
            this.NewCustomer.Size = new System.Drawing.Size(130, 23);
            this.NewCustomer.TabIndex = 6;
            this.NewCustomer.Text = "New Customer";
            this.NewCustomer.UseVisualStyleBackColor = true;
            this.NewCustomer.Click += new System.EventHandler(this.NewCustomer_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(662, 89);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(130, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(662, 118);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Zip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(94, 153);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(377, 22);
            this.City.TabIndex = 15;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(94, 218);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(195, 22);
            this.Address.TabIndex = 16;
            // 
            // State
            // 
            this.State.Location = new System.Drawing.Point(369, 218);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(155, 22);
            this.State.TabIndex = 17;
            // 
            // Zip
            // 
            this.Zip.Location = new System.Drawing.Point(595, 218);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(100, 22);
            this.Zip.TabIndex = 18;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(94, 285);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(195, 22);
            this.Phone.TabIndex = 19;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(94, 360);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(195, 22);
            this.Email.TabIndex = 20;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.State);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.NewCustomer);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Options);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Options;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button NewCustomer;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.TextBox Zip;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Email;
    }
}