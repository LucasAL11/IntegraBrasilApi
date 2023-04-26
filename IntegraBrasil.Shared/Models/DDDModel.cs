using System.Text.Json.Serialization;

namespace IntegraBrasil.Shared.Models;

public class DDDModel
{
    [JsonPropertyName("state")] 
    public string? State { get; set; }
    
    [JsonPropertyName("cities")] 
    public List<string>? Cities { get; set; }
}