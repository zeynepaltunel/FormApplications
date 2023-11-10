namespace ColorDialog
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
            colorButton=new Button();
            colorDialog1=new System.Windows.Forms.ColorDialog();
            SuspendLayout();
            // 
            // colorButton
            // 
            colorButton.Location=new Point(282, 132);
            colorButton.Name="colorButton";
            colorButton.Size=new Size(181, 67);
            colorButton.TabIndex=0;
            colorButton.Text="Select Color";
            colorButton.UseVisualStyleBackColor=true;
            colorButton.Click+=colorButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(colorButton);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}