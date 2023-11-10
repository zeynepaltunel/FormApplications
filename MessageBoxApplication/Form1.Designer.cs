namespace MessageBoxApplication
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
            clickButton=new Button();
            testButton=new Button();
            testButton2=new Button();
            defaultButton=new Button();
            SuspendLayout();
            // 
            // clickButton
            // 
            clickButton.Location=new Point(320, 95);
            clickButton.Name="clickButton";
            clickButton.Size=new Size(112, 34);
            clickButton.TabIndex=0;
            clickButton.Text="Click Me";
            clickButton.UseVisualStyleBackColor=true;
            clickButton.Click+=clickButton_Click;
            // 
            // testButton
            // 
            testButton.Location=new Point(320, 173);
            testButton.Name="testButton";
            testButton.Size=new Size(112, 34);
            testButton.TabIndex=1;
            testButton.Text="Test";
            testButton.UseVisualStyleBackColor=true;
            testButton.Click+=testButton_Click;
            // 
            // testButton2
            // 
            testButton2.Location=new Point(320, 245);
            testButton2.Name="testButton2";
            testButton2.Size=new Size(112, 34);
            testButton2.TabIndex=2;
            testButton2.Text="Test2";
            testButton2.UseVisualStyleBackColor=true;
            testButton2.Click+=testButton2_Click;
            // 
            // defaultButton
            // 
            defaultButton.Location=new Point(320, 35);
            defaultButton.Name="defaultButton";
            defaultButton.Size=new Size(112, 34);
            defaultButton.TabIndex=3;
            defaultButton.Text="Default";
            defaultButton.UseVisualStyleBackColor=true;
            defaultButton.Click+=defaultButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(defaultButton);
            Controls.Add(testButton2);
            Controls.Add(testButton);
            Controls.Add(clickButton);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button clickButton;
        private Button testButton;
        private Button testButton2;
        private Button defaultButton;
    }
}