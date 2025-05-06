namespace MusicAtoutV1_Gautret_Ethan
{
    partial class FAjoutModif
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Button_OK = new Button();
            button2 = new Button();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtRemarque = new TextBox();
            txtNaiss = new TextBox();
            txtMort = new TextBox();
            cboStyle = new ComboBox();
            cboNation = new ComboBox();
            bsCompo = new BindingSource(components);
            error1 = new ErrorProvider(components);
            bsNation = new BindingSource(components);
            bsStyle = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsCompo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "nom Compositeur :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "prenom Compositeur :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Remarque :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 171);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 3;
            label4.Text = "Année de Naissance :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(327, 171);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 4;
            label5.Text = "Année de Mort : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 215);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 5;
            label6.Text = "Nationalité :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 260);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "Style :";
            // 
            // Button_OK
            // 
            Button_OK.Location = new Point(176, 319);
            Button_OK.Name = "Button_OK";
            Button_OK.Size = new Size(75, 23);
            Button_OK.TabIndex = 7;
            Button_OK.Text = "OK";
            Button_OK.UseVisualStyleBackColor = true;
            Button_OK.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(272, 319);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(176, 6);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 9;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(176, 35);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(100, 23);
            txtPrenom.TabIndex = 10;
            // 
            // txtRemarque
            // 
            txtRemarque.Location = new Point(176, 66);
            txtRemarque.Multiline = true;
            txtRemarque.Name = "txtRemarque";
            txtRemarque.Size = new Size(435, 96);
            txtRemarque.TabIndex = 11;
            // 
            // txtNaiss
            // 
            txtNaiss.Location = new Point(176, 168);
            txtNaiss.Name = "txtNaiss";
            txtNaiss.Size = new Size(100, 23);
            txtNaiss.TabIndex = 12;
            // 
            // txtMort
            // 
            txtMort.Location = new Point(428, 168);
            txtMort.Name = "txtMort";
            txtMort.Size = new Size(100, 23);
            txtMort.TabIndex = 13;
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(176, 257);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(121, 23);
            cboStyle.TabIndex = 14;
            // 
            // cboNation
            // 
            cboNation.FormattingEnabled = true;
            cboNation.Location = new Point(176, 212);
            cboNation.Name = "cboNation";
            cboNation.Size = new Size(121, 23);
            cboNation.TabIndex = 15;
            // 
            // bsCompo
            // 
            bsCompo.CurrentChanged += bsCompo_CurrentChanged;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // FAjoutModif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 373);
            Controls.Add(cboNation);
            Controls.Add(cboStyle);
            Controls.Add(txtMort);
            Controls.Add(txtNaiss);
            Controls.Add(txtRemarque);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(button2);
            Controls.Add(Button_OK);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FAjoutModif";
            Text = "FAjoutModif";
            Load += FAjoutModif_Load;
            ((System.ComponentModel.ISupportInitialize)bsCompo).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button Button_OK;
        private Button button2;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtRemarque;
        private TextBox txtNaiss;
        private TextBox txtMort;
        private ComboBox cboStyle;
        private ComboBox cboNation;
        private BindingSource bsCompo;
        private ErrorProvider error1;
        private BindingSource bsNation;
        private BindingSource bsStyle;
    }
}