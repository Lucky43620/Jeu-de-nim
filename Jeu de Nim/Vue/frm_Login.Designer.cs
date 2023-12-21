namespace Jeu_de_Nim.Vue
{
    partial class frm_Login
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
            groupBox_Login = new GroupBox();
            btn_Annuler = new Button();
            btn_Connexion = new Button();
            textBox_MotDePasse = new TextBox();
            label_MotDePasse = new Label();
            textBox_NomJoueur = new TextBox();
            label_NomJoueur = new Label();
            groupBox_Login.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Login
            // 
            groupBox_Login.Controls.Add(btn_Annuler);
            groupBox_Login.Controls.Add(btn_Connexion);
            groupBox_Login.Controls.Add(textBox_MotDePasse);
            groupBox_Login.Controls.Add(label_MotDePasse);
            groupBox_Login.Controls.Add(textBox_NomJoueur);
            groupBox_Login.Controls.Add(label_NomJoueur);
            groupBox_Login.Location = new Point(12, 12);
            groupBox_Login.Name = "groupBox_Login";
            groupBox_Login.Size = new Size(341, 317);
            groupBox_Login.TabIndex = 0;
            groupBox_Login.TabStop = false;
            groupBox_Login.Text = "Login";
            // 
            // btn_Annuler
            // 
            btn_Annuler.BackColor = SystemColors.ControlDark;
            btn_Annuler.Location = new Point(6, 231);
            btn_Annuler.Name = "btn_Annuler";
            btn_Annuler.Size = new Size(323, 74);
            btn_Annuler.TabIndex = 5;
            btn_Annuler.Text = "Annuler";
            btn_Annuler.UseVisualStyleBackColor = false;
            btn_Annuler.Click += btn_Annuler_Click;
            // 
            // btn_Connexion
            // 
            btn_Connexion.BackColor = SystemColors.ActiveCaption;
            btn_Connexion.Location = new Point(6, 151);
            btn_Connexion.Name = "btn_Connexion";
            btn_Connexion.Size = new Size(323, 74);
            btn_Connexion.TabIndex = 4;
            btn_Connexion.Text = "Connexion";
            btn_Connexion.UseVisualStyleBackColor = false;
            btn_Connexion.Click += btn_Connexion_Click;
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
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 339);
            Controls.Add(groupBox_Login);
            Name = "frm_Login";
            Text = "Login";
            groupBox_Login.ResumeLayout(false);
            groupBox_Login.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Login;
        private Button btn_Connexion;
        private TextBox textBox_MotDePasse;
        private Label label_MotDePasse;
        private TextBox textBox_NomJoueur;
        private Label label_NomJoueur;
        private Button btn_Annuler;
    }
}