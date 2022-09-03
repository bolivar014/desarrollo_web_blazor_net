﻿// Importamos Capa Entity
using Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Conexión a la base de datos
using DataAccess;

namespace Business
{
    public class B_Product
    {
        // Listamos los datos que exista en DB.
        public static List<ProductEntity> ProductList()
        {
            // Generamos conexión temporal a la DB
            using (var db = new InventaryContext())
            {
                // Retornamos el db.Context de Products
                return db.Products.ToList();
            }
        }

        // Creamos producto
        public static void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct);
            }
        }

        // Actualizamos producto
        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
    }
}
