﻿namespace TextBoxApplication
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
            textBox1=new TextBox();
            textBox2=new TextBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location=new Point(320, 95);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(150, 31);
            textBox1.TabIndex=0;
            textBox1.TextChanged+=textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(320, 159);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(150, 31);
            textBox2.TabIndex=1;
            textBox2.TextChanged+=textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(255, 98);
            label1.Name="label1";
            label1.Size=new Size(63, 25);
            label1.TabIndex=2;
            label1.Text="Name:";
            label1.Click+=label1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(232, 162);
            label2.Name="label2";
            label2.Size=new Size(86, 25);
            label2.TabIndex=3;
            label2.Text="Surname:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(353, 219);
            label3.Name="label3";
            label3.Size=new Size(0, 25);
            label3.TabIndex=4;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}