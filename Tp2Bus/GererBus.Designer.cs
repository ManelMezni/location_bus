namespace Tp2Bus
{
    partial class GererBus
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnChercher = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrixJour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpachat = new System.Windows.Forms.DateTimePicker();
            this.txtPrixAchat = new System.Windows.Forms.TextBox();
            this.txtCapacite = new System.Windows.Forms.TextBox();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtImmat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvBus = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-65, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 29);
            this.label6.TabIndex = 47;
            this.label6.Text = "qt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-65, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 29);
            this.label8.TabIndex = 45;
            this.label8.Text = "ref";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.Green;
            this.btnEnregistrer.Location = new System.Drawing.Point(566, 216);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(252, 46);
            this.btnEnregistrer.TabIndex = 52;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnChercher
            // 
            this.btnChercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercher.Location = new System.Drawing.Point(566, 148);
            this.btnChercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(252, 46);
            this.btnChercher.TabIndex = 51;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPrixJour);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpachat);
            this.panel1.Controls.Add(this.txtPrixAchat);
            this.panel1.Controls.Add(this.txtCapacite);
            this.panel1.Controls.Add(this.txtMarque);
            this.panel1.Controls.Add(this.txtImmat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(167, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 260);
            this.panel1.TabIndex = 50;
            // 
            // txtPrixJour
            // 
            this.txtPrixJour.Location = new System.Drawing.Point(200, 204);
            this.txtPrixJour.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixJour.Name = "txtPrixJour";
            this.txtPrixJour.Size = new System.Drawing.Size(175, 30);
            this.txtPrixJour.TabIndex = 11;
            this.txtPrixJour.Text = "0,0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prix Loc Jour";
            // 
            // dtpachat
            // 
            this.dtpachat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpachat.Location = new System.Drawing.Point(199, 86);
            this.dtpachat.Margin = new System.Windows.Forms.Padding(4);
            this.dtpachat.Name = "dtpachat";
            this.dtpachat.Size = new System.Drawing.Size(175, 30);
            this.dtpachat.TabIndex = 9;
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
            // txtCapacite
            // 
            this.txtCapacite.Location = new System.Drawing.Point(197, 126);
            this.txtCapacite.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(176, 30);
            this.txtCapacite.TabIndex = 7;
            this.txtCapacite.Text = "10";
            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(199, 48);
            this.txtMarque.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(177, 30);
            this.txtMarque.TabIndex = 6;
            // 
            // txtImmat
            // 
            this.txtImmat.Location = new System.Drawing.Point(199, 10);
            this.txtImmat.Margin = new System.Windows.Forms.Padding(4);
            this.txtImmat.Name = "txtImmat";
            this.txtImmat.Size = new System.Drawing.Size(179, 30);
            this.txtImmat.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prix achat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date d\'achat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nbre place";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marque";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Immatricumation";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(566, 72);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(252, 46);
            this.btnAjouter.TabIndex = 49;
            this.btnAjouter.Text = "Nouveau";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvBus
            // 
            this.dgvBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBus.Location = new System.Drawing.Point(166, 303);
            this.dgvBus.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBus.Name = "dgvBus";
            this.dgvBus.RowHeadersWidth = 51;
            this.dgvBus.Size = new System.Drawing.Size(703, 181);
            this.dgvBus.TabIndex = 48;
            // 
            // GererBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 512);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvBus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Name = "GererBus";
            this.Text = "Gerer Bus";
            this.Load += new System.EventHandler(this.GererBus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrixJour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpachat;
        private System.Windows.Forms.TextBox txtPrixAchat;
        private System.Windows.Forms.TextBox txtCapacite;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.TextBox txtImmat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvBus;
    }
}

