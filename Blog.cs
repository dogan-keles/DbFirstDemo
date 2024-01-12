using System;
using System.Collections.Generic;

namespace WorkintechDbFirstDemo;

public partial class Blog
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
