namespace FontDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeFontButton_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                changeFontButton.Font = fontDialog1.Font;
                fontLbl.Font = fontDialog1.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}