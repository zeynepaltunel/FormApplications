namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Çalýþmaya baþladýðý tarihi seçen kullanýcýnýn bugüne kadarki gün sayýsýný
        //hesaplayarak “x gündür çalýþýyorsun” gibi bir mesaj verdirelim.
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            int dayCount = (DateTime.Now - startDate).Days;
            resultLbl.Text = "You have been working " + dayCount + " days";
        }
    }
}