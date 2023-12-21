namespace Jeu_de_Nim.Vue
{
    partial class frm_Connexion
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
            groupBox_Connexion = new GroupBox();
            btn_Register = new Button();
            btn_Login = new Button();
            groupBox_Connexion.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Connexion
            // 
            groupBox_Connexion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox_Connexion.Controls.Add(btn_Register);
            groupBox_Connexion.Controls.Add(btn_Login);
            groupBox_Connexion.Location = new Point(12, 12);
            groupBox_Connexion.Name = "groupBox_Connexion";
            groupBox_Connexion.Size = new Size(344, 261);
            groupBox_Connexion.TabIndex = 0;
            groupBox_Connexion.TabStop = false;
            groupBox_Connexion.Text = "Connexion";
            // 
            // btn_Register
            // 
            btn_Register.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_Register.Location = new Point(6, 142);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(330, 106);
            btn_Register.TabIndex = 1;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_Login
            // 
            btn_Login.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_Login.Location = new Point(6, 30);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(330, 106);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // frm_Connexion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 285);
            Controls.Add(groupBox_Connexion);
            Name = "frm_Connexion";
            Text = "Connexion";
            groupBox_Connexion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Connexion;
        private Button btn_Register;
        private Button btn_Login;
    }
}