using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System;

namespace ReactAspCrud.Models
{
	public class StudentDbContext : DbContext
	{
		public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
		{
		}

		public DbSet<Student> Student { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

		}
	
	}
}
