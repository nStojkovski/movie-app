namespace MoviesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataBirthdayCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = CAST('1995-08-13' AS DATETIME) WHERE Id = 1");
            Sql("UPDATE Customers SET Birthday = CAST('1990-12-10' AS DATETIME) WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
