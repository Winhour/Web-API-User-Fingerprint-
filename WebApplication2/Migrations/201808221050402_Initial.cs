namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fingerprints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LThumb = c.String(),
                        LIndex = c.String(),
                        LMiddle = c.String(),
                        LRing = c.String(),
                        LLittle = c.String(),
                        RThumb = c.String(),
                        RIndex = c.String(),
                        RMiddle = c.String(),
                        RRing = c.String(),
                        RLittle = c.String(),
                        LThumbC = c.String(),
                        LIndexC = c.String(),
                        LMiddleC = c.String(),
                        LRingC = c.String(),
                        LLittleC = c.String(),
                        RThumbC = c.String(),
                        RIndexC = c.String(),
                        RMiddleC = c.String(),
                        RRingC = c.String(),
                        RLittleC = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User_Data",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Fingerprint_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User_Data");
            DropTable("dbo.Fingerprints");
        }
    }
}
