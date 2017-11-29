namespace TalentosEasy
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using TalentosEasy.Models;

    public partial class ModelDados : DbContext
    {
        public ModelDados()
            : base("name=ModelDados")
        {
        }

        public virtual DbSet<Conhecimento> Conhecimento { get; set; }
        public virtual DbSet<Talento> Talento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
