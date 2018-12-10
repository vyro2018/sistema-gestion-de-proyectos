using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager_1._0
{
    public class Class_sector
    {
        public int Id_sector { get; set; }
        public string Nombre { get; set; }

        public Class_sector()
        {
            this.Id_sector = -1;
            this.Nombre = "";
        }
    }
    public class Class_proyecto
    {
        public int Id_proyecto { get; set; }
        public int Id_tipo { get; set; }
        public int Id_clasificacion { get; set; }
        public int Id_customer { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Evaluacion { get; set; }
        public string Comentarios { get; set; }
        public string FechaAlta { get; set; }
        public string Estado_viabilidad { get; set; }

        /// <summary>
        /// Constructor Inicial
        /// </summary>
        public Class_proyecto()
        {
            this.Id_proyecto = -1;
            this.Id_tipo = -1;
            this.Id_clasificacion = -1;
            this.Nombre = "";
            this.Precio = 0.0;
            this.Evaluacion = "";
            this.Comentarios= "";
            this.FechaAlta = "";
            this.Estado_viabilidad = "";
        }
    }
}
