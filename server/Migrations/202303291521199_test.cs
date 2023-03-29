﻿namespace server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "PaidAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "PaidAt", c => c.DateTime(nullable: false));
        }
    }
}
