namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //�al��maya ba�lad��� tarihi se�en kullan�c�n�n bug�ne kadarki g�n say�s�n�
        //hesaplayarak �x g�nd�r �al���yorsun� gibi bir mesaj verdirelim.
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            int dayCount = (DateTime.Now - startDate).Days;
            resultLbl.Text = "You have been working " + dayCount + " days";
        }
    }
}