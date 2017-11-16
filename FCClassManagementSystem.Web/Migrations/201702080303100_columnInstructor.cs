namespace FCClassManagementSystem.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columnInstructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FitnessClasses", "Instructor", c => c.String());
            AlterColumn("dbo.FitnessClasses", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FitnessClasses", "Description", c => c.String());
            DropColumn("dbo.FitnessClasses", "Instructor");
        }
    }
}
