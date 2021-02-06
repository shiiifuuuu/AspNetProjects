namespace Vidly.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBMoviesValueUpdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate='2/24/2017', AddedDate='2/7/2018', InStock=3 WHERE Id=1");
            Sql("UPDATE Movies SET ReleaseDate='10/14/1994', AddedDate='5/17/2018', InStock=2 WHERE Id=2");
            Sql("UPDATE Movies SET ReleaseDate='3/1/2013', AddedDate='12/2/2019', InStock=8 WHERE Id=3");
            Sql("UPDATE Movies SET ReleaseDate='8/26/2016', AddedDate='7/27/2017', InStock=7 WHERE Id=4");
            Sql("UPDATE Movies SET ReleaseDate='7/18/2008', AddedDate='6/7/2020', InStock=1 WHERE Id=6");
        }
        
        public override void Down()
        {
        }
    }
}
