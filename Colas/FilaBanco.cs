using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasColasDobles.Colas
{
	public  class FilaBanco
	{
		public Cola<TurnoBanco> turnos = new Cola<TurnoBanco>();
		private int turnoActual;

		public FilaBanco() {
			turnoActual = 1;
		}

		public void AsignarTurno()
		{
			
			TurnoBanco turno = new TurnoBanco(turnoActual++ );
			turnos.Encolar(turno);
			Console.WriteLine($"Turno asignado: {turno.Numero}");
		}

		public void AtenderCliente() {

			if (turnos.EstaVacia())
			{
				Console.WriteLine("No hay clientes que atender.");
				return;
			}
				
			TurnoBanco atendido = turnos.Desencolar();
			Console.WriteLine($"Atendiendo al cliente con el turno: {atendido.Numero}");
		}

	}
}
