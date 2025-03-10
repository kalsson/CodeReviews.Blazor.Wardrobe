using Wardrobe.Shared.Entities;

namespace Wardrobe.API.Repositories;

public interface IWardrobeItemRepository
{
    List<WardrobeItem> GetAllWardrobeItems();
    List<WardrobeItem> AddWardrobeItem(WardrobeItem wardrobeItem);
    List<WardrobeItem>? UpdateWardrobeItem(int id, WardrobeItem wardrobeItem);
    List<WardrobeItem>? DeleteWardrobeItem(int id);
}