using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wardrobe.API.Repositories;
using Wardrobe.API.Services;
using Wardrobe.Shared.Entities;
using Wardrobe.Shared.Models.WardrobeItem;

namespace Wardrobe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardrobeItemController : ControllerBase
    {
        private readonly IWardrobeItemService _wardrobeItemService;

        public WardrobeItemController(IWardrobeItemService wardrobeItemService)
        {
            _wardrobeItemService = wardrobeItemService;
        }
        
        [HttpGet]
        public ActionResult<List<WardrobeItemResponse>> GetAllWardrobeItems()
        {
            return Ok(_wardrobeItemService.GetAllWardrobeItems());
        }
        
        [HttpPost]
        public ActionResult<List<WardrobeItemResponse>> AddWardrobeItem(WardrobeItemCreateRequest wardrobeItem)
        {
            return Ok(_wardrobeItemService.AddWardrobeItem(wardrobeItem));
        }
        
        [HttpPut("{id}")]
        public ActionResult<List<WardrobeItemResponse>> UpdateWardrobeItem(int id, WardrobeItemUpdateRequest wardrobeItem)
        {
            var result = _wardrobeItemService.UpdateWardrobeItem(id, wardrobeItem);
            if (result is null)
            {
                return NotFound("Wardrobe Item with the given ID not found.");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<WardrobeItemResponse>> DeleteWardrobeItem(int id)
        {
            var result = _wardrobeItemService.DeleteWardrobeItem(id);
            if (result is null)
            {
                return NotFound("Wardrobe Item with the given ID not found.");
            }
            return Ok(result);
        }
    }
}
