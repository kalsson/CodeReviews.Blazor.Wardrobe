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

    /// Retrieves all wardrobe items available in the repository.
    /// <returns>A list of all wardrobe items.</returns>
    public List<WardrobeItem> GetAllWardrobeItems()
    {
        return _wardrobeItems;
    }

    /// Adds a new wardrobe item to the repository.
    /// <param name="wardrobeItem">The wardrobe item to be added.</param>
    /// <returns>An updated list of all wardrobe items including the newly added item.</returns>
    public List<WardrobeItem> AddWardrobeItem(WardrobeItem wardrobeItem)
    {
        _wardrobeItems.Add(wardrobeItem);
        return _wardrobeItems;
    }

    /// Updates an existing wardrobe item in the repository.
    /// <param name="id">The unique identifier of the wardrobe item to be updated.</param>
    /// <param name="wardrobeItem">The updated wardrobe item details.</param>
    /// <returns>A list of all wardrobe items after the update, or null if the item was not found.</returns>
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

    /// Deletes a wardrobe item from the repository based on the specified identifier.
    /// <param name="id">The identifier of the wardrobe item to be deleted.</param>
    /// <returns>An updated list of all wardrobe items excluding the deleted item, or null if the item was not found.</returns>
    public List<WardrobeItem>? DeleteWardrobeItem(int id)
    {
        var itemToDelete = _wardrobeItems.FirstOrDefault(x => x.Id == id);
        if (itemToDelete is null)
        {
            return null;
        }
        _wardrobeItems.Remove(itemToDelete);
        return _wardrobeItems;
    }

    /// Retrieves a wardrobe item by its unique identifier.
    /// <param name="id">The unique identifier of the wardrobe item to retrieve.</param>
    /// <returns>The wardrobe item with the specified identifier, or null if not found.</returns>
    public WardrobeItem? GetWardrobeItemById(int id)
    {
        return _wardrobeItems.FirstOrDefault(x => x.Id == id);
    }
}