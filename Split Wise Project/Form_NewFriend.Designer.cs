namespace Split_Wise_Project
{
    partial class Form_NewFriend
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
            textBox1 = new TextBox();
            TB_Friends_Name = new TextBox();
            pictureBox1 = new PictureBox();
            TB_Friends_Surname = new TextBox();
            button1 = new Button();
            button2 = new Button();
            TB_Friends_Description = new TextBox();
            TB_Friends_Email = new TextBox();
            TB_Friends_Phone = new TextBox();
            TB_Friends_Information = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Broadway", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 22);
            textBox1.TabIndex = 0;
            textBox1.Text = "Crear Nuevo Contacto";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TB_Friends_Name
            // 
            TB_Friends_Name.BackColor = SystemColors.MenuBar;
            TB_Friends_Name.Location = new Point(118, 42);
            TB_Friends_Name.Name = "TB_Friends_Name";
            TB_Friends_Name.Size = new Size(190, 23);
            TB_Friends_Name.TabIndex = 1;
            TB_Friends_Name.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.But_New_Photo;
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // TB_Friends_Surname
            // 
            TB_Friends_Surname.BackColor = SystemColors.MenuBar;
            TB_Friends_Surname.Location = new Point(118, 71);
            TB_Friends_Surname.Name = "TB_Friends_Surname";
            TB_Friends_Surname.Size = new Size(190, 23);
            TB_Friends_Surname.TabIndex = 3;
            TB_Friends_Surname.Text = "Apellidos";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Font = new Font("Broadway", 14.25F, FontStyle.Bold);
            button1.Location = new Point(12, 273);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 9;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += But_Friends_Cancel_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Menu;
            button2.Font = new Font("Broadway", 14.25F, FontStyle.Bold);
            button2.Location = new Point(189, 273);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 10;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += But_Friends_Create_Click;
            // 
            // TB_Friends_Description
            // 
            TB_Friends_Description.BackColor = SystemColors.MenuBar;
            TB_Friends_Description.Location = new Point(12, 100);
            TB_Friends_Description.Name = "TB_Friends_Description";
            TB_Friends_Description.Size = new Size(296, 23);
            TB_Friends_Description.TabIndex = 11;
            TB_Friends_Description.Text = "Descripción";
            // 
            // TB_Friends_Email
            // 
            TB_Friends_Email.BackColor = SystemColors.MenuBar;
            TB_Friends_Email.Location = new Point(12, 129);
            TB_Friends_Email.Name = "TB_Friends_Email";
            TB_Friends_Email.Size = new Size(296, 23);
            TB_Friends_Email.TabIndex = 12;
            TB_Friends_Email.Text = "Correo";
            // 
            // TB_Friends_Phone
            // 
            TB_Friends_Phone.BackColor = SystemColors.MenuBar;
            TB_Friends_Phone.Location = new Point(12, 158);
            TB_Friends_Phone.Name = "TB_Friends_Phone";
            TB_Friends_Phone.Size = new Size(296, 23);
            TB_Friends_Phone.TabIndex = 13;
            TB_Friends_Phone.Text = "Telefono";
            // 
            // TB_Friends_Information
            // 
            TB_Friends_Information.BackColor = SystemColors.MenuBar;
            TB_Friends_Information.Location = new Point(12, 187);
            TB_Friends_Information.Name = "TB_Friends_Information";
            TB_Friends_Information.Size = new Size(296, 23);
            TB_Friends_Information.TabIndex = 14;
            TB_Friends_Information.Text = "Más Información";
            // 
            // Form_NewFriend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 314);
            Controls.Add(TB_Friends_Information);
            Controls.Add(TB_Friends_Phone);
            Controls.Add(TB_Friends_Email);
            Controls.Add(TB_Friends_Description);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TB_Friends_Surname);
            Controls.Add(pictureBox1);
            Controls.Add(TB_Friends_Name);
            Controls.Add(textBox1);
            Name = "Form_NewFriend";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox TB_Friends_Name;
        private PictureBox pictureBox1;
        private TextBox TB_Friends_Surname;
        private Button button1;
        private Button button2;
        private TextBox TB_Friends_Description;
        private TextBox TB_Friends_Email;
        private TextBox TB_Friends_Phone;
        private TextBox TB_Friends_Information;
    }
}