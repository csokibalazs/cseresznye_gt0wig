using System;
using System.Collections.Generic;

namespace MarvelFilmek.MovieModels;

public partial class Character
{
    public int Id { get; set; }

    public int CharacterId { get; set; }

    public string Name { get; set; } = null!;

    public string? Alias { get; set; }

    public string? Actor { get; set; }

    public string? Powers { get; set; }

    public string? Affiliation { get; set; }

    public virtual ICollection<Appearance> Appearances { get; set; } = new List<Appearance>();
}
