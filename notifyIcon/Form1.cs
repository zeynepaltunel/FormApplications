namespace notifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyButton_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;   
            notifyIcon.ShowBalloonTip(3000, "Warning!", "Don't click button", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}