﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
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
    
        public DbSet<Abonnement> Abonnements { get; set; }
        public DbSet<Candidature> Candidatures { get; set; }
        public DbSet<Competence> Competences { get; set; }
        public DbSet<Historique> Historiques { get; set; }
        public DbSet<Metier> Metiers { get; set; }
        public DbSet<Multimedia> Multimedias { get; set; }
        public DbSet<Niveau> Niveaux { get; set; }
        public DbSet<TypeAbonnement> TypeAbonnements { get; set; }
        public DbSet<TypeCompetence> TypeCompetences { get; set; }
        public DbSet<TypeContrat> TypeContrats { get; set; }
        public DbSet<TypeMedia> TypeMedias { get; set; }
        public DbSet<TypeUtilisateur> TypeUtilisateurs { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Domaine> Domaines { get; set; }
        public DbSet<Offre> Offres { get; set; }
    }
}
