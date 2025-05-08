namespace MusicAtoutV1_Gautret.Models
{
    partial class FVille
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
            bsVille = new BindingSource(components);
            dgvVille = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bsVille).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVille).BeginInit();
            SuspendLayout();
            // 
            // bsVille
            // 
            bsVille.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // dgvVille
            // 
            dgvVille.AllowUserToAddRows = false;
            dgvVille.AllowUserToDeleteRows = false;
            dgvVille.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVille.Location = new Point(25, 32);
            dgvVille.Margin = new Padding(3, 4, 3, 4);
            dgvVille.Name = "dgvVille";
            dgvVille.ReadOnly = true;
            dgvVille.RowHeadersWidth = 51;
            dgvVille.Size = new Size(858, 555);
            dgvVille.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 4);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Liste des villes";
            // 
            // FVille
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(dgvVille);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FVille";
            Text = "FVille";
            Load += FVille_Load;
            ((System.ComponentModel.ISupportInitialize)bsVille).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVille).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsVille;
        private DataGridView dgvVille;
        private Label label1;
    }
}