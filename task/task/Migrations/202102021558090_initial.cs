namespace task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        address = c.String(maxLength: 200),
                        mobile = c.String(maxLength: 50),
                        doctorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.doctorID, cascadeDelete: true)
                .Index(t => t.doctorID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 50),
                        mobile = c.String(maxLength: 50),
                        speciality = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RXes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        patientID = c.Int(nullable: false),
                        clinicID = c.Int(nullable: false),
                        date = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinics", t => t.clinicID, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.patientID, cascadeDelete: true)
                .Index(t => t.patientID)
                .Index(t => t.clinicID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 50),
                        mobile = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RX_details",
                c => new
                    {
                        RXId = c.Int(nullable: false),
                        medicineId = c.Int(nullable: false),
                        dosage = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => new { t.RXId, t.medicineId })
                .ForeignKey("dbo.Medicines", t => t.medicineId, cascadeDelete: true)
                .ForeignKey("dbo.RXes", t => t.RXId, cascadeDelete: true)
                .Index(t => t.RXId)
                .Index(t => t.medicineId);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 50),
                        code = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RX_details", "RXId", "dbo.RXes");
            DropForeignKey("dbo.RX_details", "medicineId", "dbo.Medicines");
            DropForeignKey("dbo.RXes", "patientID", "dbo.Patients");
            DropForeignKey("dbo.RXes", "clinicID", "dbo.Clinics");
            DropForeignKey("dbo.Clinics", "doctorID", "dbo.Doctors");
            DropIndex("dbo.RX_details", new[] { "medicineId" });
            DropIndex("dbo.RX_details", new[] { "RXId" });
            DropIndex("dbo.RXes", new[] { "clinicID" });
            DropIndex("dbo.RXes", new[] { "patientID" });
            DropIndex("dbo.Clinics", new[] { "doctorID" });
            DropTable("dbo.Medicines");
            DropTable("dbo.RX_details");
            DropTable("dbo.Patients");
            DropTable("dbo.RXes");
            DropTable("dbo.Doctors");
            DropTable("dbo.Clinics");
        }
    }
}
