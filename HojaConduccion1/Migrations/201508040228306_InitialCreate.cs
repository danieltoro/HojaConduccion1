namespace HojaConduccion1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Maniobras",
                c => new
                    {
                        ManiobraID = c.Int(nullable: false, identity: true),
                        Tren = c.Int(nullable: false),
                        CocheP = c.Int(nullable: false),
                        Radio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ManiobraID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Maniobras");
        }
    }
}
