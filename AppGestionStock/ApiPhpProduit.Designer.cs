namespace AppGestionStock
{
    partial class ApiPhpProduit
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
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(815, 613);
            this.btnEffacer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(130, 51);
            this.btnEffacer.TabIndex = 30;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(651, 613);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(130, 51);
            this.btnChoisir.TabIndex = 29;
            this.btnChoisir.Text = "&Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(471, 613);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(130, 51);
            this.btnSupprimer.TabIndex = 28;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(290, 613);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 51);
            this.btnModifier.TabIndex = 27;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(117, 613);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(130, 51);
            this.btnAjouter.TabIndex = 26;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtPU
            // 
            this.txtPU.Location = new System.Drawing.Point(16, 525);
            this.txtPU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(334, 26);
            this.txtPU.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 475);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Prix Unitaire";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(16, 413);
            this.txtQte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(334, 26);
            this.txtQte.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantite";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(16, 301);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(334, 26);
            this.txtDescription.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(16, 189);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(334, 26);
            this.txtLibelle.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Libelle";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(16, 76);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(334, 26);
            this.txtId.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(416, 72);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 62;
            this.dg.RowTemplate.Height = 28;
            this.dg.Size = new System.Drawing.Size(743, 500);
            this.dg.TabIndex = 32;
            // 
            // ApiPhpProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 678);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Name = "ApiPhpProduit";
            this.Text = "ApiPhpProduit";
            this.Load += new System.EventHandler(this.ApiPhpProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtPU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg;
    }
}