using SistemaDeAlquilerDeVehiculos.BackEnd.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAlquilerDeVehiculos.BackEnd.Models.Context
{
    public class Context : DbContext
    {
        public Context()
            : base("name=connectionAlquilerVehiculosDB")
        {
          
        }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<TipoCombustible> TipoCombustibles { get; set; }
        public DbSet<TipoTransmision> TipoTransmisions { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var alquiler = modelBuilder.Entity<Alquiler>();
            alquiler.ToTable("Alquiler");
            alquiler.HasKey(e => e.Id);
            alquiler.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).IsRequired();
            alquiler.Property(e => e.Id).HasColumnName("AlquilerId");
            alquiler.Property(e => e.MetodoPago).HasColumnName("MetodoPago").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            alquiler.Property(e => e.Costo).HasColumnName("Costo").HasColumnType("decimal").HasPrecision(10,2).IsRequired();
            alquiler.Property(e => e.FechaDesde).HasColumnName("FechaDesde").HasColumnType("datetime").IsRequired();
            alquiler.Property(e => e.FechaHasta).HasColumnName("FechaHasta").HasColumnType("datetime").IsRequired();
            alquiler.Property(e => e.FechaDevolucion).HasColumnName("FechaDevolucion").HasColumnType("datetime");
            alquiler.Property(e => e.Penalidad).HasColumnName("Penalidad").HasColumnType("decimal").HasPrecision(10, 2);
            alquiler.Property(e => e.Estatus).HasColumnName("Estatus").HasColumnType("varchar").HasMaxLength(2).IsRequired();
            alquiler.Property(e => e.Borrado).HasColumnName("Borrado").HasColumnType("bit").IsRequired();
            alquiler.Property(e => e.FechaRegistro).HasColumnName("FechaRegistro").HasColumnType("datetime").IsRequired();
            alquiler.Property(e => e.FechaModificacion).HasColumnName("FechaModificacion").HasColumnType("datetime");
            //foreing keys
            alquiler.HasRequired(e => e.Cliente).WithMany(e => e.Alquileres).HasForeignKey(e => e.ClienteId);
            alquiler.HasRequired(e => e.Vehiculo).WithMany(e => e.Alquileres).HasForeignKey(e => e.VehiculoId);

            var cliente = modelBuilder.Entity<Cliente>();
            cliente.ToTable("Cliente");
            cliente.HasKey(e => e.Id);
            cliente.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).IsRequired();
            cliente.Property(e => e.Id).HasColumnName("ClienteId");
            cliente.Property(e => e.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            cliente.Property(e => e.Apellido).HasColumnName("Apellido").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            cliente.Property(e => e.Direccion).HasColumnName("Direccion").HasColumnType("varchar").HasMaxLength(500).IsRequired();
            cliente.Property(e => e.Telefono).HasColumnName("Telefono").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            cliente.Property(e => e.Correo).HasColumnName("Correo").HasColumnType("varchar").HasMaxLength(100);
            cliente.Property(e => e.Cedula).HasColumnName("Cedula").HasColumnType("varchar").HasMaxLength(11).IsRequired();
            cliente.Property(e => e.Estatus).HasColumnName("Estatus").HasColumnType("varchar").HasMaxLength(2).IsRequired();
            cliente.Property(e => e.Borrado).HasColumnName("Borrado").HasColumnType("bit").IsRequired();
            cliente.Property(e => e.FechaRegistro).HasColumnName("FechaRegistro").HasColumnType("datetime").IsRequired();
            cliente.Property(e => e.FechaModificacion).HasColumnName("FechaModificacion").HasColumnType("datetime");

            var marca = modelBuilder.Entity<Marca>();
            marca.ToTable("Marca");
            marca.HasKey(e => e.Id);
            marca.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).IsRequired();
            marca.Property(e => e.Id).HasColumnName("MarcaId");
            marca.Property(e => e.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            marca.Property(e => e.Estatus).HasColumnName("Estatus").HasColumnType("varchar").HasMaxLength(2).IsRequired();
            marca.Property(e => e.Borrado).HasColumnName("Borrado").HasColumnType("bit").IsRequired();
            marca.Property(e => e.FechaRegistro).HasColumnName("FechaRegistro").HasColumnType("datetime").IsRequired();
            marca.Property(e => e.FechaModificacion).HasColumnName("FechaModificacion").HasColumnType("datetime");

            var modelo = modelBuilder.Entity<Modelo>();
            modelo.ToTable("Modelo");
            modelo.HasKey(e => e.Id);
            modelo.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).IsRequired();
            modelo.Property(e => e.Id).HasColumnName("ModeloId");
            modelo.Property(e => e.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            modelo.Property(e => e.Estatus).HasColumnName("Estatus").HasColumnType("varchar").HasMaxLength(2).IsRequired();
            modelo.Property(e => e.Borrado).HasColumnName("Borrado").HasColumnType("bit").IsRequired();
            modelo.Property(e => e.FechaRegistro).HasColumnName("FechaRegistro").HasColumnType("datetime").IsRequired();
            modelo.Property(e => e.FechaModificacion).HasColumnName("FechaModificacion").HasColumnType("datetime");
            //foreign key
            modelo.HasRequired(e => e.Marca).WithMany(e => e.Modelos).HasForeignKey(e => e.MarcaId);

            var tipoCombustible = modelBuilder.Entity<TipoCombustible>();
            tipoCombustible.ToTable("TipoCombustible");
            tipoCombustible.HasKey(e => e.Id);
            tipoCombustible.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).IsRequired();
            tipoCombustible.Property(e => e.Id).HasColumnName("TipoCombustibleId");
            tipoCombustible.Property(e => e.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            tipoCombustible.Property(e => e.Estatus).HasColumnName("Estatus").HasColumnType("varchar").HasMaxLength(2).IsRequired();
            tipoCombustible.Property(e => e.Borrado).HasColumnName("Borrado").HasColumnType("bit").IsRequired();
            tipoCombustible.Property(e => e.FechaRegistro).HasColumnName("FechaRegistro").HasColumnType("datetime").IsRequired();
            tipoCombustible.Property(e => e.FechaModificacion).HasColumnName("FechaModificacion").HasColumnType("datetime");

            var tipoTransmision = modelBuilder.Entity<TipoTransmision>();
            tipoTransmision.ToTable("TipoTransmision");
            tipoTransmision.HasKey(e => e.Id);
            tipoTransmision.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).IsRequired();
            tipoTransmision.Property(e => e.Id).HasColumnName("TipoTransmisionId");
            tipoTransmision.Property(e => e.Nombre).HasColumnName("Nombre").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            tipoTransmision.Property(e => e.Estatus).HasColumnName("Estatus").HasColumnType("varchar").HasMaxLength(2).IsRequired();
            tipoTransmision.Property(e => e.Borrado).HasColumnName("Borrado").HasColumnType("bit").IsRequired();
            tipoTransmision.Property(e => e.FechaRegistro).HasColumnName("FechaRegistro").HasColumnType("datetime").IsRequired();
            tipoTransmision.Property(e => e.FechaModificacion).HasColumnName("FechaModificacion").HasColumnType("datetime");

            var vehiculo = modelBuilder.Entity<Vehiculo>();
            vehiculo.ToTable("Vehiculo");
            vehiculo.HasKey(e => e.Id);
            vehiculo.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).IsRequired();
            vehiculo.Property(e => e.Id).HasColumnName("VehiculoId");
            vehiculo.Property(e => e.Chasis).HasColumnName("Chasis").HasColumnType("varchar").HasMaxLength(100).IsRequired();
            vehiculo.Property(e => e.Placa).HasColumnName("Placa").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            vehiculo.Property(e => e.Anio).HasColumnName("Anio").HasColumnType("varchar").HasMaxLength(4).IsRequired();
            vehiculo.Property(e => e.Color).HasColumnName("Color").HasColumnType("varchar").HasMaxLength(20).IsRequired();
            vehiculo.Property(e => e.Cilindraje).HasColumnName("Cilindraje").HasColumnType("varchar").HasMaxLength(10).IsRequired();
            vehiculo.Property(e => e.KilometrosTablero).HasColumnName("KilometrosTablero").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            vehiculo.Property(e => e.CantidadPuerta).HasColumnName("CantidadPuerta").HasColumnType("int").IsRequired();
            vehiculo.Property(e => e.Precio).HasColumnName("Precio").HasColumnType("decimal").HasPrecision(10, 2).IsRequired();
            vehiculo.Property(e => e.Estatus).HasColumnName("Estatus").HasColumnType("varchar").HasMaxLength(2).IsRequired();
            vehiculo.Property(e => e.Borrado).HasColumnName("Borrado").HasColumnType("bit").IsRequired();
            vehiculo.Property(e => e.FechaRegistro).HasColumnName("FechaRegistro").HasColumnType("datetime").IsRequired();
            vehiculo.Property(e => e.FechaModificacion).HasColumnName("FechaModificacion").HasColumnType("datetime");
            //foreign key
            vehiculo.HasRequired(e => e.TipoTransmision).WithMany(e => e.Vehiculos).HasForeignKey(e => e.TipoTransmisionId);
            vehiculo.HasRequired(e => e.TipoCombustible).WithMany(e => e.Vehiculos).HasForeignKey(e => e.TipoCombustibleId);
            vehiculo.HasRequired(e => e.Modelo).WithMany(e => e.Vehiculos).HasForeignKey(e => e.ModeloId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
