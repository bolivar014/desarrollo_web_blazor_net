using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        // Evento de conexión a base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // En caso que no se hubiese configurado anteriormente, procedemos a configurar la conexión
            if(!options.IsConfigured){
                options.UseSqlServer("Server=DESKTOP-UJ2B95O; Database=InventoryDb; User id=sa; Password=admin123;");
            }
        }

        // Evento para la creación de datos de prueba
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Creación de datos en sus respectivos modelos | Entity Category
            modelBuilder.Entity<CategoryEntity>().HasData(
                // 
                new CategoryEntity {
                    CategoryId = "ASH",
                    CategoryName = "Aseo Hogar"
                },
                new CategoryEntity
                {
                    CategoryId = "ASP",
                    CategoryName = "Aseo Personal"
                },
                new CategoryEntity
                {
                    CategoryId = "HGR",
                    CategoryName = "Hogar"
                },
                new CategoryEntity
                {
                    CategoryId = "PRF",
                    CategoryName = "Perfumeria"
                },
                new CategoryEntity
                {
                    CategoryId = "SLD",
                    CategoryName = "Salud"
                },
                new CategoryEntity
                {
                    CategoryId = "VDJ",
                    CategoryName = "Video Juegos"
                }
            );

            // 
            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Central",
                    WarehouseAddress = "Cl 8 # 23 - 34"
                },
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Norte",
                    WarehouseAddress = "Cr 18 # 34 - 50"
                },
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Este",
                    WarehouseAddress = "AV 8 # 56 - 32"
                }
            );
        }

    }
}
