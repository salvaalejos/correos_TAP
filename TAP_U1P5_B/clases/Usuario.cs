using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAP_U1P5_B.clases
{
    public class Usuario
    {
        public Usuario()
        {
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private String correo;

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private String contrasenia;

        public String Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Usuario(int id, String correo, String contrasenia, String nombre)
        {
            this.id = id;
            this.correo = correo;
            this.contrasenia = contrasenia;
            this.nombre = nombre;
        }

    }
}
