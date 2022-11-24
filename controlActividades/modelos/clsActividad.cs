using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlActividades.modelos
{
    public class clsActividad
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        [BsonElement]
        public string nActividad { get; set; }
        [BsonElement("nombreActividad")]
        public string nombreActividad { get; set; }
        [BsonElement("usuario")]
        public string usuario { get; set; }
        //[BsonElement("status")]
        //public int status { get; set; }
    }
}
