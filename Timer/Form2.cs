using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        int counter = 0;
        int width = 550;
        int height = 350;
        private void timer1_Tick(object sender, EventArgs e)
        {
            width+=10;
            height+=10;
            counter++;
            Form2 form = new Form2();
            form.Size = new Size(width,height);

            if(counter == 10)
            {
                timer1.Stop();
            }

        }

        
    }
}
