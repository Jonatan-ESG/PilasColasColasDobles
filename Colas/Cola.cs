using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasColasDobles.Colas
{
    public class Cola<T>
    {
        private List<T> elementos = new List<T>();

        public void Encolar(T dato)
        {
            elementos.Add(dato);
        }

        public T Desencolar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía");

            T frente = elementos[0];
            elementos.RemoveAt(0);
            return frente;
        }
        public T VerFrente()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía");

            return elementos[0];
        }

        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        public void ImprimirCola()
        {
            string texto = "";
            elementos.ForEach(elemeto => texto += $"| {elemeto?.ToString()} |");
            Console.WriteLine(texto);
        }

        public int ObtenerLogitud() {
            return this.elementos.Count;
        }
    }
}
