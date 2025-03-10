using Wardrobe.Shared.Entities;

namespace Wardrobe.API.Repositories;

public interface IWardrobeItemRepository
{
    List<WardrobeItem> GetAllWardrobeItems();
    List<WardrobeItem> AddWardrobeItem(WardrobeItem wardrobeItem);
}