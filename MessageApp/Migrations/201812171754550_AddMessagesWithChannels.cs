namespace MessageApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMessagesWithChannels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Channels",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Content = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        Channel_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Channels", t => t.Channel_Id)
                .Index(t => t.Channel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "Channel_Id", "dbo.Channels");
            DropIndex("dbo.Messages", new[] { "Channel_Id" });
            DropTable("dbo.Messages");
            DropTable("dbo.Channels");
        }
    }
}
