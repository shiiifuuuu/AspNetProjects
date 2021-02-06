﻿namespace Vidly.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTable : DbMigration
    {
        public override void Up()
        {
	        Sql("UPDATE MembershipTypes SET Name='Basic' WHERE Id=1");
	        Sql("UPDATE MembershipTypes SET Name='Monthly' WHERE Id=2");
	        Sql("UPDATE MembershipTypes SET Name='Quarterly' WHERE Id=3");
	        Sql("UPDATE MembershipTypes SET Name='Yearly' WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
