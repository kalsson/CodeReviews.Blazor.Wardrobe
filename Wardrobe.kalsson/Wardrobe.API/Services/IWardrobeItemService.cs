using Wardrobe.API.Repositories;
using Wardrobe.Shared.Models.WardrobeItem;

namespace Wardrobe.API.Services;

public interface IWardrobeItemService
{
    WardrobeItemResponse? GetWardrobeItemById(int id);
    List<WardrobeItemResponse> GetAllWardrobeItems();
    List<WardrobeItemResponse> AddWardrobeItem(WardrobeItemCreateRequest request);
    List<WardrobeItemResponse>? UpdateWardrobeItem(int id, WardrobeItemUpdateRequest request);
    List<WardrobeItemResponse>? DeleteWardrobeItem(int id);
}