

namespace SuggestionAppLibrary.Models;

public class CategoryModel
{  [BsonId]
//unique identifier and should be assigned a value
   [BsonRepresentation(BsonType.ObjectId)]
   //create a new identifier
   public string Id { get; set;}
   public string CategoryName { get; set;}
   public string CategoryDescription { get; set; }
}
