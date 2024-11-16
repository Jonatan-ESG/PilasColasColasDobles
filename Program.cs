using PilasColasColasDobles.Colas;
using PilasColasColasDobles.ColasDobles;
using PilasColasColasDobles.Pilas;

namespace PilasColasColasDobles
{
    internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ProbarPila");
			ProbarPila();

			Console.WriteLine("ProbarNavegador");
			ProbarNavegador();

			Console.WriteLine("ProbarCola");
			ProbarCola();

			Console.WriteLine("ProbarCache");
			ProbarCache();
		}

		static void ProbarCache()
		{
			try
			{
				CacheLRU cache = new CacheLRU(3);

				Console.WriteLine("Insertar valores");
				cache.Insertar("Datos Jonatan", "Nommbre Completo: Jonatan Sandoval");
				cache.Insertar("Datos Sharon", "Nombre Completo: Sharon Marroquin");
				cache.Insertar("Datos Kennet", "Nombre Completo: Kennet Santiesteban");
				
				cache.MostrarEstado();

				Console.WriteLine("Buscar Jonatan");
				Console.WriteLine($"Valor obtenido: {cache.Obtener("Datos Jonatan")}");
				

				cache.MostrarEstado();

				Console.WriteLine("Buscar Sharon");
				Console.WriteLine($"Valor obtenido: {cache.Obtener("Datos Sharon")}");

				cache.MostrarEstado();

				Console.WriteLine("Buscar Marlon");
				cache.Insertar("Datos Marlon", "Nombre Completo: Marlon Pappa");

				cache.MostrarEstado();


			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		static void ProbarCola() {
			try
			{
				FilaBanco fila = new FilaBanco();

				fila.AsignarTurno();
				fila.AsignarTurno();
				fila.AtenderCliente();
				fila.AsignarTurno();
				fila.AsignarTurno();
				fila.AsignarTurno();
				fila.AsignarTurno();
				fila.AsignarTurno();
				fila.AtenderCliente();
				fila.AtenderCliente();

				fila.turnos.ImprimirCola();

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		static void ProbarPila()
		{
			try
			{
				Pila<int> pilaPrueba = new Pila<int>();

				pilaPrueba.Apilar(5);
				pilaPrueba.Apilar(4);
				pilaPrueba.Desapilar();
				pilaPrueba.Apilar(45);
				pilaPrueba.Apilar(6);
				pilaPrueba.Apilar(4);
				pilaPrueba.Apilar(2);
				pilaPrueba.Vaciar();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		static void ProbarNavegador()
		{
			try
			{
				Navegador navegador = new Navegador();

				navegador.VisitarPagina("https://google.com");
				navegador.VisitarPagina("https://facebook.com");
				navegador.VisitarPagina("https://instagram.com");
				navegador.VisitarPagina("https://tiktok.com");

				navegador.historial.ImprimirPila();

				navegador.IrAtras();
				navegador.IrAtras();

				navegador.historial.ImprimirPila();

				navegador.IrAdelante();

				navegador.historial.ImprimirPila();

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
	}
}
