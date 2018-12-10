using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager_1._0
{
    public class class_customer
    {
        public int Id_customer { get; set; }
        public string Nombre { get; set; }
        public int Id_sector { get; set; }
        public string Fecha_alta { get; set; }
        public double Profit { get; set; }
        /// <summary>
        /// Constructor Inicial
        /// </summary>
        public class_customer()
        {
            this.Id_customer = -1;
            this.Nombre = "";
            this.Id_sector = -1;
            this.Fecha_alta = DateTime.Now.ToString();
            this.Profit = 0;
        }

        /// <summary>
        /// Clase base sector
        /// </summary>
        /// <param name="pNombre">Nombre de la compañia</param>
        /// <param name="pId_sector">ID del sector al que pertenece su giro</param>
        public class_customer(string pNombre, int pId_sector)
        {
            this.Id_customer = -1;
            this.Nombre = pNombre;
            this.Id_sector = pId_sector;
            this.Fecha_alta = DateTime.Now.ToString();
        }
    }

    public class class_Fiscal : class_customer
    {
        public string RFC { get; set; }
        public string Razon_social {get;set;}
        public string Regimen { get;set;}
        public string Nombre_comercial { get;set;}
        public string Calle { get;set;}
        public int Numero_ext { get;set;}
        public int Numero_int { get;set;}
        public string Colonia { get;set;}
        public string Municipio { get;set;}
        public string Estado { get;set;}
        public string email_facturacion { get; set; }
        public string CP { get; set; }

        public class_Fiscal()
        {
            this.RFC = "";
            this.Razon_social = "";
            this.Regimen = "";
            this.Nombre_comercial = "";
            this.Calle = "";
            this.Numero_ext = -1;
            this.Numero_int = -1;
            this.Colonia = "";
            this.Municipio = "";
            this.Estado = "";
            this.email_facturacion = "";
            this.CP = "";
        }

        public class_Fiscal(class_customer pCliente)
        {
            this.Id_customer = pCliente.Id_customer;
            this.Nombre = pCliente.Nombre;
            this.Id_sector = pCliente.Id_sector;
            this.Fecha_alta = pCliente.Fecha_alta;
            this.Profit = pCliente.Profit;

            this.RFC = "";
            this.Razon_social = "";
            this.Regimen = "";
            this.Nombre_comercial = "";
            this.Calle = "";
            this.Numero_ext = -1;
            this.Numero_int = -1;
            this.Colonia = "";
            this.Municipio = "";
            this.Estado = "";
            this.email_facturacion = "";
            this.CP = "";
        }

        /// <summary>
        /// Constructor que recive datos fiscales
        /// </summary>
        /// <param name="pId_cliente">Id_Cliente</param>
        /// <param name="pRFC">RFC cliente</param>
        /// <param name="pRazon_social">Razon Social</param>
        /// <param name="pRegimen">Regimen Fiscal</param>
        /// <param name="pNombre_comercial">Nombre Comercial</param>
        /// <param name="pCalle">Calle</param>
        /// <param name="pNumero_ext">Numero Exterior</param>
        /// <param name="pNumero_int">Número Interior</param>
        /// <param name="pColonia">Colonia</param>
        /// <param name="pMunicipio">Municipio</param>
        /// <param name="pEstado">Estado</param>
        /// <param name="pCP">Codigo Postal</param>
        /// <param name="pemail_facturacion">Email quien recive la factura</param>
        public class_Fiscal(int pId_cliente, string pRFC, string pRazon_social, string pRegimen, string pNombre_comercial, string pCalle, int pNumero_ext, int pNumero_int, string pColonia, string pMunicipio, string pEstado, string pCP, string pemail_facturacion)
        {
            this.Id_customer = pId_cliente;
            this.RFC = pRFC;
            this.Razon_social = pRazon_social;
            this.Regimen = pRegimen;
            this.Nombre_comercial = pNombre_comercial;
            this.Calle = pCalle;
            this.Numero_ext = pNumero_ext;
            this.Numero_int = pNumero_int;
            this.Colonia = pColonia;
            this.Municipio = pMunicipio;
            this.Estado = pEstado;
            this.email_facturacion = pemail_facturacion;
            this.CP = pCP;
        }

        public class_Fiscal(class_customer pCliente, string pRFC="N/A", string pRazon_social="N/A", string pRegimen=" ", string pNombre_comercial=" ", string pCalle=" ", int pNumero_ext=0, int pNumero_int=0, string pColonia=" ", string pMunicipio=" ", string pEstado=" ", string pCP=" ", string pemail_facturacion=" ")
        {
            this.Id_customer = pCliente.Id_customer;
            this.Nombre = pCliente.Nombre;
            this.Id_sector = pCliente.Id_sector;
            this.Fecha_alta = pCliente.Fecha_alta;
            this.Profit = pCliente.Profit;
            
            this.RFC = pRFC;
            this.Razon_social = pRazon_social;
            this.Regimen = pRegimen;
            this.Nombre_comercial = pNombre_comercial;
            this.Calle = pCalle;
            this.Numero_ext = pNumero_ext;
            this.Numero_int = pNumero_int;
            this.Colonia = pColonia;
            this.Municipio = pMunicipio;
            this.Estado = pEstado;
            this.email_facturacion = pemail_facturacion;
            this.CP = pCP;
        }
    }
}