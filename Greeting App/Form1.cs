namespace Greeting_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string city = txtCity.Text.Trim();

            if (string.IsNullOrEmpty(city))
            {
                lblResult.Text = $"Hello, " + (name) + "! Welcome to Windows Forms.";
                
            }

            else
            {
                lblResult.Text = $"Hello, " + (name) + "! From " + (city);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            lblResult.Text = "";
            txtName.Focus();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnGreet.Enabled = txtName.Text.Trim().Length > 0;

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
