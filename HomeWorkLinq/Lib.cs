using System;
using System.Collections.Generic;

namespace HomeWorkLinq;

public partial class Lib
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<SCard> SCards { get; } = new List<SCard>();

    public virtual ICollection<TCard> TCards { get; } = new List<TCard>();
}
