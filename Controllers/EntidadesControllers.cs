using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Testing2.Models;

namespace Testing2.Controllers
{
    public class EntidadesControllers : Controller
    {
        public IActionResult ListadoEntidades() //vista de lista de entidades
        {
            List<Entidades> ListadoEntidades = new List<Entidades>();

            //Conexion
            SqlCommand Commando = new SqlCommand("Select top 10 DNI as [DNI], Nombre as [Nombre], Apellido as [Apellido], Direccion as [Direccion] from Table_Entidades", Conexion.ObtenerConexion());
            SqlDataReader reader = Commando.ExecuteReader();

            while (reader.Read())
            {
                //Creamos un objeto Producto
                Entidades ObjEntidades = new Entidades();

                ObjEntidades.DNI = Convert.ToInt32(reader["DNI"]);
                ObjEntidades.Nombre = Convert.ToString(reader["Nombre"]);
                ObjEntidades.Apellido = Convert.ToString(reader["Apellido"]);
                ObjEntidades.Direccion = Convert.ToString(reader["Direccion"]);
                ListadoEntidades.Add(ObjEntidades); //Pasamos el Objeto a la Lista
            }
            reader.Close();
            return View(ListadoEntidades);
        }


        [HttpGet]
        public IActionResult Editar(Int32 dni, string Nombre, String Apellido, String Direccion)
        {
            int dnienviado = dni;
            string nombre = Nombre;
            string apellido = Apellido;
            string direccion = Direccion;

            //Conectar tu base de datos.
            //obtener el registro.

            Entidades ModificarEntidad = new Entidades();

            return View(ModificarEntidad);
        }


        [HttpPost]
        public IActionResult Editar(Entidades entidades)
        {

            //Conectar tu base de datos.
            //obtener el registro.

            Entidades ModificarEntidad = new Entidades();

            return View(ModificarEntidad);
        }

        public IActionResult NuevaEntidad()
        {
            Entidades NuevaEntidad = new Entidades();

            return View(NuevaEntidad);
        }
    }

}
