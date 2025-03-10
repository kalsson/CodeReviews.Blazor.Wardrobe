using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wardrobe.Shared.Entities;

namespace Wardrobe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WardrobeItemController : ControllerBase
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

        /// Retrieves a list of all wardrobe items.
        /// <returns>
        /// A list of all available wardrobe items.
        /// </returns>
        [HttpGet]
        public ActionResult<List<WardrobeItem>> GetAllWardrobeItems()
        {
            return Ok(_wardrobeItems);
        }
    }
}
