namespace Passion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class passion3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PetDtoes",
                c => new
                    {
                        PetID = c.Int(nullable: false, identity: true),
                        PetName = c.String(),
                        PetBreed = c.String(),
                        PetWeight = c.Int(nullable: false),
                        SpeciesID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PetID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PetDtoes");
        }
    }
}
