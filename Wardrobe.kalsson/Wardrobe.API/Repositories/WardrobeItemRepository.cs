using Wardrobe.Shared.Entities;

namespace Wardrobe.API.Repositories;

public class WardrobeItemRepository : IWardrobeItemRepository
{
    private static List<WardrobeItem> _wardrobeItems = new List<WardrobeItem>
    {
        new WardrobeItem
        {
            Id = 1, 
            Name = "Wardrobe Item 1", 
            Description = "This is some description 1",
            DateCreated = DateTime.Now.AddHours(1),
            ImagePath = ""
        },
        new WardrobeItem
        {
            Id = 2,
            Name = "Wardrobe Item 2",
            Description = "This is some description 2",
            DateCreated = DateTime.Now.AddHours(2),
            ImagePath = ""
        }
    };
    
    public List<WardrobeItem> GetAllWardrobeItems()
    {
        return _wardrobeItems;
    }

    public List<WardrobeItem> AddWardrobeItem(WardrobeItem wardrobeItem)
    {
        _wardrobeItems.Add(wardrobeItem);
        return _wardrobeItems;
    }

    public List<WardrobeItem>? UpdateWardrobeItem(int id, WardrobeItem wardrobeItem)
    {
        var itemToUpdateIndex = _wardrobeItems.FindIndex(x => x.Id == id);
        if (itemToUpdateIndex == -1)
        {
            return null;
        }
        _wardrobeItems[itemToUpdateIndex] = wardrobeItem;
        return _wardrobeItems;
        
    }
}