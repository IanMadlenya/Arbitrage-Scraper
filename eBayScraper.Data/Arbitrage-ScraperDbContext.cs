using eBayScraper.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBayScraper.Data
{
	public class Arbitrage_ScraperDbContext : DbContext
	{
		public Arbitrage_ScraperDbContext(DbContextOptions<Arbitrage_ScraperDbContext> options)
			: base (options)
		{

		}
		public DbSet<Book> Books { get; set; }
	}
}
