using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos;

namespace ventas.Modelos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public int CategoriaId { get; set; }
        public Categoria categoria { get; set; }

        public Cliente(int id, string nombre, int telefono, string direccion,string ciudad, Categoria categoria )
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Ciudad = ciudad;
            CategoriaId = categoria.Id;
            
        }
    }
}
