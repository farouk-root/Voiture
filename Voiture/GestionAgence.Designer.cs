namespace Voiture
{
    partial class GestionAgence
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
            this.components = new System.ComponentModel.Container();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Dernier = new System.Windows.Forms.Button();
            this.Precedant = new System.Windows.Forms.Button();
            this.Suivant = new System.Windows.Forms.Button();
            this.Debut = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_localisation = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom_agence = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDAGENCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMAGENCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGENCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vOITUREDataSet = new Voiture.VOITUREDataSet();
            this.aGENCETableAdapter = new Voiture.VOITUREDataSetTableAdapters.AGENCETableAdapter();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOITUREDataSet)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.OldLace;
            this.panel6.Controls.Add(this.Dernier);
            this.panel6.Controls.Add(this.Precedant);
            this.panel6.Controls.Add(this.Suivant);
            this.panel6.Controls.Add(this.Debut);
            this.panel6.Controls.Add(this.Supprimer);
            this.panel6.Controls.Add(this.Modifier);
            this.panel6.Controls.Add(this.Enregistrer);
            this.panel6.Controls.Add(this.Nouveau);
            this.panel6.Location = new System.Drawing.Point(634, 573);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(542, 171);
            this.panel6.TabIndex = 24;
            // 
            // Dernier
            // 
            this.Dernier.BackColor = System.Drawing.Color.HotPink;
            this.Dernier.Location = new System.Drawing.Point(409, 101);
            this.Dernier.Name = "Dernier";
            this.Dernier.Size = new System.Drawing.Size(92, 40);
            this.Dernier.TabIndex = 21;
            this.Dernier.Text = "Dernier";
            this.Dernier.UseVisualStyleBackColor = false;
            this.Dernier.Click += new System.EventHandler(this.Dernier_Click);
            // 
            // Precedant
            // 
            this.Precedant.BackColor = System.Drawing.Color.HotPink;
            this.Precedant.Location = new System.Drawing.Point(286, 101);
            this.Precedant.Name = "Precedant";
            this.Precedant.Size = new System.Drawing.Size(92, 40);
            this.Precedant.TabIndex = 20;
            this.Precedant.Text = "Precedant";
            this.Precedant.UseVisualStyleBackColor = false;
            this.Precedant.Click += new System.EventHandler(this.Precedant_Click);
            // 
            // Suivant
            // 
            this.Suivant.BackColor = System.Drawing.Color.HotPink;
            this.Suivant.Location = new System.Drawing.Point(162, 101);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(92, 40);
            this.Suivant.TabIndex = 19;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = false;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Debut
            // 
            this.Debut.BackColor = System.Drawing.Color.HotPink;
            this.Debut.Location = new System.Drawing.Point(34, 101);
            this.Debut.Name = "Debut";
            this.Debut.Size = new System.Drawing.Size(92, 40);
            this.Debut.TabIndex = 18;
            this.Debut.Text = "Debut";
            this.Debut.UseVisualStyleBackColor = false;
            this.Debut.Click += new System.EventHandler(this.Debut_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.HotPink;
            this.Supprimer.Location = new System.Drawing.Point(409, 29);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(88, 40);
            this.Supprimer.TabIndex = 17;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.HotPink;
            this.Modifier.Location = new System.Drawing.Point(286, 29);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(84, 40);
            this.Modifier.TabIndex = 16;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.BackColor = System.Drawing.Color.HotPink;
            this.Enregistrer.Location = new System.Drawing.Point(162, 29);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(92, 40);
            this.Enregistrer.TabIndex = 15;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = false;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.BackColor = System.Drawing.Color.HotPink;
            this.Nouveau.Location = new System.Drawing.Point(34, 29);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(92, 40);
            this.Nouveau.TabIndex = 14;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = false;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // txt_telephone
            // 
            this.txt_telephone.BackColor = System.Drawing.Color.OldLace;
            this.txt_telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telephone.Location = new System.Drawing.Point(245, 468);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(204, 38);
            this.txt_telephone.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PeachPuff;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(57, 465);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(165, 46);
            this.panel5.TabIndex = 22;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Voiture.Properties.Resources.telephone;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tel :";
            // 
            // txt_localisation
            // 
            this.txt_localisation.BackColor = System.Drawing.Color.OldLace;
            this.txt_localisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_localisation.Location = new System.Drawing.Point(243, 373);
            this.txt_localisation.Name = "txt_localisation";
            this.txt_localisation.Size = new System.Drawing.Size(204, 38);
            this.txt_localisation.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(55, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 46);
            this.panel4.TabIndex = 20;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Voiture.Properties.Resources.location;
            this.pictureBox4.Location = new System.Drawing.Point(3, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Localisation :";
            // 
            // txt_nom_agence
            // 
            this.txt_nom_agence.BackColor = System.Drawing.Color.OldLace;
            this.txt_nom_agence.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_agence.Location = new System.Drawing.Point(241, 283);
            this.txt_nom_agence.Name = "txt_nom_agence";
            this.txt_nom_agence.Size = new System.Drawing.Size(204, 38);
            this.txt_nom_agence.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(53, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 46);
            this.panel3.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Voiture.Properties.Resources.voiture1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom Agence :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 114);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Voiture.Properties.Resources.voiture;
            this.pictureBox2.Location = new System.Drawing.Point(974, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(310, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 100);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion Agence de voiture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Voiture.Properties.Resources.voiture;
            this.pictureBox1.Location = new System.Drawing.Point(66, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.OldLace;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(245, 550);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(204, 38);
            this.txt_email.TabIndex = 26;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PeachPuff;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(57, 547);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(165, 46);
            this.panel7.TabIndex = 25;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Voiture.Properties.Resources.gmail__1_1;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.HotPink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAGENCEDataGridViewTextBoxColumn,
            this.nOMAGENCEDataGridViewTextBoxColumn,
            this.aDRESSEDataGridViewTextBoxColumn,
            this.nUMTELDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aGENCEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(562, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(614, 239);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // iDAGENCEDataGridViewTextBoxColumn
            // 
            this.iDAGENCEDataGridViewTextBoxColumn.DataPropertyName = "ID_AGENCE";
            this.iDAGENCEDataGridViewTextBoxColumn.HeaderText = "ID_AGENCE";
            this.iDAGENCEDataGridViewTextBoxColumn.Name = "iDAGENCEDataGridViewTextBoxColumn";
            // 
            // nOMAGENCEDataGridViewTextBoxColumn
            // 
            this.nOMAGENCEDataGridViewTextBoxColumn.DataPropertyName = "NOM_AGENCE";
            this.nOMAGENCEDataGridViewTextBoxColumn.HeaderText = "NOM_AGENCE";
            this.nOMAGENCEDataGridViewTextBoxColumn.Name = "nOMAGENCEDataGridViewTextBoxColumn";
            // 
            // aDRESSEDataGridViewTextBoxColumn
            // 
            this.aDRESSEDataGridViewTextBoxColumn.DataPropertyName = "ADRESSE";
            this.aDRESSEDataGridViewTextBoxColumn.HeaderText = "ADRESSE";
            this.aDRESSEDataGridViewTextBoxColumn.Name = "aDRESSEDataGridViewTextBoxColumn";
            // 
            // nUMTELDataGridViewTextBoxColumn
            // 
            this.nUMTELDataGridViewTextBoxColumn.DataPropertyName = "NUM_TEL";
            this.nUMTELDataGridViewTextBoxColumn.HeaderText = "NUM_TEL";
            this.nUMTELDataGridViewTextBoxColumn.Name = "nUMTELDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // aGENCEBindingSource
            // 
            this.aGENCEBindingSource.DataMember = "AGENCE";
            this.aGENCEBindingSource.DataSource = this.vOITUREDataSet;
            // 
            // vOITUREDataSet
            // 
            this.vOITUREDataSet.DataSetName = "VOITUREDataSet";
            this.vOITUREDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aGENCETableAdapter
            // 
            this.aGENCETableAdapter.ClearBeforeFill = true;
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.PowderBlue;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(241, 209);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(204, 38);
            this.txt_ID.TabIndex = 29;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PeachPuff;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.pictureBox7);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(53, 206);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(165, 46);
            this.panel8.TabIndex = 28;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Voiture.Properties.Resources.ID_Ecole;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 46);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID_Agence :";
            // 
            // GestionAgence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 773);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_localisation);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_nom_agence);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "GestionAgence";
            this.Text = "GestionAgence";
            this.Load += new System.EventHandler(this.GestionAgence_Load);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vOITUREDataSet)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Dernier;
        private System.Windows.Forms.Button Precedant;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Debut;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_localisation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom_agence;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VOITUREDataSet vOITUREDataSet;
        private System.Windows.Forms.BindingSource aGENCEBindingSource;
        private VOITUREDataSetTableAdapters.AGENCETableAdapter aGENCETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAGENCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMAGENCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label6;
    }
}