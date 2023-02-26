namespace MagicAPI.Models
{
    public record MessageHubModel
    {
        public string RoomName { get; init; } = null!;
        public string RoomId { get; init; } = null!;
    }
}
