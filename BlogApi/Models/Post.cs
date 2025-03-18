using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApi.Models;

[Table("posts")]
public class Post : EntityBase
{
    [Required]
    [MaxLength(255)]
    [MinLength(10)]
    public string Title { get; set; }

    [Required]
    [MaxLength(10_000)]
    [MinLength(100)]
    public string Content { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "The view must be greater than 0")]
    public int ViewCount { get; set; } = 1;

    public Author Author { get; set; }
    public Guid AuthorId { get; set; }

    public ICollection<Comment> Comments { get; set; } = [];
}
