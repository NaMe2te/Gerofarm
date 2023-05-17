using Backend.Application.Dto;

namespace Backend.Application.Services;

public interface IPostService
{
    Task<IEnumerable<PostDto>> GetPosts(int getPostsCount, int alreadyPostsExistCount = 0);
}