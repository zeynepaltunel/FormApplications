namespace NumericUpDown
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1=new System.Windows.Forms.NumericUpDown();
            decrementButton=new Button();
            incrementButton=new Button();
            resultLabel=new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location=new Point(308, 126);
            numericUpDown1.Name="numericUpDown1";
            numericUpDown1.Size=new Size(180, 31);
            numericUpDown1.TabIndex=0;
            numericUpDown1.ValueChanged+=numericUpDown1_ValueChanged;
            // 
            // decrementButton
            // 
            decrementButton.BackColor=Color.DarkGoldenrod;
            decrementButton.Location=new Point(268, 180);
            decrementButton.Name="decrementButton";
            decrementButton.Size=new Size(112, 34);
            decrementButton.TabIndex=1;
            decrementButton.Text="Decrement";
            decrementButton.UseVisualStyleBackColor=false;
            decrementButton.Click+=decrementButton_Click;
            // 
            // incrementButton
            // 
            incrementButton.BackColor=Color.DarkKhaki;
            incrementButton.Location=new Point(417, 180);
            incrementButton.Name="incrementButton";
            incrementButton.Size=new Size(112, 34);
            incrementButton.TabIndex=2;
            incrementButton.Text="Increment";
            incrementButton.UseVisualStyleBackColor=false;
            incrementButton.Click+=incrementButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize=true;
            resultLabel.Location=new Point(385, 248);
            resultLabel.Name="resultLabel";
            resultLabel.Size=new Size(33, 25);
            resultLabel.TabIndex=3;
            resultLabel.Text="---";
            resultLabel.Click+=label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.DarkCyan;
            ClientSize=new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(incrementButton);
            Controls.Add(decrementButton);
            Controls.Add(numericUpDown1);
            Name="Form2";
            Text="Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Button decrementButton;
        private Button incrementButton;
        private Label resultLabel;
    }
}