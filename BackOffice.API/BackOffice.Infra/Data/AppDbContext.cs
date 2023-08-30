using BackOffice.Doamin.Entities;
using BackOffice.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackOffice.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Mapeamento para Pessoa
            modelBuilder.Entity<Pessoa>()
                .HasKey(p => p.Id);

            // Mapeamento para Qualificacao
            modelBuilder.Entity<Qualificacao>()
                .HasKey(q => q.Id);

            // Mapeamento para Endereco
            modelBuilder.Entity<Endereco>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Endereco>()
                .HasOne(e => e.Pessoa)
                .WithMany(p => p.Enderecos) 
                .HasForeignKey(e => e.PessoaId);

            // Mapeamento para PessoaQualificacao
            modelBuilder.Entity<PessoaQualificacao>()
                .HasKey(pq => new { pq.PessoaId, pq.QualificacaoId });

            modelBuilder.Entity<PessoaQualificacao>()
                .HasOne(pq => pq.Pessoa)
                .WithMany(p => p.PessoasQualificacoes)
                .HasForeignKey(pq => pq.PessoaId);

            modelBuilder.Entity<PessoaQualificacao>()
                .HasOne(pq => pq.Qualificacao)
                .WithMany()
                .HasForeignKey(pq => pq.QualificacaoId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
