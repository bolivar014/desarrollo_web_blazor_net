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
    public class B_InputOutput
    {
        public List<InputOutputEntity> InputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInputOutput);
                db.SaveChanges();
            }
        }

        public void UpdateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInputOutput);
                db.SaveChanges();
            }
        }
    }
}
