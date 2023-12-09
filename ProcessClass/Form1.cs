using System.Diagnostics;
namespace ProcessClass
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "www.google.com/search?q=" + searchBox.Text);
        }
    }
}