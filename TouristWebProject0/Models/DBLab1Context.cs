using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TouristWebProject0
{
    public partial class DBLab1Context : DbContext
    {
        public DBLab1Context()
        {

        }

        public DBLab1Context(DbContextOptions<DBLab1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<CompetitionTeam> CompetitionTeams { get; set; }
        public virtual DbSet<Complexity> Complexities { get; set; }
        public virtual DbSet<Obstacle> Obstacles { get; set; }
        public virtual DbSet<ObstacleCompetition> ObstacleCompetitions { get; set; }
        public virtual DbSet<Partisipant> Partisipants { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<RankPartisipant> RankPartisipants { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Sex> Sexes { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamPartisipant> TeamPartisipants { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server= DESKTOP-8AGUDFK; Database=DBLab1; Trusted_Connection=True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Competition>(entity =>
            {
                entity.HasKey(e => e.IdCompetition)
                    .HasName("PK_Competition");

                entity.Property(e => e.IdCompetition).HasColumnName("id_competition");

                entity.Property(e => e.IdComplexity).HasColumnName("id_complexity");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.StartTax)
                    .HasColumnType("money")
                    .HasColumnName("Start_tax");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Start_time");

                entity.HasOne(d => d.IdComplexityNavigation)
                    .WithMany(p => p.Competitions)
                    .HasForeignKey(d => d.IdComplexity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competitions_Complexities");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Competitions)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competition_Types");
            });

            modelBuilder.Entity<CompetitionTeam>(entity =>
            {
                entity.ToTable("Competition/Team");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Admitted)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("admitted")
                    .IsFixedLength(true);

                entity.Property(e => e.IdCompetition).HasColumnName("id_competition");

                entity.Property(e => e.IdTeam).HasColumnName("id_team");

                entity.Property(e => e.Penalty).HasColumnName("penalty");

                entity.Property(e => e.ResultTime).HasColumnName("result_time");

                entity.HasOne(d => d.IdCompetitionNavigation)
                    .WithMany(p => p.CompetitionTeams)
                    .HasForeignKey(d => d.IdCompetition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competition/Team_Competitions");

                entity.HasOne(d => d.IdTeamNavigation)
                    .WithMany(p => p.CompetitionTeams)
                    .HasForeignKey(d => d.IdTeam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competition/Team_Teams");
            });

            modelBuilder.Entity<Complexity>(entity =>
            {
                entity.HasKey(e => e.IdComplexity);

                entity.Property(e => e.IdComplexity).HasColumnName("id_complexity");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Obstacle>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descriptiom)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ObstacleCompetition>(entity =>
            {
                entity.ToTable("Obstacle/competition");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCompetition).HasColumnName("id_competition");

                entity.Property(e => e.IdObstacle).HasColumnName("id_obstacle");

                entity.HasOne(d => d.IdCompetitionNavigation)
                    .WithMany(p => p.ObstacleCompetitions)
                    .HasForeignKey(d => d.IdCompetition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obstacle/competition_Competition");

                entity.HasOne(d => d.IdObstacleNavigation)
                    .WithMany(p => p.ObstacleCompetitions)
                    .HasForeignKey(d => d.IdObstacle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Obstacle/competition_Obstacles");
            });

            modelBuilder.Entity<Partisipant>(entity =>
            {
                entity.HasKey(e => e.IdParticipant);

                entity.Property(e => e.IdParticipant)
                    .ValueGeneratedNever()
                    .HasColumnName("id_participant");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_birth");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.IdSex).HasColumnName("id_sex");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PhoneNumber).HasColumnName("Phone_number");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Partisipants)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partisipants_Statuses");

                entity.HasOne(d => d.IdSexNavigation)
                    .WithMany(p => p.Partisipants)
                    .HasForeignKey(d => d.IdSex)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partisipants_Sexes");
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.HasKey(e => e.IdRank);

                entity.Property(e => e.IdRank).HasColumnName("id_rank");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<RankPartisipant>(entity =>
            {
                entity.ToTable("Rank/partisipant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateOfAchievement)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_achievement");

                entity.Property(e => e.IdPartisipant).HasColumnName("id_partisipant");

                entity.Property(e => e.IdRank).HasColumnName("id_rank");

                entity.HasOne(d => d.IdPartisipantNavigation)
                    .WithMany(p => p.RankPartisipants)
                    .HasForeignKey(d => d.IdPartisipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rank/partisipant_Partisipants");

                entity.HasOne(d => d.IdRankNavigation)
                    .WithMany(p => p.RankPartisipants)
                    .HasForeignKey(d => d.IdRank)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rank/partisipant_Ranks");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdObstacleCompetition).HasColumnName("id_obstacle_competition");

                entity.Property(e => e.IdPartisipant).HasColumnName("id_partisipant");

                entity.Property(e => e.Penalty).HasColumnName("penalty");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.HasOne(d => d.IdObstacleCompetitionNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.IdObstacleCompetition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Results_Obstacle/competition");

                entity.HasOne(d => d.IdPartisipantNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.IdPartisipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Results_Partisipants");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRoles)
                    .HasName("PK_Statuses");

                entity.Property(e => e.IdRoles).HasColumnName("id_roles");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.HasKey(e => e.IdSex);

                entity.Property(e => e.IdSex).HasColumnName("id_sex");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.IdTeam);

                entity.Property(e => e.IdTeam).HasColumnName("id_team");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.File).HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<TeamPartisipant>(entity =>
            {
                entity.ToTable("Team/partisipant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPartisipant).HasColumnName("id_partisipant");

                entity.Property(e => e.IdTeam).HasColumnName("id_team");

                entity.Property(e => e.Participated)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdPartisipantNavigation)
                    .WithMany(p => p.TeamPartisipants)
                    .HasForeignKey(d => d.IdPartisipant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team/partisipant_Partisipants");

                entity.HasOne(d => d.IdTeamNavigation)
                    .WithMany(p => p.TeamPartisipants)
                    .HasForeignKey(d => d.IdTeam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team/partisipant_Teams");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.HasKey(e => e.IdType);

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
