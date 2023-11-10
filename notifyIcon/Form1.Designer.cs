namespace notifyIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyButton=new Button();
            notifyIcon=new NotifyIcon(components);
            SuspendLayout();
            // 
            // notifyButton
            // 
            notifyButton.Location=new Point(294, 121);
            notifyButton.Name="notifyButton";
            notifyButton.Size=new Size(167, 77);
            notifyButton.TabIndex=0;
            notifyButton.Text="Show Notification";
            notifyButton.UseVisualStyleBackColor=true;
            notifyButton.Click+=notifyButton_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon=(Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text="notifyIcon1";
            notifyIcon.Visible=true;
            notifyIcon.MouseDoubleClick+=notifyIcon1_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(notifyButton);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button notifyButton;
        private NotifyIcon notifyIcon;
    }
}