using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using controlActividades.modelos;

namespace controlActividades.modelos
{
    public class clsMetodos
    {
        ///<sumary>
        ///insertar un usuario
        ///</sumary>
        /// <param name="oUsuario"></param>

        public static void InsertarUsuario(clsUsuario oUsuario)
        {
            var dbCollection = clsConexionMDB.GetUsuarioCollection();
            dbCollection.InsertOne(oUsuario);
        }

        ///<sumary>
        ///insertar una Actividad 
        /// </sumary>
        /// <param name="oActividad"></param>
        
        public static void InsertarActividad(clsActividad oActividad)
        {
            var dbCollection = clsConexionMDB.GetActividadCollection();
            dbCollection.InsertOne(oActividad);
        }


        /// <summary>
        /// Reemplaza un Usuario
        /// </summary>
        /// <param name="oUsuarioOriginal"></param>
        /// <param name="oUsuarioNuevo"></param>
        public static void ReemplazarUsuario(clsUsuario oUsuarioOriginal, clsUsuario oUsuarioNuevo)
        {
            var dbCollection = clsConexionMDB.GetUsuarioCollection();
            dbCollection.ReplaceOne(D => D.nUsuario == oUsuarioOriginal.nUsuario, oUsuarioNuevo);
        }

        ///<sumary>
        ///remplazar una Actividad
        /// </sumary>
        /// <param name="oActividadOriginal"></param>
        /// <param name="oActividadNueva"></param>
        /// 
        public static void remplazarActividad(clsActividad oActividadOriginal, clsActividad oActividadNueva)
        {
            var dbcollection = clsConexionMDB.GetActividadCollection();
            dbcollection.ReplaceOne(D => D.nActividad == oActividadOriginal.nActividad, oActividadNueva);
        }

        /// <summary>
        /// Elimina un Usuario
        /// </summary>
        /// <param name="oUsuario"></param>
        public static void EliminarUsuario(clsUsuario oUsuario)
        {
            var dbCollection = clsConexionMDB.GetUsuarioCollection();
            dbCollection.DeleteOne(D => D.nUsuario == oUsuario.nUsuario);
        }
        /// <sumary>
        /// Eliminar una actividad 
        /// </sumary>
        /// <param name="oActividad"></param>
        public static void EliminarActividad(clsActividad oActividad)
        {
            var dbcollection = clsConexionMDB.GetActividadCollection();
            dbcollection.DeleteOne(D => D.nActividad == oActividad.nActividad);
        }

        /// <summary>
        /// Verifica la existencia de un Usuario
        /// </summary>
        /// <param name="sMatricula"></param>
        /// <returns>bool</returns>
        public static bool VerificarUsuario(String sMatricula)
        {
            var dbCollection = clsConexionMDB.GetUsuarioCollection();
            var Exist = dbCollection.Find(D => D.nUsuario == sMatricula).First();
            if (Exist != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
