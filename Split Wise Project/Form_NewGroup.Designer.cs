﻿namespace Split_Wise_Project
{
    partial class Form_NewGroup
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
            textBox4 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            TB_NewGroup_Description = new TextBox();
            PB_New_Icon = new PictureBox();
            TB_NewGroup_Name = new TextBox();
            textBox1 = new TextBox();
            PB_New_Member = new PictureBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PB_New_Icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_New_Member).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuBar;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Enabled = false;
            textBox4.Font = new Font("Broadway", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = SystemColors.MenuText;
            textBox4.Location = new Point(12, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(190, 19);
            textBox4.TabIndex = 21;
            textBox4.Text = "Miembros";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Font = new Font("Broadway", 14.25F, FontStyle.Bold);
            button2.Location = new Point(189, 278);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 20;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += But_Groups_Create_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Font = new Font("Broadway", 14.25F, FontStyle.Bold);
            button1.Location = new Point(12, 278);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 19;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += But_Groups_Cancel_Click;
            // 
            // TB_NewGroup_Description
            // 
            TB_NewGroup_Description.BackColor = SystemColors.MenuBar;
            TB_NewGroup_Description.Location = new Point(118, 76);
            TB_NewGroup_Description.Name = "TB_NewGroup_Description";
            TB_NewGroup_Description.Size = new Size(190, 23);
            TB_NewGroup_Description.TabIndex = 18;
            TB_NewGroup_Description.Text = "Descripción";
            // 
            // PB_New_Icon
            // 
            PB_New_Icon.Image = Properties.Resources.But_New_Photo;
            PB_New_Icon.Location = new Point(12, 47);
            PB_New_Icon.Name = "PB_New_Icon";
            PB_New_Icon.Size = new Size(100, 52);
            PB_New_Icon.SizeMode = PictureBoxSizeMode.Zoom;
            PB_New_Icon.TabIndex = 17;
            PB_New_Icon.TabStop = false;
            PB_New_Icon.Click += PB_New_Icon_Click;
            PB_New_Icon.MouseEnter += PB_New_Icon_MouseEnter;
            PB_New_Icon.MouseLeave += PB_New_Icon_MouseLeave;
            // 
            // TB_NewGroup_Name
            // 
            TB_NewGroup_Name.BackColor = SystemColors.MenuBar;
            TB_NewGroup_Name.Location = new Point(118, 47);
            TB_NewGroup_Name.Name = "TB_NewGroup_Name";
            TB_NewGroup_Name.Size = new Size(190, 23);
            TB_NewGroup_Name.TabIndex = 16;
            TB_NewGroup_Name.Text = "Nombre del Grupo";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Broadway", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.MenuText;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 22);
            textBox1.TabIndex = 15;
            textBox1.Text = "Crear Nuevo Grupo\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // PB_New_Member
            // 
            PB_New_Member.Image = Properties.Resources.But_New_Friend;
            PB_New_Member.Location = new Point(208, 105);
            PB_New_Member.Name = "PB_New_Member";
            PB_New_Member.Size = new Size(100, 52);
            PB_New_Member.SizeMode = PictureBoxSizeMode.Zoom;
            PB_New_Member.TabIndex = 22;
            PB_New_Member.TabStop = false;
            PB_New_Member.Click += PB_New_Member_Click;
            PB_New_Member.MouseEnter += PB_New_Member_MouseEnter;
            PB_New_Member.MouseLeave += PB_New_Member_MouseLeave;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(296, 109);
            dataGridView1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.But_Friends;
            pictureBox1.Location = new Point(137, 278);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form_NewGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 314);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(PB_New_Member);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TB_NewGroup_Description);
            Controls.Add(PB_New_Icon);
            Controls.Add(TB_NewGroup_Name);
            Controls.Add(textBox1);
            Name = "Form_NewGroup";
            ((System.ComponentModel.ISupportInitialize)PB_New_Icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_New_Member).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private Button button2;
        private Button button1;
        private TextBox TB_NewGroup_Description;
        private PictureBox PB_New_Icon;
        private TextBox TB_NewGroup_Name;
        private TextBox textBox1;
        private PictureBox PB_New_Member;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}