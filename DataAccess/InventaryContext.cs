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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // En caso que no se hubiese configurado anteriormente, procedemos a configurar la conexión
            if(!options.IsConfigured){
                options.UseSqlServer("Server=DESKTOP-UJ2B95O; Database=InventoryDb; User id=DESKTOP-UJ2B95O\\JUAN-; Password= ");
            }
        }
    }
}
