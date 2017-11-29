namespace TalentosEasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conhecimentos",
                c => new
                    {
                        IdConhecimento = c.Int(nullable: false, identity: true),
                        IdTalento = c.Int(nullable: false),
                        NomeConhecimento = c.String(),
                    })
                .PrimaryKey(t => t.IdConhecimento)
                .ForeignKey("dbo.Talento", t => t.IdTalento, cascadeDelete: true)
                .Index(t => t.IdTalento);
            
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
            DropForeignKey("dbo.Conhecimentos", "IdTalento", "dbo.Talento");
            DropIndex("dbo.Conhecimentos", new[] { "IdTalento" });
            DropTable("dbo.Talento");
            DropTable("dbo.Conhecimentos");
        }
    }
}
