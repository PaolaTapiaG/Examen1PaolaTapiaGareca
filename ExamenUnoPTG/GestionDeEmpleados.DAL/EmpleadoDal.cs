using GestionDeEmpleados.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.DAL
{
    public class EmpleadoDal
    {
        Empleado empleado = new Empleado();
        public DataTable ListarEmpleadoDal()
        {
            string consulta = "select * from empleado";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
        }
        public void InsertarEmpleadoDal(Empleado empleado)
        {
            string consulta = "insert into empleado values(" + empleado.IdPersona + "," +
                                                         "'" + empleado.Puesto + "'," +
                                                         "" + empleado.Salario + "," +
                                                         "'" + empleado.FechaContratacion+ "')";
            conexion.Ejecutar(consulta);
        }
      
        public Empleado ObtenerEmpleadoIdDal(int idempleado)
        {
            string consulta = "select * from empleado where idempleado=" + idempleado;
            DataTable table = conexion.EjecutarDataTabla(consulta, "table");
            if (table.Rows.Count > 0)
            {
                empleado.IdEmpleado = Convert.ToInt32(table.Rows[0]["idempleado"]);
                empleado.IdPersona = Convert.ToInt32(table.Rows[0]["idpersona"]);
                empleado.Puesto= table.Rows[0]["Puesto"].ToString();
                empleado.Salario = Convert.ToDecimal(table.Rows[0]["salario"]);
                empleado.FechaContratacion = Convert.ToDateTime(table.Rows[0]["fechacontratacion"]);

            }
            return empleado;
        }
        public void EditarEmpleadoDal(Empleado empleado)
        {
            string consulta = "update empleado set  idpersona=" + empleado.IdPersona + "," +
                                                        "puesto='" + empleado.Puesto + "'," +
                                                        "salario=" + empleado.Salario + "," +
                                                        "fechacontratacion='" + empleado.FechaContratacion+ "' " +
                                                "where idempleado=" + empleado.IdEmpleado;
            conexion.Ejecutar(consulta);
        }
        public void EliminarEmpleadoDal(int idpersona)
        {
            string consulta = "delete from empleado where idempleado=" + idpersona;
            conexion.Ejecutar(consulta);
        }
    }
}
