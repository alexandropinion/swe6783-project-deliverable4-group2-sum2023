namespace project_deliverable_4
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
            SetupButtons();
        }

        private void SetupButtons()
        {
            try
            {
                SetBtnIcon(btn: button1, btn_fp: "C:\\Users\\snipe\\OneDrive\\Documents\\GitHub\\swe6783-project-deliverable4-group2-sum2023\\project-deliverable-4\\imgs\\home-ico.ico");
                SetBtnIcon(btn: button2, btn_fp: "C:\\Users\\snipe\\OneDrive\\Documents\\GitHub\\swe6783-project-deliverable4-group2-sum2023\\project-deliverable-4\\imgs\\calendar-ico.ico");
                SetBtnIcon(btn: button3, btn_fp: "C:\\Users\\snipe\\OneDrive\\Documents\\GitHub\\swe6783-project-deliverable4-group2-sum2023\\project-deliverable-4\\imgs\\mail-ico.ico");
                SetBtnIcon(btn: button4, btn_fp: "C:\\Users\\snipe\\OneDrive\\Documents\\GitHub\\swe6783-project-deliverable4-group2-sum2023\\project-deliverable-4\\imgs\\files-ico.ico");
                SetBtnIcon(btn: button5, btn_fp: "C:\\Users\\snipe\\OneDrive\\Documents\\GitHub\\swe6783-project-deliverable4-group2-sum2023\\project-deliverable-4\\imgs\\video-ico.ico");
                SetBtnIcon(btn: button6, btn_fp: "C:\\Users\\snipe\\OneDrive\\Documents\\GitHub\\swe6783-project-deliverable4-group2-sum2023\\project-deliverable-4\\imgs\\question-ico.ico");
                SetBtnIcon(btn: button7, btn_fp: "C:\\Users\\snipe\\OneDrive\\Documents\\GitHub\\swe6783-project-deliverable4-group2-sum2023\\project-deliverable-4\\imgs\\logout-ico.ico");

                SetBtnIcon(btn: button14, btn_fp: "C:\\Users\\snipe\\OneDrive\\Documents\\GitHub\\swe6783-project-deliverable4-group2-sum2023\\project-deliverable-4\\imgs\\gears-ico2.ico");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("File was not discovered - ensure all image files are in the proper image directory: Exception = " + ex.ToString());
            }

        }

        private void SetBtnIcon(Button btn, string btn_fp)
        {
            btn.Image = Image.FromFile(btn_fp);
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalendarForm calendar = new();
            calendar.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            MailForm mail = new();
            mail.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Live live = new();
            live.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to logout of your virtual classroom?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void HomePageForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e) // Econ button
        {
            Live live = new();
            live.Show();
        }

        private void button9_Click(object sender, EventArgs e) // History button
        {
            Live live = new();
            live.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Live live = new();
            live.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Live live = new();
            live.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Live live = new();
            live.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Live live = new();
            live.Show();
        }
    }
}