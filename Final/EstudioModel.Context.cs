﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBESTUDIO2010Entities : DbContext
    {
        public DBESTUDIO2010Entities()
            : base("name=DBESTUDIO2010Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ALUMNOS> ALUMNOS { get; set; }
        public virtual DbSet<CARRERAS> CARRERAS { get; set; }
        public virtual DbSet<CURSOS> CURSOS { get; set; }
        public virtual DbSet<NOTAS> NOTAS { get; set; }
    
        public virtual ObjectResult<listar1_Result> listar1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<listar1_Result>("listar1");
        }
    }
}