using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAP_U1P5_B.clases;

namespace TAP_U1P5_B
{
    public partial class Form1 : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool errores = validar();

            if ( ! errores) {
                // No hay errores
                String nombre = Interaction.InputBox("Nombre:");
                if ( nombre != null && nombre.Length > 0 ) 
                {
                    Usuario u = new Usuario();
                    u.Id = usuarios.Count + 1;
                    u.Nombre = nombre;
                    u.Correo = fieldCorreo.Text.Trim().ToLower();
                    u.Contrasenia = fieldContrasenia.Text;

                    usuarios.Add(u);

                    guardar();

                    new CorreosForm(usuarios, u).Show();
                }
            }
        }

        private bool validar()
        {
            String msg = "";

            if(fieldCorreo.Text.Length > 0 ) 
            {
                if( ! fieldCorreo.Text.Contains("@"))
                {
                    msg += "\nEl correo no tiene un formato correcto";
                    fieldCorreo.BackColor = Color.Yellow;
                }
            } 
            else
            {
                msg += "\nEl correo no puede ser vacío";
                fieldCorreo.BackColor = Color.Yellow;
            }

            if( fieldContrasenia.Text.Length <= 0 )
            {
                msg += "\nLa contraseña no puede estar vacía";
                fieldContrasenia.BackColor = Color.Yellow;
            }

            if(msg.Length > 0 )
            {
                MessageBox.Show("Errores:" + msg);
            }

            return msg.Length > 0;
        }

        private void guardar()
        {
            try
            {
                String json = JsonConvert.SerializeObject(usuarios);

                StreamWriter sw = new StreamWriter("usuarios.json", false);
                sw.Write(json);
                sw.Close();

                MessageBox.Show("Registrado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                new Log().WriteException(ex);
                MessageBox.Show("Error al guardar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fieldContrasenia.Clear();
            fieldCorreo.Clear();
            try
            {
                StreamReader sr = new StreamReader("usuarios.json");
                string json = sr.ReadToEnd();
                sr.Close();

                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                new Log().WriteException(ex);
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Usuario user = null;
            foreach (Usuario u in usuarios)
            {
                if(u.Correo.Equals(fieldCorreo.Text) && u.Contrasenia.Equals(fieldContrasenia.Text))
                {
                    user = u;
                    break;
                }
            }

            if (user != null)
            {
                this.Hide();
                var ventanaCorreos = new CorreosForm(usuarios, user);
                ventanaCorreos.Show();
                ventanaCorreos.FormClosed += ManejarCierreCorreosForm;
                
            }
            else
            {
                MessageBox.Show("Usuarios y/o contraseña incorrectos");
            }
        }
        private void ManejarCierreCorreosForm(object sender, FormClosedEventArgs e)
        {
            Form1_Load(null, null);
            this.Show(); 
        }
    }
}
