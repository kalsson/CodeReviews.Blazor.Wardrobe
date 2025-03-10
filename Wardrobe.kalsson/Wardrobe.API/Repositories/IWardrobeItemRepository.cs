using Wardrobe.Shared.Entities;

namespace Wardrobe.API.Repositories;

public interface IWardrobeItemRepository
{
    WardrobeItem? GetWardrobeItemById(int id);
    List<WardrobeItem> GetAllWardrobeItems();
    List<WardrobeItem> AddWardrobeItem(WardrobeItem wardrobeItem);
    List<WardrobeItem>? UpdateWardrobeItem(int id, WardrobeItem wardrobeItem);
    List<WardrobeItem>? DeleteWardrobeItem(int id);
}