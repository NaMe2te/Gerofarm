namespace Backend.DataAccess.Models;

public class Post
{
    public Post(int id, string title)
    {
        Id = id;
        Title = title;
    }

    protected Post() { }
    
    public int Id { get; init; }
    public string Title { get; init; }
}