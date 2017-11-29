namespace TalentosEasy
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDados : DbContext
    {
        public ModelDados()
            : base("name=ModelDados")
        {
        }

        public virtual DbSet<Conhecimentos> Conhecimentos { get; set; }
        public virtual DbSet<Talentos> Talentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conhecimentos>()
                .Property(e => e.nomeConhecimento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.nomeTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.emailTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.cidadeTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.telefoneTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.linkedinTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.skypeTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.estadoTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.portifolioTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.disponibilidadeTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.horarioTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.pretencaoTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.nomeTalentoBanco)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.agenciaTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.cpfTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.contaTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.bancoTalento)
                .IsUnicode(false);

            modelBuilder.Entity<Talentos>()
                .Property(e => e.tipoContaTalento)
                .IsUnicode(false);
        }
    }
}
