namespace vue
{
    partial class ajouter_etatcolis
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codecolis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse_clt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_clt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desgiation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateajout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 100);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label14.Location = new System.Drawing.Point(704, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 29);
            this.label14.TabIndex = 15;
            this.label14.Text = "xyz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Location = new System.Drawing.Point(704, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bonjour Adiminstrateur";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 595);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(212, 462);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 25;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(53, 505);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 16);
            this.label18.TabIndex = 24;
            this.label18.Text = "commentaire de livreur";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 505);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(157, 470);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "liveur";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ajouter l\'etat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 423);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "choisir un nouvelle etat ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 420);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(694, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "choisir l\'etat actuel";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(846, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.codecolis,
            this.nom_client,
            this.adresse_clt,
            this.tel_clt,
            this.prix,
            this.desgiation,
            this.Dateajout});
            this.dataGridView1.Location = new System.Drawing.Point(18, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 170);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // selected
            // 
            this.selected.HeaderText = "selected";
            this.selected.MinimumWidth = 6;
            this.selected.Name = "selected";
            this.selected.Width = 125;
            // 
            // codecolis
            // 
            this.codecolis.HeaderText = "Code";
            this.codecolis.MinimumWidth = 6;
            this.codecolis.Name = "codecolis";
            this.codecolis.Width = 125;
            // 
            // nom_client
            // 
            this.nom_client.HeaderText = "Nom Client";
            this.nom_client.MinimumWidth = 6;
            this.nom_client.Name = "nom_client";
            this.nom_client.Width = 125;
            // 
            // adresse_clt
            // 
            this.adresse_clt.HeaderText = "Adresse Client";
            this.adresse_clt.MinimumWidth = 6;
            this.adresse_clt.Name = "adresse_clt";
            this.adresse_clt.Width = 125;
            // 
            // tel_clt
            // 
            this.tel_clt.HeaderText = "Numero de telephone Client";
            this.tel_clt.MinimumWidth = 6;
            this.tel_clt.Name = "tel_clt";
            this.tel_clt.Width = 125;
            // 
            // prix
            // 
            this.prix.HeaderText = "prix";
            this.prix.MinimumWidth = 6;
            this.prix.Name = "prix";
            this.prix.Width = 125;
            // 
            // desgiation
            // 
            this.desgiation.HeaderText = "desiation";
            this.desgiation.MinimumWidth = 6;
            this.desgiation.Name = "desgiation";
            this.desgiation.Width = 125;
            // 
            // Dateajout
            // 
            this.Dateajout.HeaderText = "Date d\'ajout";
            this.Dateajout.MinimumWidth = 6;
            this.Dateajout.Name = "Dateajout";
            this.Dateajout.Width = 125;
            // 
            // ajouter_etatcolis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 595);
            this.Controls.Add(this.panel1);
            this.Name = "ajouter_etatcolis";
            this.Text = "ajouter_etatcolis";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn codecolis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse_clt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_clt;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn desgiation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateajout;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}