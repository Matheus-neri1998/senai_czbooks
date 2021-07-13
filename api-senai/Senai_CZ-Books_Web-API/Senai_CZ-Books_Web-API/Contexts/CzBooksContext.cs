using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Senai_CZ_Books_Web_API.Domains;

#nullable disable

namespace Senai_CZ_Books_Web_API.Contexts
{
    public partial class CzBooksContext : DbContext
    {
        public CzBooksContext()
        {
        }

        public CzBooksContext(DbContextOptions<CzBooksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autores { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Instituicao> Instituicoes { get; set; }
        public virtual DbSet<Livros> Livros { get; set; }
        public virtual DbSet<TiposUsuarios> TiposUsuarios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148 // For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAB08DESK2001\\SQLEXPRESS; initial catalog=CZ_Books; user=sa; pwd=sa132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK__Autor__DD33B0312FB2434D");

                entity.ToTable("Autor");

                entity.Property(e => e.NomeAutor)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdLivroNavigation)
                    .WithMany(p => p.Autors)
                    .HasForeignKey(d => d.IdLivro)
                    .HasConstraintName("FK__Autor__IdLivro__5812160E");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Autores)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Autor__IdUsuario__571DF1D5");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__A3C02A10A84A8A9F");

                entity.Property(e => e.Categorias)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Instituicao>(entity =>
            {
                entity.HasKey(e => e.IdInstituicao)
                    .HasName("PK__Institui__B771C0D8B2FA3928");

                entity.ToTable("Instituicao");

                entity.Property(e => e.Instituicoes)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Instituicao");
            });

            modelBuilder.Entity<Livros>(entity =>
            {
                entity.HasKey(e => e.IdLivro)
                    .HasName("PK__Livros__3B69D85A331FF4A9");

                entity.Property(e => e.DataPublicacao).HasColumnType("date");

                entity.Property(e => e.Preco)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sinopse)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Livros__IdCatego__5070F446");

                entity.HasOne(d => d.IdInstituicaoNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdInstituicao)
                    .HasConstraintName("FK__Livros__IdInstit__4F7CD00D");
            });

            modelBuilder.Entity<TiposUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TiposUsu__CA04062BE214BB55");

                entity.Property(e => e.TipoUsuario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF9712134A82");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuarios__IdTipo__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
