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
    public partial class frm_Inscription : Form
    {
        private readonly BmlContext _context;
        public frm_Inscription()
        {
            InitializeComponent();
            _context = new BmlContext();
        }

        private void btn_Inscription_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = textBox_NomJoueur.Text;
            string motDePasse = textBox_MotDePasse.Text;
            string repeterMotDePasse = textBox_RepeterMotDePasse.Text;

            // Vérifier si les champs sont renseignés
            if (string.IsNullOrWhiteSpace(nomUtilisateur) || string.IsNullOrWhiteSpace(motDePasse) || string.IsNullOrWhiteSpace(repeterMotDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            // Vérifier si les deux mots de passe correspondent
            if (motDePasse != repeterMotDePasse)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas !");
                return;
            }

            // Vérifier si le nom d'utilisateur est déjà pris
            if (_context.Joueurs.Any(j => j.NomUtilisateur == nomUtilisateur))
            {
                MessageBox.Show("Ce nom d'utilisateur est déjà pris !");
                return;
            }

            // Créer un nouvel utilisateur
            Joueur nouvelUtilisateur = new Joueur
            {
                NomUtilisateur = nomUtilisateur,
                MotDePasse = motDePasse,
                // Vous pouvez également initialiser d'autres propriétés ici si nécessaire
                Victoires = 0,
                Defaites = 0
            };

            // Ajouter le nouvel utilisateur à la base de données
            _context.Joueurs.Add(nouvelUtilisateur);
            _context.SaveChanges();

            MessageBox.Show("Inscription réussie ! Vous pouvez maintenant vous connecter.");

            // Fermer le formulaire d'inscription après l'enregistrement réussi
            this.Close();
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
