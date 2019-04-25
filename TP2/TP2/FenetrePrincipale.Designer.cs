namespace TP2
{
    partial class FenetrePrincipale
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
            this.MappeMonde = new TP2.Map();
            this.SuspendLayout();
            // 
            // MappeMonde
            // 
            this.MappeMonde.Location = new System.Drawing.Point(0, 33);
            this.MappeMonde.Name = "MappeMonde";
            this.MappeMonde.Size = new System.Drawing.Size(1376, 832);
            this.MappeMonde.TabIndex = 0;
            this.MappeMonde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MappeMonde_KeyDown);
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 918);
            this.Controls.Add(this.MappeMonde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP2";
            this.ResumeLayout(false);

        }

        #endregion

        private Map MappeMonde;
    }
}

