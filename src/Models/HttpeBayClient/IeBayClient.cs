using eBayScraper.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wyatt_Fleming.Models.HttpeBayClient
{
	public interface IeBayClient
	{
		//Task<IEnumerable<Book>> AllBooks { get; }
		Task<IEnumerable<Book>> GetBooks();
		
	}
}
