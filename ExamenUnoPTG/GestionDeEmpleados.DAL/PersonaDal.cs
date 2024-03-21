using GestionDeEmpleados.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.DAL
{
    public class PersonaDal
    {
        Persona persona = new Persona();
        public DataTable ListarPersonaDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
        }
        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," +
                                                         "'" + persona.Apellido + "'," +
                                                         "'" + persona.Estado + "')";
            conexion.Ejecutar(consulta);
        }
        public Persona ObtenerPersonaIdDal(int idpersona)
        {
            string consulta = "select * from persona where idpersona=" + idpersona;
            DataTable table = conexion.EjecutarDataTabla(consulta, "table");
            if (table.Rows.Count > 0)
            {
                persona.IdPersona = Convert.ToInt32(table.Rows[0]["idpersona"]);
                persona.Nombre = table.Rows[0]["nombre"].ToString();
                persona.Apellido = table.Rows[0]["apellido"].ToString();
                persona.Estado = table.Rows[0]["estado"].ToString();

            }
            return persona;
        }
        public void EditarPersonaDal(Persona p)
        {
            string consulta = "update persona set nombre='" + p.Nombre + "'," +
                                                        "apellido='" + p.Apellido + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idpersona=" + p.IdPersona;
            conexion.Ejecutar(consulta);
        }
        public void EliminarPersonaDal(int idpersona)
        {
            string consulta = "delete from persona where idpersona=" + idpersona;
            conexion.Ejecutar(consulta);
        }
    }
}
