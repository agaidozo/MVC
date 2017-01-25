namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'be330b5c-a0dc-4f2e-b472-feefcd7fa41f', N'admin@vidly.com', 0, N'AGJ9IGfuESannqYIabIFPGUJ7S3JhC3vL0XjOJqq/KD49NwpSYv57raTF4of1INd3w==', N'2f4259b7-e713-4494-8d49-5007d370729d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c83029ce-1db5-41f8-8b4b-8cc32d45cc0a', N'guest@vidly.com', 0, N'AFGiUa+AziKzEFtRveHPp14jixR0J947OuwkM9FOx5ovS2uOXb8ncEX+5dFMZloI7A==', N'9c8f7ebd-edbe-4c13-b5cb-7307a8d3f52f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'41456e15-39f9-4279-84e8-1e775288f2ab', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'be330b5c-a0dc-4f2e-b472-feefcd7fa41f', N'41456e15-39f9-4279-84e8-1e775288f2ab')

");
        }

        public override void Down()
        {
        }
    }
}
