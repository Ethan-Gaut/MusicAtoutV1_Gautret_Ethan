namespace MusicAtoutV1_Gautret_Ethan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvVille = new DataGridView();
            bsVille = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvVille).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsVille).BeginInit();
            SuspendLayout();
            // 
            // dgvVille
            // 
            dgvVille.AllowUserToAddRows = false;
            dgvVille.AllowUserToDeleteRows = false;
            dgvVille.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVille.Location = new Point(251, 230);
            dgvVille.Name = "dgvVille";
            dgvVille.ReadOnly = true;
            dgvVille.Size = new Size(485, 173);
            dgvVille.TabIndex = 0;
            dgvVille.CellContentClick += dgvVille_CellContentClick;
            // 
            // bsVille
            // 
            bsVille.CurrentChanged += bsVille_CurrentChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 552);
            Controls.Add(dgvVille);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVille).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsVille).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvVille;
        private MenuStrip menuStrip1;
        private BindingSource bsVille;
    }
}
