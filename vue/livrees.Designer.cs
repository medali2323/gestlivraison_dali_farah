namespace vue
{
    partial class livrees
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codecolis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse_clt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_clt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desgiation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateajout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datelivraison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codecolis,
            this.nom_client,
            this.adresse_clt,
            this.tel_clt,
            this.prix,
            this.desgiation,
            this.Dateajout,
            this.datelivraison,
            this.etat});
            this.dataGridView1.Location = new System.Drawing.Point(-197, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 375);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // datelivraison
            // 
            this.datelivraison.HeaderText = "date de livraison";
            this.datelivraison.MinimumWidth = 6;
            this.datelivraison.Name = "datelivraison";
            this.datelivraison.Width = 125;
            // 
            // etat
            // 
            this.etat.HeaderText = "etat";
            this.etat.MinimumWidth = 6;
            this.etat.Name = "etat";
            this.etat.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // livrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "livrees";
            this.Text = "livrees";
            this.Load += new System.EventHandler(this.livrees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codecolis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse_clt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_clt;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn desgiation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateajout;
        private System.Windows.Forms.DataGridViewTextBoxColumn datelivraison;
        private System.Windows.Forms.DataGridViewTextBoxColumn etat;
        private System.Windows.Forms.Label label1;
    }
}