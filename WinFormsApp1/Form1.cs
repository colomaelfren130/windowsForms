namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, Window Forms!");
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye, See you Next Time!");
        }
    }
}
