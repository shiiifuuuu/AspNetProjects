namespace Vidly.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreDataAdd : DbMigration
    {
        public override void Up()
        {
	        Sql("INSERT into Genres (Name) VALUES ('Action')");
	        Sql("INSERT into Genres (Name) VALUES ('Adventure')");
	        Sql("INSERT into Genres (Name) VALUES ('Comedy')");
	        Sql("INSERT into Genres (Name) VALUES ('Drama')");
	        Sql("INSERT into Genres (Name) VALUES ('Fantasy')");
	        Sql("INSERT into Genres (Name) VALUES ('Horror')");
	        Sql("INSERT into Genres (Name) VALUES ('Romance')");
	        Sql("INSERT into Genres (Name) VALUES ('Thriller')");
	        Sql("INSERT into Genres (Name) VALUES ('Western')");
        }
        
        public override void Down()
        {
        }
    }
}
