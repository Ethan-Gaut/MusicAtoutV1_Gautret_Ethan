namespace MusicAtoutV1_Gautret_Ethan
{
    partial class FStyle
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
            cboStyle = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvCompositeur = new DataGridView();
            bsStyle = new BindingSource(components);
            txtDebut = new TextBox();
            txtFin = new TextBox();
            bsCompo = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompo).BeginInit();
            SuspendLayout();
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(217, 31);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(166, 23);
            cboStyle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(199, 15);
            label1.TabIndex = 1;
            label1.Text = "Sélectionner un style ou une époque";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 34);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Début du style";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 34);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Fin du style";
            label3.Click += label3_Click;
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.AllowUserToAddRows = false;
            dgvCompositeur.AllowUserToDeleteRows = false;
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(43, 84);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.ReadOnly = true;
            dgvCompositeur.Size = new Size(790, 354);
            dgvCompositeur.TabIndex = 4;
            dgvCompositeur.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bsStyle
            // 
            bsStyle.CurrentChanged += bsStyle_CurrentChanged;
            // 
            // txtDebut
            // 
            txtDebut.Location = new Point(493, 31);
            txtDebut.Name = "txtDebut";
            txtDebut.Size = new Size(100, 23);
            txtDebut.TabIndex = 5;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(681, 31);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(100, 23);
            txtFin.TabIndex = 6;
            // 
            // FStyle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1014, 450);
            Controls.Add(txtFin);
            Controls.Add(txtDebut);
            Controls.Add(dgvCompositeur);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboStyle);
            Name = "FStyle";
            Text = "FStyle";
            Load += FStyle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboStyle;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvCompositeur;
        private BindingSource bsStyle;
        private TextBox txtDebut;
        private TextBox txtFin;
        private BindingSource bsCompo;
    }
}