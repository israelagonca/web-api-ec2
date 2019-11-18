using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FutShowMe.Infra.Data.Context
{
    public partial class FutshowmedbContext : DbContext
    {
        public FutshowmedbContext()
        {
        }

        public FutshowmedbContext(DbContextOptions<FutshowmedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tblacoescamera> Tblacoescamera { get; set; }
        public virtual DbSet<Tblcamera> Tblcamera { get; set; }
        public virtual DbSet<Tblcompartilhamento> Tblcompartilhamento { get; set; }
        public virtual DbSet<Tbllocal> Tbllocal { get; set; }
        public virtual DbSet<Tblquadra> Tblquadra { get; set; }
        public virtual DbSet<Tblvideo> Tblvideo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Tblacoescamera>(entity =>
            {
                entity.ToTable("tblacoescamera", "futshowmedb");
                entity.HasKey(e => e.IdAcoesCamera);
                entity.Property(e => e.Excluido).HasColumnType("tinyint(4)");
                entity.Property(e => e.IdCamera).HasColumnType("int(11)");

                entity.Property(e => e.MsgErro)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblcamera>(entity =>
            {
                entity.HasKey(e => e.Idtblcamera);

                entity.ToTable("tblcamera", "futshowmedb");

                entity.Property(e => e.Idtblcamera)
                    .HasColumnName("idtblcamera")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataCriacao)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido).HasColumnType("tinyint(4)");

                entity.Property(e => e.IdQuadra).HasColumnType("int(11)");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Posicao)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblcompartilhamento>(entity =>
            {
                entity.HasKey(e => e.IdCompartilhamento);

                entity.ToTable("tblcompartilhamento", "futshowmedb");

                entity.Property(e => e.IdCompartilhamento)
                    .HasColumnName("idCompartilhamento")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario).HasColumnType("int(11)");

                entity.Property(e => e.IdVideo).HasColumnType("int(11)");

                entity.Property(e => e.TipoCompartilhamento)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbllocal>(entity =>
            {
                entity.HasKey(e => e.Idlocal);

                entity.ToTable("tbllocal", "futshowmedb");

                entity.Property(e => e.Idlocal)
                    .HasColumnName("idlocal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnName("CEP")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Rua)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblquadra>(entity =>
            {
                entity.HasKey(e => e.IdQuadra);

                entity.ToTable("tblquadra", "futshowmedb");

                entity.Property(e => e.IdQuadra)
                    .HasColumnName("idQuadra")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLocal).HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });



            modelBuilder.Entity<Tblvideo>(entity =>
            {
                entity.HasKey(e => e.IdVideo);

                entity.ToTable("tblvideo", "futshowmedb");

                entity.Property(e => e.IdVideo).HasColumnType("int(11)");

                entity.Property(e => e.Diretorio)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Excluido).HasColumnType("tinyint(4)");

                entity.Property(e => e.IdCamera).HasColumnType("int(11)");

                entity.Property(e => e.NomeArquivo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
