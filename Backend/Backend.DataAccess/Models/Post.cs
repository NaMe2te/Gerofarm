namespace Backend.DataAccess.Models;

public class Post
{
    public Post(string title)
    {
        Title = title;
    }

    protected Post() { }
    
    public int Id { get; init; }
    public string Title { get; init; }
}