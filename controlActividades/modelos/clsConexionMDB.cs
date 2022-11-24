using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlActividades.modelos
{
    public class clsConexionMDB
    {
        /// <summary>
        /// Busca la coleccion de Usuario
        /// </summary>
        /// <returns>IMongoCollection<clsAlumnoModelo></returns>
        public static IMongoCollection<clsUsuario> GetUsuarioCollection()
        {
            MongoClient clienteMongo = new MongoClient("mongodb://localhost:27017");
            var db = clienteMongo.GetDatabase("controlActividades");
            return db.GetCollection<clsUsuario>("Usuario");
        }

        /// <summary>
        /// busca la coleccion de Actididad
        /// </summary>
        /// <returns>IMongoCollection</returns>
         public static IMongoCollection<clsActividad> GetActividadCollection()
        {
            MongoClient clienteMongo = new MongoClient("mongodb://localhost:27017");
            var db = clienteMongo.GetDatabase("controlActividades");
            return db.GetCollection<clsActividad>("Actividad");
        }
    }
}
