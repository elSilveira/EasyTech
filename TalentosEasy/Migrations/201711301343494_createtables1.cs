namespace TalentosEasy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtables1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Conhecimentos", newName: "Conhecimento");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Conhecimento", newName: "Conhecimentos");
        }
    }
}
