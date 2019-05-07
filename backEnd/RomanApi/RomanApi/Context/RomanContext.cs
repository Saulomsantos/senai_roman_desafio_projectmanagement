using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RomanApi.Domains
{
    public partial class RomanContext : DbContext
    {
        public RomanContext()
        {
        }

        public RomanContext(DbContextOptions<RomanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Equipes> Equipes { get; set; }
        public virtual DbSet<Projetos> Projetos { get; set; }
        public virtual DbSet<Temas> Temas { get; set; }
        public virtual DbSet<Tiposusuario> Tiposusuario { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=romandb.database.windows.net; Initial Catalog=romanbd; user id=roman-admin; pwd=Batata123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipes>(entity =>
            {
                entity.ToTable("EQUIPES");

                entity.HasIndex(e => e.Equipe)
                    .HasName("UQ__EQUIPES__F9437C8A959DBFA1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Equipe)
                    .IsRequired()
                    .HasColumnName("EQUIPE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Projetos>(entity =>
            {
                entity.ToTable("PROJETOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("DESCRICAO")
                    .HasColumnType("text");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemaId).HasColumnName("TEMA_ID");

                entity.HasOne(d => d.Tema)
                    .WithMany(p => p.Projetos)
                    .HasForeignKey(d => d.TemaId)
                    .HasConstraintName("FK__PROJETOS__TEMA_I__5812160E");
            });

            modelBuilder.Entity<Temas>(entity =>
            {
                entity.ToTable("TEMAS");

                entity.HasIndex(e => e.Tema)
                    .HasName("UQ__TEMAS__B7FF44CE0AE4CF7C")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ativo)
                    .HasColumnName("ATIVO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tema)
                    .IsRequired()
                    .HasColumnName("TEMA")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tiposusuario>(entity =>
            {
                entity.ToTable("TIPOSUSUARIO");

                entity.HasIndex(e => e.TipoUsuario)
                    .HasName("UQ__TIPOSUSU__D13E583B01B688E7")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TipoUsuario)
                    .IsRequired()
                    .HasColumnName("TIPO_USUARIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("USUARIOS");

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__USUARIOS__161CF724E74DCC45")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EquipeId).HasColumnName("EQUIPE_ID");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("NOME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnName("SENHA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipousuarioId).HasColumnName("TIPOUSUARIO_ID");

                entity.HasOne(d => d.Equipe)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.EquipeId)
                    .HasConstraintName("FK__USUARIOS__EQUIPE__5165187F");

                entity.HasOne(d => d.Tipousuario)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.TipousuarioId)
                    .HasConstraintName("FK__USUARIOS__TIPOUS__5070F446");
            });
        }
    }
}
