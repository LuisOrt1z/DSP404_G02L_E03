using System;
using System.Collections.Generic;

namespace Parte1
{
    public class Venta
    {
        private string cliente;
        private DateTime fecha;
        private List<Producto> productos;

        public Venta(string cliente)
        {
            this.cliente = cliente;
            this.fecha = DateTime.Now;
            this.productos = new List<Producto>();
        }

        public List<Producto> Productos { get => productos;}

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach (Producto producto in Productos)
            {
                total += producto.Valor;
            }
            return total;
        }
    }
}
