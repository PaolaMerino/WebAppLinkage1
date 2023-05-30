using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebAppLinkage1.Models
{
    public class Departamento
    {
        public int idDepartamento { get; set; }
        public string departamento { get; set; }

        public static DataTable Listar()
        {
            CRUD Tabla = new CRUD();
            return Tabla.Listar("departamento");
        }
    }

}