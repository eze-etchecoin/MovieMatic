using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Clase22JSon
{
    public class EntityPersistor<T>
    {
        private string _nombreArchivo;

        public EntityPersistor()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            var nombreTipo = typeof(T).FullName;
            _nombreArchivo = path + "\\" + nombreTipo + ".json";
        }

        public void Grabar(T entidad)
        {
            var lista = new List<T>();
            lista.Add(entidad);
            Grabar(lista);
        }

        public void Grabar(IEnumerable<T> lista)
        {
            var listaSerializa = JsonConvert.SerializeObject(lista);
            System.IO.File.WriteAllText(_nombreArchivo, listaSerializa);
        }


        public IEnumerable<T> Recuperar()
        {
            var contenido = System.IO.File.ReadAllText(_nombreArchivo);
            var lista = JsonConvert.DeserializeObject<List<T>>(contenido);
            return lista;
        }
    }
}
