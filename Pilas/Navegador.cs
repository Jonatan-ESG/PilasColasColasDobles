using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasColasDobles.Pilas
{
    public class Navegador
    {
        public Pila<string> historial = new Pila<string>();
        public Pila<string> adelante = new Pila<string>();

        public void VisitarPagina(string url)
        {
            historial.Apilar(url);
            adelante.Vaciar();
            Console.WriteLine($"Visitando: {url}");
        }

        public void IrAtras()
        {
            if (historial.EstaVacia())
            {
                Console.WriteLine("No hay páginas en el historial.");
                return;
            }

            string paginaActual = historial.Desapilar();
            adelante.Apilar(paginaActual);
            Console.WriteLine($"Volviendo a: {historial.VerTope()}");
        }

        public void IrAdelante()
        {
            if (adelante.EstaVacia())
            {
                Console.WriteLine("No hay páginas siguientes.");
                return;
            }

            string pagina = adelante.Desapilar();
            historial.Apilar(pagina);
            Console.WriteLine($"Avanzando a: {pagina}");
        }



    }
}
