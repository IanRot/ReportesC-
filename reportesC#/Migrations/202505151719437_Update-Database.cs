namespace reportesC_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "ITEBIS", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Productoes", "TOTAL_GENERAL", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "TOTAL_GENERAL");
            DropColumn("dbo.Productoes", "ITEBIS");
        }
    }
}
