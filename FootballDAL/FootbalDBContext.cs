using System;
using FootballDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FootballDAL
{
    public partial class FootbalDBContext : DbContext
    {
        public FootbalDBContext()
        {
        }

        public FootbalDBContext(DbContextOptions<FootbalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=165.232.107.123;Database=FootbalDB;Username=postgres;Password=1;Persist Security Info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "C.UTF-8");

            modelBuilder.Entity<Match>(entity =>
            {
                entity.ToTable("matches");

                entity.HasIndex(e => e.Id, "matches_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateHeld)
                    .HasColumnType("date")
                    .HasColumnName("date_held")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FirstTeamId).HasColumnName("firstTeamId");

                entity.Property(e => e.SecondTeamId).HasColumnName("secondTeamId");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.ToTable("players");

                entity.HasIndex(e => e.Id, "players_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name")
                    .HasDefaultValueSql("'playername'::character varying");

                entity.Property(e => e.Playlevel)
                    .HasColumnName("playlevel")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdTeam)
                    .WithMany(p => p.Players)
                    .HasConstraintName("players_teams_id_fk");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("teams");

                entity.HasIndex(e => e.Id, "teams_id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("character varying")
                    .HasColumnName("name")
                    .HasDefaultValueSql("'temaName'::character varying");

                entity.Property(e => e.Playlevel)
                    .HasColumnType("character varying")
                    .HasColumnName("playlevel");

                entity.HasOne(d => d.IdMatch)
                    .WithOne(p => p.Team)
                    .HasForeignKey<Team>(d => d.Id)
                    .HasConstraintName("teams_matches_id_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
