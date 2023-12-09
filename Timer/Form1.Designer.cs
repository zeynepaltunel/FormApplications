namespace Timer
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
            components=new System.ComponentModel.Container();
            counterLabel=new Label();
            timer1=new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // counterLabel
            // 
            counterLabel.AutoSize=true;
            counterLabel.Location=new Point(87, 67);
            counterLabel.Name="counterLabel";
            counterLabel.Size=new Size(84, 25);
            counterLabel.TabIndex=0;
            counterLabel.Text="Counter: ";
            // 
            // timer1
            // 
            timer1.Interval=1000;
            timer1.Tick+=timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(counterLabel);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label counterLabel;
        private System.Windows.Forms.Timer timer1;
    }
}