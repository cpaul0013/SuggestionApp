namespace SuggestionAppLibrary.Models;

internal class UserModel
{
   [BsonId]
   //unique identifier and should be assigned a value
   [BsonRepresentation(BsonType.ObjectId)]
   //create a new identifier
   public string Id { get; set; }
   public string ObjectIdentifier { get; set; }
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string DisplayName { get; set; }
   public string EmailAddress { get; set; }
   public List<BasicSuggestionModel> AuthoredAuggestions { get; set; } = new();
   public List<BasicSuggestionModel> VotedOnSuggestions { get; set; } = new();

}
