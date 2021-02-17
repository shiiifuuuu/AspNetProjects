namespace Vidly.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
			INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd1fc0b7b-5320-46d5-8a15-73fa4acc4c95', N'CanManageCustomers')

			INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'08b5fc3c-f6cc-4d50-ab80-90fc33a27fd8', N'guest@email.com', 0, N'ALwLYJ/IK67GacDiLwwMTh3KbD+R8O/KqzeO727/UgGO/okXdHnJ4gRgbkiUlRxtGw==', N'f858a8dd-9d10-491e-b2ed-0c9c681ee5cb', NULL, 0, 0, NULL, 1, 0, N'guest@email.com')

			INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bfa73194-9ee0-4936-af6b-40067df8127d', N'admin@vidly.com', 0, N'AGkJw8hY6wKvv82g/PBCSi50+PSo+BBkS/+35+7yDRu8+8tHrkqrDOHj6bQJmp3Idg==', N'2a56ccee-ac47-42ac-b1f2-6f7097fb0ff3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

			INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bfa73194-9ee0-4936-af6b-40067df8127d', N'd1fc0b7b-5320-46d5-8a15-73fa4acc4c95')
			");
        }
        
        public override void Down()
        {
        }
    }
}
