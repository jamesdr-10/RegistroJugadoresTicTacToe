using System.Text.Json.Serialization;
public class PartidaResponse
{
    [JsonPropertyName("partidaId")]
    public int PartidaId { get; set; }

    [JsonPropertyName("jugador1Id")]
    public int Jugador1Id { get; set; }

    [JsonPropertyName("jugador2Id")]
    public int? Jugador2Id { get; set; }
}
