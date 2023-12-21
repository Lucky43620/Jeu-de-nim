using System;
using System.Collections.Generic;

namespace Jeu_de_Nim.Models;

public partial class Party
{
    public int IdPartie { get; set; }

    public int? IdJoueur1 { get; set; }

    public int? IdJoueur2 { get; set; }

    public int? BatonnetsRestants { get; set; }

    public int? Gagnant { get; set; }

    public int? TourJoueur { get; set; }

    public virtual ICollection<ActionsJoueur> ActionsJoueurs { get; set; } = new List<ActionsJoueur>();

    public virtual Joueur? IdJoueur1Navigation { get; set; }

    public virtual Joueur? IdJoueur2Navigation { get; set; }
}
