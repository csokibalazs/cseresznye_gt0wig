using System;
using System.Collections.Generic;

namespace cseresznye_gt0wig.MovieModels;

public partial class Movie
{
    public int Id { get; set; }

    public int MovieId { get; set; }

    public string Title { get; set; } = null!;

    public DateTime? ReleaseDate { get; set; }

    public string? Director { get; set; }

    public int? BoxOfficeInMillions { get; set; }

    public int? RuntimeInMinutes { get; set; }

    public decimal? Rating { get; set; }
}
