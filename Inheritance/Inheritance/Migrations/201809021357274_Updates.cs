namespace Inheritance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HireDate = c.DateTime(nullable: false),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FirstName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        InstructorID = c.Int(nullable: false),
                        Location = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.InstructorID)
                .ForeignKey("dbo.Instructors", t => t.InstructorID)
                .Index(t => t.InstructorID);
            
            AddColumn("dbo.Courses", "Instructor_ID", c => c.Int());
            CreateIndex("dbo.Courses", "Instructor_ID");
            AddForeignKey("dbo.Courses", "Instructor_ID", "dbo.Instructors", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "InstructorID", "dbo.Instructors");
            DropForeignKey("dbo.Courses", "Instructor_ID", "dbo.Instructors");
            DropIndex("dbo.OfficeAssignments", new[] { "InstructorID" });
            DropIndex("dbo.Courses", new[] { "Instructor_ID" });
            DropColumn("dbo.Courses", "Instructor_ID");
            DropTable("dbo.OfficeAssignments");
            DropTable("dbo.Instructors");
        }
    }
}
