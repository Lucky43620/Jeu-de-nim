namespace Jeu_de_Nim.Vue
{
    partial class frm_Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox_Accueil = new GroupBox();
            btn_JouerMulti = new Button();
            btn_JouerSolo = new Button();
            btn_Deconnexion = new Button();
            label_NbDefaite = new Label();
            label_NombreDeDefaite = new Label();
            label_NbVictoire = new Label();
            label_Victoire = new Label();
            label_NomJoueur = new Label();
            listBox_Classement = new ListBox();
            groupBox_Accueil.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Accueil
            // 
            groupBox_Accueil.Controls.Add(btn_JouerMulti);
            groupBox_Accueil.Controls.Add(btn_JouerSolo);
            groupBox_Accueil.Controls.Add(btn_Deconnexion);
            groupBox_Accueil.Controls.Add(label_NbDefaite);
            groupBox_Accueil.Controls.Add(label_NombreDeDefaite);
            groupBox_Accueil.Controls.Add(label_NbVictoire);
            groupBox_Accueil.Controls.Add(label_Victoire);
            groupBox_Accueil.Controls.Add(label_NomJoueur);
            groupBox_Accueil.Controls.Add(listBox_Classement);
            groupBox_Accueil.Location = new Point(12, 12);
            groupBox_Accueil.Name = "groupBox_Accueil";
            groupBox_Accueil.Size = new Size(574, 267);
            groupBox_Accueil.TabIndex = 0;
            groupBox_Accueil.TabStop = false;
            groupBox_Accueil.Text = "Accueil";
            // 
            // btn_JouerMulti
            // 
            btn_JouerMulti.Location = new Point(6, 211);
            btn_JouerMulti.Name = "btn_JouerMulti";
            btn_JouerMulti.Size = new Size(277, 48);
            btn_JouerMulti.TabIndex = 8;
            btn_JouerMulti.Text = "Lancer une partie en multijoueur";
            btn_JouerMulti.UseVisualStyleBackColor = true;
            // 
            // btn_JouerSolo
            // 
            btn_JouerSolo.Location = new Point(6, 157);
            btn_JouerSolo.Name = "btn_JouerSolo";
            btn_JouerSolo.Size = new Size(277, 48);
            btn_JouerSolo.TabIndex = 7;
            btn_JouerSolo.Text = "Lancer une partie contre l'IA";
            btn_JouerSolo.UseVisualStyleBackColor = true;
            // 
            // btn_Deconnexion
            // 
            btn_Deconnexion.Location = new Point(6, 108);
            btn_Deconnexion.Name = "btn_Deconnexion";
            btn_Deconnexion.Size = new Size(211, 34);
            btn_Deconnexion.TabIndex = 6;
            btn_Deconnexion.Text = "Déconnexion";
            btn_Deconnexion.UseVisualStyleBackColor = true;
            btn_Deconnexion.Click += btn_Deconnexion_Click;
            // 
            // label_NbDefaite
            // 
            label_NbDefaite.AutoSize = true;
            label_NbDefaite.Location = new Point(191, 80);
            label_NbDefaite.Name = "label_NbDefaite";
            label_NbDefaite.Size = new Size(25, 25);
            label_NbDefaite.TabIndex = 5;
            label_NbDefaite.Text = "D";
            // 
            // label_NombreDeDefaite
            // 
            label_NombreDeDefaite.AutoSize = true;
            label_NombreDeDefaite.Location = new Point(6, 80);
            label_NombreDeDefaite.Name = "label_NombreDeDefaite";
            label_NombreDeDefaite.Size = new Size(179, 25);
            label_NombreDeDefaite.TabIndex = 4;
            label_NombreDeDefaite.Text = "Nombre de défaites :";
            // 
            // label_NbVictoire
            // 
            label_NbVictoire.AutoSize = true;
            label_NbVictoire.Location = new Point(194, 55);
            label_NbVictoire.Name = "label_NbVictoire";
            label_NbVictoire.Size = new Size(23, 25);
            label_NbVictoire.TabIndex = 3;
            label_NbVictoire.Text = "V";
            // 
            // label_Victoire
            // 
            label_Victoire.AutoSize = true;
            label_Victoire.Location = new Point(6, 55);
            label_Victoire.Name = "label_Victoire";
            label_Victoire.Size = new Size(182, 25);
            label_Victoire.TabIndex = 2;
            label_Victoire.Text = "Nombre de victoires :";
            // 
            // label_NomJoueur
            // 
            label_NomJoueur.AutoSize = true;
            label_NomJoueur.Location = new Point(6, 30);
            label_NomJoueur.Name = "label_NomJoueur";
            label_NomJoueur.Size = new Size(104, 25);
            label_NomJoueur.TabIndex = 1;
            label_NomJoueur.Text = "NomJoueur";
            // 
            // listBox_Classement
            // 
            listBox_Classement.FormattingEnabled = true;
            listBox_Classement.ItemHeight = 25;
            listBox_Classement.Location = new Point(289, 30);
            listBox_Classement.Name = "listBox_Classement";
            listBox_Classement.Size = new Size(279, 229);
            listBox_Classement.TabIndex = 0;
            // 
            // frm_Accueil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 287);
            Controls.Add(groupBox_Accueil);
            Name = "frm_Accueil";
            Text = "Accueil";
            groupBox_Accueil.ResumeLayout(false);
            groupBox_Accueil.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Accueil;
        private Label label_NomJoueur;
        private ListBox listBox_Classement;
        private Label label_NbDefaite;
        private Label label_NombreDeDefaite;
        private Label label_NbVictoire;
        private Label label_Victoire;
        private Button btn_JouerMulti;
        private Button btn_JouerSolo;
        private Button btn_Deconnexion;
    }
}
