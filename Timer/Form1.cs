namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            counterLabel.Text = "Counter : " + counter.ToString();
            if (counter == 11)
            {
                timer1.Stop();
                counterLabel.Text = "Time is up!";
            }
        }
        /*
          
         
         */
    }
}