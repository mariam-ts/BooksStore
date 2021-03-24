using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookStore
{
    public partial class PlaceOrder : Form
    {
        private int Quantity;
        private double subtotal = 0;
        private double tax = 0;
        private double total = 0;
        private double price = 0;

        int CustomerId;
        int BookId;
        DataTable BooksDT;
        DataTable CustomersDT;
        Double lineTotal;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LoadDataInBookCombo();
            DisableFields();
        }
        private void DisableFields()
        {
            Author.Enabled = false;
            ISBN.Enabled = false;
            Price.Enabled = false;
        }
        private void LoadDataInBookCombo()
        {
            services service = new services();
            BooksDT = service.getTable("Books");
            foreach (DataRow row in BooksDT.Rows)
            {
                BookOptions.Items.Add(row["Title"].ToString());
            }
        }
        private void LoadDataInCustomCombo()
        {
            services service = new services();
            CustomersDT = service.getTable("Customers");
            foreach (DataRow row in CustomersDT.Rows)
            {
                BookOptions.Items.Add(row["FirstName"].ToString()+ " "+ row["LasttName"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(BookOptions.SelectedItem == null)
            {
                MessageBox.Show("Please select the book before add it in the cart", "Warning");
                BookOptions.Focus();

            }
            else if(int.TryParse(quantity.Text, out int n) == false)
            {
                MessageBox.Show("Quantity should be numeric", "Warning");
                quantity.Focus();
            }
            else if (quantity.Text == null)
            {
                MessageBox.Show("Please, write quantity");
                quantity.Focus();
            }
            else if (int.TryParse(quantity.Text, out int m) && m<=0)
            {
                MessageBox.Show("Quantity should be more than zero", "Warning");
                quantity.Focus();
            }
            else
            {
                int.TryParse(quantity.Text, out int k);
                this.Quantity = k;
                int.TryParse(Price.Text, out int p);
                this.price = p;
                lineTotal = this.Quantity * this.price;

                string[] row = new string[] { BookOptions.SelectedItem.ToString(), Price.ToString(), this.Quantity.ToString(), lineTotal.ToString() };
                ChoosenBooks.Rows.Add(row);
                this.subtotal += lineTotal;
                this.tax += 0.1 * lineTotal;
                this.total = this.subtotal + this.tax;
                Subtotal.Text = this.subtotal.ToString();
                Tax.Text = this.tax.ToString();
                Total.Text = this.total.ToString();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if((Author.Text == null))
            {
                MessageBox.Show("Please select the book before confirm order", "Warning");
                BookOptions.Focus();
            }
            else if(!(this.Quantity > 0))
            {
                MessageBox.Show("Please, add title");
                AddTitle.Focus();
                
            }
            else
            {
                services service = new services();
                string[] OrderRow = new string[3];
                OrderRow[0] = BookId.ToString();
                OrderRow[1] = this.Quantity.ToString();
                OrderRow[2] = lineTotal.ToString();
                service.InsertOrderDetails(OrderRow);

                string[] row = new string[6];
                row[0] = CustomerId.ToString();
                row[1] = subtotal.ToString();
                row[2] = tax.ToString();
                row[3] = total.ToString();
                service.InsertOrders(row);
               
            }
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel order?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ChoosenBooks.Rows.Clear();
                Subtotal.Text= null;
                Tax.Text = null;
                Total.Text = null;
                Author.Text = null;
                ISBN.Text = null;
                Price.Text = null;
                quantity.Text = null;
                BookOptions.Text = null;


                this.Quantity = 0;
                this.subtotal = 0;
                this.tax = 0;
                this.total = 0;


     }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomersForm_Click(object sender, EventArgs e)
        {
            FormCustomer fc = new FormCustomer();
            this.Hide();
            fc.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Hide();
            m.ShowDialog();
        }

        private void CustomerOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerId = CustomerOptions.SelectedIndex + 1;
        }

        private void BookOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookId = BookOptions.SelectedIndex + 1;
            foreach (DataRow row in BooksDT.Rows)
            {
                if (row["Id"].ToString() == BookId.ToString())
                {
                    Author.Text = row["Author"].ToString();
                    ISBN.Text = row["ISBN"].ToString();
                    Price.Text = row["Price"].ToString();
                }
            }
        }
    }

}
