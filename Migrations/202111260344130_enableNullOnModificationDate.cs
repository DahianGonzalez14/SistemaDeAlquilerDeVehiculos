namespace SistemaDeAlquilerDeVehiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enableNullOnModificationDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alquiler", "FechaDevolucion", c => c.DateTime());
            AlterColumn("dbo.Alquiler", "FechaModificacion", c => c.DateTime());
            AlterColumn("dbo.Cliente", "FechaModificacion", c => c.DateTime());
            AlterColumn("dbo.Vehiculo", "FechaModificacion", c => c.DateTime());
            AlterColumn("dbo.Modelo", "FechaModificacion", c => c.DateTime());
            AlterColumn("dbo.Marca", "FechaModificacion", c => c.DateTime());
            AlterColumn("dbo.TipoCombustible", "FechaModificacion", c => c.DateTime());
            AlterColumn("dbo.TipoTransmision", "FechaModificacion", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TipoTransmision", "FechaModificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TipoCombustible", "FechaModificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Marca", "FechaModificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Modelo", "FechaModificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vehiculo", "FechaModificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cliente", "FechaModificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Alquiler", "FechaModificacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Alquiler", "FechaDevolucion", c => c.DateTime(nullable: false));
        }
    }
}
