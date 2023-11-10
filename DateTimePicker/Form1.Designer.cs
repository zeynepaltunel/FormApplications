namespace DateTimePicker
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
            dateTimePicker1=new System.Windows.Forms.DateTimePicker();
            dateLbl=new Label();
            resultLbl=new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location=new Point(302, 59);
            dateTimePicker1.Name="dateTimePicker1";
            dateTimePicker1.Size=new Size(300, 31);
            dateTimePicker1.TabIndex=0;
            dateTimePicker1.ValueChanged+=dateTimePicker1_ValueChanged;
            // 
            // dateLbl
            // 
            dateLbl.AutoSize=true;
            dateLbl.Location=new Point(178, 64);
            dateLbl.Name="dateLbl";
            dateLbl.Size=new Size(90, 25);
            dateLbl.TabIndex=1;
            dateLbl.Text="Start Date";
            // 
            // resultLbl
            // 
            resultLbl.AutoSize=true;
            resultLbl.Location=new Point(302, 116);
            resultLbl.Name="resultLbl";
            resultLbl.Size=new Size(24, 25);
            resultLbl.TabIndex=2;
            resultLbl.Text="...";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(resultLbl);
            Controls.Add(dateLbl);
            Controls.Add(dateTimePicker1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Label dateLbl;
        private Label resultLbl;
    }
}