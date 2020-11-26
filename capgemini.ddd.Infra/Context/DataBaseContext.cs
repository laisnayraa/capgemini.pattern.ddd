using capgemini.ddd.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace capgemini.ddd.Infra.Context
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() { }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<Aluno> Aluno { get; set; }
        //public DbSet<Instrutor> Instrutor { get; set; }
        public DbSet<Turma> Turma { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CadastroCrossfit;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(b =>
            {
                b.HasKey(p => p.Id);

                b.Property(_ => _.NomeCompleto)
                    .IsRequired()
                    .HasMaxLength(80);

                b.Property(_ => _.CPF)
                    .IsRequired()
                    .HasMaxLength(15);

                b.Property(_ => _.Contato)
                    .IsRequired()
                    .HasMaxLength(15);

                b.Property(_ => _.DataCadastro)
                    .IsRequired();

                b.Property(_ => _.Ativo)
                    .IsRequired();

                //RelationShip
                b.HasOne(_ => _.Turma)
                    .WithMany()
                    .HasForeignKey(_ => _.IdTurma);
            });

            //modelBuilder.Entity<Instrutor>(b =>
            //{
            //    b.HasKey(p => p.Id);

            //    b.Property(_ => _.NomeCompleto)
            //    .IsRequired()
            //    .HasMaxLength(80);

            //    b.Property(_ => _.CPF)
            //        .IsRequired()
            //        .HasMaxLength(15);

            //    b.Property(_ => _.Contato)
            //        .IsRequired()
            //        .HasMaxLength(15);

            //    //RelationShip
            //    b.HasOne(_ => _.Turma)
            //        .WithMany()
            //        .HasForeignKey(_ => _.IdTurma);
            //});

            modelBuilder.Entity<Turma>(b =>
            {
                b.HasKey(p => p.Id);

                b.Property(_ => _.Horario)
                    .IsRequired();

                b.Property(_ => _.Duracao)
                    .IsRequired();

                //RelationShip
                b.HasOne(_ => _.Aluno)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(_ => _.IdAluno);

                //b.HasOne(_ => _.Instrutor)
                //    .WithMany()
                //    .OnDelete(DeleteBehavior.Restrict)
                //    .HasForeignKey(_ => _.IdInstrutor);
            });
        }
    }
}
