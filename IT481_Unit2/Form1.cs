using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT481_Unit2
{
    public partial class Form1 : Form
    {

        DB database;
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new DB("Server = DESKTOP-PPM7QKS\\SQLEXPRESS; " +
                                        "Trusted_Connection=true;" +
                                        "Database=northwind;" +
                                        "Connection timeout=30");

            MessageBox.Show("Connection information sent");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer count");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCompanyNames();
            MessageBox.Show(names, "Company names");

        }
    }
}
