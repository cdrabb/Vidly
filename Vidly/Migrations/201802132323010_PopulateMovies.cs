namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('The Ritual', 2/10/2018, 2/13/2018, 10, 1)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('Superbad', 3/1/2009, 5/11/2010, 7, 2)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('Lost', 7/20/2006, 2/11/2010, 0, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
