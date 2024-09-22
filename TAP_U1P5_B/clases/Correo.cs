using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAP_U1P5_B.clases
{
	public class Correo
	{
		public Correo() { }

		private int idDestino;

		public int IdDestino
		{
			get { return idDestino; }
			set { idDestino = value; }
		}

		private int idOrigen;

		public int IdOrigen
		{
			get { return idOrigen; }
			set { idOrigen = value; }
		}

		private String asunto;

		public String Asunto
		{
			get { return asunto; }
			set { asunto = value; }
		}

		private String mensaje;

		public String Mensaje
		{
			get { return mensaje; }
			set { mensaje = value; }
		}

        public Correo(int idDestino, int idOrigen, String asunto, String mensaje)
        {
            this.idDestino = idDestino;
			this.idOrigen = idOrigen;
			this.asunto = asunto;
			this.mensaje = mensaje;
        }

    }
}
