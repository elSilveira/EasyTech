namespace TalentosEasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conhecimentos",
                c => new
                    {
                        IdConhecimento = c.Int(nullable: false, identity: true),
                        NomeConhecimento = c.String(),
                        NotaConhecimento = c.Int(nullable: false),
                        Talento_IdTalento = c.Int(),
                    })
                .PrimaryKey(t => t.IdConhecimento)
                .ForeignKey("dbo.Talento", t => t.Talento_IdTalento)
                .Index(t => t.Talento_IdTalento);
            
            CreateTable(
                "dbo.Talento",
                c => new
                    {
                        IdTalento = c.Int(nullable: false, identity: true),
                        NomeTalento = c.String(),
                        EmailTalento = c.String(),
                        CidadeTalento = c.String(),
                        TelefoneTalento = c.String(),
                        LinkedinTalento = c.String(),
                        SkypeTalento = c.String(),
                        EstadoTalento = c.String(),
                        PortifolioTalento = c.String(),
                        DisponibilidadeTalento = c.String(),
                        HorarioTalento = c.String(),
                        PretencaoTalento = c.String(),
                        NomeTalentoBanco = c.String(),
                        AgenciaTalento = c.String(),
                        CpfTalento = c.String(),
                        ContaTalento = c.String(),
                        BancoTalento = c.String(),
                        TipoContaTalento = c.String(),
                        OutroConhecimentoTalento = c.String(),
                        CrudTalento = c.String(),
                    })
                .PrimaryKey(t => t.IdTalento);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Conhecimentos", "Talento_IdTalento", "dbo.Talento");
            DropIndex("dbo.Conhecimentos", new[] { "Talento_IdTalento" });
            DropTable("dbo.Talento");
            DropTable("dbo.Conhecimentos");
        }
    }
}
