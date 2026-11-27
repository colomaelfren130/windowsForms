namespace FormBasics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Do you really want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            lblWelcome.Text = "Welcome! Today is " + DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void btnLightMode_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }
    }
}
