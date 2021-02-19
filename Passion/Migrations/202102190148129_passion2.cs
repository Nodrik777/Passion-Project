namespace Passion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class passion2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Species", "SpeciesType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Species", "SpeciesType");
        }
    }
}
