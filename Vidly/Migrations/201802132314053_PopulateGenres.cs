namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES('Horror')");
            Sql("INSERT INTO Genres(Name) VALUES('Comedy')");
            Sql("INSERT INTO Genres(Name) VALUES('Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
