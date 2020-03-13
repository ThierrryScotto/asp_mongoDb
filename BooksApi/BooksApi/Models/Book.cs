using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace BooksApi.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] 
        public String Id { get; set; }

        [BsonElement("Name")]
        public String Name { get; set; }

        [BsonElement("Price")]
        public Decimal Price { get; set; }

        [BsonElement("Category")]
        public String Category { get; set; }

        [BsonElement("Author")]
        public String Author { get; set; }
    }
}
