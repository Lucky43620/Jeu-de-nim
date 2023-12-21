using System;
using System.Collections.Generic;

namespace Jeu_de_Nim.Models;

public partial class ActionsJoueur
{
    public int IdAction { get; set; }

    public int? IdPartie { get; set; }

    public int? IdJoueur { get; set; }

    public int? NombreBatonnetsRetires { get; set; }

    public DateTime? TempsAction { get; set; }

    public virtual Joueur? IdJoueurNavigation { get; set; }

    public virtual Party? IdPartieNavigation { get; set; }
}
