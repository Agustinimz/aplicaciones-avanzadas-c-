using System;
using SkyNetModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SkyNet.imz
{
    public partial class Program
    {
        static EliminadorDAL eliminadorDAL = new EliminadorDAL();

        static void BuscarEliminador()
        {

            Console.Clear();
            skyNetIMZ();

            //Declaramos atributos

            string tipo;
            Int32 destino;
            bool esValido;

            //Console.WriteLine("Ingrese Tipo de Terminator :");
            /*new EliminadorDAL().FiltrarEliminadores(Console.ReadLine().Trim())
                .ForEach(e => Console.WriteLine("[Numero de Serie: {0}] [Tipo: {1}] [Objetivo: {2}] [Destino: {3}]", e.Numero_serie, e.Tipo, e.Objetivo, e.Destino));*/
            
            
                do
                {   
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("Ingrese Tipo de Terminator :");
                    Console.ResetColor();
                
                    tipo =Console.ReadLine().Trim();
                } while (tipo.Equals(string.Empty));
                do
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("Ingresa año destino: ");
                    Console.ResetColor();
                    esValido = Int32.TryParse(Console.ReadLine().Trim(), out destino);
                } while (!esValido);
                List<Eliminador> eliminadores = new EliminadorDAL().FiltrarEliminadores(tipo, destino);
            
                // List < Eliminador > eliminadores = new EliminadorDAL().FiltrarEliminadores(Console.ReadLine().Trim());
            foreach (Eliminador e in eliminadores)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Numero de Serie : {0}", e.Numero_serie);
                Console.WriteLine("Tipo : {0}", e.Tipo);
                Console.WriteLine("Objetivo : {0}", e.Objetivo);
                Console.WriteLine("Destino : {0}", e.Destino);
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                 Presione cualquier tecla para volver al MENU");
            Console.ResetColor();
            Console.ReadKey();

        }
        static void MostrarEliminador()
        {
            Console.Clear();
            skyNetIMZ();

            List<Eliminador> eliminadores = eliminadorDAL.ObtenerEliminador();
            for (int i = 0; i < eliminadores.Count; i++)
            {
                Eliminador actual = eliminadores[i];
                Console.WriteLine("SkyNET > Numero de Serie: {1} Tipo: {2} Objetivo: {3} Destino: {4}", i, actual.Numero_serie, actual.Tipo, actual.Objetivo, actual.Destino);



                /*
                Console.WriteL("Numero de Serie : {0}", actual.Numero_serie);
                Console.WriteLine("Tipo : {0}", actual.Tipo);
                Console.WriteLine("Objetivo : {0}", actual.Objetivo);
                Console.WriteLine("Destino : {0}", actual.Destino);
                */
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                 Presione cualquier tecla para volver al MENU"); 
            Console.ResetColor();
            Console.ReadKey();

            

        }
        static void IngresarEliminador()
        {
            //Asignamos variables
            string numero_serie;
            string tipo;
            int prioridad_base;
            string objetivo;
            Int32 destino;
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚───────────────────────────── Bienvenido para registrar un SkyNet debes...........  ─────────────────────────────╝");
            Console.ResetColor();
            bool esValido;
            bool option = true;

            //Ingresamo Numero de serie
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ingrese Numero de Serie: ");
                Console.ResetColor();
                numero_serie = Console.ReadLine().Trim();
                if (numero_serie.Length == 7)
                {
                    option = false;
                }else
                {
                    option = true;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("                              ╚────────────    Tienes que ingresar 7 caracteres");
                    Console.ResetColor();
                    
                }

            } while (numero_serie.Equals(string.Empty) ||option);

            //Ingresamos Tipo
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ingrese Tipo: ");
                Console.ResetColor();

                Console.WriteLine("a) T-1");
                Console.WriteLine("b) T-800");
                Console.WriteLine("c) T-1000");
                Console.WriteLine("d) T-3000");
                tipo = Console.ReadLine().Trim();

                switch (tipo)
                {
                    case "a": option = false; tipo = "T-1";
                        break;
                    case "b":option = false; tipo = "T-800";
                        break;
                    case "c":option = false; tipo = "T-1000";
                        break;
                    case "d":
                        option = false; tipo = "T-3000";
                        break;
                    default: option = true;
                        break;
                }

            } while (tipo.Equals(string.Empty) || option) ;

            //Ingresamos Objetvo
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ingrese Objetivo: ");
                Console.ResetColor();
                
                objetivo = Console.ReadLine().Trim();

                switch (objetivo)
                {
                    case "Sarah Connor":
                        prioridad_base = 1;
                        break;
                    case "Pedro Gaete":
                        prioridad_base = 2;
                        break;
                    case "Juan Mir":
                        prioridad_base = 3;
                        break;
                    case "Juan Tabilo": 
                         prioridad_base = 4;
                        break;
                    default:
                         prioridad_base = 999;
                        break;
                }


            } while (objetivo.Equals(string.Empty) || option);

            //Ingresamos Año destino
            do
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ingrese Año Destino: ");
                Console.ResetColor();
                esValido = Int32.TryParse(Console.ReadLine().Trim(), out destino);

                if (destino >= 1997 && destino <= 3000)
                {
                    esValido = true;
                }
                else
                {
                    esValido &= false;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("                              ╚────────────    Debes ingresar una fecha que este entre 1997-3000");
                    Console.ResetColor();
                }
                    
            } while (!esValido);
            Console.Clear();


            Eliminador e = new Eliminador()
            {
                
                Numero_serie = numero_serie,
                Tipo = tipo,
                Objetivo = objetivo,
                Destino = destino
                

            };
            
            eliminadorDAL.AgregarEliminador(e);

        }

    }
}