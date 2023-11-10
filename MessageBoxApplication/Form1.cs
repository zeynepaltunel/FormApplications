using System.Diagnostics;

namespace MessageBoxApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void clickButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome!!!", "Visual Programming", MessageBoxButtons.OKCancel);

            if (DialogResult == DialogResult.OK)
            {
                Debug.Print("You clicked OK");
            }
            else
            {
                Debug.Print("You clicked Cancel");
            }
        }

        private void testButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!", "Test2", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A","B",MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button2);
        }
    }
}
