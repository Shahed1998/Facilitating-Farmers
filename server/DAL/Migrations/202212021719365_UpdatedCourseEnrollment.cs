namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCourseEnrollment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CourseEnrollments", "Review", c => c.String(nullable: false, maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CourseEnrollments", "Review", c => c.String(nullable: false));
        }
    }
}
