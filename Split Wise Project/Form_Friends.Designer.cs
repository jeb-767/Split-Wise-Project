namespace Split_Wise_Project
{
    partial class Form_Friends
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
            PB_New_Friend = new PictureBox();
            List_View_Friends = new ListView();
            Panel_Friends = new Panel();
            ((System.ComponentModel.ISupportInitialize)PB_New_Friend).BeginInit();
            SuspendLayout();
            // 
            // PB_New_Friend
            // 
            PB_New_Friend.Image = Properties.Resources.But_New_Friend;
            PB_New_Friend.Location = new Point(255, 265);
            PB_New_Friend.Name = "PB_New_Friend";
            PB_New_Friend.Size = new Size(65, 50);
            PB_New_Friend.SizeMode = PictureBoxSizeMode.Zoom;
            PB_New_Friend.TabIndex = 1;
            PB_New_Friend.TabStop = false;
            PB_New_Friend.Click += pictureBox1_Click;
            PB_New_Friend.MouseEnter += pictureBox1_MouseEnter;
            PB_New_Friend.MouseLeave += PB_New_Friend_MouseLeave;
            // 
            // List_View_Friends
            // 
            List_View_Friends.Location = new Point(2, 5);
            List_View_Friends.Name = "List_View_Friends";
            List_View_Friends.Size = new Size(318, 254);
            List_View_Friends.TabIndex = 2;
            List_View_Friends.UseCompatibleStateImageBehavior = false;
            // 
            // Panel_Friends
            // 
            Panel_Friends.Location = new Point(2, 5);
            Panel_Friends.Name = "Panel_Friends";
            Panel_Friends.Size = new Size(318, 310);
            Panel_Friends.TabIndex = 3;
            // 
            // Form_Friends
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 314);
            Controls.Add(List_View_Friends);
            Controls.Add(PB_New_Friend);
            Controls.Add(Panel_Friends);
            Name = "Form_Friends";
            ((System.ComponentModel.ISupportInitialize)PB_New_Friend).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PB_New_Friend;
        private ListView List_View_Friends;
        private Panel Panel_Friends;
    }
}