﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vue
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gestlivraisonEntities6 : DbContext
    {
        public gestlivraisonEntities6()
            : base("name=gestlivraisonEntities6")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<colis> colis { get; set; }
        public virtual DbSet<Depot> Depot { get; set; }
        public virtual DbSet<Etat> Etat { get; set; }
        public virtual DbSet<etatcolis> etatcolis { get; set; }
        public virtual DbSet<expediteur> expediteur { get; set; }
        public virtual DbSet<livreur> livreur { get; set; }
        public virtual DbSet<RecetteExpediteur> RecetteExpediteur { get; set; }
        public virtual DbSet<Reclamation> Reclamation { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}
