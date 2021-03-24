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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCustomer fc = new FormCustomer();
            this.Hide();
            fc.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormBooks_Click(object sender, EventArgs e)
        {
            FormBooks fb = new FormBooks();
            this.Hide();
            fb.ShowDialog();
        }

        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            PlaceOrder po = new PlaceOrder();
            this.Hide();
            po.ShowDialog();
        }
    }
}
