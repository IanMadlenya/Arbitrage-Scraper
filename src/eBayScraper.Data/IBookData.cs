using System;
using System.Collections.Generic;
using System.Text;
using eBayScraper.Core;

namespace eBayScraper.Data
{
	public interface IBookData
	{
		IEnumerable<Book> GetAll();

	}

	 
}
