using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Jeu_de_Nim.Models;

public partial class BmlContext : DbContext
{
    public BmlContext()
    {
    }

    public BmlContext(DbContextOptions<BmlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActionsJoueur> ActionsJoueurs { get; set; }

    public virtual DbSet<Classement> Classements { get; set; }

    public virtual DbSet<Joueur> Joueurs { get; set; }

    public virtual DbSet<Party> Parties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=192.168.29.13,1433\\MSSQLSERVER;User ID=sa;Password=erty64%;Database=BML;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActionsJoueur>(entity =>
        {
            entity.HasKey(e => e.IdAction).HasName("PK__Actions___18CD692F3ADB4D68");

            entity.ToTable("Actions_Joueurs");

            entity.Property(e => e.IdAction).HasColumnName("ID_Action");
            entity.Property(e => e.IdJoueur).HasColumnName("ID_Joueur");
            entity.Property(e => e.IdPartie).HasColumnName("ID_Partie");
            entity.Property(e => e.NombreBatonnetsRetires).HasColumnName("Nombre_batonnets_retires");
            entity.Property(e => e.TempsAction)
                .HasColumnType("datetime")
                .HasColumnName("Temps_action");

            entity.HasOne(d => d.IdJoueurNavigation).WithMany(p => p.ActionsJoueurs)
                .HasForeignKey(d => d.IdJoueur)
                .HasConstraintName("FK__Actions_J__ID_Jo__4E88ABD4");

            entity.HasOne(d => d.IdPartieNavigation).WithMany(p => p.ActionsJoueurs)
                .HasForeignKey(d => d.IdPartie)
                .HasConstraintName("FK__Actions_J__ID_Pa__4D94879B");
        });

        modelBuilder.Entity<Classement>(entity =>
        {
            entity.HasKey(e => e.IdClassement).HasName("PK__Classeme__4D53BC817D28E1B4");

            entity.ToTable("Classement");

            entity.Property(e => e.IdClassement).HasColumnName("ID_Classement");
            entity.Property(e => e.IdJoueur).HasColumnName("ID_Joueur");

            entity.HasOne(d => d.IdJoueurNavigation).WithMany(p => p.Classements)
                .HasForeignKey(d => d.IdJoueur)
                .HasConstraintName("FK__Classemen__ID_Jo__4AB81AF0");
        });

        modelBuilder.Entity<Joueur>(entity =>
        {
            entity.HasKey(e => e.IdJoueur).HasName("PK__Joueurs__DBEE7609ECC67156");

            entity.Property(e => e.IdJoueur).HasColumnName("ID_Joueur");
            entity.Property(e => e.Defaites).HasDefaultValue(0);
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Mot_de_passe");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nom_utilisateur");
            entity.Property(e => e.Victoires).HasDefaultValue(0);
        });

        modelBuilder.Entity<Party>(entity =>
        {
            entity.HasKey(e => e.IdPartie).HasName("PK__Parties__23E2AA57AAAE038E");

            entity.Property(e => e.IdPartie).HasColumnName("ID_Partie");
            entity.Property(e => e.BatonnetsRestants).HasColumnName("Batonnets_restants");
            entity.Property(e => e.IdJoueur1).HasColumnName("ID_Joueur1");
            entity.Property(e => e.IdJoueur2).HasColumnName("ID_Joueur2");
            entity.Property(e => e.TourJoueur).HasColumnName("Tour_joueur");

            entity.HasOne(d => d.IdJoueur1Navigation).WithMany(p => p.PartyIdJoueur1Navigations)
                .HasForeignKey(d => d.IdJoueur1)
                .HasConstraintName("FK__Parties__ID_Joue__46E78A0C");

            entity.HasOne(d => d.IdJoueur2Navigation).WithMany(p => p.PartyIdJoueur2Navigations)
                .HasForeignKey(d => d.IdJoueur2)
                .HasConstraintName("FK__Parties__ID_Joue__47DBAE45");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
