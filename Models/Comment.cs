using System;
using System.Collections.Generic;

namespace Blog_WebApp.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public int? BlogId { get; set; }

    public int? UserId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Blog? Blog { get; set; }

    public virtual User? User { get; set; }
}
