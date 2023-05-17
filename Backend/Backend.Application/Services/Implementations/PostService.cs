using Backend.Application.Dto;
using Backend.Application.Mapping;
using Backend.DataAccess;
using Backend.DataAccess.Database;
using Microsoft.EntityFrameworkCore;

namespace Backend.Application.Services.Implementations;

public class PostService : IPostService
{
    private readonly DatabaseContext _context;

    public PostService(DatabaseContext context)
    {
        _context = context;
    }

    public IEnumerable<PostDto> GetPosts(int getPostsCount, int alreadyPostsExistCount = 0)
    {
        return _context.Posts
            .OrderBy(post => post.Id)
            .Skip(alreadyPostsExistCount)
            .Take(getPostsCount)
            .Select(post => post.AdDto());
    }
}