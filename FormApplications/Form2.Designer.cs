﻿namespace TextBoxApplication
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
            label1=new Label();
            textBox1=new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(260, 162);
            label1.Name="label1";
            label1.Size=new Size(63, 25);
            label1.TabIndex=0;
            label1.Text="Name:";
            label1.Click+=label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location=new Point(325, 162);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(150, 31);
            textBox1.TabIndex=1;
            textBox1.TextChanged+=textBox1_TextChanged;
            textBox1.KeyPress+=textBox1_KeyPress;
            // 
            // Form2
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name="Form2";
            Text="Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
    }
}