using Wardrobe.Shared.Models.WardrobeItem;

namespace Wardrobe.API.Services;

public interface IWardrobeItemService
{
    List<WardrobeItemResponse> GetAllWardrobeItems();
    List<WardrobeItemResponse> AddWardrobeItem(WardrobeItemCreateRequest request);
    List<WardrobeItemResponse>? UpdateWardrobeItem(int id, WardrobeItemUpdateRequest request);
}