namespace MusicAtoutV1_Gautret
{
    partial class FOeuvreCompositeur
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            cboStyle = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtDebut = new TextBox();
            txtFin = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            dgvCompositeurStyle = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCompositeur = new TextBox();
            txtNationalite = new TextBox();
            txtStyle = new TextBox();
            label8 = new Label();
            txtNais = new TextBox();
            label9 = new Label();
            txtMort = new TextBox();
            txtRemarque = new TextBox();
            lbOeuvre = new Label();
            dgvOeuvresCompositeur = new DataGridView();
            bsStyle = new BindingSource(components);
            bsCompositeur = new BindingSource(components);
            bsOeuvre = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeurStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOeuvresCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOeuvre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 6);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Style";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(48, 30);
            cboStyle.Margin = new Padding(3, 4, 3, 4);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(238, 28);
            cboStyle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 65);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Début";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(125, 65);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 3;
            label3.Text = "Fin";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDebut
            // 
            txtDebut.Location = new Point(48, 89);
            txtDebut.Margin = new Padding(3, 4, 3, 4);
            txtDebut.Name = "txtDebut";
            txtDebut.Size = new Size(69, 27);
            txtDebut.TabIndex = 4;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(125, 89);
            txtFin.Margin = new Padding(3, 4, 3, 4);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(79, 27);
            txtFin.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(417, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 705);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 123);
            label4.Name = "label4";
            label4.Size = new Size(211, 20);
            label4.TabIndex = 7;
            label4.Text = "liste des compositeurs du style";
            // 
            // dgvCompositeurStyle
            // 
            dgvCompositeurStyle.AllowUserToAddRows = false;
            dgvCompositeurStyle.AllowUserToDeleteRows = false;
            dgvCompositeurStyle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeurStyle.Location = new Point(44, 147);
            dgvCompositeurStyle.Margin = new Padding(3, 4, 3, 4);
            dgvCompositeurStyle.Name = "dgvCompositeurStyle";
            dgvCompositeurStyle.ReadOnly = true;
            dgvCompositeurStyle.RowHeadersWidth = 51;
            dgvCompositeurStyle.Size = new Size(367, 385);
            dgvCompositeurStyle.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(435, 34);
            label5.Name = "label5";
            label5.Size = new Size(155, 20);
            label5.TabIndex = 9;
            label5.Text = "Vous avez Selectionné";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(507, 72);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 10;
            label6.Text = "Nationalité";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(817, 72);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 11;
            label7.Text = "Style";
            // 
            // txtCompositeur
            // 
            txtCompositeur.Location = new Point(610, 31);
            txtCompositeur.Margin = new Padding(3, 4, 3, 4);
            txtCompositeur.Name = "txtCompositeur";
            txtCompositeur.Size = new Size(386, 27);
            txtCompositeur.TabIndex = 12;
            // 
            // txtNationalite
            // 
            txtNationalite.Location = new Point(610, 69);
            txtNationalite.Margin = new Padding(3, 4, 3, 4);
            txtNationalite.Name = "txtNationalite";
            txtNationalite.Size = new Size(190, 27);
            txtNationalite.TabIndex = 13;
            // 
            // txtStyle
            // 
            txtStyle.Location = new Point(864, 69);
            txtStyle.Margin = new Padding(3, 4, 3, 4);
            txtStyle.Name = "txtStyle";
            txtStyle.Size = new Size(132, 27);
            txtStyle.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(515, 111);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 15;
            label8.Text = "Naissance";
            // 
            // txtNais
            // 
            txtNais.Location = new Point(610, 108);
            txtNais.Margin = new Padding(3, 4, 3, 4);
            txtNais.Name = "txtNais";
            txtNais.Size = new Size(92, 27);
            txtNais.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(809, 115);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 17;
            label9.Text = "Décès";
            // 
            // txtMort
            // 
            txtMort.Location = new Point(864, 112);
            txtMort.Margin = new Padding(3, 4, 3, 4);
            txtMort.Name = "txtMort";
            txtMort.Size = new Size(97, 27);
            txtMort.TabIndex = 18;
            // 
            // txtRemarque
            // 
            txtRemarque.Location = new Point(464, 147);
            txtRemarque.Margin = new Padding(3, 4, 3, 4);
            txtRemarque.Multiline = true;
            txtRemarque.Name = "txtRemarque";
            txtRemarque.Size = new Size(531, 131);
            txtRemarque.TabIndex = 19;
            // 
            // lbOeuvre
            // 
            lbOeuvre.AutoSize = true;
            lbOeuvre.BackColor = Color.Transparent;
            lbOeuvre.Location = new Point(464, 309);
            lbOeuvre.Name = "lbOeuvre";
            lbOeuvre.Size = new Size(193, 20);
            lbOeuvre.TabIndex = 20;
            lbOeuvre.Text = "Les oeuvres du compositeur";
            // 
            // dgvOeuvresCompositeur
            // 
            dgvOeuvresCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOeuvresCompositeur.Location = new Point(464, 333);
            dgvOeuvresCompositeur.Margin = new Padding(3, 4, 3, 4);
            dgvOeuvresCompositeur.Name = "dgvOeuvresCompositeur";
            dgvOeuvresCompositeur.RowHeadersWidth = 51;
            dgvOeuvresCompositeur.Size = new Size(533, 351);
            dgvOeuvresCompositeur.TabIndex = 21;
            // 
            // bsStyle
            // 
            bsStyle.CurrentChanged += bsStyle_CurrentChanged;
            // 
            // bsCompositeur
            // 
            bsCompositeur.CurrentChanged += bsCompositeur_CurrentChanged;
            // 
            // FOeuvreCompositeur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 738);
            Controls.Add(dgvOeuvresCompositeur);
            Controls.Add(lbOeuvre);
            Controls.Add(txtRemarque);
            Controls.Add(txtMort);
            Controls.Add(label9);
            Controls.Add(txtNais);
            Controls.Add(label8);
            Controls.Add(txtStyle);
            Controls.Add(txtNationalite);
            Controls.Add(txtCompositeur);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgvCompositeurStyle);
            Controls.Add(label4);
            Controls.Add(txtFin);
            Controls.Add(txtDebut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboStyle);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FOeuvreCompositeur";
            Text = "Les ouvres d'un compossiteur";
            Load += FOeuvreCompositeur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeurStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOeuvresCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOeuvre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboStyle;
        private Label label2;
        private Label label3;
        private TextBox txtDebut;
        private TextBox txtFin;
        private PictureBox pictureBox1;
        private Label label4;
        private DataGridView dgvCompositeurStyle;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCompositeur;
        private TextBox txtNationalite;
        private TextBox txtStyle;
        private Label label8;
        private TextBox txtNais;
        private Label label9;
        private TextBox txtMort;
        private TextBox txtRemarque;
        private Label lbOeuvre;
        private DataGridView dgvOeuvresCompositeur;
        private BindingSource bsStyle;
        private BindingSource bsCompositeur;
        private BindingSource bsOeuvre;
    }
}