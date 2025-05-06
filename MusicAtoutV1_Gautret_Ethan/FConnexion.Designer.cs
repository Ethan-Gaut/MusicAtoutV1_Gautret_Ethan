namespace MusicAtoutV1_Gautret_Ethan
{
    partial class FConnexion
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            btConnexion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(907, 536);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 171);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Identifiant :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 227);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Mot de passe :";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(350, 195);
            tbLogin.Margin = new Padding(3, 4, 3, 4);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(189, 27);
            tbLogin.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(350, 251);
            tbPassword.Margin = new Padding(3, 4, 3, 4);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(189, 27);
            tbPassword.TabIndex = 4;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btConnexion
            // 
            btConnexion.BackColor = Color.SteelBlue;
            btConnexion.ForeColor = SystemColors.ButtonHighlight;
            btConnexion.Location = new Point(350, 286);
            btConnexion.Margin = new Padding(3, 4, 3, 4);
            btConnexion.Name = "btConnexion";
            btConnexion.Size = new Size(114, 31);
            btConnexion.TabIndex = 5;
            btConnexion.Text = "Connexion";
            btConnexion.UseVisualStyleBackColor = false;
            btConnexion.Click += btConnexion_Click;
            // 
            // FConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btConnexion);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FConnexion";
            Text = "FConnexion";
            Load += FConnexion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private Button btConnexion;
    }
}