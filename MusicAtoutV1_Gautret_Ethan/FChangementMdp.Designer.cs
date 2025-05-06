
namespace MusicAtoutV1_Gautret_Ethan
{
    partial class FChangementMdp
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
            tbAncienMdp = new TextBox();
            tbNouveauMdp = new TextBox();
            tbConfirmMdp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_valid = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbAncienMdp
            // 
            tbAncienMdp.Location = new Point(61, 115);
            tbAncienMdp.Margin = new Padding(3, 4, 3, 4);
            tbAncienMdp.Name = "tbAncienMdp";
            tbAncienMdp.Size = new Size(225, 27);
            tbAncienMdp.TabIndex = 0;
            tbAncienMdp.TextChanged += this.tbAncienMdp_TextChanged;
            // 
            // tbNouveauMdp
            // 
            tbNouveauMdp.Location = new Point(61, 193);
            tbNouveauMdp.Margin = new Padding(3, 4, 3, 4);
            tbNouveauMdp.Name = "tbNouveauMdp";
            tbNouveauMdp.Size = new Size(225, 27);
            tbNouveauMdp.TabIndex = 1;
            tbNouveauMdp.TextChanged += this.tbNouveauMdp_TextChanged;
            // 
            // tbConfirmMdp
            // 
            tbConfirmMdp.Location = new Point(61, 261);
            tbConfirmMdp.Margin = new Padding(3, 4, 3, 4);
            tbConfirmMdp.Name = "tbConfirmMdp";
            tbConfirmMdp.Size = new Size(225, 27);
            tbConfirmMdp.TabIndex = 2;
            tbConfirmMdp.TextChanged += tbConfirmMdp_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 91);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 3;
            label1.Text = "Ancien mot de passe :";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 169);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 4;
            label2.Text = "Nouveau mot de passe :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 237);
            label3.Name = "label3";
            label3.Size = new Size(213, 20);
            label3.TabIndex = 5;
            label3.Text = "Confirmer votre mot de passe :";
            label3.Click += this.label3_Click;
            // 
            // btn_valid
            // 
            btn_valid.Location = new Point(61, 296);
            btn_valid.Margin = new Padding(3, 4, 3, 4);
            btn_valid.Name = "btn_valid";
            btn_valid.Size = new Size(86, 31);
            btn_valid.TabIndex = 6;
            btn_valid.Text = "Confirmer";
            btn_valid.UseVisualStyleBackColor = true;
            btn_valid.Click += btn_valid_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 9);
            label4.Name = "label4";
            label4.Size = new Size(252, 20);
            label4.TabIndex = 7;
            label4.Text = "Changement de votre mot de passe: ";
            // 
            // FChangementMdp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 600);
            Controls.Add(label4);
            Controls.Add(btn_valid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbConfirmMdp);
            Controls.Add(tbNouveauMdp);
            Controls.Add(tbAncienMdp);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FChangementMdp";
            Text = "FChangementMdp";
            Load += FChangementMdp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbAncienMdp;
        private TextBox tbNouveauMdp;
        private TextBox tbConfirmMdp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_valid;
        private Label label4;
        private EventHandler tbAncienMdp_TextChanged;
        private EventHandler tbNouveauMdp_TextChanged;
        private EventHandler label1_Click;
        private EventHandler label3_Click;
    }
}