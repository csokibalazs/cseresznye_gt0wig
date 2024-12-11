using System;
using System.Collections.Generic;

namespace MarvelFilmek.MovieModels;

public partial class Appearance
{
    public int AppearanceId { get; set; }

    public int? MovieId { get; set; }

    public int? CharacterId { get; set; }

    public virtual Character? Character { get; set; }

    public virtual Movie? Movie { get; set; }
}
