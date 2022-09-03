// Importamos Capa Entity
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
    public class B_Category
    {
        // Listamos los datos que exista en DB.
        public List<CategoryEntity> CategoryList() {
            // Generamos conexión temporal a la DB
            using (var db = new InventaryContext()) {
                // Retornamos el db.Context de categories
                return db.Categories.ToList();
            }
        }

        // Creamos Categoria
        public void CreateCategory(CategoryEntity oCategory) {
            // Generamos conexión temporal a la DB
            using (var db = new InventaryContext()) {
                // Creamos registro en Db con el OCategory -> Objeto Categoria
                db.Categories.Add(oCategory);
            }
        }

        // Evento para la actualización de la categoria
        public void UpdateCategory(CategoryEntity oCategory) {
            // Generamos conexión temporal a la DB
            using (var db = new InventaryContext()) { 
                // Actualizamos el objeto Categoria
                db.Categories.Update(oCategory);
                // Guardamos
                db.SaveChanges();
            }
        }
    }
}
