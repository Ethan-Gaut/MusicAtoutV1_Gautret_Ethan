namespace MusicAtoutV1_Gautret
{
    partial class FCompositeurNation
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
            cboNation = new ComboBox();
            label1 = new Label();
            dgvCompositeur = new DataGridView();
            bsCompositeur = new BindingSource(components);
            bsNation = new BindingSource(components);
            button1 = new Button();
            btAjout = new Button();
            btModif = new Button();
            btSupp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).BeginInit();
            SuspendLayout();
            // 
            // cboNation
            // 
            cboNation.FormattingEnabled = true;
            cboNation.Location = new Point(98, 11);
            cboNation.Margin = new Padding(3, 4, 3, 4);
            cboNation.Name = "cboNation";
            cboNation.Size = new Size(138, 28);
            cboNation.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "Nationalité";
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.AllowUserToAddRows = false;
            dgvCompositeur.AllowUserToDeleteRows = false;
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(7, 49);
            dgvCompositeur.Margin = new Padding(3, 4, 3, 4);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.ReadOnly = true;
            dgvCompositeur.RowHeadersWidth = 51;
            dgvCompositeur.Size = new Size(894, 512);
            dgvCompositeur.TabIndex = 2;
            // 
            // bsCompositeur
            // 
            bsCompositeur.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // bsNation
            // 
            bsNation.CurrentChanged += bsNation_CurrentChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(262, 11);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(158, 31);
            button1.TabIndex = 3;
            button1.Text = "Toutes les nationalités";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btAjout
            // 
            btAjout.BackColor = Color.FromArgb(128, 255, 128);
            btAjout.Location = new Point(12, 569);
            btAjout.Margin = new Padding(3, 4, 3, 4);
            btAjout.Name = "btAjout";
            btAjout.Size = new Size(86, 31);
            btAjout.TabIndex = 4;
            btAjout.Text = "Ajouter";
            btAjout.UseVisualStyleBackColor = false;
            btAjout.Click += btAjout_Click;
            // 
            // btModif
            // 
            btModif.BackColor = Color.FromArgb(255, 192, 128);
            btModif.Location = new Point(389, 569);
            btModif.Margin = new Padding(3, 4, 3, 4);
            btModif.Name = "btModif";
            btModif.Size = new Size(122, 31);
            btModif.TabIndex = 5;
            btModif.Text = "Modifier";
            btModif.UseVisualStyleBackColor = false;
            btModif.Click += btModif_Click_1;
            // 
            // btSupp
            // 
            btSupp.BackColor = Color.FromArgb(255, 128, 128);
            btSupp.Location = new Point(770, 569);
            btSupp.Margin = new Padding(3, 4, 3, 4);
            btSupp.Name = "btSupp";
            btSupp.Size = new Size(131, 31);
            btSupp.TabIndex = 6;
            btSupp.Text = "Supprimer";
            btSupp.UseVisualStyleBackColor = false;
            btSupp.Click += btSupp_Click;
            // 
            // FCompositeurNation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 652);
            Controls.Add(btSupp);
            Controls.Add(btModif);
            Controls.Add(btAjout);
            Controls.Add(button1);
            Controls.Add(dgvCompositeur);
            Controls.Add(label1);
            Controls.Add(cboNation);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FCompositeurNation";
            Text = "FCompositeurNation";
            Load += FCompositeurNation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboNation;
        private Label label1;
        private DataGridView dgvCompositeur;
        private BindingSource bsCompositeur;
        private BindingSource bsNation;
        private Button button1;
        private Button btAjout;
        private Button btModif;
        private Button btSupp;
    }
}