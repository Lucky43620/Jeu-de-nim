namespace Jeu_de_Nim.Vue
{
    public partial class frm_Accueil : Form
    {
        public int IdJoueur { get; set; }
        public string NomJoueur { get; set; }
        public int NbVictoires { get; set; }
        public int NbDefaites { get; set; }

        public frm_Accueil()
        {
            InitializeComponent();
        }

        public void MettreAJourInfosJoueur()
        {
            label_NomJoueur.Text = NomJoueur;
            label_NbVictoire.Text = NbVictoires.ToString();
            label_NbDefaite.Text = NbDefaites.ToString();
        }

        private void btn_Deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
