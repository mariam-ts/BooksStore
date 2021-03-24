using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;

namespace BookStore
{
    public partial class FormCustomer : Form
    {
        DataTable DT;
        int id;
        public FormCustomer()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadDataInCombo();
            DisableFields();
        }
        private void DisableFields()
        {
            FirstName.Enabled = false;
            LastName.Enabled = false;
            City.Enabled = false;
            Address.Enabled = false;
            Zip.Enabled = false;
            Phone.Enabled = false;
            State.Enabled = false;
            Email.Enabled = false;
        }
        private void EnableFileds()
        {
            FirstName.Enabled = true;
            LastName.Enabled = true;
            City.Enabled = true;
            Address.Enabled = true;
            Zip.Enabled = true;
            Phone.Enabled = true;
            State.Enabled = true;
            Email.Enabled = true;
        }
        private void ClearFields()
        {
            FirstName.Text = "";
            LastName.Text = "";
            City.Text = "";
            Address.Text = "";
            Zip.Text = "";
            Phone.Text = "";
            State.Text = "";
            Email.Text = "";
        }
        private void LoadDataInCombo()
        {
            services service = new services();
            DT = service.getTable("Customers");
            foreach (DataRow row in DT.Rows)
            {
                Options.Items.Add(row["FirstName"].ToString()+ " "+row["LastName"].ToString());
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Hide();
            m.Show();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = Options.SelectedIndex + 1;
            foreach (DataRow row in DT.Rows)
            {
                if (row["Id"].ToString() == id.ToString())
                {
                    FirstName.Text = row["FirstName"].ToString();
                    LastName.Text = row["LastName"].ToString();
                    City.Text = row["City"].ToString();
                    Address.Text = row["Address"].ToString();
                    Zip.Text = row["Zip"].ToString();
                    Phone.Text = row["Phone"].ToString();
                    State.Text = row["State"].ToString();
                    Email.Text = row["Email"].ToString();
                }
            }
            EnableFileds();
        }
        private void NewCustomer_Click(object sender, EventArgs e)
        {
            Options.Enabled = false;
            ClearFields();
            EnableFileds();
            FirstName.Focus();
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(FirstName.Text, "[a-zA-Z]{1,}"))
            {
                MessageBox.Show("Please enter proper First Name", "Warning");
                FirstName.Focus();
            }
            else if (!Regex.IsMatch(LastName.Text, "[a-zA-Z]{1,}"))
            {
                MessageBox.Show("Please enter proper Last Name", "Warning");
                LastName.Focus();
            }
            else if (!Regex.IsMatch(City.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$"))
            {
                MessageBox.Show("Please enter proper City", "Warning");
                City.Focus();
            }
            else if (!Regex.IsMatch(Address.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$"))
            {
                MessageBox.Show("Please enter proper Address", "Warning");
                Address.Focus();
            }
            else if (!Regex.IsMatch(State.Text, @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$"))
            {
                MessageBox.Show("Please enter proper State", "Warning");
                State.Focus();
            }
            else if (!Regex.IsMatch(Zip.Text, @"^\d{5}(?:[-\s]\d{4})?$"))
            {
                MessageBox.Show("Please enter proper Zip code", "Warning");
                Zip.Focus();
            }
            else if (!Regex.IsMatch(Phone.Text, "[+(995)0-9]{10}"))
            {
                MessageBox.Show("Please enter proper Phone Number (pattern : +995 *** ***)", "Warning");
                Phone.Focus();
            }
            else if (!Regex.IsMatch(Email.Text, "^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$"))
            {
                MessageBox.Show("Please enter proper Email Address", "Warning");
                Email.Focus();
            }
            else{
                string[] data = new string[8];
                data[0] = FirstName.Text;
                data[1] = LastName.Text;
                data[2] = Address.Text;
                data[3] = City.Text;
                data[4] = State.Text;
                data[5] = Zip.Text;
                data[6] = Phone.Text;
                data[7] = Email.Text;
                services s = new services();

                if (Options.Enabled)
                {
                    var result = MessageBox.Show("Do you want to update information?", "Warning",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        s.updateCustomers(data, id);
                        MessageBox.Show("You've updated information successfully");
                    }

                }
                else
                {
                    var result = MessageBox.Show("Do you want to insert information?", "Warning",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        s.insertCustomers(data);
                        Options.Enabled = true;
                        MessageBox.Show("You've inserted information successfully");
                    }

                }
                Options.Items.Clear();
                LoadDataInCombo();

            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to clear fields?", "Warning",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ClearFields();
            }

        }
    }
}
