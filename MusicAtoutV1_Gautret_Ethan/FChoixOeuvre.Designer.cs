namespace MusicAtoutV1_Gautret_Ethan
{
    partial class FChoixOeuvre
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
            pictureBox1 = new PictureBox();
            cboStyle = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDebut = new TextBox();
            txtFin = new TextBox();
            label5 = new Label();
            dgvCompositeur = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            txtNP = new TextBox();
            txtNat = new TextBox();
            label8 = new Label();
            txtSty = new TextBox();
            txtNai = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtdec = new TextBox();
            label11 = new Label();
            dgvOeuvre = new DataGridView();
            txtRem = new TextBox();
            bsStyle = new BindingSource(components);
            bsCompo = new BindingSource(components);
            bsOeuvre = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOeuvre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsOeuvre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Scheherazade", 22F, FontStyle.Bold);
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 50);
            label1.TabIndex = 1;
            label1.Text = "Atout";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(308, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(537, 535);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // cboStyle
            // 
            cboStyle.BackColor = SystemColors.ScrollBar;
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(12, 122);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(199, 23);
            cboStyle.TabIndex = 3;
            cboStyle.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(13, 103);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 4;
            label2.Text = "Style";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 159);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Début";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 159);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 6;
            label4.Text = "Fin";
            // 
            // txtDebut
            // 
            txtDebut.BackColor = SystemColors.ScrollBar;
            txtDebut.Location = new Point(13, 177);
            txtDebut.Name = "txtDebut";
            txtDebut.Size = new Size(51, 23);
            txtDebut.TabIndex = 7;
            // 
            // txtFin
            // 
            txtFin.BackColor = SystemColors.ScrollBar;
            txtFin.Location = new Point(81, 177);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(50, 23);
            txtFin.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 212);
            label5.Name = "label5";
            label5.Size = new Size(145, 15);
            label5.TabIndex = 9;
            label5.Text = "Compositeurs de ce style";
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.BackgroundColor = SystemColors.ActiveCaption;
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(6, 230);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.Size = new Size(281, 305);
            dgvCompositeur.TabIndex = 10;
            dgvCompositeur.CellContentClick += dgvCompositeur_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(308, 30);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 11;
            label6.Text = "Vous avez sélectionné";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Location = new Point(308, 71);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 12;
            label7.Text = "Nationalité";
            label7.Click += label7_Click;
            // 
            // txtNP
            // 
            txtNP.Location = new Point(443, 22);
            txtNP.Name = "txtNP";
            txtNP.Size = new Size(344, 23);
            txtNP.TabIndex = 13;
            txtNP.TextChanged += textBox2_TextChanged;
            // 
            // txtNat
            // 
            txtNat.Location = new Point(443, 63);
            txtNat.Name = "txtNat";
            txtNat.Size = new Size(135, 23);
            txtNat.TabIndex = 14;
            txtNat.TextChanged += txtNat_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Location = new Point(597, 71);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 15;
            label8.Text = "Style";
            // 
            // txtSty
            // 
            txtSty.Location = new Point(639, 63);
            txtSty.Name = "txtSty";
            txtSty.Size = new Size(148, 23);
            txtSty.TabIndex = 16;
            // 
            // txtNai
            // 
            txtNai.Location = new Point(443, 99);
            txtNai.Name = "txtNai";
            txtNai.Size = new Size(52, 23);
            txtNai.TabIndex = 17;
            txtNai.TextChanged += textBox5_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Location = new Point(308, 107);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 18;
            label9.Text = "Naissance";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Location = new Point(514, 105);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 19;
            label10.Text = "Décès";
            label10.Click += label10_Click;
            // 
            // txtdec
            // 
            txtdec.Location = new Point(561, 99);
            txtdec.Name = "txtdec";
            txtdec.Size = new Size(41, 23);
            txtdec.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaption;
            label11.Location = new Point(308, 212);
            label11.Name = "label11";
            label11.Size = new Size(179, 15);
            label11.TabIndex = 21;
            label11.Text = "Les oeuvres de ce compositeur";
            // 
            // dgvOeuvre
            // 
            dgvOeuvre.AllowUserToAddRows = false;
            dgvOeuvre.AllowUserToDeleteRows = false;
            dgvOeuvre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOeuvre.Location = new Point(330, 230);
            dgvOeuvre.Name = "dgvOeuvre";
            dgvOeuvre.ReadOnly = true;
            dgvOeuvre.Size = new Size(493, 294);
            dgvOeuvre.TabIndex = 22;
            dgvOeuvre.CellContentClick += dataGridView2_CellContentClick;
            // 
            // txtRem
            // 
            txtRem.Location = new Point(318, 140);
            txtRem.Multiline = true;
            txtRem.Name = "txtRem";
            txtRem.Size = new Size(516, 69);
            txtRem.TabIndex = 23;
            txtRem.TextChanged += txtRem_TextChanged;
            // 
            // bsStyle
            // 
            bsStyle.CurrentChanged += bsStyle_CurrentChanged;
            // 
            // bsCompo
            // 
            bsCompo.CurrentChanged += bsCompo_CurrentChanged;
            // 
            // bsOeuvre
            // 
            bsOeuvre.CurrentChanged += bsOeuvre_CurrentChanged;
            // 
            // FChoixOeuvre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 536);
            Controls.Add(txtRem);
            Controls.Add(dgvOeuvre);
            Controls.Add(label11);
            Controls.Add(txtdec);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtNai);
            Controls.Add(txtSty);
            Controls.Add(label8);
            Controls.Add(txtNat);
            Controls.Add(txtNP);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvCompositeur);
            Controls.Add(label5);
            Controls.Add(txtFin);
            Controls.Add(txtDebut);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboStyle);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "FChoixOeuvre";
            RightToLeft = RightToLeft.No;
            Text = "FChoixOeuvre";
            Load += FChoixOeuvre_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOeuvre).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompo).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsOeuvre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cboStyle;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDebut;
        private TextBox txtFin;
        private Label label5;
        private DataGridView dgvCompositeur;
        private Label label6;
        private Label label7;
        private TextBox txtNP;
        private TextBox txtNat;
        private Label label8;
        private TextBox txtSty;
        private TextBox txtNai;
        private Label label9;
        private Label label10;
        private TextBox txtdec;
        private Label label11;
        private DataGridView dgvOeuvre;
        private TextBox txtRem;
        private BindingSource bsStyle;
        private BindingSource bsCompo;
        private BindingSource bsOeuvre;
    }
}