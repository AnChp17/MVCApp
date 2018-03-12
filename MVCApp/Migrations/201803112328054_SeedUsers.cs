namespace MVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'da5d53b9-3485-49ea-8539-b724b4959bfc', N'guest@vidly.com', 0, N'ADyAYhazxwZXBBc+H4t/AIhyVANGln+aDikKb3FfiEUxbk74y2edvCaOs5MmCzzG3Q==', N'a4acf113-fd6d-4382-aac1-2860e890ad1a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dc48c42e-615e-4ab0-872d-5efcb9024314', N'admin@vidly.com', 0, N'AAJk8oiKJgREgu+RmvVjfHFjRg2FF7Y/15kOYHZdE4IzNN4XI1dIGZ93qxS12irxjA==', N'75e5c29c-774f-4a87-b097-d21f145e9e8f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'59f0843c-d002-4808-94b5-548217881338', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dc48c42e-615e-4ab0-872d-5efcb9024314', N'59f0843c-d002-4808-94b5-548217881338')


");
        }
        
        public override void Down()
        {
        }
    }
}
