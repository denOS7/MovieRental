namespace MovieRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Sci-Fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'War')");
        }
        
        public override void Down()
        {
        }
    }
}
