using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNetModel
{
    public class Eliminador
    {
        private string numero_serie;
        private string tipo;
        private int prioridad_base;
        private string objetivo;
        private Int32 destino;

        public string Numero_serie { get => numero_serie; set => numero_serie = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Prioridad_base { get => prioridad_base; set => prioridad_base = value; }
        public string Objetivo { get => objetivo; set => objetivo = value; }
        public int Destino { get => destino; set => destino = value; }
    }
}
