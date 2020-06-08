using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ETrade.Entity.Concrete
{ 
    [Table("tbl_Basket")]
    public class tbl_Basket
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string _id { get; set; } 
        [StringLength(20)]
        public string BookName { get; set; }
        [StringLength(250)]
        public string BookAuthor { get; set; }
        [StringLength(250)]
        public string BookPrice { get; set; }
        public string BookCategory { get; set; }
    }
}
