namespace BlogCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdfasdf : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.TestCs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TestCs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Age = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
