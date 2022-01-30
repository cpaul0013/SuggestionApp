using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuggestionAppLibrary.Models;

public class StatusModel
{
   [BsonId]
   //unique identifier and should be assigned a value
   [BsonRepresentation(BsonType.ObjectId)]
   //create a new identifier
   public string Id { get; set; }
   public string StatusName { get; set; }
   public string StatusDescription { get; set; }
}
