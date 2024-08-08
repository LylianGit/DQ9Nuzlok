namespace DQ9_Personnage_Aléatoire
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbGuerrier = new System.Windows.Forms.CheckBox();
            this.cbPretre = new System.Windows.Forms.CheckBox();
            this.cbArtisteMartial = new System.Windows.Forms.CheckBox();
            this.cbMage = new System.Windows.Forms.CheckBox();
            this.cbPaladin = new System.Windows.Forms.CheckBox();
            this.cbGladiateur = new System.Windows.Forms.CheckBox();
            this.cbTroubadour = new System.Windows.Forms.CheckBox();
            this.cbVoleur = new System.Windows.Forms.CheckBox();
            this.cbRanger = new System.Windows.Forms.CheckBox();
            this.cbArmagicien = new System.Windows.Forms.CheckBox();
            this.cbSommite = new System.Windows.Forms.CheckBox();
            this.btnVocation = new System.Windows.Forms.Button();
            this.resultat = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.Label();
            this.perso = new System.Windows.Forms.Label();
            this.btnPerso = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbPerso1 = new System.Windows.Forms.CheckBox();
            this.cbPerso3 = new System.Windows.Forms.CheckBox();
            this.cbPerso2 = new System.Windows.Forms.CheckBox();
            this.cbPerso4 = new System.Windows.Forms.CheckBox();
            this.cbVocations = new System.Windows.Forms.CheckBox();
            this.cbPersonnages = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbGuerrier
            // 
            this.cbGuerrier.AutoSize = true;
            this.cbGuerrier.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbGuerrier.Location = new System.Drawing.Point(4, 56);
            this.cbGuerrier.Margin = new System.Windows.Forms.Padding(6);
            this.cbGuerrier.Name = "cbGuerrier";
            this.cbGuerrier.Size = new System.Drawing.Size(98, 28);
            this.cbGuerrier.TabIndex = 0;
            this.cbGuerrier.Text = "Guerrier";
            this.cbGuerrier.UseVisualStyleBackColor = false;
            this.cbGuerrier.CheckedChanged += new System.EventHandler(this.cbGuerrier_CheckedChanged);
            // 
            // cbPretre
            // 
            this.cbPretre.AutoSize = true;
            this.cbPretre.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbPretre.Location = new System.Drawing.Point(4, 99);
            this.cbPretre.Margin = new System.Windows.Forms.Padding(6);
            this.cbPretre.Name = "cbPretre";
            this.cbPretre.Size = new System.Drawing.Size(79, 28);
            this.cbPretre.TabIndex = 1;
            this.cbPretre.Text = "Prêtre";
            this.cbPretre.UseVisualStyleBackColor = false;
            this.cbPretre.CheckedChanged += new System.EventHandler(this.cbPretre_CheckedChanged);
            // 
            // cbArtisteMartial
            // 
            this.cbArtisteMartial.AutoSize = true;
            this.cbArtisteMartial.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbArtisteMartial.Location = new System.Drawing.Point(4, 184);
            this.cbArtisteMartial.Margin = new System.Windows.Forms.Padding(6);
            this.cbArtisteMartial.Name = "cbArtisteMartial";
            this.cbArtisteMartial.Size = new System.Drawing.Size(139, 28);
            this.cbArtisteMartial.TabIndex = 3;
            this.cbArtisteMartial.Text = "Artiste martial";
            this.cbArtisteMartial.UseVisualStyleBackColor = false;
            this.cbArtisteMartial.CheckedChanged += new System.EventHandler(this.cbArtisteMartial_CheckedChanged);
            // 
            // cbMage
            // 
            this.cbMage.AutoSize = true;
            this.cbMage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbMage.Location = new System.Drawing.Point(4, 141);
            this.cbMage.Margin = new System.Windows.Forms.Padding(6);
            this.cbMage.Name = "cbMage";
            this.cbMage.Size = new System.Drawing.Size(77, 28);
            this.cbMage.TabIndex = 2;
            this.cbMage.Text = "Mage";
            this.cbMage.UseVisualStyleBackColor = false;
            this.cbMage.CheckedChanged += new System.EventHandler(this.cbMage_CheckedChanged);
            // 
            // cbPaladin
            // 
            this.cbPaladin.AutoSize = true;
            this.cbPaladin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbPaladin.Location = new System.Drawing.Point(146, 99);
            this.cbPaladin.Margin = new System.Windows.Forms.Padding(6);
            this.cbPaladin.Name = "cbPaladin";
            this.cbPaladin.Size = new System.Drawing.Size(91, 28);
            this.cbPaladin.TabIndex = 7;
            this.cbPaladin.Text = "Paladin";
            this.cbPaladin.UseVisualStyleBackColor = false;
            this.cbPaladin.CheckedChanged += new System.EventHandler(this.cbPaladin_CheckedChanged);
            // 
            // cbGladiateur
            // 
            this.cbGladiateur.AutoSize = true;
            this.cbGladiateur.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbGladiateur.Location = new System.Drawing.Point(146, 56);
            this.cbGladiateur.Margin = new System.Windows.Forms.Padding(6);
            this.cbGladiateur.Name = "cbGladiateur";
            this.cbGladiateur.Size = new System.Drawing.Size(114, 28);
            this.cbGladiateur.TabIndex = 6;
            this.cbGladiateur.Text = "Gladiateur";
            this.cbGladiateur.UseVisualStyleBackColor = false;
            this.cbGladiateur.CheckedChanged += new System.EventHandler(this.cbGladiateur_CheckedChanged);
            // 
            // cbTroubadour
            // 
            this.cbTroubadour.AutoSize = true;
            this.cbTroubadour.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbTroubadour.Location = new System.Drawing.Point(4, 269);
            this.cbTroubadour.Margin = new System.Windows.Forms.Padding(6);
            this.cbTroubadour.Name = "cbTroubadour";
            this.cbTroubadour.Size = new System.Drawing.Size(129, 28);
            this.cbTroubadour.TabIndex = 5;
            this.cbTroubadour.Text = "Troubadour";
            this.cbTroubadour.UseVisualStyleBackColor = false;
            this.cbTroubadour.CheckedChanged += new System.EventHandler(this.cbTroubadour_CheckedChanged);
            // 
            // cbVoleur
            // 
            this.cbVoleur.AutoSize = true;
            this.cbVoleur.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbVoleur.Location = new System.Drawing.Point(4, 226);
            this.cbVoleur.Margin = new System.Windows.Forms.Padding(6);
            this.cbVoleur.Name = "cbVoleur";
            this.cbVoleur.Size = new System.Drawing.Size(85, 28);
            this.cbVoleur.TabIndex = 4;
            this.cbVoleur.Text = "Voleur";
            this.cbVoleur.UseVisualStyleBackColor = false;
            this.cbVoleur.CheckedChanged += new System.EventHandler(this.cbVoleur_CheckedChanged);
            // 
            // cbRanger
            // 
            this.cbRanger.AutoSize = true;
            this.cbRanger.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbRanger.Location = new System.Drawing.Point(146, 184);
            this.cbRanger.Margin = new System.Windows.Forms.Padding(6);
            this.cbRanger.Name = "cbRanger";
            this.cbRanger.Size = new System.Drawing.Size(91, 28);
            this.cbRanger.TabIndex = 9;
            this.cbRanger.Text = "Ranger";
            this.cbRanger.UseVisualStyleBackColor = false;
            this.cbRanger.CheckedChanged += new System.EventHandler(this.cbRanger_CheckedChanged);
            // 
            // cbArmagicien
            // 
            this.cbArmagicien.AutoSize = true;
            this.cbArmagicien.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbArmagicien.Location = new System.Drawing.Point(146, 141);
            this.cbArmagicien.Margin = new System.Windows.Forms.Padding(6);
            this.cbArmagicien.Name = "cbArmagicien";
            this.cbArmagicien.Size = new System.Drawing.Size(125, 28);
            this.cbArmagicien.TabIndex = 8;
            this.cbArmagicien.Text = "Armagicien";
            this.cbArmagicien.UseVisualStyleBackColor = false;
            this.cbArmagicien.CheckedChanged += new System.EventHandler(this.cbArmagicien_CheckedChanged);
            // 
            // cbSommite
            // 
            this.cbSommite.AutoSize = true;
            this.cbSommite.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbSommite.Location = new System.Drawing.Point(146, 226);
            this.cbSommite.Margin = new System.Windows.Forms.Padding(6);
            this.cbSommite.Name = "cbSommite";
            this.cbSommite.Size = new System.Drawing.Size(103, 28);
            this.cbSommite.TabIndex = 10;
            this.cbSommite.Text = "Sommité";
            this.cbSommite.UseVisualStyleBackColor = false;
            this.cbSommite.CheckedChanged += new System.EventHandler(this.cbSommite_CheckedChanged);
            // 
            // btnVocation
            // 
            this.btnVocation.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVocation.Location = new System.Drawing.Point(364, 127);
            this.btnVocation.Margin = new System.Windows.Forms.Padding(6);
            this.btnVocation.Name = "btnVocation";
            this.btnVocation.Size = new System.Drawing.Size(138, 42);
            this.btnVocation.TabIndex = 12;
            this.btnVocation.Text = "VOCATION";
            this.btnVocation.UseVisualStyleBackColor = false;
            this.btnVocation.Click += new System.EventHandler(this.btnVocation_Click);
            // 
            // resultat
            // 
            this.resultat.AutoSize = true;
            this.resultat.BackColor = System.Drawing.Color.GreenYellow;
            this.resultat.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resultat.Location = new System.Drawing.Point(769, 429);
            this.resultat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(202, 117);
            this.resultat.TabIndex = 13;
            this.resultat.Text = "test";
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(301, 9);
            this.debug.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(0, 24);
            this.debug.TabIndex = 14;
            // 
            // perso
            // 
            this.perso.AutoSize = true;
            this.perso.BackColor = System.Drawing.Color.Red;
            this.perso.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.perso.Location = new System.Drawing.Point(565, 429);
            this.perso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.perso.Name = "perso";
            this.perso.Size = new System.Drawing.Size(137, 80);
            this.perso.TabIndex = 15;
            this.perso.Text = "test";
            // 
            // btnPerso
            // 
            this.btnPerso.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPerso.Location = new System.Drawing.Point(364, 36);
            this.btnPerso.Margin = new System.Windows.Forms.Padding(6);
            this.btnPerso.Name = "btnPerso";
            this.btnPerso.Size = new System.Drawing.Size(138, 42);
            this.btnPerso.TabIndex = 16;
            this.btnPerso.Text = "PERSO";
            this.btnPerso.UseVisualStyleBackColor = false;
            this.btnPerso.Click += new System.EventHandler(this.btnPerso_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Fuchsia;
            this.btnReset.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnReset.Location = new System.Drawing.Point(364, 196);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 42);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbPerso1
            // 
            this.cbPerso1.AutoSize = true;
            this.cbPerso1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbPerso1.Location = new System.Drawing.Point(603, 54);
            this.cbPerso1.Margin = new System.Windows.Forms.Padding(6);
            this.cbPerso1.Name = "cbPerso1";
            this.cbPerso1.Size = new System.Drawing.Size(39, 28);
            this.cbPerso1.TabIndex = 19;
            this.cbPerso1.Text = "1";
            this.cbPerso1.UseVisualStyleBackColor = false;
            this.cbPerso1.CheckedChanged += new System.EventHandler(this.cbPerso1_CheckedChanged);
            // 
            // cbPerso3
            // 
            this.cbPerso3.AutoSize = true;
            this.cbPerso3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbPerso3.Location = new System.Drawing.Point(705, 54);
            this.cbPerso3.Margin = new System.Windows.Forms.Padding(6);
            this.cbPerso3.Name = "cbPerso3";
            this.cbPerso3.Size = new System.Drawing.Size(39, 28);
            this.cbPerso3.TabIndex = 20;
            this.cbPerso3.Text = "3";
            this.cbPerso3.UseVisualStyleBackColor = false;
            this.cbPerso3.CheckedChanged += new System.EventHandler(this.cbPerso3_CheckedChanged);
            // 
            // cbPerso2
            // 
            this.cbPerso2.AutoSize = true;
            this.cbPerso2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbPerso2.Location = new System.Drawing.Point(654, 54);
            this.cbPerso2.Margin = new System.Windows.Forms.Padding(6);
            this.cbPerso2.Name = "cbPerso2";
            this.cbPerso2.Size = new System.Drawing.Size(39, 28);
            this.cbPerso2.TabIndex = 21;
            this.cbPerso2.Text = "2";
            this.cbPerso2.UseVisualStyleBackColor = false;
            this.cbPerso2.CheckedChanged += new System.EventHandler(this.cbPerso2_CheckedChanged);
            // 
            // cbPerso4
            // 
            this.cbPerso4.AutoSize = true;
            this.cbPerso4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbPerso4.Location = new System.Drawing.Point(754, 54);
            this.cbPerso4.Margin = new System.Windows.Forms.Padding(6);
            this.cbPerso4.Name = "cbPerso4";
            this.cbPerso4.Size = new System.Drawing.Size(39, 28);
            this.cbPerso4.TabIndex = 21;
            this.cbPerso4.Text = "4";
            this.cbPerso4.UseVisualStyleBackColor = false;
            this.cbPerso4.CheckedChanged += new System.EventHandler(this.cbPerso4_CheckedChanged);
            // 
            // cbVocations
            // 
            this.cbVocations.AutoSize = true;
            this.cbVocations.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbVocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVocations.Location = new System.Drawing.Point(34, 9);
            this.cbVocations.Margin = new System.Windows.Forms.Padding(6);
            this.cbVocations.Name = "cbVocations";
            this.cbVocations.Size = new System.Drawing.Size(203, 35);
            this.cbVocations.TabIndex = 22;
            this.cbVocations.Text = "VOCATIONS";
            this.cbVocations.UseVisualStyleBackColor = false;
            this.cbVocations.CheckedChanged += new System.EventHandler(this.cbVocations_CheckedChanged);
            // 
            // cbPersonnages
            // 
            this.cbPersonnages.AutoSize = true;
            this.cbPersonnages.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbPersonnages.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPersonnages.Location = new System.Drawing.Point(594, 9);
            this.cbPersonnages.Margin = new System.Windows.Forms.Padding(6);
            this.cbPersonnages.Name = "cbPersonnages";
            this.cbPersonnages.Size = new System.Drawing.Size(228, 33);
            this.cbPersonnages.TabIndex = 23;
            this.cbPersonnages.Text = "PERSONNAGES";
            this.cbPersonnages.UseVisualStyleBackColor = false;
            this.cbPersonnages.CheckedChanged += new System.EventHandler(this.cbPersonnages_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(294, 5);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(269, 28);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Activer personnage aléatoire";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(348, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "désactiver sa vocation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(348, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "<------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1408, 843);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbPersonnages);
            this.Controls.Add(this.cbVocations);
            this.Controls.Add(this.cbPerso4);
            this.Controls.Add(this.cbPerso2);
            this.Controls.Add(this.cbPerso3);
            this.Controls.Add(this.cbPerso1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPerso);
            this.Controls.Add(this.perso);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.btnVocation);
            this.Controls.Add(this.cbSommite);
            this.Controls.Add(this.cbRanger);
            this.Controls.Add(this.cbArmagicien);
            this.Controls.Add(this.cbPaladin);
            this.Controls.Add(this.cbGladiateur);
            this.Controls.Add(this.cbTroubadour);
            this.Controls.Add(this.cbVoleur);
            this.Controls.Add(this.cbArtisteMartial);
            this.Controls.Add(this.cbMage);
            this.Controls.Add(this.cbPretre);
            this.Controls.Add(this.cbGuerrier);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Classe Aléatoire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbGuerrier;
        private System.Windows.Forms.CheckBox cbPretre;
        private System.Windows.Forms.CheckBox cbArtisteMartial;
        private System.Windows.Forms.CheckBox cbMage;
        private System.Windows.Forms.CheckBox cbPaladin;
        private System.Windows.Forms.CheckBox cbGladiateur;
        private System.Windows.Forms.CheckBox cbTroubadour;
        private System.Windows.Forms.CheckBox cbVoleur;
        private System.Windows.Forms.CheckBox cbRanger;
        private System.Windows.Forms.CheckBox cbArmagicien;
        private System.Windows.Forms.CheckBox cbSommite;
        private System.Windows.Forms.Button btnVocation;
        private System.Windows.Forms.Label resultat;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Label perso;
        private System.Windows.Forms.Button btnPerso;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cbPerso1;
        private System.Windows.Forms.CheckBox cbPerso3;
        private System.Windows.Forms.CheckBox cbPerso2;
        private System.Windows.Forms.CheckBox cbPerso4;
        private System.Windows.Forms.CheckBox cbVocations;
        private System.Windows.Forms.CheckBox cbPersonnages;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

