namespace NgocTram_2080601170.Migrations
{
    using NgocTram_2080601170.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES ( NAME) VALUES ( 'Development')");
            Sql("INSERT INTO CATEGORIES ( NAME) VALUES ( 'Business')");
            Sql("INSERT INTO CATEGORIES ( NAME) VALUES (  'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
