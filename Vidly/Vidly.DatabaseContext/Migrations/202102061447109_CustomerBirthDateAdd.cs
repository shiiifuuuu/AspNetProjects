﻿namespace Vidly.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerBirthDateAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DoB", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DoB");
        }
    }
}
