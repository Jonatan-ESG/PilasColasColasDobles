using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasColasDobles.ColasDobles
{
	public class ColaDoble<T>
	{
		private LinkedList<T> elementos = new LinkedList<T>();

		public void InsertarAlFrente(T dato)
		{
			elementos.AddFirst(dato);
		}

		public void InsertarAlFinal(T dato)
		{
			elementos.AddLast(dato);
		}

		public T EliminarAlFrente()
		{
			if (EstaVacia())
				throw new InvalidOperationException("La cola doble está vacía");

			T frente = elementos.First.Value;
			elementos.RemoveFirst();
			return frente;
		}

		public T EliminarAlFinal()
		{
			if (EstaVacia())
				throw new InvalidOperationException("La cola doble está vacia");

			T final = elementos.Last.Value;
			elementos.RemoveLast();
			return final;
		}


		public T VerFrente()
		{
			if (EstaVacia())
				throw new InvalidOperationException("La cola doble está vacía");

			return elementos.First.Value;
		}

		public T VerFinal()
		{
			if (EstaVacia())
				throw new InvalidOperationException("La cola doble está vacia");

			return elementos.Last.Value;
		}

		public bool EstaVacia()
		{
			return elementos.Count == 0;
		}

	}
}
