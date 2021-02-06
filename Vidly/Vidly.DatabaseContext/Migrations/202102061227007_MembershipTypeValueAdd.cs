namespace Vidly.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeValueAdd : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)"); //Pay as you go type
            Sql("INSERT into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)"); //1 month type
            Sql("INSERT into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)"); //3 month type
            Sql("INSERT into MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 300, 12, 20)"); //12 month type
        }
        
        public override void Down()
        {
        }
    }
}
