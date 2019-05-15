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
            this.GrpInfosVis = new System.Windows.Forms.GroupBox();
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
            this.GrpInfosAnimaux = new System.Windows.Forms.GroupBox();
            this.PicInfoLion = new System.Windows.Forms.PictureBox();
            this.PicInfoMouton = new System.Windows.Forms.PictureBox();
            this.LblQtLion = new System.Windows.Forms.Label();
            this.LblQtMouton = new System.Windows.Forms.Label();
            this.PicInfoGrizzly = new System.Windows.Forms.PictureBox();
            this.PicInfoRhino = new System.Windows.Forms.PictureBox();
            this.PicInfoLicorne = new System.Windows.Forms.PictureBox();
            this.PicInfoBuffle = new System.Windows.Forms.PictureBox();
            this.LblQtGrizzly = new System.Windows.Forms.Label();
            this.LblQtRhino = new System.Windows.Forms.Label();
            this.LblQtLicorne = new System.Windows.Forms.Label();
            this.LblQtBuffle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblInfoType = new System.Windows.Forms.Label();
            this.LblInfoGenreA = new System.Windows.Forms.Label();
            this.LblAgeA = new System.Windows.Forms.Label();
            this.LblInfoFaim = new System.Windows.Forms.Label();
            this.LblInfoEnceinte = new System.Windows.Forms.Label();
            this.PicInfoVis = new System.Windows.Forms.PictureBox();
            this.LblInfoNomVis = new System.Windows.Forms.Label();
            this.LblInfoGenreVis = new System.Windows.Forms.Label();
            this.LblInfoTempsPasserVis = new System.Windows.Forms.Label();
            this.GrpInfosVis.SuspendLayout();
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
            this.GrpInfosAnimaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoLion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoMouton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoGrizzly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoRhino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoLicorne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoBuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoVis)).BeginInit();
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
            // GrpInfosVis
            // 
            this.GrpInfosVis.Controls.Add(this.LblInfoTempsPasserVis);
            this.GrpInfosVis.Controls.Add(this.LblInfoGenreVis);
            this.GrpInfosVis.Controls.Add(this.LblInfoNomVis);
            this.GrpInfosVis.Controls.Add(this.PicInfoVis);
            this.GrpInfosVis.Location = new System.Drawing.Point(0, 855);
            this.GrpInfosVis.Name = "GrpInfosVis";
            this.GrpInfosVis.Size = new System.Drawing.Size(577, 83);
            this.GrpInfosVis.TabIndex = 5;
            this.GrpInfosVis.TabStop = false;
            this.GrpInfosVis.Text = "Informations du visiteur";
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
            this.BtnAchatLion.Location = new System.Drawing.Point(1382, 146);
            this.BtnAchatLion.Name = "BtnAchatLion";
            this.BtnAchatLion.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatLion.TabIndex = 11;
            this.BtnAchatLion.Text = "Acheter un lion";
            this.BtnAchatLion.UseVisualStyleBackColor = true;
            // 
            // BtnAchatMouton
            // 
            this.BtnAchatMouton.Location = new System.Drawing.Point(1382, 276);
            this.BtnAchatMouton.Name = "BtnAchatMouton";
            this.BtnAchatMouton.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatMouton.TabIndex = 12;
            this.BtnAchatMouton.Text = "Acheter un mouton";
            this.BtnAchatMouton.UseVisualStyleBackColor = true;
            // 
            // BtnAchatGrizzly
            // 
            this.BtnAchatGrizzly.Location = new System.Drawing.Point(1383, 406);
            this.BtnAchatGrizzly.Name = "BtnAchatGrizzly";
            this.BtnAchatGrizzly.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatGrizzly.TabIndex = 13;
            this.BtnAchatGrizzly.Text = "Acheter un grizzly";
            this.BtnAchatGrizzly.UseVisualStyleBackColor = true;
            // 
            // BtnAchatRhino
            // 
            this.BtnAchatRhino.Location = new System.Drawing.Point(1382, 536);
            this.BtnAchatRhino.Name = "BtnAchatRhino";
            this.BtnAchatRhino.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatRhino.TabIndex = 14;
            this.BtnAchatRhino.Text = "Acheter un rhinocéros";
            this.BtnAchatRhino.UseVisualStyleBackColor = true;
            // 
            // BtnAchatLicorne
            // 
            this.BtnAchatLicorne.Location = new System.Drawing.Point(1382, 666);
            this.BtnAchatLicorne.Name = "BtnAchatLicorne";
            this.BtnAchatLicorne.Size = new System.Drawing.Size(136, 23);
            this.BtnAchatLicorne.TabIndex = 15;
            this.BtnAchatLicorne.Text = "Acheter une licorne";
            this.BtnAchatLicorne.UseVisualStyleBackColor = true;
            // 
            // BtnAchatBuffle
            // 
            this.BtnAchatBuffle.Location = new System.Drawing.Point(1382, 796);
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
            this.LblPrixLion.Location = new System.Drawing.Point(1474, 92);
            this.LblPrixLion.Name = "LblPrixLion";
            this.LblPrixLion.Size = new System.Drawing.Size(44, 20);
            this.LblPrixLion.TabIndex = 18;
            this.LblPrixLion.Text = "35 $";
            // 
            // LblPrixMouton
            // 
            this.LblPrixMouton.AutoSize = true;
            this.LblPrixMouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixMouton.Location = new System.Drawing.Point(1474, 221);
            this.LblPrixMouton.Name = "LblPrixMouton";
            this.LblPrixMouton.Size = new System.Drawing.Size(44, 20);
            this.LblPrixMouton.TabIndex = 20;
            this.LblPrixMouton.Text = "20 $";
            // 
            // PicMouton
            // 
            this.PicMouton.Image = global::TP2.Properties.Resources.sheep;
            this.PicMouton.Location = new System.Drawing.Point(1382, 180);
            this.PicMouton.Name = "PicMouton";
            this.PicMouton.Size = new System.Drawing.Size(90, 90);
            this.PicMouton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMouton.TabIndex = 19;
            this.PicMouton.TabStop = false;
            // 
            // PicLion
            // 
            this.PicLion.Image = global::TP2.Properties.Resources.lion1;
            this.PicLion.Location = new System.Drawing.Point(1382, 50);
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
            this.PicGrizzly.Location = new System.Drawing.Point(1382, 310);
            this.PicGrizzly.Name = "PicGrizzly";
            this.PicGrizzly.Size = new System.Drawing.Size(90, 90);
            this.PicGrizzly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicGrizzly.TabIndex = 21;
            this.PicGrizzly.TabStop = false;
            // 
            // PicRhino
            // 
            this.PicRhino.Image = global::TP2.Properties.Resources.rhino;
            this.PicRhino.Location = new System.Drawing.Point(1383, 440);
            this.PicRhino.Name = "PicRhino";
            this.PicRhino.Size = new System.Drawing.Size(90, 90);
            this.PicRhino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicRhino.TabIndex = 22;
            this.PicRhino.TabStop = false;
            // 
            // PicLicorne
            // 
            this.PicLicorne.Image = global::TP2.Properties.Resources.licorne;
            this.PicLicorne.Location = new System.Drawing.Point(1382, 570);
            this.PicLicorne.Name = "PicLicorne";
            this.PicLicorne.Size = new System.Drawing.Size(90, 90);
            this.PicLicorne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLicorne.TabIndex = 23;
            this.PicLicorne.TabStop = false;
            // 
            // PicBuffle
            // 
            this.PicBuffle.Image = global::TP2.Properties.Resources.buffalo;
            this.PicBuffle.Location = new System.Drawing.Point(1382, 700);
            this.PicBuffle.Name = "PicBuffle";
            this.PicBuffle.Size = new System.Drawing.Size(90, 90);
            this.PicBuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBuffle.TabIndex = 24;
            this.PicBuffle.TabStop = false;
            // 
            // LblPrixGrizzly
            // 
            this.LblPrixGrizzly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixGrizzly.Location = new System.Drawing.Point(1474, 347);
            this.LblPrixGrizzly.Name = "LblPrixGrizzly";
            this.LblPrixGrizzly.Size = new System.Drawing.Size(44, 20);
            this.LblPrixGrizzly.TabIndex = 0;
            this.LblPrixGrizzly.Text = "30 $";
            // 
            // LblPrixRhino
            // 
            this.LblPrixRhino.AutoSize = true;
            this.LblPrixRhino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixRhino.Location = new System.Drawing.Point(1475, 486);
            this.LblPrixRhino.Name = "LblPrixRhino";
            this.LblPrixRhino.Size = new System.Drawing.Size(44, 20);
            this.LblPrixRhino.TabIndex = 25;
            this.LblPrixRhino.Text = "40 $";
            // 
            // LblPrixLicorne
            // 
            this.LblPrixLicorne.AutoSize = true;
            this.LblPrixLicorne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixLicorne.Location = new System.Drawing.Point(1474, 613);
            this.LblPrixLicorne.Name = "LblPrixLicorne";
            this.LblPrixLicorne.Size = new System.Drawing.Size(44, 20);
            this.LblPrixLicorne.TabIndex = 26;
            this.LblPrixLicorne.Text = "50 $";
            // 
            // LblPrixBuffle
            // 
            this.LblPrixBuffle.AutoSize = true;
            this.LblPrixBuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrixBuffle.Location = new System.Drawing.Point(1474, 737);
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
            this.MappeMonde.Size = new System.Drawing.Size(1376, 799);
            this.MappeMonde.sizeListeAnimaux = 0;
            this.MappeMonde.sizeListeVisiteur = 0;
            this.MappeMonde.TabIndex = 0;
            this.MappeMonde.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MappeMonde_KeyUp);
            // 
            // GrpInfosAnimaux
            // 
            this.GrpInfosAnimaux.Controls.Add(this.LblInfoEnceinte);
            this.GrpInfosAnimaux.Controls.Add(this.LblInfoFaim);
            this.GrpInfosAnimaux.Controls.Add(this.LblAgeA);
            this.GrpInfosAnimaux.Controls.Add(this.LblInfoGenreA);
            this.GrpInfosAnimaux.Controls.Add(this.LblInfoType);
            this.GrpInfosAnimaux.Controls.Add(this.pictureBox1);
            this.GrpInfosAnimaux.Controls.Add(this.LblQtBuffle);
            this.GrpInfosAnimaux.Controls.Add(this.LblQtLicorne);
            this.GrpInfosAnimaux.Controls.Add(this.LblQtRhino);
            this.GrpInfosAnimaux.Controls.Add(this.LblQtGrizzly);
            this.GrpInfosAnimaux.Controls.Add(this.PicInfoBuffle);
            this.GrpInfosAnimaux.Controls.Add(this.PicInfoLicorne);
            this.GrpInfosAnimaux.Controls.Add(this.PicInfoRhino);
            this.GrpInfosAnimaux.Controls.Add(this.PicInfoGrizzly);
            this.GrpInfosAnimaux.Controls.Add(this.LblQtMouton);
            this.GrpInfosAnimaux.Controls.Add(this.LblQtLion);
            this.GrpInfosAnimaux.Controls.Add(this.PicInfoMouton);
            this.GrpInfosAnimaux.Controls.Add(this.PicInfoLion);
            this.GrpInfosAnimaux.Location = new System.Drawing.Point(577, 855);
            this.GrpInfosAnimaux.Name = "GrpInfosAnimaux";
            this.GrpInfosAnimaux.Size = new System.Drawing.Size(942, 83);
            this.GrpInfosAnimaux.TabIndex = 0;
            this.GrpInfosAnimaux.TabStop = false;
            this.GrpInfosAnimaux.Text = "Informations des animaux";
            // 
            // PicInfoLion
            // 
            this.PicInfoLion.Image = global::TP2.Properties.Resources.lion1;
            this.PicInfoLion.Location = new System.Drawing.Point(6, 19);
            this.PicInfoLion.Name = "PicInfoLion";
            this.PicInfoLion.Size = new System.Drawing.Size(25, 25);
            this.PicInfoLion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicInfoLion.TabIndex = 0;
            this.PicInfoLion.TabStop = false;
            // 
            // PicInfoMouton
            // 
            this.PicInfoMouton.Image = global::TP2.Properties.Resources.sheep;
            this.PicInfoMouton.Location = new System.Drawing.Point(6, 50);
            this.PicInfoMouton.Name = "PicInfoMouton";
            this.PicInfoMouton.Size = new System.Drawing.Size(25, 25);
            this.PicInfoMouton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicInfoMouton.TabIndex = 1;
            this.PicInfoMouton.TabStop = false;
            // 
            // LblQtLion
            // 
            this.LblQtLion.AutoSize = true;
            this.LblQtLion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtLion.Location = new System.Drawing.Point(37, 24);
            this.LblQtLion.Name = "LblQtLion";
            this.LblQtLion.Size = new System.Drawing.Size(19, 20);
            this.LblQtLion.TabIndex = 2;
            this.LblQtLion.Text = "0";
            // 
            // LblQtMouton
            // 
            this.LblQtMouton.AutoSize = true;
            this.LblQtMouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtMouton.Location = new System.Drawing.Point(37, 55);
            this.LblQtMouton.Name = "LblQtMouton";
            this.LblQtMouton.Size = new System.Drawing.Size(19, 20);
            this.LblQtMouton.TabIndex = 3;
            this.LblQtMouton.Text = "0";
            // 
            // PicInfoGrizzly
            // 
            this.PicInfoGrizzly.Image = global::TP2.Properties.Resources.grizzly;
            this.PicInfoGrizzly.Location = new System.Drawing.Point(93, 19);
            this.PicInfoGrizzly.Name = "PicInfoGrizzly";
            this.PicInfoGrizzly.Size = new System.Drawing.Size(25, 25);
            this.PicInfoGrizzly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicInfoGrizzly.TabIndex = 4;
            this.PicInfoGrizzly.TabStop = false;
            // 
            // PicInfoRhino
            // 
            this.PicInfoRhino.Image = global::TP2.Properties.Resources.rhino;
            this.PicInfoRhino.Location = new System.Drawing.Point(93, 50);
            this.PicInfoRhino.Name = "PicInfoRhino";
            this.PicInfoRhino.Size = new System.Drawing.Size(25, 25);
            this.PicInfoRhino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicInfoRhino.TabIndex = 5;
            this.PicInfoRhino.TabStop = false;
            // 
            // PicInfoLicorne
            // 
            this.PicInfoLicorne.Image = global::TP2.Properties.Resources.licorne;
            this.PicInfoLicorne.Location = new System.Drawing.Point(179, 19);
            this.PicInfoLicorne.Name = "PicInfoLicorne";
            this.PicInfoLicorne.Size = new System.Drawing.Size(25, 25);
            this.PicInfoLicorne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicInfoLicorne.TabIndex = 6;
            this.PicInfoLicorne.TabStop = false;
            // 
            // PicInfoBuffle
            // 
            this.PicInfoBuffle.Image = global::TP2.Properties.Resources.buffalo;
            this.PicInfoBuffle.Location = new System.Drawing.Point(179, 50);
            this.PicInfoBuffle.Name = "PicInfoBuffle";
            this.PicInfoBuffle.Size = new System.Drawing.Size(25, 25);
            this.PicInfoBuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicInfoBuffle.TabIndex = 7;
            this.PicInfoBuffle.TabStop = false;
            // 
            // LblQtGrizzly
            // 
            this.LblQtGrizzly.AutoSize = true;
            this.LblQtGrizzly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtGrizzly.Location = new System.Drawing.Point(124, 24);
            this.LblQtGrizzly.Name = "LblQtGrizzly";
            this.LblQtGrizzly.Size = new System.Drawing.Size(19, 20);
            this.LblQtGrizzly.TabIndex = 8;
            this.LblQtGrizzly.Text = "0";
            // 
            // LblQtRhino
            // 
            this.LblQtRhino.AutoSize = true;
            this.LblQtRhino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtRhino.Location = new System.Drawing.Point(124, 55);
            this.LblQtRhino.Name = "LblQtRhino";
            this.LblQtRhino.Size = new System.Drawing.Size(19, 20);
            this.LblQtRhino.TabIndex = 9;
            this.LblQtRhino.Text = "0";
            // 
            // LblQtLicorne
            // 
            this.LblQtLicorne.AutoSize = true;
            this.LblQtLicorne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtLicorne.Location = new System.Drawing.Point(210, 24);
            this.LblQtLicorne.Name = "LblQtLicorne";
            this.LblQtLicorne.Size = new System.Drawing.Size(19, 20);
            this.LblQtLicorne.TabIndex = 10;
            this.LblQtLicorne.Text = "0";
            // 
            // LblQtBuffle
            // 
            this.LblQtBuffle.AutoSize = true;
            this.LblQtBuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQtBuffle.Location = new System.Drawing.Point(210, 55);
            this.LblQtBuffle.Name = "LblQtBuffle";
            this.LblQtBuffle.Size = new System.Drawing.Size(19, 20);
            this.LblQtBuffle.TabIndex = 11;
            this.LblQtBuffle.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP2.Properties.Resources.animal_logo;
            this.pictureBox1.Location = new System.Drawing.Point(441, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LblInfoType
            // 
            this.LblInfoType.AutoSize = true;
            this.LblInfoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoType.Location = new System.Drawing.Point(517, 13);
            this.LblInfoType.Name = "LblInfoType";
            this.LblInfoType.Size = new System.Drawing.Size(59, 17);
            this.LblInfoType.TabIndex = 13;
            this.LblInfoType.Text = "Type : ";
            // 
            // LblInfoGenreA
            // 
            this.LblInfoGenreA.AutoSize = true;
            this.LblInfoGenreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoGenreA.Location = new System.Drawing.Point(517, 34);
            this.LblInfoGenreA.Name = "LblInfoGenreA";
            this.LblInfoGenreA.Size = new System.Drawing.Size(68, 17);
            this.LblInfoGenreA.TabIndex = 14;
            this.LblInfoGenreA.Text = "Genre : ";
            // 
            // LblAgeA
            // 
            this.LblAgeA.AutoSize = true;
            this.LblAgeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgeA.Location = new System.Drawing.Point(517, 55);
            this.LblAgeA.Name = "LblAgeA";
            this.LblAgeA.Size = new System.Drawing.Size(51, 17);
            this.LblAgeA.TabIndex = 15;
            this.LblAgeA.Text = "Age : ";
            // 
            // LblInfoFaim
            // 
            this.LblInfoFaim.AutoSize = true;
            this.LblInfoFaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoFaim.Location = new System.Drawing.Point(658, 13);
            this.LblInfoFaim.Name = "LblInfoFaim";
            this.LblInfoFaim.Size = new System.Drawing.Size(167, 17);
            this.LblInfoFaim.TabIndex = 16;
            this.LblInfoFaim.Text = "Besoin d\'être nourri : ";
            // 
            // LblInfoEnceinte
            // 
            this.LblInfoEnceinte.AutoSize = true;
            this.LblInfoEnceinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoEnceinte.Location = new System.Drawing.Point(658, 55);
            this.LblInfoEnceinte.Name = "LblInfoEnceinte";
            this.LblInfoEnceinte.Size = new System.Drawing.Size(86, 17);
            this.LblInfoEnceinte.TabIndex = 17;
            this.LblInfoEnceinte.Text = "Enceinte : ";
            // 
            // PicInfoVis
            // 
            this.PicInfoVis.Image = global::TP2.Properties.Resources.personnages;
            this.PicInfoVis.Location = new System.Drawing.Point(42, 13);
            this.PicInfoVis.Name = "PicInfoVis";
            this.PicInfoVis.Size = new System.Drawing.Size(70, 70);
            this.PicInfoVis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicInfoVis.TabIndex = 0;
            this.PicInfoVis.TabStop = false;
            // 
            // LblInfoNomVis
            // 
            this.LblInfoNomVis.AutoSize = true;
            this.LblInfoNomVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoNomVis.Location = new System.Drawing.Point(118, 13);
            this.LblInfoNomVis.Name = "LblInfoNomVis";
            this.LblInfoNomVis.Size = new System.Drawing.Size(55, 17);
            this.LblInfoNomVis.TabIndex = 1;
            this.LblInfoNomVis.Text = "Nom : ";
            // 
            // LblInfoGenreVis
            // 
            this.LblInfoGenreVis.AutoSize = true;
            this.LblInfoGenreVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoGenreVis.Location = new System.Drawing.Point(118, 36);
            this.LblInfoGenreVis.Name = "LblInfoGenreVis";
            this.LblInfoGenreVis.Size = new System.Drawing.Size(58, 17);
            this.LblInfoGenreVis.TabIndex = 2;
            this.LblInfoGenreVis.Text = "Sexe : ";
            // 
            // LblInfoTempsPasserVis
            // 
            this.LblInfoTempsPasserVis.AutoSize = true;
            this.LblInfoTempsPasserVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfoTempsPasserVis.Location = new System.Drawing.Point(118, 58);
            this.LblInfoTempsPasserVis.Name = "LblInfoTempsPasserVis";
            this.LblInfoTempsPasserVis.Size = new System.Drawing.Size(225, 17);
            this.LblInfoTempsPasserVis.TabIndex = 3;
            this.LblInfoTempsPasserVis.Text = "Temps passer depuis arrivé : ";
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 938);
            this.Controls.Add(this.GrpInfosAnimaux);
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
            this.Controls.Add(this.GrpInfosVis);
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
            this.GrpInfosVis.ResumeLayout(false);
            this.GrpInfosVis.PerformLayout();
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
            this.GrpInfosAnimaux.ResumeLayout(false);
            this.GrpInfosAnimaux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoLion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoMouton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoGrizzly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoRhino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoLicorne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoBuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicInfoVis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Map MappeMonde;
        private Label LblArgent;
        public Label LblDate;
        private Label LblDechets;
        private Label LblAnimal;
        private GroupBox GrpInfosVis;
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
        private GroupBox GrpInfosAnimaux;
        private Label LblQtBuffle;
        private Label LblQtLicorne;
        private Label LblQtRhino;
        private Label LblQtGrizzly;
        private PictureBox PicInfoBuffle;
        private PictureBox PicInfoLicorne;
        private PictureBox PicInfoRhino;
        private PictureBox PicInfoGrizzly;
        private Label LblQtMouton;
        private Label LblQtLion;
        private PictureBox PicInfoMouton;
        private PictureBox PicInfoLion;
        private Label LblInfoEnceinte;
        private Label LblInfoFaim;
        private Label LblAgeA;
        private Label LblInfoGenreA;
        private Label LblInfoType;
        private PictureBox pictureBox1;
        private Label LblInfoTempsPasserVis;
        private Label LblInfoGenreVis;
        private Label LblInfoNomVis;
        private PictureBox PicInfoVis;
    }
}

