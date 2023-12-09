using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Alta 2 tane buton koyalım. Bu butonlar aracılığıyla
        // numeric updown’un değerlerini arttırıp azaltalım.
        // Fakat burada dikkat edilmesi gereken bir diğer nokta:
        // maximum ve minimum değerlere dikkat edilmesi lazım.
        // Aksi halde hata fıratır. Kısacası değer ataması yaparken
        // maximum değerin üstünde veya minimum değerin altında bir
        // değer atanmamalıdır

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown1.Value;
            resultLabel.Text = (value*2).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            decimal result = numericUpDown1.Value + numericUpDown1.Increment;
            numericUpDown1.Value = result > numericUpDown1.Maximum ? numericUpDown1.Maximum : result;
        }

        private void decrementButton_Click(object sender, EventArgs e)
        {
            decimal result = numericUpDown1.Value - numericUpDown1.Increment;
            numericUpDown1.Value = result < numericUpDown1.Minimum ? numericUpDown1.Minimum : result;
        }

        
    }
}
