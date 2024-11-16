using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasColasDobles.Pilas
{
    public class Pila<T>
    {
        private List<T> elementos = new List<T>();

        public void Apilar(T dato)
        {
            elementos.Add(dato);
        }

        public T Desapilar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila está vacia");

            T tope = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
            return tope;
        }

        public T VerTope()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila está vacia");
            return elementos[elementos.Count - 1];
        }

        public bool EstaVacia()
        {
            return elementos.Count == 0;

        }

        public void Vaciar()
        {
            elementos.Clear();
        }

        public void ImprimirPila()
        {
            string texto = "";
            elementos.ForEach(elemeto => texto += $"| {elemeto} |");
            Console.WriteLine(texto);
        }
    }
}
