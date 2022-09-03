// 
using Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 
using DataAccess;

namespace Business
{
    public class B_WareHouse
    {
        public static List<WarehouseEntity> WareHouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public static void CreateWareHouse(WarehouseEntity oWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oWareHouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWareHouse(WarehouseEntity oWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oWareHouse);
                db.SaveChanges();
            }
        }
    }
}
