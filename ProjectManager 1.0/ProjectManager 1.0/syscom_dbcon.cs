using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectManager_1._0
{
    public class syscom_dbcon
    {
        public static bool Ping { get; set; }

        /// <summary>
        /// Metodo para abrir conexión a la base de datos
        /// </summary>
        /// <returns>Regresa la conexión</returns>
        private static MySqlConnection AbrirConexion()
        {
            Ping = false;
            MySqlConnection conectar = new MySqlConnection(@"Server=localhost; Database=syscom_prd; Uid=root; Pwd=; Port=3306");// @"Server=69.162.113.162; Database=syscomit_PRD; Uid=syscomit_prdadm; Pwd=S1sc0m2019; Port=3306"
            conectar.OpenAsync(new System.Threading.CancellationToken());
            Ping = true;

            return conectar;
        }

        /// <summary>
        /// Metodo para leer la lista de clientes en la base de datos
        /// </summary>
        /// <returns>Regresa una lista con los clientes en caso de existir</returns>
        public static List<class_customer> LeerEmpresas()
        {
            List<class_customer> Lista_clientes = new List<class_customer>();
            MySqlCommand select = new MySqlCommand(string.Format("select * from  tbl_clientes"), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();

            while (_lector.Read())
            {
                class_customer cliente = new class_customer();
                cliente.Id_customer = _lector.GetInt32("Id_customer");
                cliente.Nombre = _lector.GetString("Nombre");
                cliente.Id_sector = _lector.GetInt32("Id_sector");
                cliente.Profit = _lector.GetInt32("Profit");
                cliente.Fecha_alta = _lector.GetString("Fecha_alta");
                Lista_clientes.Add(cliente);
            }

            return Lista_clientes;
        }

        /// <summary>
        /// Lee la información fiscal cuyo Id sea el que coincide con la empresa
        /// </summary>
        /// <param name="pId_customer">Id de la empresa</param>
        /// <returns>regresa un tipo de dato class_Fiscal</returns>
        public static class_Fiscal LeerFiscal(int pId_customer)
        {
            MySqlCommand select = new MySqlCommand(string.Format("select * from  tbl_clt_fiscal where Id_cliente= '{0}'", pId_customer), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();

            if (_lector.Read())
            {
                class_Fiscal cliente = new class_Fiscal();
                
                cliente.RFC = _lector.GetString("RFC");
                cliente.Razon_social = _lector.GetString("Razon_social");
                cliente.Regimen = _lector.GetString("Regimen");
                cliente.Nombre_comercial = _lector.GetString("Nombre_comercial");
                cliente.Calle = _lector.GetString("Calle");
                cliente.Numero_ext = _lector.GetInt32("Numero_ext");
                cliente.Numero_int = _lector.GetInt32("Numero_int");
                cliente.Colonia = _lector.GetString("Colonia");
                cliente.Municipio = _lector.GetString("Municipio");
                cliente.Estado = _lector.GetString("Estado");
                cliente.CP = _lector.GetString("CP");
                cliente.email_facturacion = _lector.GetString("email_facturacion");

                class_customer clienteBase = syscom_dbcon.LeerCustomer(pId_customer);
                cliente.Id_customer = clienteBase.Id_customer;
                cliente.Nombre = clienteBase.Nombre;
                cliente.Id_sector = clienteBase.Id_sector;
                cliente.Profit = clienteBase.Profit;
                cliente.Fecha_alta = clienteBase.Fecha_alta;

                return cliente;
            }

            return null;
        }

        /// <summary>
        /// Metodo para obtener los datos del customer especificando su Id
        /// </summary>
        /// <param name="pId_customer">ID Customer</param>
        /// <returns>Te regresa un class_customer</returns>
        public static class_customer LeerCustomer(int pId_customer)
        {
            MySqlCommand select = new MySqlCommand(string.Format("select * from  tbl_clientes where Id_customer= '{0}'", pId_customer), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();

            if (_lector.Read())
            {
                class_customer cliente = new class_customer();
                cliente.Id_customer = _lector.GetInt32("Id_customer");
                cliente.Nombre = _lector.GetString("Nombre");
                cliente.Id_sector = _lector.GetInt32("Id_sector");
                cliente.Profit = _lector.GetInt32("Profit");
                cliente.Fecha_alta = _lector.GetString("Fecha_alta");
                return cliente;
            }

            return null;
        }

        /// <summary>
        /// Lectura de la base de datos para los proyectos
        /// </summary>
        /// <param name="pId_customer">Id del customer</param>
        /// <returns>Regresa la lista de proyectos class_proyecto con el Id del customer</returns>
        public static List<Class_proyecto> LeerProyectos(int pId_customer)
        {
            MySqlCommand select = new MySqlCommand(string.Format("select * from tbl_proyectos where Id_customer= '{0}'", pId_customer), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();
            List<Class_proyecto> lista_proyectos = new List<Class_proyecto>();

            while (_lector.Read())
            {
                Class_proyecto customer = new Class_proyecto();
                customer.Id_proyecto = _lector.GetInt32("Id_customer");
                customer.Id_tipo = _lector.GetInt32("Id_tipo");
                customer.Id_clasificacion = _lector.GetInt32("Id_clasificacion");
                customer.Id_customer = _lector.GetInt32("Id_customer");
                customer.Nombre = _lector.GetString("Nombre");
                customer.Precio = _lector.GetDouble("Precio");
                customer.Evaluacion = _lector.GetString("Evaluacion");
                customer.Comentarios = _lector.GetString("Comentarios");
                customer.FechaAlta = _lector.GetString("FechaAlta");
                lista_proyectos.Add(customer);
            }
            return lista_proyectos;
        }

        /// <summary>
        /// Lee los contactos por cliente
        /// </summary>
        /// <param name="pId_Contacto">Id del customer</param>
        /// <returns>Regresa una lista de la clase class_cliente</returns>
        public static List<class_cliente> LeerContactos(int pId_Contacto)
        {
            MySqlCommand select = new MySqlCommand(string.Format("select * from tbl_clt_personal where Id_cliente= '{0}'", pId_Contacto), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();
            List<class_cliente> lista_contactos = new List<class_cliente>();

            while (_lector.Read())
            {
                class_cliente customer = new class_cliente();
                customer.Id_cliente = _lector.GetInt32("Id_cliente");
                customer.Id_persona = _lector.GetInt32("Id_personal");
                customer.Nombres= _lector.GetString("Nombre");
                customer.Apellido_Paterno= _lector.GetString("Apellido_paterno");
                customer.Apellido_Materno = _lector.GetString("Apellido_materno");
                customer.Puesto = _lector.GetString("Puesto");
                customer.Correo = _lector.GetString("Correo");
                customer.Tel_oficina = _lector.GetString("tel_oficina");
                customer.Celular = _lector.GetString("tel_movil1");
                customer.Tel_movil1 = _lector.GetString("tel_movil2");
                lista_contactos.Add(customer);
            }
            return lista_contactos;
        }

        /// <summary>
        /// Ingresas el nombre del sector y te regresa el ID del mismo.
        /// </summary>
        /// <param name="pNombreSector">Nombre del sector</param>
        /// <returns>Id_sector</returns>
        public static int LeerSector(string pNombreSector)
        {
            MySqlCommand select = new MySqlCommand(string.Format(@"select Id_sector from tbl_sector where Nombre='{0}'", pNombreSector), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();

            if (_lector.Read())
                return _lector.GetInt32(0);

            return -1;
        }

        /// <summary>
        /// Le das el Id_sector y te regresa el Nombre del sector
        /// </summary>
        /// <param name="pId_Sector">es el Id de la tabla que corresponde al sector</param>
        /// <returns>Nombre del sector</returns>
        public static string LeerSector(int pId_Sector)
        {
            MySqlCommand select = new MySqlCommand(string.Format(@"select Nombre from tbl_sector where Id_sector='{0}'", pId_Sector), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();

            if (_lector.Read())
                return _lector.GetString(0);

            return null;
        }

        /// <summary>
        /// Retorna una lista de sectores cuyo parametros son Id_sector y Nombre
        /// </summary>
        /// <returns>Lista dinamica con objetos class_sector</returns>
        public static List<Class_sector> LeerSector()
        {
            MySqlCommand select = new MySqlCommand(string.Format(@"select Id_sector, Nombre from tbl_sector"), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();
            List<Class_sector> Lista_sector = new List<Class_sector>();

            while (_lector.Read())
            {
                Class_sector cliente = new Class_sector();
                cliente.Id_sector = _lector.GetInt32("Id_sector");
                cliente.Nombre = _lector.GetString("Nombre");

                Lista_sector.Add(cliente);
            }

            return Lista_sector;
        }

        /// <summary>
        /// Busqueda de Datos fiscales dado un cliente
        /// </summary>
        /// <param name="pcliente_Base">Instancia de class_custommer</param>
        /// <returns>regresa una class_Fiscal con los datos Fiscales</returns>
        public static class_Fiscal BuscarDatoFiscal(int pId_customer)
        {
            class_Fiscal datos_fiscales = new class_Fiscal();
            MySqlCommand select = new MySqlCommand(string.Format(@"select * from tbl_clt_fiscal where Id_cliente='{0}';", pId_customer), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();

            if (_lector.Read())
            {
                datos_fiscales.RFC = _lector.GetString("RFC");
                datos_fiscales.Razon_social = _lector.GetString("Razon_social");
                datos_fiscales.Regimen = _lector.GetString("Regimen");
                datos_fiscales.Nombre_comercial = _lector.GetString("Nombre_comercial");
                datos_fiscales.Calle = _lector.GetString("Calle");
                datos_fiscales.Numero_ext = _lector.GetInt32("Numero_ext");
                datos_fiscales.Numero_int = _lector.GetInt32("Numero_int");
                datos_fiscales.Colonia = _lector.GetString("Colonia");
                datos_fiscales.Municipio = _lector.GetString("Municipio");
                datos_fiscales.Estado = _lector.GetString("Estado");
                datos_fiscales.CP = _lector.GetString("CP");
                datos_fiscales.email_facturacion = _lector.GetString("email_facturacion");
                return datos_fiscales;
            }

            return null;
        }

        /// <summary>
        /// Busca la el proyectos al ID especificado
        /// </summary>
        /// <param name="pId_proyecto">Id del proyecto</param>
        /// <returns>Te regresa la variable Class_proyecto</returns>
        public static Class_proyecto BuscarProyecto(int pId_proyecto)
        {
            Class_proyecto proyecto = new Class_proyecto();
            MySqlCommand select = new MySqlCommand(string.Format(@"select * from tbl_proyectos where Id_proyecto='{0}';", pId_proyecto), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();

            if (_lector.Read())
            {
                proyecto.Id_proyecto = _lector.GetInt32("Id_customer");
                proyecto.Id_tipo = _lector.GetInt32("Id_tipo");
                proyecto.Id_clasificacion = _lector.GetInt32("Id_clasificacion");
                proyecto.Id_customer = _lector.GetInt32("Id_customer");
                proyecto.Nombre = _lector.GetString("Nombre");
                proyecto.Precio = _lector.GetDouble("Precio");
                proyecto.Evaluacion = _lector.GetString("Evaluacion");
                proyecto.Comentarios = _lector.GetString("Comentarios");
                proyecto.FechaAlta = _lector.GetString("FechaAlta");
                return proyecto;
            }

            return null;
        }

        /// <summary>
        /// Busca y valida si el usuario existe y puede acceder al sistema
        /// </summary>
        /// <param name="pUser">usuario</param>
        /// <param name="pPass">password</param>
        /// <returns>regresa el estado del usuario</returns>
        public static bool BuscarUsuario(string pUser, string pPass)
        {
            MySqlCommand select = new MySqlCommand(string.Format(@"select Status from tbl_useradmin where Nombre='{0}' && Password='{1}';", pUser, pPass), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();

            if (_lector.Read())
            {
                if(_lector.GetString(0) == "activo")
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Metodo para buscar Contacto usando cualquier parte del nombre siempre que coincida completo
        /// </summary>
        /// <param name="pNombre_apellidos">Nombre o Apellido de la persona</param>
        /// <returns>Regresa una lista de coincidencias del tipo class_cliente</returns>
        public static List<class_cliente> BuscarContacto(string pNombre_apellidos)
        {
            MySqlCommand select = new MySqlCommand(string.Format(@"select * from tbl_clt_personal where Nombre='{0}' or Apellido_paterno='{0}' or Apellido_materno='{0}';", pNombre_apellidos), syscom_dbcon.AbrirConexion());
            MySqlDataReader _lector = select.ExecuteReader();
            List<class_cliente> Lista_contactos = new List<class_cliente>();

            while (_lector.Read())
            {
                class_cliente customer= new class_cliente();
                customer.Id_cliente = _lector.GetInt32("Id_cliente");
                customer.Id_persona = _lector.GetInt32("Id_personal");
                customer.Nombres = _lector.GetString("Nombre");
                customer.Apellido_Paterno = _lector.GetString("Apellido_paterno");
                customer.Apellido_Materno = _lector.GetString("Apellido_materno");
                customer.Puesto = _lector.GetString("Puesto");
                customer.Correo = _lector.GetString("Correo");
                customer.Tel_oficina = _lector.GetString("tel_oficina");
                customer.Celular = _lector.GetString("tel_movil1");
                customer.Tel_movil1 = _lector.GetString("tel_movil2");
                Lista_contactos.Add(customer);
            }

            return Lista_contactos;
        }

        /// <summary>
        /// Id_customer
        /// Nombre
        /// Id_sector        giro del negocio(retail, etc etc)
        /// Fecha_alta
        /// </summary>
        /// <param name="customer">Se pasa un cliente para poderlo insertar en la tabla</param>
        /// <returns>1 si ha insertado los datos, 0 si ha habido algún error</returns>
        public static int InsertarEmpresa(class_customer customer)
        {
            int retorno = 0;
            MySqlCommand insert = new MySqlCommand(string.Format("Insert into tbl_clientes(Nombre, Id_sector, Profit, Fecha_alta) values('{0}','{1}','{2}','{3}')", customer.Nombre, customer.Id_sector, customer.Profit, customer.Fecha_alta), syscom_dbcon.AbrirConexion());
            retorno = insert.ExecuteNonQuery();
            return retorno;
        }

        /// <summary>
        /// Agrega los datos fiscales a la base de datos mediante el objeto class_Fiscal que proporciones
        /// </summary>
        /// <param name="pFiscales">Variable class_Fiscal</param>
        /// <returns>Número diferente a 0 si es correcto el insert</returns>
        public static int InsertarDatoFiscal(class_Fiscal pFiscales)
        {
            int retorno = 0;
            MySqlCommand insert = new MySqlCommand(string.Format("Insert into tbl_clt_fiscal(Id_cliente, RFC, Razon_social, Regimen, Nombre_comercial, Calle, Numero_ext, Numero_int, Colonia, Municipio, Estado, CP, email_facturacion) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", pFiscales.Id_customer, pFiscales.RFC, pFiscales.Razon_social, pFiscales.Regimen, pFiscales.Nombre_comercial, pFiscales.Calle, pFiscales.Numero_ext, pFiscales.Numero_int , pFiscales.Colonia, pFiscales.Municipio, pFiscales.Estado, pFiscales.CP, pFiscales.email_facturacion), syscom_dbcon.AbrirConexion());
            retorno = insert.ExecuteNonQuery();
            return retorno;
        }
        
        public static int InsertarConsultor()
        {
            return 1;
        }

        public static int InsertarProyecto()
        {
            return 1;
        }

        public static int InsertarContacto()
        {
            return 1;
        }

        public static int InsertarNivelesySalarios()
        {
            return 1;
        }

        //Tiene fallas el codigo dentro de la sintaxis del query.
        public static int ActualizarDatoFiscal(class_Fiscal pFiscales)
        {
            int retorno = 0;
            MySqlCommand insert = new MySqlCommand(string.Format(@"UPDATE tbl_clt_fiscal SET RFC='{0}', Razon_social='{1}', Regimen='{2}', " +
                "Nombre_comercial='{3}', Calle='{4}', Numero_ext='{5}', Numero_int='{6}', Colonia='{7}', Municipio='{8}', Estado='{9}'," +
                " CP='{10}', email_facturacion='{11}' WHERE Id_cliente='{12}';)", pFiscales.RFC, pFiscales.Razon_social, pFiscales.Regimen,
                pFiscales.Nombre_comercial, pFiscales.Calle, pFiscales.Numero_ext, pFiscales.Numero_int, pFiscales.Colonia, pFiscales.Municipio,
                pFiscales.Estado, pFiscales.CP, pFiscales.email_facturacion, pFiscales.Id_customer), syscom_dbcon.AbrirConexion());
            retorno = insert.ExecuteNonQuery();
            return retorno;
        }

        /// <summary>
        /// Borra los datos Fiscales que corresponden al ID del customer
        /// </summary>
        /// <param name="pId_customer">ID customer</param>
        /// <returns>Regresa un numero diferente a 0 en caso de exito</returns>
        public static int BorrarFiscal(int pId_customer)
        {
            int retorno = 0;
            MySqlCommand insert = new MySqlCommand(string.Format("DELETE FROM tbl_clt_fiscal WHERE Id_cliente='{0}')", pId_customer), syscom_dbcon.AbrirConexion());
            retorno = insert.ExecuteNonQuery();
            return retorno;
        }
        
    }
}