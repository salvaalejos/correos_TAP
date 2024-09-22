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
    public partial class CorreosForm : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Correo> correos = new List<Correo>();
        private Usuario user = new Usuario();

        public CorreosForm()
        {
            InitializeComponent();
        }

        public CorreosForm(List<Usuario> usuarios, Usuario user)
        {
            this.user = user;
            this.usuarios = usuarios;

            InitializeComponent();

            this.Text = "Correos de " + user.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetallesCorreoForm form = new DetallesCorreoForm(
                usuarios, user, null
            );
            form.ShowDialog();

            Correo mail = form.correo;
            if (mail != null)
            {
                correos.Add(mail);
                try
                {
                    guardar();
                    MessageBox.Show("Enviado");
                    CorreosForm_Load(null, null);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
                
            }
        }

        private void guardar()
        {
            try
            {
                String json = JsonConvert.SerializeObject(correos);

                StreamWriter sw = new StreamWriter("correos.json", false);
                sw.Write(json);
                sw.Close();

                
            }
            catch (Exception ex)
            {
                new Log().WriteException(ex);
                MessageBox.Show("Error al guardar");
            }
        }

        private void leer()
        {
            try
            {
                StreamReader sr = new StreamReader("correos.json");
                String json = sr.ReadToEnd();
                sr.Close();

                if( ! String.IsNullOrEmpty(json))
                {
                    correos = JsonConvert.
                        DeserializeObject<List<Correo>>(json);
                }
            }
            catch (Exception ex)
            {
                new Log().WriteException(ex);
            }
        }

        private void CorreosForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanelEntrada.Controls.Clear();
            flowLayoutPanelSalida.Controls.Clear();
            leer();

            int indice = 0;
            foreach (Correo c in correos)
            {
                if(c.IdDestino == user.Id)
                {
                    FlowLayoutPanel panel = new FlowLayoutPanel();
                    panel.Size = new Size(
                        flowLayoutPanelEntrada.Width - 3,
                        100
                    );
                    Label label = new Label();
                    label.Text = c.Asunto;
                    label.Text += "\n" + buscar(c.IdOrigen);
                    label.AutoSize = true;
                    panel.Controls.Add( label );

                    Button button = new Button();
                    button.Text = "Ver";
                    button.Tag = "" + indice;
                    button.Click += verCorreo;
                    panel.Controls.Add( button );
                    
                    Button buttonDelete = new Button();
                    buttonDelete.Text = "X";
                    buttonDelete.Tag = "" + indice;
                    buttonDelete.BackColor = Color.Red;
                    buttonDelete.Click += eliminarCorreo;
                    panel.Controls.Add( buttonDelete );
                    flowLayoutPanelSalida.Controls.Add( panel );

                    flowLayoutPanelEntrada.Controls.Add( panel );
                }
                if(c.IdOrigen == user.Id)
                {
                    FlowLayoutPanel panel = new FlowLayoutPanel();
                    panel.Size = new Size(
                        flowLayoutPanelSalida.Width - 3,
                        100
                    );
                    Label label = new Label();
                    label.Text = c.Asunto;
                    label.Text += "\n" + buscar(c.IdDestino);
                    label.AutoSize = true;
                    panel.Controls.Add( label );

                    Button button = new Button();
                    button.Text = "Ver";
                    button.Tag = "" + indice;
                    button.Click += verCorreo;
                    panel.Controls.Add( button );
                    
                    Button buttonDelete = new Button();
                    buttonDelete.Text = "X";
                    buttonDelete.Tag = "" + indice;
                    buttonDelete.BackColor = Color.Red;
                    buttonDelete.Click += eliminarCorreo;
                    panel.Controls.Add( buttonDelete );
                    flowLayoutPanelSalida.Controls.Add( panel );
                }
                indice++;
            }
        }

        private String buscar(int id)
        {
            String persona = null;
            foreach (Usuario u in usuarios) {
                if(u.Id == id)
                {
                    persona = u.Nombre + "(" + u.Correo + ")";
                    break;
                }
            }
            return persona;
        }

        private void verCorreo(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //Button btn = (Button)sender;

            int index = int.Parse("" + btn.Tag);
            Correo mail = correos[index];

            new DetallesCorreoForm(usuarios, user, mail).Show();
        }
        private void eliminarCorreo(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //Button btn = (Button)sender;

            int index = int.Parse("" + btn.Tag);
            correos.RemoveAt(index);
            guardar();
            CorreosForm_Load(null, null);
            MessageBox.Show("Correo eliminado");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios " + user.Nombre+"!");
            this.Close();
        }
    }
}
