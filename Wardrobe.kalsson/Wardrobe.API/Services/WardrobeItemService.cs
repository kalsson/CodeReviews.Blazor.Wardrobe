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

    public List<WardrobeItemResponse> GetAllWardrobeItems()
    {
        var result = _wardrobeItemRepository.GetAllWardrobeItems();
        return result.Adapt<List<WardrobeItemResponse>>();
    }

    public List<WardrobeItemResponse> AddWardrobeItem(WardrobeItemCreateRequest request)
    {
        var newItem = request.Adapt<WardrobeItem>();
        var result = _wardrobeItemRepository.AddWardrobeItem(newItem);
        return result.Adapt<List<WardrobeItemResponse>>();
    }
}