namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addojectorientated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "PAddress_Email", c => c.String());
            AddColumn("dbo.Person", "CreditsEarned", c => c.Double());
            AddColumn("dbo.Person", "Gpa", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Gpa");
            DropColumn("dbo.Person", "CreditsEarned");
            DropColumn("dbo.Person", "PAddress_Email");
        }
    }
}
