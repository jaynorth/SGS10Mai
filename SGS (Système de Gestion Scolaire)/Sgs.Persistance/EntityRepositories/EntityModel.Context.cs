﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sgs.Persistance.EntityRepositories
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SGS_Entities : DbContext
    {
        public SGS_Entities()
            : base("name=SGS_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbCour> tbCours { get; set; }
        public virtual DbSet<tbEnseignant> tbEnseignants { get; set; }
        public virtual DbSet<tbEtudiant> tbEtudiants { get; set; }
        public virtual DbSet<tbFormation> tbFormations { get; set; }
        public virtual DbSet<tbSession> tbSessions { get; set; }
    }
}
