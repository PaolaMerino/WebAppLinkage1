using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebAppLinkage1.Models;

namespace WebAppLinkage1.Servicios
{
    public class DepartamentosService
    {
        public List<Departamento> GetDepartamentos()
        {
            DataTable dt = new DataTable();
            dt = Departamento.Listar();
            List<Departamento> deptoList = new List<Departamento>();
            foreach (DataRow row in dt.Rows)
            {//Creamos el objeto
                Departamento depto = new Departamento();
                depto.idDepartamento = int.Parse(row["idDepartamento"].ToString());
                depto.departamento = row["departamento"].ToString();
                //Agregamos el objeto a la lista
                deptoList.Add(depto); 
            }
            return deptoList;
        }
    }
}