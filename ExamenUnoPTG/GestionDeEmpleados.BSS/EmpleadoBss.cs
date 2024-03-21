using GestionDeEmpleados.DAL;
using GestionDeEmpleados.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeEmpleados.BSS
{
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListarEmpleadoBss()
        {
            return dal.ListarEmpleadoDal();
        }
        public void InsertarEmpleadoBss(Empleado empleado)
        {
            dal.InsertarEmpleadoDal(empleado);
        }
        public Empleado ObtenerEmpleadoIdBss(int idempleado)
        {
            return dal.ObtenerEmpleadoIdDal(idempleado);
        }
        public void EditarEmpleadoBss(Empleado empleado)
        {
            dal.EditarEmpleadoDal(empleado);
        }
        public void EliminarEmpleadoBss(int idempleado)
        {
            dal.EliminarEmpleadoDal(idempleado);
        }
    }
}
