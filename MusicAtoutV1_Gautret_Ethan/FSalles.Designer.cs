namespace MusicAtoutV1_Gautret
{
    partial class FSalles
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
            bsSalle = new BindingSource(components);
            dgvSalle = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bsSalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalle).BeginInit();
            SuspendLayout();
            // 
            // bsSalle
            // 
            bsSalle.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // dgvSalle
            // 
            dgvSalle.AllowUserToAddRows = false;
            dgvSalle.AllowUserToDeleteRows = false;
            dgvSalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalle.Location = new Point(27, 85);
            dgvSalle.Margin = new Padding(3, 4, 3, 4);
            dgvSalle.Name = "dgvSalle";
            dgvSalle.ReadOnly = true;
            dgvSalle.RowHeadersWidth = 51;
            dgvSalle.Size = new Size(851, 461);
            dgvSalle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 43);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 1;
            label1.Text = "Liste des salles";
            // 
            // FSalles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(dgvSalle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FSalles";
            Text = "FSalles";
            Load += FSalles_Load;
            ((System.ComponentModel.ISupportInitialize)bsSalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private BindingSource bsSalle;
        private DataGridView dgvSalle;
        private Label label1;
    }
}