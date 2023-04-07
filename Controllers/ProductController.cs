using APIDemo.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace APIDemo.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    
    public class ProductController : ControllerBase
    {
        static readonly HttpClient client = new HttpClient();

        [HttpGet]
        [Authorize]
        public IActionResult GetProducts()
        {
        var products = new List<string>();

            products.Add("ütü");
            products.Add("tabak");
            products.Add("çanak");
            products.Add("telefon");
            return Ok(products);
        }

        [HttpGet("Posts")]
        public async Task<IActionResult> GetPosts() 
        {
            using HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");

            string responseBody = await response.Content.ReadAsStringAsync();

            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(responseBody);

            return Ok(posts);

        }

        [HttpPost]

        public async Task<IActionResult> PostCategoryToBookAPI()
        {

            var content = new
            {
                id = 0,
                name = "Timsah"
            };

            HttpContent jsonContent = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");

            using HttpResponseMessage response = await client.PostAsync("https://localhost:7288/Category",jsonContent);

            return Ok(response);

        }

    }
}
