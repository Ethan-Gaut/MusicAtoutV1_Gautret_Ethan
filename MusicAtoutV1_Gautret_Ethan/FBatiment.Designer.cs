namespace MusicAtoutV1_Gautret_Ethan
{
    partial class FBatiment
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
            bsBatiment = new BindingSource(components);
            dgvBatiment = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsBatiment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBatiment).BeginInit();
            SuspendLayout();
            // 
            // dgvBatiment
            // 
            dgvBatiment.AllowUserToAddRows = false;
            dgvBatiment.AllowUserToDeleteRows = false;
            dgvBatiment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatiment.Location = new Point(21, 29);
            dgvBatiment.Name = "dgvBatiment";
            dgvBatiment.ReadOnly = true;
            dgvBatiment.Size = new Size(767, 365);
            dgvBatiment.TabIndex = 0;
            // 
            // FBatiment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBatiment);
            Name = "FBatiment";
            Text = "FBatiment";
            Load += FBatiment_Load;
            ((System.ComponentModel.ISupportInitialize)bsBatiment).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBatiment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsBatiment;
        private DataGridView dgvBatiment;
    }
}