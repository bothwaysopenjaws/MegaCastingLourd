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
    
    public partial class domaine
    {
        public domaine()
        {
            this.metiers = new HashSet<metier>();
            this.utilisateurs = new HashSet<utilisateur>();
        }
    
        public int id { get; set; }
        public string libelle { get; set; }
    
        public virtual ICollection<metier> metiers { get; set; }
        public virtual ICollection<utilisateur> utilisateurs { get; set; }
    }
}
