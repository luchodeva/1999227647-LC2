namespace CajeroAutomatico.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cuentas",
                c => new
                    {
                        cuentaId = c.Int(nullable: false, identity: true),
                        numeroCuenta = c.Int(nullable: false),
                        pin = c.Int(nullable: false),
                        saldoDisponible = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.cuentaId);
            
            CreateTable(
                "dbo.Retiros",
                c => new
                    {
                        retiroId = c.Int(nullable: false, identity: true),
                        fechaRetiro = c.DateTime(nullable: false),
                        montoRetiro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.retiroId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Retiros");
            DropTable("dbo.Cuentas");
        }
    }
}
