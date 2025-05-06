namespace MusicAtoutV1_Gautret_Ethan
{
    partial class FAjoutUtilisateur
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
            lbIdentifiant = new Label();
            lbConfMdp = new Label();
            lbMdp = new Label();
            tbIdentifiant = new TextBox();
            tbMdp = new TextBox();
            tbConfMdp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nudDroit = new NumericUpDown();
            btnAjoutUtilisateur = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDroit).BeginInit();
            SuspendLayout();
            // 
            // lbIdentifiant
            // 
            lbIdentifiant.AutoSize = true;
            lbIdentifiant.Location = new Point(81, 63);
            lbIdentifiant.Name = "lbIdentifiant";
            lbIdentifiant.Size = new Size(84, 20);
            lbIdentifiant.TabIndex = 0;
            lbIdentifiant.Text = "Identifiant :";
            // 
            // lbConfMdp
            // 
            lbConfMdp.AutoSize = true;
            lbConfMdp.Location = new Point(81, 215);
            lbConfMdp.Name = "lbConfMdp";
            lbConfMdp.Size = new Size(193, 20);
            lbConfMdp.TabIndex = 1;
            lbConfMdp.Text = "Confirmez le mot de passe :";
            // 
            // lbMdp
            // 
            lbMdp.AutoSize = true;
            lbMdp.Location = new Point(81, 136);
            lbMdp.Name = "lbMdp";
            lbMdp.Size = new Size(105, 20);
            lbMdp.TabIndex = 2;
            lbMdp.Text = "Mot de passe :";
            lbMdp.Click += lbMdp_Click;
            // 
            // tbIdentifiant
            // 
            tbIdentifiant.Location = new Point(81, 87);
            tbIdentifiant.Margin = new Padding(3, 4, 3, 4);
            tbIdentifiant.Name = "tbIdentifiant";
            tbIdentifiant.Size = new Size(237, 27);
            tbIdentifiant.TabIndex = 3;
            // 
            // tbMdp
            // 
            tbMdp.Location = new Point(81, 160);
            tbMdp.Margin = new Padding(3, 4, 3, 4);
            tbMdp.Name = "tbMdp";
            tbMdp.Size = new Size(237, 27);
            tbMdp.TabIndex = 4;
            // 
            // tbConfMdp
            // 
            tbConfMdp.Location = new Point(81, 239);
            tbConfMdp.Margin = new Padding(3, 4, 3, 4);
            tbConfMdp.Name = "tbConfMdp";
            tbConfMdp.Size = new Size(237, 27);
            tbConfMdp.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 6;
            label1.Text = "Ajout d'un Utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 289);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 7;
            label2.Text = "Niveau du droit :";
            // 
            // nudDroit
            // 
            nudDroit.Location = new Point(81, 313);
            nudDroit.Margin = new Padding(3, 4, 3, 4);
            nudDroit.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudDroit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDroit.Name = "nudDroit";
            nudDroit.Size = new Size(165, 27);
            nudDroit.TabIndex = 8;
            nudDroit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAjoutUtilisateur
            // 
            btnAjoutUtilisateur.BackColor = Color.FromArgb(192, 255, 192);
            btnAjoutUtilisateur.Location = new Point(81, 371);
            btnAjoutUtilisateur.Margin = new Padding(3, 4, 3, 4);
            btnAjoutUtilisateur.Name = "btnAjoutUtilisateur";
            btnAjoutUtilisateur.Size = new Size(165, 31);
            btnAjoutUtilisateur.TabIndex = 9;
            btnAjoutUtilisateur.Text = "Ajouter";
            btnAjoutUtilisateur.UseVisualStyleBackColor = false;
            btnAjoutUtilisateur.Click += btnAjoutUtilisateur_Click;
            // 
            // FAjoutUtilisateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 429);
            Controls.Add(btnAjoutUtilisateur);
            Controls.Add(nudDroit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbConfMdp);
            Controls.Add(tbMdp);
            Controls.Add(tbIdentifiant);
            Controls.Add(lbMdp);
            Controls.Add(lbConfMdp);
            Controls.Add(lbIdentifiant);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FAjoutUtilisateur";
            Text = "FAjoutUtilisateur";
            Load += FAjoutUtilisateur_Load;
            ((System.ComponentModel.ISupportInitialize)nudDroit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIdentifiant;
        private Label lbConfMdp;
        private Label lbMdp;
        private TextBox tbIdentifiant;
        private TextBox tbMdp;
        private TextBox tbConfMdp;
        private Label label1;
        private Label label2;
        private NumericUpDown nudDroit;
        private Button btnAjoutUtilisateur;
    }
}