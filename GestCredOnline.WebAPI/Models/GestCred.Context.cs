﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestCredOnline.WebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GestCredOnline_DBEntities : DbContext
    {
        public GestCredOnline_DBEntities()
            : base("name=GestCredOnline_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<EmployeurContrat> EmployeurContrat { get; set; }
        public virtual DbSet<Fichier> Fichier { get; set; }
        public virtual DbSet<PieceType> PieceType { get; set; }
        public virtual DbSet<ProductProgram> ProductProgram { get; set; }
        public virtual DbSet<ProductProgramCheckList> ProductProgramCheckList { get; set; }
        public virtual DbSet<RegimeMatrimonial> RegimeMatrimonial { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<EntreprisesAgrees> EntreprisesAgrees { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Prospects> Prospects { get; set; }
    }
}
