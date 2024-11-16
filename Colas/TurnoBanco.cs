using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasColasColasDobles.Colas
{
	public class TurnoBanco
	{
		public int Numero { get; set; }

		public TurnoBanco(int numero) {
			this.Numero = numero;
		}

		public override string ToString() { 
			return Numero.ToString();
		}

	}
}
