namespace ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog(this); //rengin seçilip seçilmediðini kontrol ediyoruz.
            if (result == DialogResult.OK) //OK butonuna basýldý mý?
            {
                BackColor = colorDialog1.Color;
            }
        }
    }
}