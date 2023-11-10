namespace FontDialog
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
            changeFontButton=new Button();
            fontDialog1=new System.Windows.Forms.FontDialog();
            fontLbl=new Label();
            SuspendLayout();
            // 
            // changeFontButton
            // 
            changeFontButton.Location=new Point(308, 135);
            changeFontButton.Name="changeFontButton";
            changeFontButton.Size=new Size(142, 47);
            changeFontButton.TabIndex=0;
            changeFontButton.Text="Change Font";
            changeFontButton.UseVisualStyleBackColor=true;
            changeFontButton.Click+=changeFontButton_Click;
            // 
            // fontLbl
            // 
            fontLbl.AutoSize=true;
            fontLbl.Location=new Point(308, 213);
            fontLbl.Name="fontLbl";
            fontLbl.Size=new Size(145, 25);
            fontLbl.TabIndex=1;
            fontLbl.Text="Zeynep ALTUNEL";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(fontLbl);
            Controls.Add(changeFontButton);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button changeFontButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private Label fontLbl;
    }
}