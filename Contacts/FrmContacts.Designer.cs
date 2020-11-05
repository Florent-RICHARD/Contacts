namespace Contacts
{
    partial class frmContacts
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
            this.lblChoixPhoto = new System.Windows.Forms.Label();
            this.lstContact = new System.Windows.Forms.ListBox();
            this.grbAjout = new System.Windows.Forms.GroupBox();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.rdbParticulier = new System.Windows.Forms.RadioButton();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.grbContacts = new System.Windows.Forms.GroupBox();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.grbRecherche = new System.Windows.Forms.GroupBox();
            this.txtTelRech = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenomRech = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomRech = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbAjout.SuspendLayout();
            this.grbContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.grbRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoixPhoto
            // 
            this.lblChoixPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lblChoixPhoto.Enabled = false;
            this.lblChoixPhoto.Location = new System.Drawing.Point(31, 158);
            this.lblChoixPhoto.Name = "lblChoixPhoto";
            this.lblChoixPhoto.Size = new System.Drawing.Size(125, 32);
            this.lblChoixPhoto.TabIndex = 14;
            this.lblChoixPhoto.Text = "Cliquer pour sélectionner une photo";
            this.lblChoixPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChoixPhoto.Visible = false;
            this.lblChoixPhoto.Click += new System.EventHandler(this.LblChoixPhoto_Click);
            // 
            // lstContact
            // 
            this.lstContact.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstContact.FormattingEnabled = true;
            this.lstContact.HorizontalScrollbar = true;
            this.lstContact.Location = new System.Drawing.Point(6, 19);
            this.lstContact.Name = "lstContact";
            this.lstContact.Size = new System.Drawing.Size(318, 459);
            this.lstContact.TabIndex = 9;
            this.lstContact.Click += new System.EventHandler(this.lstContact_Click);
            this.lstContact.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstContact_DrawItem);
            this.lstContact.SelectedIndexChanged += new System.EventHandler(this.LstContact_SelectedIndexChanged);
            // 
            // grbAjout
            // 
            this.grbAjout.Controls.Add(this.rdbProfessionnel);
            this.grbAjout.Controls.Add(this.rdbParticulier);
            this.grbAjout.Controls.Add(this.btnAnnuler);
            this.grbAjout.Controls.Add(this.btnAjouter);
            this.grbAjout.Controls.Add(this.txtTel);
            this.grbAjout.Controls.Add(this.label3);
            this.grbAjout.Controls.Add(this.txtPrenom);
            this.grbAjout.Controls.Add(this.lblPrenom);
            this.grbAjout.Controls.Add(this.txtNom);
            this.grbAjout.Controls.Add(this.label1);
            this.grbAjout.Location = new System.Drawing.Point(12, 236);
            this.grbAjout.Name = "grbAjout";
            this.grbAjout.Size = new System.Drawing.Size(170, 175);
            this.grbAjout.TabIndex = 8;
            this.grbAjout.TabStop = false;
            this.grbAjout.Text = "ajout contact";
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.ForeColor = System.Drawing.Color.Green;
            this.rdbProfessionnel.Location = new System.Drawing.Point(73, 17);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.Size = new System.Drawing.Size(87, 17);
            this.rdbProfessionnel.TabIndex = 11;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            this.rdbProfessionnel.CheckedChanged += new System.EventHandler(this.rdbProfessionnel_CheckedChanged);
            // 
            // rdbParticulier
            // 
            this.rdbParticulier.AutoSize = true;
            this.rdbParticulier.ForeColor = System.Drawing.Color.Purple;
            this.rdbParticulier.Location = new System.Drawing.Point(0, 17);
            this.rdbParticulier.Name = "rdbParticulier";
            this.rdbParticulier.Size = new System.Drawing.Size(70, 17);
            this.rdbParticulier.TabIndex = 10;
            this.rdbParticulier.TabStop = true;
            this.rdbParticulier.Text = "particulier";
            this.rdbParticulier.UseVisualStyleBackColor = true;
            this.rdbParticulier.CheckedChanged += new System.EventHandler(this.rdbParticulier_CheckedChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Image = global::Contacts.Properties.Resources.annuler;
            this.btnAnnuler.Location = new System.Drawing.Point(119, 130);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(45, 45);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::Contacts.Properties.Resources.ajouter;
            this.btnAjouter.Location = new System.Drawing.Point(54, 130);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(45, 45);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(54, 92);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(106, 20);
            this.txtTel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "tel";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(54, 66);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(106, 20);
            this.txtPrenom.TabIndex = 5;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 69);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(42, 13);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "prénom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(54, 40);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(106, 20);
            this.txtNom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // btnNouveauContact
            // 
            this.btnNouveauContact.Location = new System.Drawing.Point(12, 210);
            this.btnNouveauContact.Name = "btnNouveauContact";
            this.btnNouveauContact.Size = new System.Drawing.Size(169, 20);
            this.btnNouveauContact.TabIndex = 10;
            this.btnNouveauContact.Text = "nouveau contact";
            this.btnNouveauContact.UseVisualStyleBackColor = true;
            this.btnNouveauContact.Click += new System.EventHandler(this.btnNouveauContact_Click);
            // 
            // grbContacts
            // 
            this.grbContacts.Controls.Add(this.lstContact);
            this.grbContacts.Controls.Add(this.btnSuppr);
            this.grbContacts.Controls.Add(this.btnModif);
            this.grbContacts.Location = new System.Drawing.Point(188, 5);
            this.grbContacts.Name = "grbContacts";
            this.grbContacts.Size = new System.Drawing.Size(333, 533);
            this.grbContacts.TabIndex = 15;
            this.grbContacts.TabStop = false;
            this.grbContacts.Text = "les contacts";
            // 
            // btnSuppr
            // 
            this.btnSuppr.Image = global::Contacts.Properties.Resources.supprimer;
            this.btnSuppr.Location = new System.Drawing.Point(279, 482);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(45, 45);
            this.btnSuppr.TabIndex = 10;
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.BtnSuppr_Click);
            // 
            // btnModif
            // 
            this.btnModif.Image = global::Contacts.Properties.Resources.modifier;
            this.btnModif.Location = new System.Drawing.Point(228, 482);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(45, 45);
            this.btnModif.TabIndex = 11;
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // imgPhoto
            // 
            this.imgPhoto.Enabled = false;
            this.imgPhoto.Image = global::Contacts.Properties.Resources.vide;
            this.imgPhoto.Location = new System.Drawing.Point(12, 12);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(170, 173);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 13;
            this.imgPhoto.TabStop = false;
            this.imgPhoto.Click += new System.EventHandler(this.ImgPhoto_Click);
            // 
            // grbRecherche
            // 
            this.grbRecherche.Controls.Add(this.txtTelRech);
            this.grbRecherche.Controls.Add(this.label2);
            this.grbRecherche.Controls.Add(this.txtPrenomRech);
            this.grbRecherche.Controls.Add(this.label4);
            this.grbRecherche.Controls.Add(this.txtNomRech);
            this.grbRecherche.Controls.Add(this.label5);
            this.grbRecherche.Location = new System.Drawing.Point(12, 417);
            this.grbRecherche.Name = "grbRecherche";
            this.grbRecherche.Size = new System.Drawing.Size(170, 121);
            this.grbRecherche.TabIndex = 16;
            this.grbRecherche.TabStop = false;
            this.grbRecherche.Text = "recherche";
            // 
            // txtTelRech
            // 
            this.txtTelRech.Location = new System.Drawing.Point(54, 92);
            this.txtTelRech.Name = "txtTelRech";
            this.txtTelRech.Size = new System.Drawing.Size(106, 20);
            this.txtTelRech.TabIndex = 7;
            this.txtTelRech.TextChanged += new System.EventHandler(this.txtTelRech_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "tel";
            // 
            // txtPrenomRech
            // 
            this.txtPrenomRech.Location = new System.Drawing.Point(54, 66);
            this.txtPrenomRech.Name = "txtPrenomRech";
            this.txtPrenomRech.Size = new System.Drawing.Size(106, 20);
            this.txtPrenomRech.TabIndex = 5;
            this.txtPrenomRech.TextChanged += new System.EventHandler(this.txtPrenomRech_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "prénom";
            // 
            // txtNomRech
            // 
            this.txtNomRech.Location = new System.Drawing.Point(54, 40);
            this.txtNomRech.Name = "txtNomRech";
            this.txtNomRech.Size = new System.Drawing.Size(106, 20);
            this.txtNomRech.TabIndex = 3;
            this.txtNomRech.TextChanged += new System.EventHandler(this.txtNomRech_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "nom";
            // 
            // frmContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 538);
            this.Controls.Add(this.grbRecherche);
            this.Controls.Add(this.grbContacts);
            this.Controls.Add(this.btnNouveauContact);
            this.Controls.Add(this.lblChoixPhoto);
            this.Controls.Add(this.imgPhoto);
            this.Controls.Add(this.grbAjout);
            this.Name = "frmContacts";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.FrmContacts_Load);
            this.grbAjout.ResumeLayout(false);
            this.grbAjout.PerformLayout();
            this.grbContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.grbRecherche.ResumeLayout(false);
            this.grbRecherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChoixPhoto;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.ListBox lstContact;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.GroupBox grbAjout;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouveauContact;
        private System.Windows.Forms.GroupBox grbContacts;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.RadioButton rdbParticulier;
        private System.Windows.Forms.GroupBox grbRecherche;
        private System.Windows.Forms.TextBox txtTelRech;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenomRech;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomRech;
        private System.Windows.Forms.Label label5;
    }
}

