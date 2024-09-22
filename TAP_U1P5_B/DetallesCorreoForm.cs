using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAP_U1P5_B.clases;

namespace TAP_U1P5_B
{
    public partial class DetallesCorreoForm : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private Usuario user = new Usuario();
        public Correo correo = null;

        public DetallesCorreoForm()
        {
            InitializeComponent();
        }

        public DetallesCorreoForm(List<Usuario> usuarios, Usuario user, Correo correo)
        {
            this.user = user;
            this.correo = correo;
            this.usuarios = usuarios;

            InitializeComponent();

            // Cuando se lee o se abre un correo de la bandeja
            if(correo != null)
            {
                comboBox1.Enabled = false;
                textBox1.ReadOnly = true;
                richTextBox1.ReadOnly = true;
                button1.Visible = false;

                textBox1.Text = correo.Asunto;
                richTextBox1.Text = correo.Mensaje;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 &&
               !String.IsNullOrEmpty(textBox1.Text) &&
               !String.IsNullOrEmpty(richTextBox1.Text))
            {
                correo = new Correo();
                correo.IdOrigen = user.Id;
                correo.IdDestino = usuarios[comboBox1.SelectedIndex].Id;
                correo.Asunto = textBox1.Text;
                correo.Mensaje = richTextBox1.Text;

                Close();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
        }

        private void DetallesCorreoForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach(Usuario u in usuarios)
            {
                comboBox1.Items.Add(u.Nombre + "(" + u.Correo + ")");
            }
        }
    }
}
