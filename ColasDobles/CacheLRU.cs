using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasColasDobles.ColasDobles
{
	public class CacheLRU
	{
		private int capacidad;
		private Dictionary<string, string> cache = new Dictionary<string, string>();
		private LinkedList<string> orden = new LinkedList<string>();

		public CacheLRU(int capacidad)
		{
			this.capacidad = capacidad;
		}

		public string Obtener(string clave)
		{
			if (!cache.ContainsKey(clave)) return "No existe";

			orden.Remove(clave);
			orden.AddFirst(clave);
			return cache[clave];
		}

		public void Insertar(string clave, string valor) {

			if (cache.ContainsKey(clave))
			{
				orden.Remove(clave);
			}
			else if (cache.Count >= capacidad) {
				string menosUsado = orden.Last.Value;
				orden.RemoveLast();
				cache.Remove(menosUsado);
			}

			cache[clave] = valor;
			orden.AddFirst(clave);
		}

		public void MostrarEstado() {
			Console.WriteLine("Estado actual: ");
			foreach(var clave in orden)
			{
				Console.WriteLine($"Clave: {clave}, Valor: {cache[clave]}");
			}
		
		}

	}
}
