using System.Text.Json.Serialization;

namespace ArtFrame.Models
{
    public class ObjectsModel
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }
        [JsonPropertyName("objectIDs")]
        public List<int>? ObjectIDs { get; set; }
    }

    public class Object
    {
        public int ObjectID { get; set; }
    }
}
