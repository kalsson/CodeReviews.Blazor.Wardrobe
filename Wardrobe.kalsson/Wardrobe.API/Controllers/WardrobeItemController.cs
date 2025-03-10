using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wardrobe.API.Repositories;
using Wardrobe.Shared.Entities;

namespace Wardrobe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardrobeItemController : ControllerBase
    {
        private readonly IWardrobeItemRepository _wardrobeItemRepository;

        public WardrobeItemController(IWardrobeItemRepository wardrobeItemRepository)
        {
            _wardrobeItemRepository = wardrobeItemRepository;
        }
        
        [HttpGet]
        public ActionResult<List<WardrobeItem>> GetAllWardrobeItems()
        {
            return Ok(_wardrobeItemRepository.GetAllWardrobeItems());
        }
        
        [HttpPost]
        public ActionResult<List<WardrobeItem>> AddWardrobeItem(WardrobeItem wardrobeItem)
        {
            return Ok(_wardrobeItemRepository.AddWardrobeItem(wardrobeItem));
        }
    }
}
