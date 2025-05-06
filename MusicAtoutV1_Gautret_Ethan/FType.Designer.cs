namespace MusicAtoutV1_Gautret_Ethan
{
    partial class FType
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
            bsType = new BindingSource(components);
            dgvType = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvType).BeginInit();
            SuspendLayout();
            // 
            // dgvType
            // 
            dgvType.AllowUserToAddRows = false;
            dgvType.AllowUserToDeleteRows = false;
            dgvType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvType.Location = new Point(12, 12);
            dgvType.Name = "dgvType";
            dgvType.ReadOnly = true;
            dgvType.Size = new Size(776, 426);
            dgvType.TabIndex = 0;
            // 
            // FType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvType);
            Name = "FType";
            Text = "FType";
            Load += FType_Load;
            ((System.ComponentModel.ISupportInitialize)bsType).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvType).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsType;
        private DataGridView dgvType;
    }
}