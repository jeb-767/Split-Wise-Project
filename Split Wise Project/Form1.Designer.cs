namespace Split_Wise_Project
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
            panel1 = new Panel();
            But_Hist = new PictureBox();
            But_Groups = new PictureBox();
            But_Friends = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)But_Hist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)But_Groups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)But_Friends).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 397);
            panel1.TabIndex = 3;
            // 
            // But_Hist
            // 
            But_Hist.Image = Properties.Resources.But_Hist1;
            But_Hist.Location = new Point(223, 415);
            But_Hist.Name = "But_Hist";
            But_Hist.Size = new Size(98, 23);
            But_Hist.SizeMode = PictureBoxSizeMode.Zoom;
            But_Hist.TabIndex = 6;
            But_Hist.TabStop = false;
            // 
            // But_Groups
            // 
            But_Groups.Image = Properties.Resources.But_Groups;
            But_Groups.Location = new Point(12, 415);
            But_Groups.Name = "But_Groups";
            But_Groups.Size = new Size(98, 23);
            But_Groups.SizeMode = PictureBoxSizeMode.Zoom;
            But_Groups.TabIndex = 7;
            But_Groups.TabStop = false;
            // 
            // But_Friends
            // 
            But_Friends.Image = Properties.Resources.But_Friends;
            But_Friends.Location = new Point(119, 415);
            But_Friends.Name = "But_Friends";
            But_Friends.Size = new Size(98, 23);
            But_Friends.SizeMode = PictureBoxSizeMode.Zoom;
            But_Friends.TabIndex = 8;
            But_Friends.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 397);
            panel2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 450);
            Controls.Add(panel2);
            Controls.Add(But_Friends);
            Controls.Add(But_Groups);
            Controls.Add(But_Hist);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)But_Hist).EndInit();
            ((System.ComponentModel.ISupportInitialize)But_Groups).EndInit();
            ((System.ComponentModel.ISupportInitialize)But_Friends).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox But_Friends;
        private Panel panel2;
        private PictureBox But_Hist;
        private PictureBox But_Groups;
        private PictureBox But_Friends;
    }
}
