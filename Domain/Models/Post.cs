namespace Domain.Models;

public class Post
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int VoleAmount { get; set; }
    public DateTime CreateId { get; set; }
}
