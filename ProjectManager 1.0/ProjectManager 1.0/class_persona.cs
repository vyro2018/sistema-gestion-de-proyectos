using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager_1._0
{
    /// <summary>
    /// Clase que define una persona, que se puede convertir en consultor o cliente usando 
    /// datos generales como el correo electrónico y su Nombre.
    /// </summary>
    public class class_persona
    {
        public int Id_persona { get; set; }
        public string Nombres { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Constructor Inicial
        /// </summary>
        public class_persona()
        {
            this.Id_persona = -1;
            this.Nombres = "";
            this.Apellido_Materno = "";
            this.Apellido_Paterno = "";
            this.Correo = "";
            this.Celular = "";
            this.FechaAlta = DateTime.Now;
        }

        /// <summary>
        /// Información base para poder dar de alta una persona en el sistema
        /// </summary>
        /// <param name="Nombre">Nombre(s) de la persona</param>
        /// <param name="correo">Correo electrónico</param>
        public class_persona(string pNombre, string pCorreo)
        {
            this.Nombres = pNombre;
            this.Correo = pCorreo;
            this.FechaAlta = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pId_persona">ID unico de la persona</param>
        /// <param name="pNombre">Nombre de la persona</param>
        /// <param name="pApellidoP">Apellido paterno</param>
        /// <param name="pApellidoM">Apellido materno</param>
        /// <param name="pCorreo">Correo eletrónico</param>
        /// <param name="pCelular">Telefono Celular</param>
        public class_persona(int pId_persona, string pNombre, string pApellidoP, string pApellidoM, string pCorreo, string pCelular)
        {
            this.Nombres = pNombre;
            this.Correo = pCorreo;
            this.Id_persona = pId_persona;
            this.Apellido_Paterno = pApellidoP;
            this.Apellido_Materno = pApellidoM;
            this.Celular = pCelular;
            this.FechaAlta = DateTime.Now;
        }
    }

    /// <summary>
    /// Esta persona se define como cliente y sus datos son del tipo cliente que son diferentes al de un consultor
    /// </summary>
    public class class_cliente:class_persona
    {
        public string Tel_oficina { get; set; }
        public string Tel_movil1 { get; set; }
        public int Id_cliente { get; set; }
        public string Puesto { get; set; }

        /// <summary>
        /// Constructor Inicial
        /// </summary>
        public class_cliente()
        {
            this.Tel_oficina = "";
            this.Id_cliente = -1;
            this.Tel_movil1 = "";
            this.Tel_oficina = "";
        }

        /// <summary>
        /// Constructor Con parametros minimos para ser un cliente
        /// </summary>
        /// <param name="id_cliente">Id_autoincremental que se asigna de forma automatica, se inicializa en -1</param>
        /// <param name="puesto">Nombre del puesto</param>
        /// <param name="telmov">Telefono mobil</param>
        /// <param name="tel_cel1">Telefono celular guardia</param>
        public class_cliente(int id_cliente, string puesto, string telmov="", string tel_cel1= "")
        {
            this.Id_cliente = Id_cliente;
            this.Puesto = puesto;
            this.Tel_oficina = telmov;
            this.Tel_movil1 = tel_cel1;
        }
    }

    public class class_consultor : class_persona
    {
        public string Status { get; set; }
        public string Cv { get; set; }
        public int  Id_lista_modulos { get; set; }
        public int Id_lista_proyectos { get; set; }

        public class_consultor()
        {
            this.Status = "Recien Ingreso";
            this.Cv = "";
            this.Id_lista_modulos = -1;
            this.Id_lista_proyectos = -1;
        }

        /// <summary>
        /// Datos minimos del constructor para ser un consultor
        /// </summary>
        /// <param name="pStatus">Status del consultor - status inicial es Recien Ingreso</param>
        /// <param name="pCv">Ruta del CV</param>
        /// <param name="pId_lista_m">Id referencia a la lista de modulos de dominio</param>
        /// <param name="pId_lista_p">Id referencia a la lista de proyectos donde está actualmente participando</param>
        public class_consultor(string pCv, string pStatus = "Recien Ingreso", int pId_lista_m=-1, int pId_lista_p=-1)
        {
            this.Status = pStatus;
            this.Cv = pCv;
            this.Id_lista_modulos = pId_lista_m;
            this.Id_lista_proyectos = pId_lista_p;
        }
    }
}
