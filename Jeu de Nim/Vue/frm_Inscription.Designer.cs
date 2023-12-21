namespace Jeu_de_Nim.Vue
{
    partial class frm_Inscription
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
            groupBox_Inscription = new GroupBox();
            textBox_RepeterMotDePasse = new TextBox();
            label_RepeterMotDePasse = new Label();
            btn_Annuler = new Button();
            btn_Inscription = new Button();
            textBox_MotDePasse = new TextBox();
            label_MotDePasse = new Label();
            textBox_NomJoueur = new TextBox();
            label_NomJoueur = new Label();
            groupBox_Inscription.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Inscription
            // 
            groupBox_Inscription.Controls.Add(textBox_RepeterMotDePasse);
            groupBox_Inscription.Controls.Add(label_RepeterMotDePasse);
            groupBox_Inscription.Controls.Add(btn_Annuler);
            groupBox_Inscription.Controls.Add(btn_Inscription);
            groupBox_Inscription.Controls.Add(textBox_MotDePasse);
            groupBox_Inscription.Controls.Add(label_MotDePasse);
            groupBox_Inscription.Controls.Add(textBox_NomJoueur);
            groupBox_Inscription.Controls.Add(label_NomJoueur);
            groupBox_Inscription.Location = new Point(12, 12);
            groupBox_Inscription.Name = "groupBox_Inscription";
            groupBox_Inscription.Size = new Size(341, 378);
            groupBox_Inscription.TabIndex = 1;
            groupBox_Inscription.TabStop = false;
            groupBox_Inscription.Text = "Inscription";
            // 
            // textBox_RepeterMotDePasse
            // 
            textBox_RepeterMotDePasse.Location = new Point(6, 176);
            textBox_RepeterMotDePasse.Name = "textBox_RepeterMotDePasse";
            textBox_RepeterMotDePasse.Size = new Size(323, 31);
            textBox_RepeterMotDePasse.TabIndex = 7;
            // 
            // label_RepeterMotDePasse
            // 
            label_RepeterMotDePasse.AutoSize = true;
            label_RepeterMotDePasse.Location = new Point(71, 148);
            label_RepeterMotDePasse.Name = "label_RepeterMotDePasse";
            label_RepeterMotDePasse.Size = new Size(203, 25);
            label_RepeterMotDePasse.TabIndex = 6;
            label_RepeterMotDePasse.Text = "Répéter le mot de passe";
            // 
            // btn_Annuler
            // 
            btn_Annuler.BackColor = SystemColors.ControlDark;
            btn_Annuler.Location = new Point(6, 297);
            btn_Annuler.Name = "btn_Annuler";
            btn_Annuler.Size = new Size(323, 74);
            btn_Annuler.TabIndex = 5;
            btn_Annuler.Text = "Annuler";
            btn_Annuler.UseVisualStyleBackColor = false;
            btn_Annuler.Click += btn_Annuler_Click;
            // 
            // btn_Inscription
            // 
            btn_Inscription.BackColor = SystemColors.ActiveCaption;
            btn_Inscription.Location = new Point(6, 217);
            btn_Inscription.Name = "btn_Inscription";
            btn_Inscription.Size = new Size(323, 74);
            btn_Inscription.TabIndex = 4;
            btn_Inscription.Text = "Inscription";
            btn_Inscription.UseVisualStyleBackColor = false;
            btn_Inscription.Click += btn_Inscription_Click;
            // 
            // textBox_MotDePasse
            // 
            textBox_MotDePasse.Location = new Point(6, 114);
            textBox_MotDePasse.Name = "textBox_MotDePasse";
            textBox_MotDePasse.Size = new Size(323, 31);
            textBox_MotDePasse.TabIndex = 3;
            // 
            // label_MotDePasse
            // 
            label_MotDePasse.AutoSize = true;
            label_MotDePasse.Location = new Point(107, 86);
            label_MotDePasse.Name = "label_MotDePasse";
            label_MotDePasse.Size = new Size(120, 25);
            label_MotDePasse.TabIndex = 2;
            label_MotDePasse.Text = "Mot de passe";
            // 
            // textBox_NomJoueur
            // 
            textBox_NomJoueur.Location = new Point(6, 52);
            textBox_NomJoueur.Name = "textBox_NomJoueur";
            textBox_NomJoueur.Size = new Size(323, 31);
            textBox_NomJoueur.TabIndex = 1;
            // 
            // label_NomJoueur
            // 
            label_NomJoueur.AutoSize = true;
            label_NomJoueur.Location = new Point(101, 24);
            label_NomJoueur.Name = "label_NomJoueur";
            label_NomJoueur.Size = new Size(133, 25);
            label_NomJoueur.TabIndex = 0;
            label_NomJoueur.Text = "Nom du joueur";
            // 
            // frm_Inscription
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 402);
            Controls.Add(groupBox_Inscription);
            Name = "frm_Inscription";
            Text = "Inscription";
            groupBox_Inscription.ResumeLayout(false);
            groupBox_Inscription.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Inscription;
        private Button btn_Annuler;
        private Button btn_Inscription;
        private TextBox textBox_MotDePasse;
        private Label label_MotDePasse;
        private TextBox textBox_NomJoueur;
        private Label label_NomJoueur;
        private TextBox textBox_RepeterMotDePasse;
        private Label label_RepeterMotDePasse;
    }
}