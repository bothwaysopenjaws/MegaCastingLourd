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
    
    public partial class metier
    {
        public metier()
        {
            this.offres = new HashSet<offre>();
        }
    
        public int id { get; set; }
        public Nullable<int> domaine_id { get; set; }
        public string libelle { get; set; }
        public string description { get; set; }
    
        public virtual domaine domaine { get; set; }
        public virtual ICollection<offre> offres { get; set; }
    }
}
