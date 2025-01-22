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
            // Form_Friends
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 314);
            Controls.Add(PB_New_Friend);
            Name = "Form_Friends";
            Text = "Form_Friends";
            ((System.ComponentModel.ISupportInitialize)PB_New_Friend).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PB_New_Friend;
    }
}