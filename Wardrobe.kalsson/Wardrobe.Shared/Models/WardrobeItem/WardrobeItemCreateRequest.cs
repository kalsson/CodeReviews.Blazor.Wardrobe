namespace Wardrobe.Shared.Models.WardrobeItem;

public class WardrobeItemCreateRequest
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public string? ImagePath { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
}