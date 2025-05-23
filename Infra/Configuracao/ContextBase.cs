﻿using Entities.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuracao;

public class ContextBase : IdentityDbContext<ApplicationUser>
{
    public ContextBase(DbContextOptions options) : base(options)
    {
    }

    protected ContextBase() { }
    
    public DbSet<SistemaFinanceiro> SistemaFinanceiro {  get; set; }
    public DbSet<UsuarioSistemaFinanceiro> UsuarioSistemaFinanceiro { get; set; }
    public DbSet<Categoria> Categoria {  get; set; }
    public DbSet<Despesa> Despesa { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(ObterStringConexao());
        base.OnConfiguring(optionsBuilder);
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Faz o mapeamento da Tabela "AspNetUsers"  para a tabela do Usuario => ApplicationUser
        builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
        base.OnModelCreating(builder);
    }

    public string ObterStringConexao()
    {
        return "Server=localhost;Port=5432;Database=FINANCEIRO_2025;User Id=admin;Password=admin1234;";
    }
}
