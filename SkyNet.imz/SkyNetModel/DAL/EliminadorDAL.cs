using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNetModel
{
    public class EliminadorDAL
    {
        //1. Crear una lista para guardar terminatorssssss
        private static List<Eliminador> eliminadores = new List<Eliminador>();

        //2. Crear operaciones ingresar/mostrar/buscar.
        public void AgregarEliminador(Eliminador e)
        {
            eliminadores.Add(e);
        }

        public List<Eliminador> ObtenerEliminador()
        {
            return eliminadores;
        }

        public List<Eliminador> FiltrarEliminadores(string tipo, Int32 destino)
        {
            //OPTIMIZAO FRACO #3 

            return eliminadores.FindAll(e => e.Tipo == tipo && e.Destino == destino);
            // && p.Estatura > 2 (Si queremos preguntar por otro atributo+)
        }
    }
}
