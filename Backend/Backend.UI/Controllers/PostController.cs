using Backend.Application.Dto;
using Backend.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.UI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostController : Controller
{
    private readonly IPostService _service;

    public PostController(IPostService service)
    {
        _service = service;
    }

    [HttpGet("get-posts")]
    public ActionResult<IEnumerable<PostDto>> GetPosts([FromQuery] int getPostsCount, int alreadyPostsExistCount = 0)
    {
        IEnumerable<PostDto> posts = _service.GetPosts(getPostsCount, alreadyPostsExistCount);
        return Ok(posts);
    }
}