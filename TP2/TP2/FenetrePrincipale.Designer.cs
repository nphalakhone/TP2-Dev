using System.Windows.Forms;

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
            this.LblArgent = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDechets = new System.Windows.Forms.Label();
            this.LblAnimal = new System.Windows.Forms.Label();
            this.GrpInfo = new System.Windows.Forms.GroupBox();
            this.TimerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.LblDollarSign = new System.Windows.Forms.Label();
            this.BtnAchatLion = new System.Windows.Forms.Button();
            this.BtnAchatMouton = new System.Windows.Forms.Button();
            this.BtnAchatGrizzly = new System.Windows.Forms.Button();
            this.BtnAchatRhino = new System.Windows.Forms.Button();
            this.BtnAchatLicorne = new System.Windows.Forms.Button();
            this.BtnAchatBuffle = new System.Windows.Forms.Button();
            this.LblPrixLion = new System.Windows.Forms.Label();
            this.LblPrixMouton = new System.Windows.Forms.Label();
            this.PicMouton = new System.Windows.Forms.PictureBox();
            this.PicLion = new System.Windows.Forms.PictureBox();
            this.PicDechets = new System.Windows.Forms.PictureBox();
            this.PicAnimal = new System.Windows.Forms.PictureBox();
            this.PicArgent = new System.Windows.Forms.PictureBox();
            this.PicDate = new System.Windows.Forms.PictureBox();
            this.PicGrizzly = new System.Windows.Forms.PictureBox();
            this.PicRhino = new System.Windows.Forms.PictureBox();
            this.PicLicorne = new System.Windows.Forms.PictureBox();
            this.PicBuffle = new System.Windows.Forms.PictureBox();
            this.LblPrixGrizzly = new System.Windows.Forms.Label();
            this.LblPrixRhino = new System.Windows.Forms.Label();
            this.LblPrixLicorne = new System.Windows.Forms.Label();
            this.LblPrixBuffle = new System.Windows.Forms.Label();
            this.TimerVisiteurEtConcierge = new System.Windows.Forms.Timer(this.components);
            this.TimerAnimaux = new System.Windows.Forms.Timer(this.components);
            this.BtnEngageConcierge = new System.Windows.Forms.Button();
            this.PicConcierge = new System.Windows.Forms.PictureBox();
            this.LblInfoConcierge = new System.Windows.Forms.Label();
            this.MappeMonde = new TP2.Map();
            ((System.ComponentModel.ISupportInitialize)(this.PicMouton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDechets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicArgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGrizzly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRhino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicorne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConcierge)).BeginInit();
            this.SuspendLayout();
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
            this.LblDate.Size = new System.Drawing.Size(126, 20);
            this.LblDate.TabIndex = 2;
            this.LblDate.Text = "1 Janvier 2019";
            // 
            // LblDechets
            // 
            this.LblDechets.AutoSize = true;
            this.LblDechets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDechets.Location = new System.Drawing.Point(680, 18);
            this.LblDechets.Name = "LblDechets";
            this.LblDechets.Size = new System.Drawing.Size(101, 20);
            this.LblDechets.TabIndex = 3;
            this.LblDechets.Text = "Dechets : 0";
            // 
            // LblAnimal
            // 
            this.LblAnimal.AutoSize = true;
            this.LblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnimal.Location = new System.Drawing.Point(468, 18);
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
            // BtnAchatLion
            // 
            this.BtnAchatLion.Location = new System.Drawing.Point(1414, 146);
            this.BtnAchatLion.Name = "BtnAchatLion";
            this.BtnAchatLion.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatLion.TabIndex = 11;
            this.BtnAchatLion.Text = "Acheter un lion";
            this.BtnAchatLion.UseVisualStyleBackColor = true;
            // 
            // BtnAchatMouton
            // 
            this.BtnAchatMouton.Location = new System.Drawing.Point(1414, 276);
            this.BtnAchatMouton.Name = "BtnAchatMouton";
            this.BtnAchatMouton.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatMouton.TabIndex = 12;
            this.BtnAchatMouton.Text = "Acheter un mouton";
            this.BtnAchatMouton.UseVisualStyleBackColor = true;
            // 
            // BtnAchatGrizzly
            // 
            this.BtnAchatGrizzly.Location = new System.Drawing.Point(1415, 406);
            this.BtnAchatGrizzly.Name = "BtnAchatGrizzly";
            this.BtnAchatGrizzly.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatGrizzly.TabIndex = 13;
            this.BtnAchatGrizzly.Text = "Acheter un grizzly";
            this.BtnAchatGrizzly.UseVisualStyleBackColor = true;
            // 
            // BtnAchatRhino
            // 
            this.BtnAchatRhino.Location = new System.Drawing.Point(1414, 536);
            this.BtnAchatRhino.Name = "BtnAchatRhino";
            this.BtnAchatRhino.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatRhino.TabIndex = 14;
            this.BtnAchatRhino.Text = "Acheter un rhinocéros";
            this.BtnAchatRhino.UseVisualStyleBackColor = true;
            // 
            // BtnAchatLicorne
            // 
            this.BtnAchatLicorne.Location = new System.Drawing.Point(1414, 666);
            this.BtnAchatLicorne.Name = "BtnAchatLicorne";
            this.BtnAchatLicorne.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatLicorne.TabIndex = 15;
            this.BtnAchatLicorne.Text = "Acheter une licorne";
            this.BtnAchatLicorne.UseVisualStyleBackColor = true;
            // 
            // BtnAchatBuffle
            // 
            this.BtnAchatBuffle.Location = new System.Drawing.Point(1414, 796);
            this.BtnAchatBuffle.Name = "BtnAchatBuffle";
            this.BtnAchatBuffle.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatBuffle.TabIndex = 16;
            this.BtnAchatBuffle.Text = "Acheter un buffle";
            this.BtnAchatBuffle.UseVisualStyleBackColor = true;
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
            // LblPrixMouton
            // 
            this.LblPrixMouton.AutoSize = true;
            this.LblPrixMouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixMouton.Location = new System.Drawing.Point(1506, 221);
            this.LblPrixMouton.Name = "LblPrixMouton";
            this.LblPrixMouton.Size = new System.Drawing.Size(44, 20);
            this.LblPrixMouton.TabIndex = 20;
            this.LblPrixMouton.Text = "20 $";
            // 
            // PicMouton
            // 
            this.PicMouton.Image = global::TP2.Properties.Resources.sheep;
            this.PicMouton.Location = new System.Drawing.Point(1414, 180);
            this.PicMouton.Name = "PicMouton";
            this.PicMouton.Size = new System.Drawing.Size(90, 90);
            this.PicMouton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMouton.TabIndex = 19;
            this.PicMouton.TabStop = false;
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
            this.PicDechets.Location = new System.Drawing.Point(633, 6);
            this.PicDechets.Name = "PicDechets";
            this.PicDechets.Size = new System.Drawing.Size(41, 41);
            this.PicDechets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicDechets.TabIndex = 9;
            this.PicDechets.TabStop = false;
            // 
            // PicAnimal
            // 
            this.PicAnimal.Image = global::TP2.Properties.Resources.animal_logo;
            this.PicAnimal.Location = new System.Drawing.Point(421, 6);
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
            // PicBuffle
            // 
            this.PicBuffle.Image = global::TP2.Properties.Resources.buffalo;
            this.PicBuffle.Location = new System.Drawing.Point(1414, 700);
            this.PicBuffle.Name = "PicBuffle";
            this.PicBuffle.Size = new System.Drawing.Size(90, 90);
            this.PicBuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBuffle.TabIndex = 24;
            this.PicBuffle.TabStop = false;
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
            // LblPrixRhino
            // 
            this.LblPrixRhino.AutoSize = true;
            this.LblPrixRhino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixRhino.Location = new System.Drawing.Point(1507, 486);
            this.LblPrixRhino.Name = "LblPrixRhino";
            this.LblPrixRhino.Size = new System.Drawing.Size(44, 20);
            this.LblPrixRhino.TabIndex = 25;
            this.LblPrixRhino.Text = "40 $";
            // 
            // LblPrixLicorne
            // 
            this.LblPrixLicorne.AutoSize = true;
            this.LblPrixLicorne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixLicorne.Location = new System.Drawing.Point(1506, 613);
            this.LblPrixLicorne.Name = "LblPrixLicorne";
            this.LblPrixLicorne.Size = new System.Drawing.Size(44, 20);
            this.LblPrixLicorne.TabIndex = 26;
            this.LblPrixLicorne.Text = "50 $";
            // 
            // LblPrixBuffle
            // 
            this.LblPrixBuffle.AutoSize = true;
            this.LblPrixBuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixBuffle.Location = new System.Drawing.Point(1506, 737);
            this.LblPrixBuffle.Name = "LblPrixBuffle";
            this.LblPrixBuffle.Size = new System.Drawing.Size(44, 20);
            this.LblPrixBuffle.TabIndex = 27;
            this.LblPrixBuffle.Text = "40 $";
            // 
            // TimerVisiteurEtConcierge
            // 
            this.TimerVisiteurEtConcierge.Enabled = true;
            this.TimerVisiteurEtConcierge.Interval = 1000;
            this.TimerVisiteurEtConcierge.Tick += new System.EventHandler(this.TimerVisiteurEtConcierge_Tick);
            // 
            // TimerAnimaux
            // 
            this.TimerAnimaux.Enabled = true;
            this.TimerAnimaux.Interval = 1000;
            this.TimerAnimaux.Tick += new System.EventHandler(this.TimerAnimaux_Tick);
            // 
            // BtnEngageConcierge
            // 
            this.BtnEngageConcierge.Location = new System.Drawing.Point(830, 18);
            this.BtnEngageConcierge.Name = "BtnEngageConcierge";
            this.BtnEngageConcierge.Size = new System.Drawing.Size(131, 23);
            this.BtnEngageConcierge.TabIndex = 28;
            this.BtnEngageConcierge.Text = "Engagez un conicerge";
            this.BtnEngageConcierge.UseVisualStyleBackColor = true;
            this.BtnEngageConcierge.Click += new System.EventHandler(this.Acheter_Concierge_Click);
            // 
            // PicConcierge
            // 
            this.PicConcierge.Location = new System.Drawing.Point(967, 6);
            this.PicConcierge.Name = "PicConcierge";
            this.PicConcierge.Size = new System.Drawing.Size(41, 41);
            this.PicConcierge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicConcierge.TabIndex = 29;
            this.PicConcierge.TabStop = false;
            // 
            // LblInfoConcierge
            // 
            this.LblInfoConcierge.AutoSize = true;
            this.LblInfoConcierge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoConcierge.Location = new System.Drawing.Point(1014, 18);
            this.LblInfoConcierge.Name = "LblInfoConcierge";
            this.LblInfoConcierge.Size = new System.Drawing.Size(218, 20);
            this.LblInfoConcierge.TabIndex = 30;
            this.LblInfoConcierge.Text = "(Frais de 2$ aux 60 jours.)";
            // 
            // MappeMonde
            // 
            this.MappeMonde.animalChoisi = null;
            this.MappeMonde.conciergeChoisi = false;
            this.MappeMonde.enableBuyAnimals = false;
            this.MappeMonde.heroOnlyArea = true;
            this.MappeMonde.Location = new System.Drawing.Point(0, 50);
            this.MappeMonde.Name = "MappeMonde";
            this.MappeMonde.placedAnimal = false;
            this.MappeMonde.Size = new System.Drawing.Size(1376, 832);
            this.MappeMonde.sizeListeAnimaux = 0;
            this.MappeMonde.sizeListeVisiteur = 0;
            this.MappeMonde.TabIndex = 0;
            this.MappeMonde.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MappeMonde_KeyUp);
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 938);
            this.Controls.Add(this.LblInfoConcierge);
            this.Controls.Add(this.PicConcierge);
            this.Controls.Add(this.BtnEngageConcierge);
            this.Controls.Add(this.LblPrixBuffle);
            this.Controls.Add(this.LblPrixLicorne);
            this.Controls.Add(this.LblPrixRhino);
            this.Controls.Add(this.LblPrixGrizzly);
            this.Controls.Add(this.PicBuffle);
            this.Controls.Add(this.PicLicorne);
            this.Controls.Add(this.PicRhino);
            this.Controls.Add(this.PicGrizzly);
            this.Controls.Add(this.LblPrixMouton);
            this.Controls.Add(this.PicMouton);
            this.Controls.Add(this.LblPrixLion);
            this.Controls.Add(this.PicLion);
            this.Controls.Add(this.BtnAchatBuffle);
            this.Controls.Add(this.BtnAchatLicorne);
            this.Controls.Add(this.BtnAchatRhino);
            this.Controls.Add(this.BtnAchatGrizzly);
            this.Controls.Add(this.BtnAchatMouton);
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
            ((System.ComponentModel.ISupportInitialize)(this.PicMouton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDechets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicArgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGrizzly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicRhino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicorne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicConcierge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Map MappeMonde;
        private Label LblArgent;
        public Label LblDate;
        private Label LblDechets;
        private Label LblAnimal;
        private GroupBox GrpInfo;
        private PictureBox PicDate;
        private PictureBox PicArgent;
        private PictureBox PicAnimal;
        private PictureBox PicDechets;
        private Timer TimerPrincipal;
        private Label LblDollarSign;
        private Button BtnAchatLion;
        private Button BtnAchatMouton;
        private Button BtnAchatGrizzly;
        private Button BtnAchatRhino;
        private Button BtnAchatLicorne;
        private Button BtnAchatBuffle;
        private PictureBox PicLion;
        private Label LblPrixLion;
        private PictureBox PicMouton;
        private Label LblPrixMouton;
        private PictureBox PicGrizzly;
        private PictureBox PicRhino;
        private PictureBox PicLicorne;
        private PictureBox PicBuffle;
        private Label LblPrixGrizzly;
        private Label LblPrixRhino;
        private Label LblPrixLicorne;
        private Label LblPrixBuffle;

        public Button getBtnLion () { return BtnAchatLion; }

        private Timer TimerVisiteurEtConcierge;
        private Timer TimerAnimaux;
        private Button BtnEngageConcierge;
        private PictureBox PicConcierge;
        private Label LblInfoConcierge;
    }
}

