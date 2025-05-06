namespace MusicAtoutV1_Gautret_Ethan
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
            bsCompo = new BindingSource(components);
            dgvCompo = new DataGridView();
            cboNation = new ComboBox();
            bsNation = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)bsCompo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).BeginInit();
            SuspendLayout();
            // 
            // bsCompo
            // 
            bsCompo.CurrentChanged += bsCompo_CurrentChanged;
            // 
            // dgvCompo
            // 
            dgvCompo.AllowUserToAddRows = false;
            dgvCompo.AllowUserToDeleteRows = false;
            dgvCompo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompo.Location = new Point(12, 50);
            dgvCompo.Name = "dgvCompo";
            dgvCompo.ReadOnly = true;
            dgvCompo.Size = new Size(776, 388);
            dgvCompo.TabIndex = 0;
            // 
            // cboNation
            // 
            cboNation.FormattingEnabled = true;
            cboNation.Location = new Point(22, 15);
            cboNation.Name = "cboNation";
            cboNation.Size = new Size(121, 23);
            cboNation.TabIndex = 1;
            cboNation.SelectedIndexChanged += cboNation_SelectedIndexChanged;
            // 
            // bsNation
            // 
            bsNation.CurrentChanged += bsNation_CurrentChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(173, 15);
            button1.Name = "button1";
            button1.Size = new Size(151, 23);
            button1.TabIndex = 2;
            button1.Text = "Toutes les nationalités";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(35, 454);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "AJOUT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(125, 454);
            button3.Name = "button3";
            button3.Size = new Size(98, 23);
            button3.TabIndex = 4;
            button3.Text = "MODIFICATION";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(238, 454);
            button4.Name = "button4";
            button4.Size = new Size(94, 23);
            button4.TabIndex = 5;
            button4.Text = "SUPPRESSION";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FCompositeurNation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cboNation);
            Controls.Add(dgvCompo);
            Name = "FCompositeurNation";
            Text = "FCompositeurNation";
            Load += FCompositeurNation_Load;
            ((System.ComponentModel.ISupportInitialize)bsCompo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompo).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsCompo;
        private DataGridView dgvCompo;
        private ComboBox cboNation;
        private BindingSource bsNation;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}