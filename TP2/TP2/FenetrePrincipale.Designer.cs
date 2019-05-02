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
            this.components = new System.ComponentModel.Container();
            this.MappeMonde = new TP2.Map();
            this.LblArgent = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDechets = new System.Windows.Forms.Label();
            this.LblAnimal = new System.Windows.Forms.Label();
            this.GrpInfo = new System.Windows.Forms.GroupBox();
            this.PicArgent = new System.Windows.Forms.PictureBox();
            this.PicDate = new System.Windows.Forms.PictureBox();
            this.PicAnimal = new System.Windows.Forms.PictureBox();
            this.PicDechets = new System.Windows.Forms.PictureBox();
            this.TimerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.LblDollarSign = new System.Windows.Forms.Label();
            this.TimerDate = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicArgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDechets)).BeginInit();
            this.SuspendLayout();
            // 
            // MappeMonde
            // 
            this.MappeMonde.Location = new System.Drawing.Point(0, 50);
            this.MappeMonde.Name = "MappeMonde";
            this.MappeMonde.Size = new System.Drawing.Size(1376, 832);
            this.MappeMonde.TabIndex = 0;
            this.MappeMonde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MappeMonde_KeyDown);
            // 
            // LblArgent
            // 
            this.LblArgent.AutoSize = true;
            this.LblArgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArgent.Location = new System.Drawing.Point(297, 18);
            this.LblArgent.Name = "LblArgent";
            this.LblArgent.Size = new System.Drawing.Size(39, 20);
            this.LblArgent.TabIndex = 1;
            this.LblArgent.Text = "100";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(59, 18);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(180, 20);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "Date : 1 Janvier 2019";
            // 
            // LblDechets
            // 
            this.LblDechets.AutoSize = true;
            this.LblDechets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDechets.Location = new System.Drawing.Point(635, 18);
            this.LblDechets.Name = "LblDechets";
            this.LblDechets.Size = new System.Drawing.Size(101, 20);
            this.LblDechets.TabIndex = 3;
            this.LblDechets.Text = "Dechets : 0";
            // 
            // LblAnimal
            // 
            this.LblAnimal.AutoSize = true;
            this.LblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnimal.Location = new System.Drawing.Point(437, 18);
            this.LblAnimal.Name = "LblAnimal";
            this.LblAnimal.Size = new System.Drawing.Size(102, 20);
            this.LblAnimal.TabIndex = 4;
            this.LblAnimal.Text = "Animaux : 0";
            // 
            // GrpInfo
            // 
            this.GrpInfo.Location = new System.Drawing.Point(0, 847);
            this.GrpInfo.Name = "GrpInfo";
            this.GrpInfo.Size = new System.Drawing.Size(1582, 91);
            this.GrpInfo.TabIndex = 5;
            this.GrpInfo.TabStop = false;
            this.GrpInfo.Text = "Informations";
            // 
            // PicArgent
            // 
            this.PicArgent.Image = global::TP2.Properties.Resources.money_stack;
            this.PicArgent.Location = new System.Drawing.Point(250, 6);
            this.PicArgent.Name = "PicArgent";
            this.PicArgent.Size = new System.Drawing.Size(41, 41);
            this.PicArgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicArgent.TabIndex = 7;
            this.PicArgent.TabStop = false;
            // 
            // PicDate
            // 
            this.PicDate.Image = global::TP2.Properties.Resources.calendar;
            this.PicDate.Location = new System.Drawing.Point(12, 6);
            this.PicDate.Name = "PicDate";
            this.PicDate.Size = new System.Drawing.Size(41, 41);
            this.PicDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDate.TabIndex = 6;
            this.PicDate.TabStop = false;
            // 
            // PicAnimal
            // 
            this.PicAnimal.Image = global::TP2.Properties.Resources.animal_logo;
            this.PicAnimal.Location = new System.Drawing.Point(390, 6);
            this.PicAnimal.Name = "PicAnimal";
            this.PicAnimal.Size = new System.Drawing.Size(41, 41);
            this.PicAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAnimal.TabIndex = 8;
            this.PicAnimal.TabStop = false;
            // 
            // PicDechets
            // 
            this.PicDechets.Image = global::TP2.Properties.Resources.trashcan;
            this.PicDechets.Location = new System.Drawing.Point(588, 6);
            this.PicDechets.Name = "PicDechets";
            this.PicDechets.Size = new System.Drawing.Size(41, 41);
            this.PicDechets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDechets.TabIndex = 9;
            this.PicDechets.TabStop = false;
            // 
            // TimerPrincipal
            // 
            this.TimerPrincipal.Enabled = true;
            this.TimerPrincipal.Interval = 1000;
            this.TimerPrincipal.Tick += new System.EventHandler(this.TimerPrincipal_Tick);
            // 
            // LblDollarSign
            // 
            this.LblDollarSign.AutoSize = true;
            this.LblDollarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDollarSign.Location = new System.Drawing.Point(342, 18);
            this.LblDollarSign.Name = "LblDollarSign";
            this.LblDollarSign.Size = new System.Drawing.Size(19, 20);
            this.LblDollarSign.TabIndex = 10;
            this.LblDollarSign.Text = "$";
            // 
            // TimerDate
            // 
            this.TimerDate.Enabled = true;
            this.TimerDate.Interval = 820;
            this.TimerDate.Tick += new System.EventHandler(this.TimerDate_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1404, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1444, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1429, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1480, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 938);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblDollarSign);
            this.Controls.Add(this.PicDechets);
            this.Controls.Add(this.PicAnimal);
            this.Controls.Add(this.PicArgent);
            this.Controls.Add(this.PicDate);
            this.Controls.Add(this.GrpInfo);
            this.Controls.Add(this.LblAnimal);
            this.Controls.Add(this.LblDechets);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblArgent);
            this.Controls.Add(this.MappeMonde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP2";
            ((System.ComponentModel.ISupportInitialize)(this.PicArgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDechets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Map MappeMonde;
        private System.Windows.Forms.Label LblArgent;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblDechets;
        private System.Windows.Forms.Label LblAnimal;
        private System.Windows.Forms.GroupBox GrpInfo;
        private System.Windows.Forms.PictureBox PicDate;
        private System.Windows.Forms.PictureBox PicArgent;
        private System.Windows.Forms.PictureBox PicAnimal;
        private System.Windows.Forms.PictureBox PicDechets;
        private System.Windows.Forms.Timer TimerPrincipal;
        private System.Windows.Forms.Label LblDollarSign;
        private System.Windows.Forms.Timer TimerDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

