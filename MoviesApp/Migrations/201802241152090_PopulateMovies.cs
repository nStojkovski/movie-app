namespace MoviesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ( 'Hangover', CAST('2015-02-23' AS DATETIME), CAST('2016-01-01' AS DATETIME), 5, 2)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ( 'Die Hard', CAST('2016-07-30' AS DATETIME), CAST('2016-01-01' AS DATETIME), 6, 1)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ( 'The Terminator', CAST('2011-11-01' AS DATETIME), CAST('2016-01-01' AS DATETIME), 5, 4)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ( 'Toy Story', CAST('2010-04-11' AS DATETIME), CAST('2016-01-01' AS DATETIME), 4, 2)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ( 'Titanic', CAST('2000-01-18' AS DATETIME), CAST('2016-01-01' AS DATETIME), 3, 3)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ( 'Alien', CAST('1997-12-31' AS DATETIME), CAST('2016-01-01' AS DATETIME), 1, 5)");
            Sql("INSERT INTO Movies ( Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ( 'American Pie', CAST('2003-08-13' AS DATETIME), CAST('2016-01-01' AS DATETIME), 7, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
