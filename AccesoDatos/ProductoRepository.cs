using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProductoRepository
    {
        public Parcial02Entities contexto = new Parcial02Entities();

        public List<Productos> ObtenerTodo()
        {
            var producto = from productos in contexto.Productos select productos;
            return producto.ToList();
        }

        public Productos ObtenerPorId(int id)
        {
            var productos = from item in contexto.Productos where item.Id == id select item;
            return productos.FirstOrDefault();
        }

        public int InsertarProducto(Productos productos)
        {
            contexto.Productos.Add(productos);
            return contexto.SaveChanges();
        }
    }
}
