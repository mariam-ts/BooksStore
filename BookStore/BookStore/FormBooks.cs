using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class FormBooks : Form
    {
        DataTable DT;
        int id;
        public FormBooks()
        {
            InitializeComponent();
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LoadDataInCombo();
            DisableFields();
        }
        private void DisableFields()
        {
            Title.Enabled = false;
            Author.Enabled = false;
            ISBN.Enabled = false;
            Price.Enabled = false;
        }
        private void EnableFileds()
        {
            Title.Enabled = true;
            Author.Enabled = true;
            ISBN.Enabled = true;
            Price.Enabled = true;
        }
        private void ClearFields()
        {
            Title.Text = "";
            Author.Text = "";
            ISBN.Text = "";
            Price.Text = null;
        }
        private void LoadDataInCombo()
        {
            services service = new services();
            DT = service.getTable("Books");
            foreach (DataRow row in DT.Rows)
            {
                Options.Items.Add(row["Title"].ToString());
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Hide();
            m.Show();
        }

        private void Options_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = Options.SelectedIndex+1;
            foreach (DataRow row in DT.Rows)
            {
                if(row["Id"].ToString() == id.ToString())
                {
                    Title.Text = row["Title"].ToString();
                    Author.Text = row["Author"].ToString();
                    ISBN.Text = row["ISBN"].ToString();
                    Price.Text = row["Price"].ToString();
                }
            }
            EnableFileds();
        }

        private void NewBook_Click(object sender, EventArgs e)
        {
            Options.Enabled = false;
            ClearFields();
            EnableFileds();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string[] data = new string[4];
            data[0] = Title.Text;
            data[1] = Author.Text;
            data[2] = ISBN.Text;
            data[3] = Price.Text;
            services s = new services();

            if (Options.Enabled)
            {
                var result = MessageBox.Show("Do you want to update information?", "Warning",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    s.updateBooks(data, id);
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
                    s.insertBooks(data);
                    Options.Enabled = true;
                    MessageBox.Show("You've inserted information successfully");
                }
               
            }
            Options.Items.Clear();
            LoadDataInCombo();
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
