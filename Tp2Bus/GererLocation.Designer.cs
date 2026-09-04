namespace Tp2Bus
{
    partial class GererLocation
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnChercher = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRecherche = new System.Windows.Forms.DateTimePicker();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.txtPrixAchat = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvLocation = new System.Windows.Forms.DataGridView();
            this.btnchercherBus = new System.Windows.Forms.Button();
            this.dgvLocations = new System.Windows.Forms.DataGridView();
            this.DateLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.immatBus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFinLoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.Green;
            this.btnEnregistrer.Location = new System.Drawing.Point(411, 169);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(252, 46);
            this.btnEnregistrer.TabIndex = 57;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click_1);
            // 
            // btnChercher
            // 
            this.btnChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercher.Location = new System.Drawing.Point(411, 101);
            this.btnChercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(252, 46);
            this.btnChercher.TabIndex = 56;
            this.btnChercher.Text = "Chercher d\'un jour";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpRecherche);
            this.panel1.Controls.Add(this.cmbBus);
            this.panel1.Controls.Add(this.dtpDebut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.txtPrixAchat);
            this.panel1.Controls.Add(this.txtClient);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 260);
            this.panel1.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "chercher";
            // 
            // dtpRecherche
            // 
            this.dtpRecherche.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpRecherche.Location = new System.Drawing.Point(139, 10);
            this.dtpRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRecherche.Name = "dtpRecherche";
            this.dtpRecherche.Size = new System.Drawing.Size(237, 30);
            this.dtpRecherche.TabIndex = 14;
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(215, 207);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(121, 33);
            this.cmbBus.TabIndex = 13;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebut.Location = new System.Drawing.Point(199, 124);
            this.dtpDebut.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(175, 30);
            this.dtpDebut.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "bus";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(199, 86);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(175, 30);
            this.dtpFin.TabIndex = 9;
            // 
            // txtPrixAchat
            // 
            this.txtPrixAchat.Location = new System.Drawing.Point(199, 165);
            this.txtPrixAchat.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixAchat.Name = "txtPrixAchat";
            this.txtPrixAchat.Size = new System.Drawing.Size(175, 30);
            this.txtPrixAchat.TabIndex = 8;
            this.txtPrixAchat.Text = "0,0";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(199, 48);
            this.txtClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(177, 30);
            this.txtClient.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "motant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "dateDeb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "client";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(411, 25);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(252, 46);
            this.btnAjouter.TabIndex = 54;
            this.btnAjouter.Text = "Nouveau";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // dgvLocation
            // 
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocation.Location = new System.Drawing.Point(13, 307);
            this.dgvLocation.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.RowHeadersWidth = 51;
            this.dgvLocation.Size = new System.Drawing.Size(549, 213);
            this.dgvLocation.TabIndex = 53;
            // 
            // btnchercherBus
            // 
            this.btnchercherBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchercherBus.Location = new System.Drawing.Point(411, 233);
            this.btnchercherBus.Margin = new System.Windows.Forms.Padding(4);
            this.btnchercherBus.Name = "btnchercherBus";
            this.btnchercherBus.Size = new System.Drawing.Size(252, 46);
            this.btnchercherBus.TabIndex = 58;
            this.btnchercherBus.Text = "Chercher d\'un bus";
            this.btnchercherBus.UseVisualStyleBackColor = true;
            this.btnchercherBus.Click += new System.EventHandler(this.btnchercherBus_Click_1);
            // 
            // dgvLocations
            // 
            this.dgvLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateLoc,
            this.immatBus,
            this.DateFinLoc,
            this.Montant,
            this.Client});
            this.dgvLocations.Location = new System.Drawing.Point(670, 79);
            this.dgvLocations.Name = "dgvLocations";
            this.dgvLocations.RowHeadersWidth = 51;
            this.dgvLocations.RowTemplate.Height = 24;
            this.dgvLocations.Size = new System.Drawing.Size(703, 162);
            this.dgvLocations.TabIndex = 82;
            // 
            // DateLoc
            // 
            this.DateLoc.HeaderText = "Date Loc";
            this.DateLoc.MinimumWidth = 6;
            this.DateLoc.Name = "DateLoc";
            this.DateLoc.Width = 125;
            // 
            // immatBus
            // 
            this.immatBus.HeaderText = "Immat";
            this.immatBus.MinimumWidth = 6;
            this.immatBus.Name = "immatBus";
            this.immatBus.Width = 125;
            // 
            // DateFinLoc
            // 
            this.DateFinLoc.HeaderText = "Date Fin Loc";
            this.DateFinLoc.MinimumWidth = 6;
            this.DateFinLoc.Name = "DateFinLoc";
            this.DateFinLoc.Width = 125;
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.MinimumWidth = 6;
            this.Montant.Name = "Montant";
            this.Montant.Width = 125;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.Width = 125;
            // 
            // GererLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 560);
            this.Controls.Add(this.dgvLocations);
            this.Controls.Add(this.btnchercherBus);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvLocation);
            this.Name = "GererLocation";
            this.Text = "GererLocation";
            this.Load += new System.EventHandler(this.GererLocation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.TextBox txtPrixAchat;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvLocation;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Button btnchercherBus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRecherche;
        private System.Windows.Forms.DataGridView dgvLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn immatBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFinLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
    }
}