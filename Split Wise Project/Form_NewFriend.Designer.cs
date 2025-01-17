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
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
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
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.Location = new Point(118, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.But_New_Group_Perfil_Image;
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuBar;
            textBox3.Location = new Point(118, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "Apellidos";
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
            // textBox4
            // 
            textBox4.BackColor = SystemColors.MenuBar;
            textBox4.Location = new Point(12, 100);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(296, 23);
            textBox4.TabIndex = 11;
            textBox4.Text = "Descripción";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.MenuBar;
            textBox5.Location = new Point(12, 129);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(296, 23);
            textBox5.TabIndex = 12;
            textBox5.Text = "Correo";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.MenuBar;
            textBox6.Location = new Point(12, 158);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(296, 23);
            textBox6.TabIndex = 13;
            textBox6.Text = "Telefono";
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.MenuBar;
            textBox7.Location = new Point(12, 187);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(296, 23);
            textBox7.TabIndex = 14;
            textBox7.Text = "Más Información";
            // 
            // Form_NewFriends
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 314);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form_NewFriends";
            Text = "Form_NewGroup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}