using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_deliverable_4
{
    public partial class CreateAccount : Form
    {
        private Database db = new Database();
        public CreateAccount()
        {
            InitializeComponent();
            InitializeUI();
        }


        private void InitializeUI()
        {
            textBox5.PasswordChar = '*';
            textBox1.Text = "First Name";
            textBox2.Text = "Last Name";
            textBox3.Text = "Email";
            textBox4.Text = "Username";
            textBox5.Text = "Password";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string new_username = textBox4.Text;
            string new_password = textBox5.Text;
            bool invalid_credentials = db.CheckValidAccount(username: new_username, password: new_password);
            if (invalid_credentials) { MessageBox.Show("Invalid Credentials: The account already exists."); return; }
            db.CreateNewAccount(username:new_username, password:new_password);
            MessageBox.Show("Account successfully created!");
            this.Close();
        }
    }
}
