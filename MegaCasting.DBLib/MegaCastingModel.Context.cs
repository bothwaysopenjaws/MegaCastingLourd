﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaCasting.DBLib
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class megacastingEntities : DbContext
    {
        public megacastingEntities()
            : base("name=megacastingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<abonnement> abonnements { get; set; }
        public DbSet<adresse> adresses { get; set; }
        public DbSet<candidature> candidatures { get; set; }
        public DbSet<competence> competences { get; set; }
        public DbSet<domaine> domaines { get; set; }
        public DbSet<historique> historiques { get; set; }
        public DbSet<metier> metiers { get; set; }
        public DbSet<multimedia> multimedias { get; set; }
        public DbSet<niveau> niveaux { get; set; }
        public DbSet<offre> offres { get; set; }
        public DbSet<typeabonnement> typeabonnements { get; set; }
        public DbSet<typecompetence> typecompetences { get; set; }
        public DbSet<typecontrat> typecontrats { get; set; }
        public DbSet<typemedia> typemedias { get; set; }
        public DbSet<typeutilisateur> typeutilisateurs { get; set; }
        public DbSet<utilisateur> utilisateurs { get; set; }
    }
}
