using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager_1._0
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void statusMessage(string mensaje, int avance_de_barra)
        {
            statusbar.Text = mensaje;
            toolStripProgressBar1.Increment(avance_de_barra);
        }

        private void mostrarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Proyectos().Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Consultores().Show();
        }

        private void revisarBalanceDeGananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Servicios().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Clientes().Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
        }

        private void btn_acceso_Click(object sender, EventArgs e)
        {
            string usuario="-1", password= "-1";
            if(textBox1.Text !="")
                usuario = textBox1.Text;
            if(textBox2.Text != "")
                password = textBox2.Text;

            if (syscom_dbcon.BuscarUsuario(usuario, password))
            {
                menuStrip1.Enabled = true;

                lblusuario.Dispose();
                textBox1.Dispose();
                textBox2.Dispose();
                btn_acceso.Dispose();
                lblacceso.Dispose();
                statusMessage("Usuario Conectado", 100);
                return;
            }
            statusMessage("Usuario No Conectado", 50);
        }
    }
}