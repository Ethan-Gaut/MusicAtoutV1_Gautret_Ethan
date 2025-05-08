namespace MusicAtoutV1_Gautret
{
    partial class FTypesOeuvres
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
            dgvTO = new DataGridView();
            bsTO = new BindingSource(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTO).BeginInit();
            SuspendLayout();
            // 
            // dgvTO
            // 
            dgvTO.AllowUserToAddRows = false;
            dgvTO.AllowUserToDeleteRows = false;
            dgvTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTO.Location = new Point(32, 39);
            dgvTO.Margin = new Padding(3, 4, 3, 4);
            dgvTO.Name = "dgvTO";
            dgvTO.ReadOnly = true;
            dgvTO.RowHeadersWidth = 51;
            dgvTO.Size = new Size(837, 512);
            dgvTO.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 1;
            label1.Text = "les types d'oeuvre";
            // 
            // FTypesOeuvres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(dgvTO);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FTypesOeuvres";
            Text = "FTypesOeuvres";
            Load += FTypesOeuvres_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTO).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTO;
        private BindingSource bsTO;
        private Label label1;
    }
}