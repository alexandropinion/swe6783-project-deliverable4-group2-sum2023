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
    public partial class Login : Form
    {
        private Database db = new();
        public Login()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool acc_created = db.CheckValidAccount(username: textBox1.Text, password: textBox2.Text);
            if (acc_created)
            {

                HomePageForm homepage = new HomePageForm();
                homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(text: "Incorrect account credentials.\nPlease try again.", caption: "Login Error");
            }
        }

        private void InitializeUI()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
            string btn_fp = "C:\\Users\\snipe\\OneDrive\\Documents\\GitHub\\swe6783-project-deliverable4-group2-sum2023\\project-deliverable-4\\imgs\\create-acc-ico.ico";
            button2.Image = Image.FromFile(btn_fp);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.TextAlign = ContentAlignment.MiddleCenter;
        }



        private bool CheckLogin(string username, string pwd)
        {

            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccount acc_create = new CreateAccount();
            acc_create.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void Login_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
