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
    
    public partial class abonnement
    {
        public int id { get; set; }
        public int restant { get; set; }
        public Nullable<int> typeAbonnement_id { get; set; }
        public System.DateTime dateSouscription { get; set; }
        public int utilisateur_id { get; set; }
    
        public virtual typeabonnement typeabonnement { get; set; }
        public virtual utilisateur utilisateur { get; set; }
    }
}