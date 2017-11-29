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
                        idConhecimento = c.Int(nullable: false),
                        idTalento = c.Int(),
                        nomeConhecimento = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idConhecimento)
                .ForeignKey("dbo.Talentos", t => t.idTalento)
                .Index(t => t.idTalento);
            
            CreateTable(
                "dbo.Talentos",
                c => new
                    {
                        idTalento = c.Int(nullable: false),
                        nomeTalento = c.String(maxLength: 254, unicode: false),
                        emailTalento = c.String(maxLength: 254, unicode: false),
                        cidadeTalento = c.String(maxLength: 254, unicode: false),
                        telefoneTalento = c.String(maxLength: 254, unicode: false),
                        linkedinTalento = c.String(maxLength: 254, unicode: false),
                        skypeTalento = c.String(maxLength: 254, unicode: false),
                        estadoTalento = c.String(maxLength: 254, unicode: false),
                        portifolioTalento = c.String(maxLength: 254, unicode: false),
                        disponibilidadeTalento = c.String(maxLength: 254, unicode: false),
                        horarioTalento = c.String(maxLength: 254, unicode: false),
                        pretencaoTalento = c.String(maxLength: 254, unicode: false),
                        nomeTalentoBanco = c.String(maxLength: 254, unicode: false),
                        agenciaTalento = c.String(maxLength: 254, unicode: false),
                        cpfTalento = c.String(maxLength: 254, unicode: false),
                        contaTalento = c.String(maxLength: 254, unicode: false),
                        bancoTalento = c.String(maxLength: 254, unicode: false),
                        tipoContaTalento = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idTalento);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Conhecimentos", "idTalento", "dbo.Talentos");
            DropIndex("dbo.Conhecimentos", new[] { "idTalento" });
            DropTable("dbo.Talentos");
            DropTable("dbo.Conhecimentos");
        }
    }
}
