using Restaurante.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Infraestructura.Datos.Repositorios
{
    public class Repositorio : IRepositorio
    {
        readonly RestauranteContexto ioContexto;

        public Repositorio()
        {
            ioContexto = new RestauranteContexto();
        }

        public T ObtenerPorCodigo<T>(params object[] aoLLaves) where T : class
        {
            return ioContexto.Set<T>().Find(aoLLaves);
        }

        public void Adicionar<T>(T aoEntidad) where T : class
        {
            ioContexto.Set<T>().Add(aoEntidad);
        }

        public void GuardarCambios()
        {
            ioContexto.SaveChanges();
        }

        public IQueryable<T> Listar<T>(string asPropiedades = "") where T : class
        {
            return ioContexto.Set<T>();
        }

    }
}
