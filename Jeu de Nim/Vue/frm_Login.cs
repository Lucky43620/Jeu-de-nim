using Jeu_de_Nim.Models;
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
    public partial class frm_Login : Form
    {
        private readonly BmlContext _context;
        public frm_Login()
        {
            InitializeComponent();
            _context = new BmlContext();
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = textBox_NomJoueur.Text;
            string motDePasse = textBox_MotDePasse.Text;

            // Vérifier si les champs sont renseignés
            if (string.IsNullOrWhiteSpace(nomUtilisateur) || string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            // Vérifier les informations d'identification dans la base de données
            Joueur utilisateur = _context.Joueurs
                .FirstOrDefault(j => j.NomUtilisateur == nomUtilisateur && j.MotDePasse == motDePasse);

            if (utilisateur != null)
            {
                // L'utilisateur est authentifié avec succès
                MessageBox.Show("Connexion réussie !");

                // Créer le formulaire d'accueil et transmettre les informations du joueur
                frm_Accueil accueilForm = new frm_Accueil();
                accueilForm.IdJoueur = utilisateur.IdJoueur;
                accueilForm.NomJoueur = utilisateur.NomUtilisateur;
                accueilForm.NbVictoires = utilisateur.Victoires ?? 0;
                accueilForm.NbDefaites = utilisateur.Defaites ?? 0;

                // Mettre à jour les labels avec les infos du joueur
                accueilForm.MettreAJourInfosJoueur();

                this.Hide();

                // Afficher le formulaire d'accueil
                accueilForm.ShowDialog();

                this.Close(); // Fermer la fenêtre de connexion une fois que l'utilisateur a terminé avec succès
            }
            else
            {
                // Identifiants incorrects
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
