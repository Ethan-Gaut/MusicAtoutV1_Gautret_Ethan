namespace MusicAtoutV1_Gautret_Ethan
{
    partial class FCompositeurStyle
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
            bsStyle = new BindingSource(components);
            bsCompositeur = new BindingSource(components);
            dgvCompositeur = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(249, 20);
            label1.TabIndex = 0;
            label1.Text = "Sélectionner un style ou une époque";
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(269, 22);
            cboStyle.Margin = new Padding(3, 4, 3, 4);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(138, 28);
            cboStyle.TabIndex = 1;
            cboStyle.SelectedIndexChanged += cboStyle_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 25);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 2;
            label2.Text = "Début du style";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(680, 25);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 3;
            label3.Text = "Fin du style";
            // 
            // txtDebut
            // 
            txtDebut.Location = new Point(548, 21);
            txtDebut.Margin = new Padding(3, 4, 3, 4);
            txtDebut.Name = "txtDebut";
            txtDebut.Size = new Size(114, 27);
            txtDebut.TabIndex = 4;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(763, 21);
            txtFin.Margin = new Padding(3, 4, 3, 4);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(114, 27);
            txtFin.TabIndex = 5;
            // 
            // bsStyle
            // 
            bsStyle.CurrentChanged += bsStyle_CurrentChanged;
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(14, 93);
            dgvCompositeur.Margin = new Padding(3, 4, 3, 4);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.RowHeadersWidth = 51;
            dgvCompositeur.Size = new Size(837, 491);
            dgvCompositeur.TabIndex = 6;
            // 
            // FCompositeurStyle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(914, 600);
            Controls.Add(dgvCompositeur);
            Controls.Add(txtFin);
            Controls.Add(txtDebut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboStyle);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FCompositeurStyle";
            Text = "FCompositeurStyle";
            Load += FCompositeurStyle_Load;
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
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
        private BindingSource bsStyle;
        private BindingSource bsCompositeur;
        private DataGridView dgvCompositeur;
    }
}