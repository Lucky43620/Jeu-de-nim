using System;
using System.Collections.Generic;

namespace Jeu_de_Nim.Models;

public partial class Classement
{
    public int IdClassement { get; set; }

    public int? IdJoueur { get; set; }

    public int? Position { get; set; }

    public virtual Joueur? IdJoueurNavigation { get; set; }
}
