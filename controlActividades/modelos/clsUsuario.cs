using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlActividades.modelos
{
    public class clsUsuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        [BsonElement("nUsuario")]
        public string nUsuario { get; set; }
        [BsonElement("nombre")]
        public String nombre { get; set; }
        [BsonElement("apellidoPaterno")]
        public String apellidoPaterno { get; set; }
        [BsonElement("apellidoMaterno")]
        public String apellidoMaterno { get; set; }
        [BsonElement("edad")]
        public string edad { get; set; }
    }
}
