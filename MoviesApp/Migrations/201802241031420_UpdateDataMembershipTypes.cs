namespace MoviesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quartly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Year' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
