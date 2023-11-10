namespace TextBoxApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void mergeName()
        {
            label3.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mergeName();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            mergeName();
        }
    }
}