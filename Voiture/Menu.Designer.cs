namespace Voiture
{
    partial class Menu
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
            this.GestionAgenceView = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionVoitureView = new System.Windows.Forms.Button();
            this.GestionClientView = new System.Windows.Forms.Button();
            this.GestionLocationView = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GestionAgenceView
            // 
            this.GestionAgenceView.Location = new System.Drawing.Point(94, 190);
            this.GestionAgenceView.Name = "GestionAgenceView";
            this.GestionAgenceView.Size = new System.Drawing.Size(140, 56);
            this.GestionAgenceView.TabIndex = 0;
            this.GestionAgenceView.Text = "Gestion Agence";
            this.GestionAgenceView.UseVisualStyleBackColor = true;
            this.GestionAgenceView.Click += new System.EventHandler(this.GestionAgenceView_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agenceToolStripMenuItem,
            this.voitureToolStripMenuItem,
            this.clienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agenceToolStripMenuItem
            // 
            this.agenceToolStripMenuItem.Name = "agenceToolStripMenuItem";
            this.agenceToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.agenceToolStripMenuItem.Text = "Agence";
            // 
            // voitureToolStripMenuItem
            // 
            this.voitureToolStripMenuItem.Name = "voitureToolStripMenuItem";
            this.voitureToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.voitureToolStripMenuItem.Text = "Voiture";
            // 
            // clienToolStripMenuItem
            // 
            this.clienToolStripMenuItem.Name = "clienToolStripMenuItem";
            this.clienToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clienToolStripMenuItem.Text = "Client";
            // 
            // GestionVoitureView
            // 
            this.GestionVoitureView.Location = new System.Drawing.Point(291, 190);
            this.GestionVoitureView.Name = "GestionVoitureView";
            this.GestionVoitureView.Size = new System.Drawing.Size(140, 56);
            this.GestionVoitureView.TabIndex = 2;
            this.GestionVoitureView.Text = "Gestion Voitures";
            this.GestionVoitureView.UseVisualStyleBackColor = true;
            this.GestionVoitureView.Click += new System.EventHandler(this.GestionVoitureView_Click);
            // 
            // GestionClientView
            // 
            this.GestionClientView.Location = new System.Drawing.Point(485, 190);
            this.GestionClientView.Name = "GestionClientView";
            this.GestionClientView.Size = new System.Drawing.Size(140, 56);
            this.GestionClientView.TabIndex = 3;
            this.GestionClientView.Text = "Gestion Clients";
            this.GestionClientView.UseVisualStyleBackColor = true;
            this.GestionClientView.Click += new System.EventHandler(this.GestionClientView_Click);
            // 
            // GestionLocationView
            // 
            this.GestionLocationView.Location = new System.Drawing.Point(680, 190);
            this.GestionLocationView.Name = "GestionLocationView";
            this.GestionLocationView.Size = new System.Drawing.Size(140, 56);
            this.GestionLocationView.TabIndex = 4;
            this.GestionLocationView.Text = "Gestion Location";
            this.GestionLocationView.UseVisualStyleBackColor = true;
            this.GestionLocationView.Click += new System.EventHandler(this.GestionLocationView_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Voiture.Properties.Resources.agence;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(926, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(112, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to agence Souhe ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(926, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GestionAgenceView);
            this.Controls.Add(this.GestionVoitureView);
            this.Controls.Add(this.GestionClientView);
            this.Controls.Add(this.GestionLocationView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GestionAgenceView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienToolStripMenuItem;
        private System.Windows.Forms.Button GestionVoitureView;
        private System.Windows.Forms.Button GestionClientView;
        private System.Windows.Forms.Button GestionLocationView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}