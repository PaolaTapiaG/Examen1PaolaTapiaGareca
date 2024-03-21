using Examen.DAL;
using Examen.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.BSS
{
    public class EmpleadosBss
    {
        EmpleadosDal dal = new EmpleadosDal();
        public DataTable ListarEmpleadosBss()
        {
            return dal.ListarEmpleadosDal();
        }
        public void InsertarEmpleadoBss(Empleados empleados)
        {
            dal.InsertarEmpleadosDal(empleados);
        }
       
       /* public void EditarEmpleadosBss(Empleados empleados)
        {
            dal.EditarEmpleadosDal(p);
        }
        public void EliminarEmpleadosBss(int id)
        {
            dal.EliminarEmpleadosDal(id);
        }*/
    }
}
