namespace ProcessClass
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
            searchButton=new Button();
            searchBox=new TextBox();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location=new Point(164, 169);
            searchButton.Name="searchButton";
            searchButton.Size=new Size(112, 34);
            searchButton.TabIndex=0;
            searchButton.Text="Search";
            searchButton.UseVisualStyleBackColor=true;
            searchButton.Click+=searchButton_Click;
            // 
            // searchBox
            // 
            searchBox.Location=new Point(291, 172);
            searchBox.Name="searchBox";
            searchBox.Size=new Size(344, 31);
            searchBox.TabIndex=1;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(searchBox);
            Controls.Add(searchButton);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private TextBox searchBox;
    }
}