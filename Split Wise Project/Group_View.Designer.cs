namespace Split_Wise_Project
{
    partial class Group_View
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
            PB_New_Gast = new PictureBox();
            PB_Back = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PB_New_Gast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_Back).BeginInit();
            SuspendLayout();
            // 
            // PB_New_Gast
            // 
            PB_New_Gast.Image = Properties.Resources.But_New_Gast;
            PB_New_Gast.Location = new Point(226, 12);
            PB_New_Gast.Name = "PB_New_Gast";
            PB_New_Gast.Size = new Size(65, 50);
            PB_New_Gast.SizeMode = PictureBoxSizeMode.Zoom;
            PB_New_Gast.TabIndex = 4;
            PB_New_Gast.TabStop = false;
            PB_New_Gast.Click += PB_New_Gast_Click;
            PB_New_Gast.MouseEnter += PB_New_Gast_MouseEnter;
            PB_New_Gast.MouseLeave += PB_New_Gast_MouseLeave;
            // 
            // PB_Back
            // 
            PB_Back.Image = Properties.Resources.But_Back;
            PB_Back.Location = new Point(12, 12);
            PB_Back.Name = "PB_Back";
            PB_Back.Size = new Size(65, 38);
            PB_Back.SizeMode = PictureBoxSizeMode.Zoom;
            PB_Back.TabIndex = 5;
            PB_Back.TabStop = false;
            PB_Back.Click += PB_Back_Click;
            PB_Back.MouseEnter += PB_Back_MouseEnter;
            PB_Back.MouseLeave += PB_Back_MouseLeave;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(83, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "Detalles de Grupo";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Group_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 269);
            Controls.Add(textBox1);
            Controls.Add(PB_Back);
            Controls.Add(PB_New_Gast);
            Name = "Group_View";
            Text = "Group_View";
            ((System.ComponentModel.ISupportInitialize)PB_New_Gast).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_Back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PB_New_Gast;
        private PictureBox PB_Back;
        private TextBox textBox1;
    }
}