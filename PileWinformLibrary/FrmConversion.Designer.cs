namespace PileWinformLibrary
{
    partial class FrmConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.mskNbAConvertir = new System.Windows.Forms.MaskedTextBox();
            this.nudNouvelleBase = new System.Windows.Forms.NumericUpDown();
            this.btnConversion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNouvelleBase)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Résultat:";
            // 
            // labelNB
            // 
            this.labelNB.AutoSize = true;
            this.labelNB.Location = new System.Drawing.Point(14, 70);
            this.labelNB.Name = "labelNB";
            this.labelNB.Size = new System.Drawing.Size(100, 13);
            this.labelNB.TabIndex = 0;
            this.labelNB.Text = "Nombre à convertir:";
            this.labelNB.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nouvelle base:";
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(98, 221);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(142, 20);
            this.txtResultat.TabIndex = 1;
            // 
            // mskNbAConvertir
            // 
            this.mskNbAConvertir.Location = new System.Drawing.Point(17, 86);
            this.mskNbAConvertir.Mask = "9999999";
            this.mskNbAConvertir.Name = "mskNbAConvertir";
            this.mskNbAConvertir.Size = new System.Drawing.Size(110, 20);
            this.mskNbAConvertir.TabIndex = 2;
            // 
            // nudNouvelleBase
            // 
            this.nudNouvelleBase.Location = new System.Drawing.Point(213, 86);
            this.nudNouvelleBase.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudNouvelleBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNouvelleBase.Name = "nudNouvelleBase";
            this.nudNouvelleBase.Size = new System.Drawing.Size(100, 20);
            this.nudNouvelleBase.TabIndex = 3;
            this.nudNouvelleBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(122, 126);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(92, 44);
            this.btnConversion.TabIndex = 4;
            this.btnConversion.Text = "Convertir";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // FrmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 288);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.nudNouvelleBase);
            this.Controls.Add(this.mskNbAConvertir);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNB);
            this.Controls.Add(this.label1);
            this.Name = "FrmConversion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNouvelleBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.MaskedTextBox mskNbAConvertir;
        private System.Windows.Forms.NumericUpDown nudNouvelleBase;
        private System.Windows.Forms.Button btnConversion;
    }
}

