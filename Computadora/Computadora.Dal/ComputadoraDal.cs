using Computadora.Dal;
using Computadora.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Computadora.Dal
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadoraDal()
        {
            string consulta = " select * from computadora";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarComputadoraDal(Computadoras computadora)
        {
            string consulta = "insert into computadora values('" + computadora.Nombre + "' ," +
                                                           "'" + computadora.Descripcion + "'," +
                                                            "" + computadora.Precio + "," +
                                                            "'" + computadora.FechaFabricacion + "')";
            conexion.Ejecutar(consulta);
        }
        public Computadoras ObtenerComputadoraId(int id)
        {
            string consulta = "select * from computadora where idcomputadora=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Computadoras c = new Computadoras();
            if (tabla.Rows.Count > 0)
            {
                c.IdComputadora = Convert.ToInt32(tabla.Rows[0]["idcomputadora"]);
                c.Nombre = tabla.Rows[0]["nombre"].ToString();
                c.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                c.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
                c.FechaFabricacion = Convert.ToDateTime(tabla.Rows[0]["fechafabricacion"]);

            }
            return c;

        }

        public void EditarComputadoraDal(Computadoras c)
        {
            string consulta = "update computadora set nombre='" + c.Nombre + "'," +
                                                 "descripcion='" + c.Descripcion+ "'," +
                                                 "precio='" + c.Precio + "'," +
                                                 "fechafabricacion='" + c.FechaFabricacion + "' " +
                               "where idcomputadora=" + c.IdComputadora;
            conexion.Ejecutar(consulta);
        }
        public void EliminarComputadoraDal(int id)
        {
            string consulta = "delete from computadora where idcomputadora=" + id;
            conexion.Ejecutar(consulta); 
            }
    }
}




