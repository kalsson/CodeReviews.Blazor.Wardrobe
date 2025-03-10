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

        /// <summary>
        /// Retrieves a list of all wardrobe items.
        /// </summary>
        /// <returns>
        /// A list of <see cref="WardrobeItemResponse"/> representing all wardrobe items.
        /// </returns>
        [HttpGet]
        public ActionResult<List<WardrobeItemResponse>> GetAllWardrobeItems()
        {
            return Ok(_wardrobeItemService.GetAllWardrobeItems());
        }

        /// <summary>
        /// Retrieves a wardrobe item by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the wardrobe item to retrieve.</param>
        /// <returns>
        /// An <see cref="ActionResult{T}"/> containing the <see cref="WardrobeItemResponse"/> if found,
        /// or a "Not Found" response if the item does not exist.
        /// </returns>
        [HttpGet("{id}")]
        public ActionResult<WardrobeItemResponse> GetWardrobeItemById(int id)
        {
            var result = _wardrobeItemService.GetWardrobeItemById(id);
            if (result is null)
            {
                return NotFound("Wardrobe item not found.");
            }
            return Ok(result);
        }

        /// <summary>
        /// Adds a new wardrobe item to the collection.
        /// </summary>
        /// <param name="wardrobeItem">The details of the wardrobe item to be added.</param>
        /// <returns>
        /// A list of <see cref="WardrobeItemResponse"/> representing the updated collection of wardrobe items.
        /// </returns>
        [HttpPost]
        public ActionResult<List<WardrobeItemResponse>> AddWardrobeItem(WardrobeItemCreateRequest wardrobeItem)
        {
            return Ok(_wardrobeItemService.AddWardrobeItem(wardrobeItem));
        }

        /// <summary>
        /// Updates an existing wardrobe item.
        /// </summary>
        /// <param name="id">The unique identifier of the wardrobe item to update.</param>
        /// <param name="wardrobeItem">The updated details for the wardrobe item.</param>
        /// <returns>
        /// A list of <see cref="WardrobeItemResponse"/> reflecting the updated state of the wardrobe item collection,
        /// or a "Not Found" response if the specified wardrobe item does not exist.
        /// </returns>
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

        /// <summary>
        /// Deletes a wardrobe item by its identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the wardrobe item to be deleted.</param>
        /// <returns>
        /// A list of <see cref="WardrobeItemResponse"/> representing the updated collection of wardrobe items,
        /// or a "Not Found" response if the item does not exist.
        /// </returns>
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
