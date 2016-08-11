namespace QuizBryan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Precio = c.Double(nullable: false),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carros");
        }
    }
}
