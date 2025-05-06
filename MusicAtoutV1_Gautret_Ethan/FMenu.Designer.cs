namespace MusicAtoutV1_Gautret_Ethan
{
    partial class FMenu
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
            menuStrip1 = new MenuStrip();
            listeToolStripMenuItem = new ToolStripMenuItem();
            villeToolStripMenuItem = new ToolStripMenuItem();
            sallesToolStripMenuItem = new ToolStripMenuItem();
            batimentsToolStripMenuItem = new ToolStripMenuItem();
            typesDoeuvreToolStripMenuItem = new ToolStripMenuItem();
            compositeursToolStripMenuItem = new ToolStripMenuItem();
            parNationalitéToolStripMenuItem = new ToolStripMenuItem();
            parStyleToolStripMenuItem = new ToolStripMenuItem();
            oeuvreToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { listeToolStripMenuItem, compositeursToolStripMenuItem, oeuvreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { villeToolStripMenuItem, sallesToolStripMenuItem, batimentsToolStripMenuItem, typesDoeuvreToolStripMenuItem });
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(43, 20);
            listeToolStripMenuItem.Text = "Liste";
            // 
            // villeToolStripMenuItem
            // 
            villeToolStripMenuItem.Name = "villeToolStripMenuItem";
            villeToolStripMenuItem.Size = new Size(152, 22);
            villeToolStripMenuItem.Text = "Villes";
            villeToolStripMenuItem.Click += villeToolStripMenuItem_Click;
            // 
            // sallesToolStripMenuItem
            // 
            sallesToolStripMenuItem.Name = "sallesToolStripMenuItem";
            sallesToolStripMenuItem.Size = new Size(152, 22);
            sallesToolStripMenuItem.Text = "Salles";
            sallesToolStripMenuItem.Click += sallesToolStripMenuItem_Click;
            // 
            // batimentsToolStripMenuItem
            // 
            batimentsToolStripMenuItem.Name = "batimentsToolStripMenuItem";
            batimentsToolStripMenuItem.Size = new Size(152, 22);
            batimentsToolStripMenuItem.Text = "Batiments";
            batimentsToolStripMenuItem.Click += batimentsToolStripMenuItem_Click;
            // 
            // typesDoeuvreToolStripMenuItem
            // 
            typesDoeuvreToolStripMenuItem.Name = "typesDoeuvreToolStripMenuItem";
            typesDoeuvreToolStripMenuItem.Size = new Size(152, 22);
            typesDoeuvreToolStripMenuItem.Text = "Types d'oeuvre";
            typesDoeuvreToolStripMenuItem.Click += typesDoeuvreToolStripMenuItem_Click;
            // 
            // compositeursToolStripMenuItem
            // 
            compositeursToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { parNationalitéToolStripMenuItem, parStyleToolStripMenuItem });
            compositeursToolStripMenuItem.Name = "compositeursToolStripMenuItem";
            compositeursToolStripMenuItem.Size = new Size(93, 20);
            compositeursToolStripMenuItem.Text = "Compositeurs";
            // 
            // parNationalitéToolStripMenuItem
            // 
            parNationalitéToolStripMenuItem.Name = "parNationalitéToolStripMenuItem";
            parNationalitéToolStripMenuItem.Size = new Size(180, 22);
            parNationalitéToolStripMenuItem.Text = "Par nationalité";
            parNationalitéToolStripMenuItem.Click += parNationalitéToolStripMenuItem_Click;
            // 
            // parStyleToolStripMenuItem
            // 
            parStyleToolStripMenuItem.Name = "parStyleToolStripMenuItem";
            parStyleToolStripMenuItem.Size = new Size(180, 22);
            parStyleToolStripMenuItem.Text = "Par style";
            parStyleToolStripMenuItem.Click += parStyleToolStripMenuItem_Click;
            // 
            // oeuvreToolStripMenuItem
            // 
            oeuvreToolStripMenuItem.Name = "oeuvreToolStripMenuItem";
            oeuvreToolStripMenuItem.Size = new Size(57, 20);
            oeuvreToolStripMenuItem.Text = "Oeuvre";
            oeuvreToolStripMenuItem.Click += oeuvreToolStripMenuItem_Click;
            // 
            // FMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FMenu";
            Text = "FMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem villeToolStripMenuItem;
        private ToolStripMenuItem sallesToolStripMenuItem;
        private ToolStripMenuItem batimentsToolStripMenuItem;
        private ToolStripMenuItem typesDoeuvreToolStripMenuItem;
        private ToolStripMenuItem compositeursToolStripMenuItem;
        private ToolStripMenuItem parNationalitéToolStripMenuItem;
        private ToolStripMenuItem parStyleToolStripMenuItem;
        private ToolStripMenuItem oeuvreToolStripMenuItem;
    }
}