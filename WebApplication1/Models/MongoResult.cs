using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MongoResult
    {
        
       [BsonId]
        public ObjectId Id { get; set; }

       public String type { get; set; }
        public String host { get; set; }

        public String source { get; set; }

        public String message { get; set; }

        public DateTime time { get; set; }

        public Int32 statusCode { get; set; }


        public String webHostHtmlMessage { get; set; }

        
        public String detail { get; set; }

        public String user { get; set; }
        public String ApplicationName { get; set; }
    }
}