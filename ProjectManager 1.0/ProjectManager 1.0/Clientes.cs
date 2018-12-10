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
    public partial class Clientes : Form
    {
        /// <summary>
        /// Variable global para referencia del cliente
        /// </summary>
        private class_customer gglobalCustomer = new class_customer();

        public Clientes()
        {
            InitializeComponent();
        }

        private void statusMessage(string mensaje,int avance_de_barra)
        {
            toolStripStatuslblStatus.Text = mensaje;
            toolStripProgressBar1.Increment(avance_de_barra);
        }

        private void CargarClientes(object sender, EventArgs e)
        {
            //Actualizamos status en pantalla
            int i = 0;//contador para iterar ciclos while
            //Mensaje inferior de pantalla
            statusMessage("Conectado a la Base de datos", 100);
            //Listas para cargar clientes y sectores que llenaran los datos en pantalla al iniciar la ventana
            List<Class_sector> sectores = new List<Class_sector>();
            List<class_customer> clientes = syscom_dbcon.LeerEmpresas();

            //cargar texto en txtSectores
            sectores = syscom_dbcon.LeerSector();
            statusMessage("Leyendo Sectores", 50);
            while (i < sectores.Count)
            {
                txtSector.Items.Add(sectores[i].Nombre);
                i++;
            }
            statusMessage("Sectores Cargados", 100);
            sectores.RemoveRange(0, sectores.Count);
            i = 0;
            //Agregar codigo para cargar datos de clientes en datagrid
            statusMessage("Cargando  clientes", 50);
            while (i < clientes.Count)
            {
                string sector = syscom_dbcon.LeerSector(clientes[i].Id_sector);
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridCustomer);
                fila.SetValues(clientes[i].Id_customer, clientes[i].Nombre, sector, clientes[i].Profit, clientes[i].Fecha_alta);
                dataGridCustomer.Rows.Add(fila);
                i++;
            }
            i = 0;
            statusMessage("Clientes cargados", 100);
        }

        private void btn_nuevo_cliente_Click(object sender, EventArgs e)
        {
            statusMessage("Cargando Cliente", 50);
            int Id_sector=-1;
            if (txtNombre.Text != "" && txtSector.Text != "")
            {
                Id_sector = syscom_dbcon.LeerSector(txtSector.Text);
                syscom_dbcon.InsertarEmpresa(new class_customer(txtNombre.Text, Id_sector));
                statusMessage("Cliente Cargado", 100);
            }
            else
            {
                statusMessage("status", 0);
                statusMessage("Algun dato es invalido, favor de no dejar campos vacios", 20);
            }
                
        }

        private void dataGridCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = 0;//Iterador de ciclos
            int renglon = e.RowIndex;
            if (renglon < 0)
                return;
            
            //Codigo para leer e insertar al datagrid de datos fiscales los datos según el cliente seleccionado en el datagrid de clientes
            this.gglobalCustomer = syscom_dbcon.LeerCustomer((int)dataGridCustomer.Rows[renglon].Cells["Id_customer"].Value);

            //llenar datos en datagrid datos fiscales
            class_Fiscal datos_fiscales = syscom_dbcon.LeerFiscal(this.gglobalCustomer.Id_customer);
            
            if (datos_fiscales != null)
            {
                dataGridFiscal.Rows.Clear();
                dataGridFiscal.Rows.Add(datos_fiscales.RFC,datos_fiscales.Razon_social, datos_fiscales.Regimen, datos_fiscales.Nombre_comercial, datos_fiscales.Calle, datos_fiscales.Numero_ext, datos_fiscales.Numero_int, datos_fiscales.Colonia, datos_fiscales.Municipio, datos_fiscales.Estado, datos_fiscales.CP, datos_fiscales.email_facturacion);
                statusMessage("Datos fiscales de "+ this.gglobalCustomer.Nombre +" cargardos", 100);
            }
            
            //llenar datos en datagrid contactos
            List<class_cliente> Lista_clientes = syscom_dbcon.LeerContactos(this.gglobalCustomer.Id_customer);
            if (Lista_clientes != null)
            {
                dataGridContactos.Rows.Clear();
                while (i < Lista_clientes.Count)
                {
                    dataGridContactos.Rows.Add(Lista_clientes[i].Id_persona, Lista_clientes[i].Nombres, Lista_clientes[i].Apellido_Paterno, Lista_clientes[i].Apellido_Materno, Lista_clientes[i].Puesto, Lista_clientes[i].Correo, Lista_clientes[i].Tel_oficina, Lista_clientes[i].Celular, Lista_clientes[i].Tel_movil1);
                    i++;
                }
            }
            i = 0;

            //llenar datos en datagrid proyectos
            List<Class_proyecto> Lista_proyectos = syscom_dbcon.LeerProyectos(this.gglobalCustomer.Id_customer);
            if (Lista_proyectos != null)
            {
                dataGridProyectos.Rows.Clear();
                while (i < Lista_clientes.Count)
                {
                    dataGridContactos.Rows.Add(Lista_proyectos[i].Id_proyecto, Lista_proyectos[i].Nombre, Lista_proyectos[i].Comentarios, Lista_proyectos[i].FechaAlta, Lista_proyectos[i].Evaluacion, Lista_proyectos[i].Precio, Lista_proyectos[i].Estado_viabilidad);
                    i++;
                }
            }
            i = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBusquedaContacto.Text != "")
            {
                int i = 0; //Iterador para ciclos
                List<class_cliente> Lista_clientes = syscom_dbcon.BuscarContacto(txtBusquedaContacto.Text);
                dataGridContactos.Rows.Clear();
                while(i < Lista_clientes.Count())
                {
                    dataGridContactos.Rows.Add(Lista_clientes[i].Id_persona, Lista_clientes[i].Nombres, Lista_clientes[i].Apellido_Paterno, Lista_clientes[i].Apellido_Materno, Lista_clientes[i].Puesto, Lista_clientes[i].Correo, Lista_clientes[i].Tel_oficina, Lista_clientes[i].Celular, Lista_clientes[i].Tel_movil1);
                    i++;
                }
                i = 0;
            }
            statusMessage("Busqueda de cliente finalizada", 100);
        }

        private void btn_buscarProyecto_Click(object sender, EventArgs e)
        {
            if (txt_buscarProyecto.Text != "")
            {
                Class_proyecto proyecto = syscom_dbcon.BuscarProyecto(int.Parse(txt_buscarProyecto.Text));
                if (proyecto != null)
                {
                    dataGridProyectos.Rows.Clear();
                    dataGridContactos.Rows.Add(proyecto.Id_proyecto, proyecto.Nombre, proyecto.Comentarios, proyecto.FechaAlta, proyecto.Evaluacion, proyecto.Precio, proyecto.Estado_viabilidad);
                }
            }
            statusMessage("Busqueda de proyecto finalizada", 100);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_fiscal_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridFiscal.Rows[0];
            class_Fiscal datos_Fiscales = syscom_dbcon.BuscarDatoFiscal(this.gglobalCustomer.Id_customer);

            if (datos_Fiscales == null)
            {
                //Insert
                datos_Fiscales = new class_Fiscal(this.gglobalCustomer, row.Cells["RFC"].Value.ToString(), row.Cells["Razon_social"].Value.ToString(),
                    row.Cells["Regimen"].Value.ToString(), row.Cells["Nombre_comercial"].Value.ToString(), row.Cells["Calle"].Value.ToString(),
                    int.Parse(row.Cells["Numero_ext"].Value.ToString()), int.Parse(row.Cells["Numero_int"].Value.ToString()), row.Cells["Colonia"].Value.ToString(),
                    row.Cells["Municipio"].Value.ToString(), row.Cells["Estado"].Value.ToString(), row.Cells["CP"].Value.ToString(),
                    row.Cells["email_facturacion"].Value.ToString());

                if (syscom_dbcon.InsertarDatoFiscal(datos_Fiscales) != 0)
                {
                    statusMessage("Datos fiscales insertados con exito", 100);
                    return;
                }
                statusMessage("Error al insertar datos fiscales", 50);
                return;
            }
            //Update
            datos_Fiscales = new class_Fiscal(this.gglobalCustomer, row.Cells["RFC"].Value.ToString(), row.Cells["Razon_social"].Value.ToString(),
                    row.Cells["Regimen"].Value.ToString(), row.Cells["Nombre_comercial"].Value.ToString(), row.Cells["Calle"].Value.ToString(),
                    int.Parse(row.Cells["Numero_ext"].Value.ToString()), int.Parse(row.Cells["Numero_int"].Value.ToString()), row.Cells["Colonia"].Value.ToString(),
                    row.Cells["Municipio"].Value.ToString(), row.Cells["Estado"].Value.ToString(), row.Cells["CP"].Value.ToString(),
                    row.Cells["email_facturacion"].Value.ToString());
            if (syscom_dbcon.ActualizarDatoFiscal(datos_Fiscales) != 0)
            {
            statusMessage("Actualización de datos fiscales con exito", 100);
                return;
            }
            statusMessage("Error al actualizar los datos fiscales", 50);
        }

        private void btn_borrar_fiscal_Click(object sender, EventArgs e)
        {
            int i = 0;//Iterador de ciclos
            DataGridViewSelectedRowCollection rows = dataGridFiscal.SelectedRows;
            while (i < rows.Count)
            {
                //Codigo para deshabilitar la relación comercial con el cliente
                int Id_customer = (int)rows[i].Cells["Id_customer"].Value;
                MessageBox.Show("Datos fiscales del cliente con ID: " + Id_customer + "Deshabilitado");
                syscom_dbcon.BorrarFiscal(Id_customer);
                i++;
                statusMessage("Borrado de datos fiscales exitoso", 100);
                return;
            }
            i = 0;
            statusMessage("No se han borrado registros Fiscales", 10);
        }

        private void btn_borrar_cliente_Click(object sender, EventArgs e)
        {
            statusMessage("Función de borrado no disponible por el momento", 100);
            /*
            int i = 0;//Iterador de ciclos
            DataGridViewSelectedRowCollection rows= dataGridCustomer.SelectedRows;
            while (i < rows.Count)
            {
                //Codigo para deshabilitar la relación comercial con el cliente
                int Id_customer = (int)rows[i].Cells["Id_customer"].Value;
                syscom_dbcon.DeshabilitarEmpresa(Id_customer);
                i++;
            }
            i = 0;
            */
        }

        private void tabControlClientes_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPage.Text == "Contactos")
                statusMessage("Datos de contacto de " + this.gglobalCustomer.Nombre + " cargardos", 100);
            if (e.TabPage.Text == "Proyectos")
                statusMessage("Datos de proyecto de " + this.gglobalCustomer.Nombre + " cargardos", 100);
            if (e.TabPage.Text == "Cliente")
                statusMessage("Datos de cliente " + this.gglobalCustomer.Nombre + " cargardos", 100);
        }
    }
}