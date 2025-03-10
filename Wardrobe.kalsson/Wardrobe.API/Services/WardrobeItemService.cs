using Mapster;
using Wardrobe.API.Repositories;
using Wardrobe.Shared.Entities;
using Wardrobe.Shared.Models.WardrobeItem;

namespace Wardrobe.API.Services;

public class WardrobeItemService : IWardrobeItemService
{
    private readonly IWardrobeItemRepository _wardrobeItemRepository;

    public WardrobeItemService(IWardrobeItemRepository wardrobeItemRepository)
    {
        _wardrobeItemRepository = wardrobeItemRepository;
    }

    /// Retrieves a wardrobe item by its unique identifier.
    /// <param name="id">The unique identifier of the wardrobe item.</param>
    /// <returns>Returns a <see cref="WardrobeItemResponse"/> object if the item is found; otherwise, null.</returns>
    public WardrobeItemResponse? GetWardrobeItemById(int id)
    {
        var result = _wardrobeItemRepository.GetWardrobeItemById(id);
        if (result is null)
        {
            return null;
        }

        return result.Adapt<WardrobeItemResponse>();
    }

    /// <summary>
    /// Retrieves all wardrobe items from the repository and maps them to a list of response models.
    /// </summary>
    /// <returns>A list of <see cref="WardrobeItemResponse"/> containing all wardrobe items.</returns>
    public List<WardrobeItemResponse> GetAllWardrobeItems()
    {
        var result = _wardrobeItemRepository.GetAllWardrobeItems();
        return result.Adapt<List<WardrobeItemResponse>>();
    }

    /// <summary>
    /// Adds a new wardrobe item to the repository and returns the updated list of wardrobe items.
    /// </summary>
    /// <param name="request">The request object containing the details of the new wardrobe item to be added.</param>
    /// <returns>A list of wardrobe item responses representing the updated collection of wardrobe items.</returns>
    public List<WardrobeItemResponse> AddWardrobeItem(WardrobeItemCreateRequest request)
    {
        var newItem = request.Adapt<WardrobeItem>();
        var result = _wardrobeItemRepository.AddWardrobeItem(newItem);
        return result.Adapt<List<WardrobeItemResponse>>();
    }

    /// <summary>
    /// Updates an existing wardrobe item with new properties provided in the update request.
    /// </summary>
    /// <param name="id">The unique identifier of the wardrobe item to update.</param>
    /// <param name="request">The updated properties of the wardrobe item encapsulated within a request object.</param>
    /// <returns>A list of all wardrobe items including the updated one, or null if the update operation failed.</returns>
    public List<WardrobeItemResponse>? UpdateWardrobeItem(int id, WardrobeItemUpdateRequest request)
    {
        var updatedItem = request.Adapt<WardrobeItem>();
        var result = _wardrobeItemRepository.UpdateWardrobeItem(id, updatedItem);
        if (result is null)
        {
            return null;
        }
        return result.Adapt<List<WardrobeItemResponse>>();
    }

    /// Deletes a wardrobe item by its ID and returns the updated list of wardrobe items.
    /// <param name="id">The ID of the wardrobe item to be deleted.</param>
    /// <returns>A list of updated wardrobe items after the specified item is deleted, or null if the item does not exist.</returns>
    public List<WardrobeItemResponse>? DeleteWardrobeItem(int id)
    {
        var result = _wardrobeItemRepository.DeleteWardrobeItem(id);
        if (result is null)
        {
            return null;
        }
        return result.Adapt<List<WardrobeItemResponse>>();
    }
}