using System;
using System.Collections.Generic;

namespace cseresznye_gt0wig.MovieModels;

public partial class Appearance
{
    public int AppearanceId { get; set; }

    public int? MovieId { get; set; }

    public int? CharacterId { get; set; }

    public virtual Character? Character { get; set; }

    public virtual Movie? Movie { get; set; }
}
