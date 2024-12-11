using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MarvelFilmek.MovieModels;

public partial class MarvelContext : DbContext
{
    public MarvelContext()
    {
    }

    public MarvelContext(DbContextOptions<MarvelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appearance> Appearances { get; set; }

    public virtual DbSet<Character> Characters { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=csoki.database.windows.net;Initial Catalog=Marvel;Persist Security Info=True;User ID=csoki;Password=Password12345;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appearance>(entity =>
        {
            entity.HasKey(e => e.AppearanceId).HasName("PK__Appearan__2E7A11DF4C9256C5");

            entity.Property(e => e.AppearanceId).HasColumnName("AppearanceID");
            entity.Property(e => e.CharacterId).HasColumnName("CharacterID");
            entity.Property(e => e.MovieId).HasColumnName("MovieID");

            entity.HasOne(d => d.Character).WithMany(p => p.Appearances)
                .HasForeignKey(d => d.CharacterId)
                .HasConstraintName("FK__Appearanc__Chara__339FAB6E");

            entity.HasOne(d => d.Movie).WithMany(p => p.Appearances)
                .HasForeignKey(d => d.MovieId)
                .HasConstraintName("FK__Appearanc__Movie__32AB8735");
        });

        modelBuilder.Entity<Character>(entity =>
        {
            entity.HasKey(e => e.CharacterId).HasName("PK__Characte__757BCA40CB704839");

            entity.Property(e => e.CharacterId)
                .ValueGeneratedNever()
                .HasColumnName("CharacterID");
            entity.Property(e => e.Actor)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Affiliation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Powers).HasColumnType("text");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.MovieId).HasName("PK__Movies__4BD2941A0F269972");

            entity.HasIndex(e => e.Title, "UQ__Movies__2CB664DC1F803D98").IsUnique();

            entity.Property(e => e.MovieId).ValueGeneratedNever();
            entity.Property(e => e.BoxOfficeInMillions).HasColumnName("BoxOffice (in millions)");
            entity.Property(e => e.Director)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Rating).HasColumnType("decimal(3, 1)");
            entity.Property(e => e.ReleaseDate).HasColumnType("date");
            entity.Property(e => e.RuntimeInMinutes).HasColumnName("Runtime (in minutes)");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
