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
            this.TimerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.LblDollarSign = new System.Windows.Forms.Label();
            this.TimerDate = new System.Windows.Forms.Timer(this.components);
            this.BtnAchatLion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.LblPrixLion = new System.Windows.Forms.Label();
            this.LblPrixMoutton = new System.Windows.Forms.Label();
            this.PicMoutton = new System.Windows.Forms.PictureBox();
            this.PicLion = new System.Windows.Forms.PictureBox();
            this.PicDechets = new System.Windows.Forms.PictureBox();
            this.PicAnimal = new System.Windows.Forms.PictureBox();
            this.PicArgent = new System.Windows.Forms.PictureBox();
            this.PicDate = new System.Windows.Forms.PictureBox();
            this.PicGrizzly = new System.Windows.Forms.PictureBox();
            this.PicRhino = new System.Windows.Forms.PictureBox();
            this.PicLicorne = new System.Windows.Forms.PictureBox();
            this.PicBuffalo = new System.Windows.Forms.PictureBox();
            this.LblPrixGrizzly = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicMoutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDechets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicArgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGrizzly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRhino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicorne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBuffalo)).BeginInit();
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
            // BtnAchatLion
            // 
            this.BtnAchatLion.Location = new System.Drawing.Point(1414, 146);
            this.BtnAchatLion.Name = "BtnAchatLion";
            this.BtnAchatLion.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatLion.TabIndex = 11;
            this.BtnAchatLion.Text = "Acheter un lion";
            this.BtnAchatLion.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1414, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Acheter un moutton";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1415, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Acheter un grizzly";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1414, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Acheter un rhinocéros";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1414, 666);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Acheter une licorne";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1414, 796);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Acheter un buffle";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // LblPrixLion
            // 
            this.LblPrixLion.AutoSize = true;
            this.LblPrixLion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixLion.Location = new System.Drawing.Point(1506, 92);
            this.LblPrixLion.Name = "LblPrixLion";
            this.LblPrixLion.Size = new System.Drawing.Size(44, 20);
            this.LblPrixLion.TabIndex = 18;
            this.LblPrixLion.Text = "35 $";
            // 
            // LblPrixMoutton
            // 
            this.LblPrixMoutton.AutoSize = true;
            this.LblPrixMoutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixMoutton.Location = new System.Drawing.Point(1506, 221);
            this.LblPrixMoutton.Name = "LblPrixMoutton";
            this.LblPrixMoutton.Size = new System.Drawing.Size(44, 20);
            this.LblPrixMoutton.TabIndex = 20;
            this.LblPrixMoutton.Text = "20 $";
            // 
            // PicMoutton
            // 
            this.PicMoutton.Image = global::TP2.Properties.Resources.sheep;
            this.PicMoutton.Location = new System.Drawing.Point(1414, 180);
            this.PicMoutton.Name = "PicMoutton";
            this.PicMoutton.Size = new System.Drawing.Size(90, 90);
            this.PicMoutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMoutton.TabIndex = 19;
            this.PicMoutton.TabStop = false;
            // 
            // PicLion
            // 
            this.PicLion.Image = global::TP2.Properties.Resources.lion1;
            this.PicLion.Location = new System.Drawing.Point(1414, 50);
            this.PicLion.Name = "PicLion";
            this.PicLion.Size = new System.Drawing.Size(90, 90);
            this.PicLion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLion.TabIndex = 17;
            this.PicLion.TabStop = false;
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
            // PicGrizzly
            // 
            this.PicGrizzly.Image = global::TP2.Properties.Resources.grizzly;
            this.PicGrizzly.Location = new System.Drawing.Point(1414, 310);
            this.PicGrizzly.Name = "PicGrizzly";
            this.PicGrizzly.Size = new System.Drawing.Size(90, 90);
            this.PicGrizzly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicGrizzly.TabIndex = 21;
            this.PicGrizzly.TabStop = false;
            // 
            // PicRhino
            // 
            this.PicRhino.Image = global::TP2.Properties.Resources.rhino;
            this.PicRhino.Location = new System.Drawing.Point(1415, 440);
            this.PicRhino.Name = "PicRhino";
            this.PicRhino.Size = new System.Drawing.Size(90, 90);
            this.PicRhino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicRhino.TabIndex = 22;
            this.PicRhino.TabStop = false;
            // 
            // PicLicorne
            // 
            this.PicLicorne.Image = global::TP2.Properties.Resources.licorne;
            this.PicLicorne.Location = new System.Drawing.Point(1414, 570);
            this.PicLicorne.Name = "PicLicorne";
            this.PicLicorne.Size = new System.Drawing.Size(90, 90);
            this.PicLicorne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLicorne.TabIndex = 23;
            this.PicLicorne.TabStop = false;
            // 
            // PicBuffalo
            // 
            this.PicBuffalo.Image = global::TP2.Properties.Resources.buffalo;
            this.PicBuffalo.Location = new System.Drawing.Point(1414, 700);
            this.PicBuffalo.Name = "PicBuffalo";
            this.PicBuffalo.Size = new System.Drawing.Size(90, 90);
            this.PicBuffalo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBuffalo.TabIndex = 24;
            this.PicBuffalo.TabStop = false;
            // 
            // LblPrixGrizzly
            // 
            this.LblPrixGrizzly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixGrizzly.Location = new System.Drawing.Point(1506, 347);
            this.LblPrixGrizzly.Name = "LblPrixGrizzly";
            this.LblPrixGrizzly.Size = new System.Drawing.Size(44, 20);
            this.LblPrixGrizzly.TabIndex = 0;
            this.LblPrixGrizzly.Text = "30 $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1507, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "40 $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1506, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "50 $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1506, 737);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "40 $";
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 938);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblPrixGrizzly);
            this.Controls.Add(this.PicBuffalo);
            this.Controls.Add(this.PicLicorne);
            this.Controls.Add(this.PicRhino);
            this.Controls.Add(this.PicGrizzly);
            this.Controls.Add(this.LblPrixMoutton);
            this.Controls.Add(this.PicMoutton);
            this.Controls.Add(this.LblPrixLion);
            this.Controls.Add(this.PicLion);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAchatLion);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP2";
            ((System.ComponentModel.ISupportInitialize)(this.PicMoutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDechets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicArgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGrizzly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRhino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicorne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBuffalo)).EndInit();
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
        private System.Windows.Forms.Button BtnAchatLion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox PicLion;
        private System.Windows.Forms.Label LblPrixLion;
        private System.Windows.Forms.PictureBox PicMoutton;
        private System.Windows.Forms.Label LblPrixMoutton;
        private System.Windows.Forms.PictureBox PicGrizzly;
        private System.Windows.Forms.PictureBox PicRhino;
        private System.Windows.Forms.PictureBox PicLicorne;
        private System.Windows.Forms.PictureBox PicBuffalo;
        private System.Windows.Forms.Label LblPrixGrizzly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

