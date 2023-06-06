using System.Text.Json.Serialization;

namespace ArtFrame.Models
{
    public class ObjectResponseModel
    {
        [JsonPropertyName("objectID")]
        public int ObjectID { get; set; }
        [JsonPropertyName("isHighlight")]
        public bool isHighlight { get; set; }
        [JsonPropertyName("accessionNumber")]
        public string? accessionNumber { get; set; }
        [JsonPropertyName("accessionYear")]
        public string? accessionYear { get; set; }
        [JsonPropertyName("primaryImage")]
        public string? primaryImage { get; set; }
        [JsonPropertyName("department")]
        public string? department { get; set; }
        [JsonPropertyName("dynasty")]
        public string? objectName { get; set; }
        [JsonPropertyName("objectID")]
        public string? title { get; set; }
        [JsonPropertyName("objectID")]
        public string? culture { get; set; }
        [JsonPropertyName("objectID")]
        public string? period { get; set; }
        [JsonPropertyName("objectID")]
        public string? dynasty { get; set; }
        [JsonPropertyName("reign")]
        public string? reign { get; set; }
        [JsonPropertyName("portfolio")]
        public string? portfolio { get; set; }
        [JsonPropertyName("artistRole")]
        public string? artistRole { get; set; }
        [JsonPropertyName("artistPrefix")]
        public string? artistPrefix { get; set; }
        [JsonPropertyName("artistDisplayName")]
        public string? artistDisplayName { get; set; }
        [JsonPropertyName("artistDisplayBio")]
        public string? artistDisplayBio { get; set; }
        [JsonPropertyName("artistNationality")]
        public string? ArtistNationality { get; set; }
        [JsonPropertyName("isPublicDomain")]
        public bool isPublicDomain { get; set; }



    }
}
