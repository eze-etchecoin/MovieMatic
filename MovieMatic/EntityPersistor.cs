using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MovieMatic
{
    class EntityPersistor<T>
    {
        private string _path;

        public EntityPersistor()
        {
            _path = AppDomain.CurrentDomain.BaseDirectory;
            
        }

        public void Grabar(IEnumerable<T> lista)
        {
            var listaSerializada = JsonConvert.SerializeObject(lista);

            var nombreTipo = typeof(T).FullName;

            var archivo = _path + "\\" + nombreTipo + ".json";

            System.IO.File.WriteAllText(archivo, listaSerializada);
        }

        public IEnumerable<T> Recuperar()
        {
            var nombreTipo = typeof(T).FullName;
            var archivo = _path + "\\" + nombreTipo + ".json";

            var contenido = System.IO.File.ReadAllText(archivo);
            var listaDeserializada = JsonConvert.DeserializeObject<List<T>>(contenido);

            return listaDeserializada;
        }
    }
}
