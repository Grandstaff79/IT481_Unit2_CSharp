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
        private Controller controller;
        private string user;
        private string password;
        private string server;
        private string database;
        private long num1;

        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "DESKTOP-PPM7QKS";
            textBox4.Text = "Northwind";
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
            button7.Click += new EventHandler(button7_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            user = textBox1.Text;
            password = textBox2.Text;
            server = textBox3.Text;
            database = textBox4.Text;





            if (user.Length == 0 || password.Length == 0 ||
                server.Length == 0 || database.Length == 0)


            {
                isValid = false;
                MessageBox.Show("You must enter username, password, server, and database values");

            }
            else if (password.Length < 6)
            {

                isValid = false;
                MessageBox.Show("Password leangth must be 6 characters or more");
            }
            else
            {
                if(!long.TryParse(password, out num1))
                {
                    isValid = false;
                    MessageBox.Show("You must enter numbers for the password");

                }
            }

            
            if (isValid)
            {
                controller = new Controller("Server = " + server + "\\SQLEXPRESS;" +
                                        "Database = " + database + ";" +
                                        "User Id = " + user + ";" +
                                        "Password = " + password + ";"
                                        );

                MessageBox.Show("Connection information sent");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = controller.getCustomerCount();
            MessageBox.Show(count, "Customer count");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = controller.getCompanyNames();
            MessageBox.Show(names, "Company names");

        }
        private void button4_Click(object sender, EventArgs e)
        {
            string count = controller.getEmployeeCount();
            MessageBox.Show(count, "Employee count");

        }
        private void button5_Click(object sender, EventArgs e)
        {
            string names = controller.getEmployeeNames();
            MessageBox.Show(names, "Employee names");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string count = controller.getOrderCount();
            MessageBox.Show(count, "Order count");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string names = controller.getShipNames();
            MessageBox.Show(names, "Order ship names");
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }
