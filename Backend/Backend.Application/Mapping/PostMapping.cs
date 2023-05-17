using Backend.Application.Dto;
using Backend.DataAccess.Models;

namespace Backend.Application.Mapping;

public static class PostMapping
{
    public static PostDto AdDto(this Post post) => new PostDto(post.Id, post.Title);
}