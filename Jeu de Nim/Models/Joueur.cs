using System;
using System.Collections.Generic;

namespace Jeu_de_Nim.Models;

public partial class Joueur
{
    public int IdJoueur { get; set; }

    public string NomUtilisateur { get; set; } = null!;

    public string MotDePasse { get; set; } = null!;

    public int? Victoires { get; set; }

    public int? Defaites { get; set; }

    public virtual ICollection<ActionsJoueur> ActionsJoueurs { get; set; } = new List<ActionsJoueur>();

    public virtual ICollection<Classement> Classements { get; set; } = new List<Classement>();

    public virtual ICollection<Party> PartyIdJoueur1Navigations { get; set; } = new List<Party>();

    public virtual ICollection<Party> PartyIdJoueur2Navigations { get; set; } = new List<Party>();
}
