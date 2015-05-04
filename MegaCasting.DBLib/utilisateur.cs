//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            this.abonnements = new HashSet<Abonnement>();
            this.competences = new HashSet<Competence>();
            this.historiques = new HashSet<Historique>();
            this.multimedias = new HashSet<Multimedia>();
            this.metiers = new HashSet<Metier>();
            this.offres = new HashSet<Offre>();
        }
    
        public int Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public System.DateTime DateNaissance { get; set; }
        public int IdentifiantTypeutilisateur { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public Nullable<int> IdentifiantAdresse { get; set; }
    
        public virtual ICollection<Abonnement> abonnements { get; set; }
        public virtual Adresse adresse { get; set; }
        public virtual ICollection<Competence> competences { get; set; }
        public virtual ICollection<Historique> historiques { get; set; }
        public virtual ICollection<Multimedia> multimedias { get; set; }
        public virtual TypeUtilisateur typeutilisateur { get; set; }
        public virtual ICollection<Metier> metiers { get; set; }
        public virtual ICollection<Offre> offres { get; set; }
    }
}
