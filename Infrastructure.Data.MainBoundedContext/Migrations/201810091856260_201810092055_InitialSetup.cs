namespace Infrastructure.Data.MainBoundedContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _201810092055_InitialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Identifier = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 150),
                        LastName = c.String(nullable: false, maxLength: 300),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Infractions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DriverId = c.Guid(nullable: false),
                        VehicleId = c.Guid(nullable: false),
                        InfractionTypeId = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.DriverId, cascadeDelete: true)
                .ForeignKey("dbo.InfractionTypes", t => t.InfractionTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.DriverId)
                .Index(t => t.VehicleId)
                .Index(t => t.InfractionTypeId);
            
            CreateTable(
                "dbo.InfractionTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 150),
                        Points = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        License = c.String(nullable: false, maxLength: 10),
                        BrandId = c.Guid(nullable: false),
                        Model = c.String(nullable: false, maxLength: 50),
                        DriverId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .ForeignKey("dbo.Drivers", t => t.DriverId)
                .Index(t => t.BrandId)
                .Index(t => t.DriverId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Infractions", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Vehicles", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Infractions", "InfractionTypeId", "dbo.InfractionTypes");
            DropForeignKey("dbo.Infractions", "DriverId", "dbo.Drivers");
            DropIndex("dbo.Vehicles", new[] { "DriverId" });
            DropIndex("dbo.Vehicles", new[] { "BrandId" });
            DropIndex("dbo.Infractions", new[] { "InfractionTypeId" });
            DropIndex("dbo.Infractions", new[] { "VehicleId" });
            DropIndex("dbo.Infractions", new[] { "DriverId" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.InfractionTypes");
            DropTable("dbo.Infractions");
            DropTable("dbo.Drivers");
            DropTable("dbo.Brands");
        }
    }
}
