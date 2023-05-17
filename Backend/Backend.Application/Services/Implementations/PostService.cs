using Backend.Application.Dto;
using Backend.Application.Mapping;
using Backend.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Backend.Application.Services.Implementations;

public class PostService : IPostService
{
    private readonly DatabaseContext _context;

    public PostService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PostDto>> GetPosts(int getPostsCount, int alreadyPostsExistCount = 0)
    {
        var posts = await _context.Posts
            .Skip(alreadyPostsExistCount)
            .Take(getPostsCount)
            .ToListAsync();

        return posts.Select(post => post.AdDto());
    }
}