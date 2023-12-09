namespace NumericUpDown
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1=new System.Windows.Forms.NumericUpDown();
            resultLbl=new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location=new Point(173, 115);
            numericUpDown1.Name="numericUpDown1";
            numericUpDown1.Size=new Size(180, 31);
            numericUpDown1.TabIndex=0;
            numericUpDown1.ValueChanged+=numericUpDown1_ValueChanged;
            // 
            // resultLbl
            // 
            resultLbl.AutoSize=true;
            resultLbl.Location=new Point(404, 117);
            resultLbl.Name="resultLbl";
            resultLbl.Size=new Size(24, 25);
            resultLbl.TabIndex=1;
            resultLbl.Text="...";
            resultLbl.Click+=label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ButtonFace;
            ClientSize=new Size(800, 450);
            Controls.Add(resultLbl);
            Controls.Add(numericUpDown1);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Label resultLbl;
    }
}