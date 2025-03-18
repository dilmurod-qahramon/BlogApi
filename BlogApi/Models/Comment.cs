using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApi.Models;

[Table("comments")]
public class Comment : EntityBase
{
    [Required]
    [MaxLength(1000)]
    public string Content { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "The Upvote must be greater than 0")]
    public int UpvoteCount { get; set; } = 0;

    public Author Author { get; set; }
    public Guid? AuthorId { get; set; }

    public Post Post { get; set; }
    public Guid PostId { get; set; }
}
