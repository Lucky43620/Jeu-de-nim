using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_Nim.Vue
{
    public partial class frm_Connexion : Form
    {
        public frm_Connexion()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            frm_Login loginForm = new frm_Login();
            loginForm.ShowDialog();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            frm_Inscription registerForm = new frm_Inscription();
            registerForm.ShowDialog();
        }
    }
}
