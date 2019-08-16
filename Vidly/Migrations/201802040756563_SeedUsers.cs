namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'763410b0-ca98-4a0d-bffc-23e9c9469d4a', N'admin@vidly.com', 0, N'ADKiY6yuwf50qt9yLl5YauqUPYiMXbw0ZU+A4hN5WfYzjmC/RwN12SwlnOt6Uw3LdQ==', N'53a26e42-58b2-4126-93aa-773f8552b56e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd352f1cb-f7c0-4ec9-9e98-5f1bab141691', N'guest@vidly.com', 0, N'AMptAFjAe7yDX2GgskAM5iGAdG0zFFJHXPlLiJXEZWU1udQfjQRlG4r9s9kTy41QGg==', N'07481689-82a7-4e97-bcce-401e90ced88a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8ecd1641-2a1d-4f5b-9552-648f769a8063', N'CanManageMovie')
        
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'763410b0-ca98-4a0d-bffc-23e9c9469d4a', N'8ecd1641-2a1d-4f5b-9552-648f769a8063')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
