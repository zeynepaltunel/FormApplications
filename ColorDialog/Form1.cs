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
            DialogResult result = colorDialog1.ShowDialog(this); //rengin se�ilip se�ilmedi�ini kontrol ediyoruz.
            if (result == DialogResult.OK) //OK butonuna bas�ld� m�?
            {
                BackColor = colorDialog1.Color;
            }
        }
    }
}