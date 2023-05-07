using System;
using FinancelyAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancelyAPI.Context;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{}

	public DbSet<User> Users { get; set; }

    public DbSet<Card> Cards { get; set; }

	public DbSet<Bill> Bills { get; set; }
}

